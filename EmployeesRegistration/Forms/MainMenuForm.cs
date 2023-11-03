using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesRegistration.Forms
{
    public partial class MainMenuForm : BaseForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            nextForm = new EmployeesListForm();
            Close();
        }

        private void departmentsButton_Click(object sender, EventArgs e)
        {
            nextForm = new DepartmentsListForm();
            Close();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            nextForm = new StatisticsForm();
            Close();
        }
    }
}
