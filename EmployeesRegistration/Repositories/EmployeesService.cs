using EmployeesRegistration.Models;
using EmployeesRegistration.DatabaseConnectionSetupUtils;
using System;
using System.Collections.Generic;

namespace EmployeesRegistration.Services
{
    public static class EmployeesService
    {
        public static Employee AddEmployee(Employee employee)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                var recruitDateString = employee.RecruitDate.ToString("yyyy-MM-dd");
                var fireDateString = employee.FireDate == null ? "NULL" 
                    : String.Format("'{0}'",  employee.FireDate?.ToString("yyyy-MM-dd"));
                command.CommandText = String.Format("INSERT INTO employees (name, personnelNumber, departmentId, title, email," +
                    "phoneNumber, recruitDate, fireDate, active) VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}', {7}, {8});",
                    employee.Name, employee.PersonnelNumber, employee.DepartmentId, employee.Title, employee.Email,
                    employee.PhoneNumber, recruitDateString, fireDateString, Convert.ToInt32(employee.Active));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return GetEmployeeById((int)command.LastInsertedId);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
        }

        public static List<Employee> GetAllEmployees()
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            var employees = new List<Employee>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM employees;";
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var fireDate = reader.IsDBNull(8) ? null : new Nullable<DateTime>(reader.GetDateTime(8));
                        var employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                            reader.GetDateTime(7), fireDate, reader.GetBoolean(9));
                        employees.Add(employee);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return employees;
            }
        }

        public static List<Employee> GetActiveEmployees()
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            var employees = new List<Employee>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM employees WHERE active=1;";
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var fireDate = reader.IsDBNull(8) ? null : new Nullable<DateTime>(reader.GetDateTime(8));
                        var employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                            reader.GetDateTime(7), fireDate, reader.GetBoolean(9));
                        employees.Add(employee);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return employees;
            }
        }

        public static Employee GetEmployeeById(int id)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("SELECT * FROM employees WHERE id={0};", id);
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var fireDate = reader.IsDBNull(8) ? null : new Nullable<DateTime>(reader.GetDateTime(8));
                        var employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), 
                            reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), 
                            reader.GetDateTime(7), fireDate, reader.GetBoolean(9));
                        return employee;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public static Employee GetEmployeeByPersonnelNumber(String personnelNumber)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("SELECT * FROM employees WHERE personnelNumber='{0}';", personnelNumber);
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var fireDate = reader.IsDBNull(8) ? null : new Nullable<DateTime>(reader.GetDateTime(8));
                        var employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                            reader.GetDateTime(7), fireDate, reader.GetBoolean(9));
                        return employee;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public static List<Employee> GetEmployeesFromDepartment(int departmentId)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            var employees = new List<Employee>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("SELECT * FROM employees WHERE departmentId={0};", departmentId);
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var fireDate = reader.IsDBNull(8) ? null : new Nullable<DateTime>(reader.GetDateTime(8));
                        var employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                            reader.GetDateTime(7), fireDate, reader.GetBoolean(9));
                        employees.Add(employee);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return employees;
            }
        }

        public static List<Employee> GetActiveEmployeesFromDepartment(int departmentId)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            var employees = new List<Employee>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("SELECT * FROM employees WHERE departmentId={0} AND active=1;", departmentId);
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var fireDate = reader.IsDBNull(8) ? null : new Nullable<DateTime>(reader.GetDateTime(8));
                        var employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                            reader.GetDateTime(7), fireDate, reader.GetBoolean(9));
                        employees.Add(employee);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return employees;
            }
        }

        public static Employee FireEmployee(int id)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                var dateString = DateTime.Now.ToString("yyyy-MM-dd");
                command.CommandText = String.Format("UPDATE employees SET fireDate='{0}', active=0 WHERE id={1};",
                    dateString, id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return GetEmployeeById(id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
        }

        public static Employee UpdateEmployeeInformation(Employee employee)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("UPDATE employees SET name='{0}', personnelNumber='{1}', title='{2}'," +
                    "departmentId={3}, email='{4}', phoneNumber='{5}' WHERE id={6};", employee.Name, employee.PersonnelNumber,
                    employee.Title, employee.DepartmentId, employee.Email, employee.PhoneNumber, employee.Id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return GetEmployeeById(employee.Id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
        }

        public static int GetRecruitedEmployeesCount(DateTime since)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                var dateString = since.ToString("yyyy-MM-dd");
                command.CommandText = String.Format("SELECT COUNT(*) FROM employees WHERE recruitDate>='{0}';", dateString);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return 0;
            }
        }

        public static int GetRecruitedEmployeesCount(DateTime since, int departmentId)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                var dateString = since.ToString("yyyy-MM-dd");
                command.CommandText = String.Format("SELECT COUNT(*) FROM employees WHERE recruitDate>='{0}' " +
                    "AND departmentId={1};", dateString, departmentId);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return 0;
            }
        }

        public static int GetFiredEmployeesCount(DateTime since)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                var dateString = since.ToString("yyyy-MM-dd");
                command.CommandText = String.Format("SELECT COUNT(*) FROM employees WHERE fireDate IS NOT NULL " +
                    "AND fireDate>='{0}';", dateString);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return 0;
            }
        }

        public static int GetFiredEmployeesCount(DateTime since, int departmentId)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                var dateString = since.ToString("yyyy-MM-dd");
                command.CommandText = String.Format("SELECT COUNT(*) FROM employees WHERE fireDate IS NOT NULL " +
                    "AND fireDate>='{0}' AND departmentId={1};", dateString, departmentId);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return 0;
            }
        }
    }
}
