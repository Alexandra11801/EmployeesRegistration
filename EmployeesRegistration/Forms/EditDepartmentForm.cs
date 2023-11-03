using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EmployeesRegistration.Forms
{
    public partial class EditDepartmentForm : BaseForm
    {
        private Department department;
        private List<Department> departments;
        private List<Employee> employees;

        public EditDepartmentForm(Department department)
        {
            InitializeComponent();
            this.department = department;
        }

        private void EditDepartmentForm_Load(object sender, EventArgs e)
        {
            SetupDepartmentView();
        }

        private void SetupDepartmentView()
        {
            nameBox.Text = department.Name;
            departments = DepartmentsService.GetAllActiveDepartments().Where(d => !d.Equals(department)).ToList();
            headDepartmentBox.Items.Add("");
            headDepartmentBox.Items.AddRange(departments.Select(d => d.Name).ToArray());
            var headDepartment = departments.Find(d => d.Id == department.HeadDepartmentId);
            headDepartmentBox.SelectedIndex = headDepartment == null ? 0 : departments.IndexOf(headDepartment) + 1;
            employees = EmployeesService.GetActiveEmployeesFromDepartment(department.Id);
            headBox.Items.Add("");
            headBox.Items.AddRange(employees.Select(e => e.Name).ToArray());
            var head = employees.Find(e => e.Id == department.HeadId);
            headBox.SelectedIndex = head == null ? 0 : employees.IndexOf(head) + 1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(nameBox.Text.Length > 0)
            {
                var headDepartmentId = headDepartmentBox.SelectedIndex == 0 ? 0
                    : departments[headDepartmentBox.SelectedIndex - 1].Id;
                var headId = headBox.SelectedIndex == 0 ? 0 : employees[headBox.SelectedIndex - 1].Id;
                var updatedDepartmentInfo = new Department(department.Id, nameBox.Text, headDepartmentId, headId, true);
                updatedDepartmentInfo = DepartmentsService.UpdateDepartmentInformation(updatedDepartmentInfo);
                if(updatedDepartmentInfo != null)
                {
                    nextForm = new DepartmentForm(updatedDepartmentInfo);
                    Close();
                }
            }
        }
    }
}
