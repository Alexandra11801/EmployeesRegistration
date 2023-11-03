using MySql.Data.MySqlClient;
using System;

namespace EmployeesRegistration.DatabaseConnectionSetupUtils
{
    public static class DatabaseSetup
    {
        public static void SetupDatabase(MySqlConnection connection)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = String.Format(
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME='employees'");
                var result = command.ExecuteScalar();
                if (result != null && Convert.ToInt32(result) == 0)
                {
                    command.CommandText = String.Format("CREATE DATABASE employees");
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    command.CommandText = "CREATE TABLE employees.employees (" +
                        "id int NOT NULL AUTO_INCREMENT," +
                        "name varchar(255) NOT NULL," +
                        "personnelNumber varchar(6) NOT NULL," +
                        "departmentId int NOT NULL," +
                        "title varchar(255) NOT NULL," +
                        "email varchar(255)," +
                        "phoneNumber varchar(32)," +
                        "recruitDate date NOT NULL," +
                        "fireDate date NULL," +
                        "active bool," +
                        "PRIMARY KEY (id)" +
                        ")";
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    command.CommandText = "CREATE TABLE employees.departments (" + 
                        "id int NOT NULL AUTO_INCREMENT," + 
                        "name varchar(255) NOT NULL," + 
                        "headDepartmentId int," + 
                        "headId int," + 
                        "active bool," + 
                        "PRIMARY KEY (id)" + 
                        ")";
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    XLSXParser.FillDatabase();
                }
            }
        }
    }
}
