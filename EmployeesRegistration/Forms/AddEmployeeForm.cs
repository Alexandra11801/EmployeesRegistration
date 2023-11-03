using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
namespace EmployeesRegistration.Forms
{
    public partial class AddEmployeeForm : BaseForm
    {
        private List<Department> departments;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            departments = DepartmentsService.GetAllActiveDepartments();
            departmentBox.Items.AddRange(departments.Select(d => d.Name).ToArray());
            departmentBox.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            nextForm = new EmployeesListForm();
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(nameBox.Text.Length > 0 && personnelNumberBox.Text.Length > 0 && titleBox.Text.Length > 0)
            {
                var employee = new Employee(nameBox.Text, personnelNumberBox.Text, departments[departmentBox.SelectedIndex].Id,
                    titleBox.Text, emailBox.Text, phoneNumberBox.Text, DateTime.Now, null, true);
                var addedEmployee = EmployeesService.AddEmployee(employee);
                if (addedEmployee != null)
                {
                    nextForm = new EmployeeForm(addedEmployee);
                    Close();
                }
            }
        }
    }
}
