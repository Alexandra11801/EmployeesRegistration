using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesRegistration.Forms
{
    public partial class AddDepartmentForm : BaseForm
    {
        private List<Department> departments;

        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private void AddDepartmentForm_Load(object sender, EventArgs e)
        {
            departments = DepartmentsService.GetAllActiveDepartments();
            departmentBox.Items.Add("");
            departmentBox.Items.AddRange(departments.Select(d => d.Name).ToArray());
            departmentBox.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            nextForm = new DepartmentsListForm();
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(nameBox.Text.Length > 0)
            {
                var headDepartmentId = departmentBox.SelectedIndex == 0 ? 0 : departments[departmentBox.SelectedIndex - 1].Id;
                var department = new Department(nameBox.Text, headDepartmentId, 0, true);
                var addedDepartment = DepartmentsService.AddDepartment(department);
                if (addedDepartment != null)
                {
                    nextForm = new DepartmentForm(addedDepartment);
                    Close();
                }
            }
        }
    }
}
