using EmployeesRegistration.Models;
using EmployeesRegistration.DatabaseConnectionSetupUtils;
using System;
using System.Collections.Generic;

namespace EmployeesRegistration.Services
{
    public static class DepartmentsService
    {
        public static Department AddDepartment(Department department)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("INSERT INTO departments (name, headDepartmentId, headId, active) " +
                    "VALUES ('{0}', {1}, {2}, {3});", department.Name, department.HeadDepartmentId, department.HeadId,
                    Convert.ToInt32(department.Active));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return GetDepartmentById((int)command.LastInsertedId);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
        }

        public static List<Department> GetAllDepartments()
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            var departments = new List<Department>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM departments;";
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var department = new Department(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                            reader.GetInt32(3), reader.GetBoolean(4));
                        departments.Add(department);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return departments;
            }
        }

        public static List<Department> GetAllActiveDepartments()
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            var departments = new List<Department>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM departments WHERE active=1;";
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var department = new Department(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                            reader.GetInt32(3), reader.GetBoolean(4));
                        departments.Add(department);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return departments;
            }
        }

        public static Department GetDepartmentById(int id)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("SELECT * FROM departments WHERE id={0};", id);
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var department = new Department(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                            reader.GetInt32(3), reader.GetBoolean(4));
                        return department;
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

        public static Department DeleteDepartment(int id)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("UPDATE departments SET active=0 WHERE id={0};", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return GetDepartmentById(id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
        }

        public static Department UpdateDepartmentInformation(Department department)
        {
            var connection = DatabaseUtils.GetDatabaseConnection("employees");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format("UPDATE departments SET name='{0}', headDepartmentId={1}, headId={2}" +
                    " WHERE id={3};", department.Name, department.HeadDepartmentId, department.HeadId, department.Id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return GetDepartmentById(department.Id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
        }
    }
}
