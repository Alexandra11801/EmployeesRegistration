using MySql.Data.MySqlClient;
using System;

namespace EmployeesRegistration.DatabaseConnectionSetupUtils
{
    public static class DatabaseUtils
    {
        private static string host = "127.0.0.1";
        private static string port = "3306";
        private static string username = "root";
        private static string password = "mysql";

        public static MySqlConnection GetDatabaseConnection()
        {
            var connectionScring = String.Format("server={0};user={1};port={2};password={3}",
                host, username, port, password);
            return new MySqlConnection(connectionScring);
        }

        public static MySqlConnection GetDatabaseConnection(string database)
        {
            var connectionScring = String.Format("server={0};user={1};port={2};password={3};database={4}",
                host, username, port, password, database);
            return new MySqlConnection(connectionScring);
        }
    }
}
