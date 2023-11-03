using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EmployeesRegistration.Forms
{
    public partial class DepartmentsListForm : BaseForm
    {
        private List<Department> allDepartments;
        private List<Department> displayedDepartments;
        private Font employeeFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Underline);

        public DepartmentsListForm()
        {
            InitializeComponent();
        }

        private void DepartmentsListForm_Load(object sender, EventArgs e)
        {
            allDepartments = DepartmentsService.GetAllDepartments().OrderBy(d => d.Active ? 0 : 1).ToList();
            displayedDepartments = new List<Department>();
            DisplayDepartments(allDepartments);
        }

        private void DisplayDepartments(List<Department> departments)
        {
            ClearDepartmentsList();
            displayedDepartments = departments;
            foreach(var department in displayedDepartments)
            {
                AddDepartment(department);
            }
        }

        private void ClearDepartmentsList()
        {
            for (var i = displayedDepartments.Count; i > 0; i--)
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

        private void AddDepartment(Department department)
        {
            var link = new LinkLabel();
            link.AutoSize = true;
            link.Padding = new Padding(0, 0, 0, 30);
            link.Text = department.Name;
            link.LinkColor = Color.Black;
            link.VisitedLinkColor = Color.Black;
            link.Font = employeeFont;
            link.LinkClicked += new LinkLabelLinkClickedEventHandler(OpenDepartmentPage);
            flowLayoutPanel.Controls.Add(link);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            nextForm = new MainMenuForm();
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var fitDepartments = allDepartments.Where(d
                => d.Name.IndexOf(searchBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0).ToList();
            DisplayDepartments(fitDepartments);
        }

        private void OpenDepartmentPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var department = displayedDepartments[flowLayoutPanel.Controls.IndexOf((Control)sender) - 1];
            nextForm = new DepartmentForm(department);
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            nextForm = new AddDepartmentForm();
            Close();
        }
    }
}
