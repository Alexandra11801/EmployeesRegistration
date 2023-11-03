using EmployeesRegistration.DatabaseConnectionSetupUtils;
using EmployeesRegistration.Forms;
using System;
using System.Windows.Forms;

namespace EmployeesRegistration
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var databaseConnection = DatabaseUtils.GetDatabaseConnection();
            try
            {
                databaseConnection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            DatabaseSetup.SetupDatabase(databaseConnection);

            new MainMenuForm().Show();
            Application.Run();
        }
    }
}
