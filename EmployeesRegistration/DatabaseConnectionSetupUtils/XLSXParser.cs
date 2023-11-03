using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeesRegistration.DatabaseConnectionSetupUtils
{
    public static class XLSXParser
    {
        private static string fileName = @"Resources\Employees.xlsx";

        public static void FillDatabase()
        {
            var employees = new List<Employee>();
            var departments = new List<Department>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName);
            try
            {
                using (var package = new ExcelPackage(path))
                {
                    var departmentsWorksheet = package.Workbook.Worksheets[1];
                    var departmentsRowCount = 2;
                    while(departmentsWorksheet.Cells[departmentsRowCount, 1].Value != null)
                    {
                        var department = new Department(Convert.ToInt32(departmentsWorksheet.Cells[departmentsRowCount, 1].Value),
                            departmentsWorksheet.Cells[departmentsRowCount, 2].Value.ToString(), true);
                        departments.Add(department);
                        departmentsRowCount++;
                    }
                    for (var i = 2; i < departmentsRowCount; i++)
                    {
                        var headDepartmentName = departmentsWorksheet.Cells[i, 3].Value?.ToString();
                        if (headDepartmentName != null)
                        {
                            departments[i - 2].HeadDepartmentId = departments.Find(d => d.Name.Equals(headDepartmentName)).Id;
                        }
                    }

                    var employeesWorksheet = package.Workbook.Worksheets[0];
                    var employeesRowCount = 2;
                    while (employeesWorksheet.Cells[employeesRowCount, 1].Value != null)
                    {
                        var departmentId = departments.Find(d 
                            => d.Name.Equals(employeesWorksheet.Cells[employeesRowCount, 5].Value.ToString())).Id;
                        var fireDateString = employeesWorksheet.Cells[employeesRowCount, 9].Value?.ToString();
                        var fireDate = fireDateString == null ? null : new Nullable<DateTime>(DateTime.Parse(fireDateString));
                        var active = fireDate == null;
                        var employee = new Employee(Convert.ToInt32(employeesWorksheet.Cells[employeesRowCount, 1].Value),
                            employeesWorksheet.Cells[employeesRowCount, 2].Value.ToString(), 
                            employeesWorksheet.Cells[employeesRowCount, 3].Value.ToString(),
                            departmentId, employeesWorksheet.Cells[employeesRowCount, 4].Value.ToString(),
                            employeesWorksheet.Cells[employeesRowCount, 6].Value.ToString(), 
                            employeesWorksheet.Cells[employeesRowCount, 7].Value.ToString(),
                            DateTime.Parse(employeesWorksheet.Cells[employeesRowCount, 8].Value.ToString()), fireDate, active);
                        employees.Add(employee);
                        if (employee.Title.Equals("Директор управления") || employee.Title.Equals("Руководитель подразделения"))
                        {
                            departments.Find(d => d.Id == employee.DepartmentId).HeadId = employee.Id;
                        }
                        employeesRowCount++;
                    }

                    foreach (var employee in employees)
                    {
                        EmployeesService.AddEmployee(employee);
                    }
                    foreach (var department in departments)
                    {
                        DepartmentsService.AddDepartment(department);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
