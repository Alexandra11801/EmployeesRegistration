using EmployeesRegistration.Forms;
using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EmployeesRegistration
{
    public partial class EmployeesListForm : BaseForm
    {
        private List<Employee> allEmployees;
        private List<Employee> displayedEmployees;
        private Font employeeFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Underline);

        public EmployeesListForm()
        {
            InitializeComponent();
        }

        private void EmployeesListForm_Load(object sender, EventArgs e)
        {
            SetupEmployeesList();
            comboBox.SelectedIndex = 0;
        }

        private void SetupEmployeesList()
        {
            allEmployees = EmployeesService.GetAllEmployees().OrderBy(emp => emp.Active ? 0 : 1)
                .ThenBy(emp => emp.Name).ToList();
            displayedEmployees = new List<Employee>();
            DisplayEmployees(allEmployees);
        }

        private void DisplayEmployees(List<Employee> employees)
        {
            ClearEmployeeList();
            displayedEmployees = employees;
            foreach (var employee in displayedEmployees)
            {
                AddEmployee(employee);
            }
        }

        private void ClearEmployeeList()
        {
            for(var i = displayedEmployees.Count; i > 0; i--)
            {
                try
                {
                    flowLayoutPanel.Controls[i].Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void AddEmployee(Employee employee)
        {
            var link = new LinkLabel();
            link.AutoSize = true;
            link.Padding = new Padding(0, 0, 0, 30);
            link.Text = String.Format("{0} ({1})", employee.Name, employee.PersonnelNumber) 
                + (employee.Active ? "" : " (недейст.)");
            link.LinkColor = Color.Black;
            link.VisitedLinkColor = Color.Black;
            link.Font = employeeFont;
            link.LinkClicked += new LinkLabelLinkClickedEventHandler(OpenEmployeePage);
            flowLayoutPanel.Controls.Add(link);
        }

        private void OpenEmployeePage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var employee = displayedEmployees[flowLayoutPanel.Controls.IndexOf((Control)sender) - 1];
            nextForm = new EmployeeForm(employee);
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var culture = StringComparison.CurrentCultureIgnoreCase;
            var fitEmployees = comboBox.SelectedIndex == 0 
                ? allEmployees.Where(emp => emp.Name.IndexOf(searchBox.Text, culture) >= 0).ToList()
                : allEmployees.Where(emp => emp.PersonnelNumber.IndexOf(searchBox.Text, culture) >= 0).ToList();
            DisplayEmployees(fitEmployees);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            nextForm = new AddEmployeeForm();
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            nextForm = new MainMenuForm();
            Close();
        }
    }
}
