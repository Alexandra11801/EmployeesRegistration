using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeesRegistration.Forms
{
    public partial class EditEmployeeForm : BaseForm
    {
        private Employee employee;
        private List<Department> departments;

        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void EditEmployeeForm_Load(object sender, System.EventArgs e)
        {
            SetupEmployeeView();
        }

        private void SetupEmployeeView()
        {
            nameBox.Text = employee.Name;
            personnelNumberBox.Text = employee.PersonnelNumber;
            titleBox.Text = employee.Title;
            departments = DepartmentsService.GetAllActiveDepartments();
            departmentBox.Items.AddRange(departments.Select(d => d.Name).ToArray());
            departmentBox.SelectedIndex = departments.IndexOf(departments.Find(d => d.Id == employee.DepartmentId));
            emailBox.Text = employee.Email;
            phoneNumberBox.Text = employee.PhoneNumber;
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (nameBox.Text.Length > 0 && personnelNumberBox.Text.Length > 0 && titleBox.Text.Length > 0 
                && departmentBox.SelectedIndex > -1)
            {
                var updatedEmployeeInfo = new Employee(employee.Id, nameBox.Text, personnelNumberBox.Text,
                    departments[departmentBox.SelectedIndex].Id, titleBox.Text, emailBox.Text, phoneNumberBox.Text,
                    employee.RecruitDate, null, true);
                updatedEmployeeInfo = EmployeesService.UpdateEmployeeInformation(updatedEmployeeInfo);
                if (updatedEmployeeInfo != null)
                {
                    nextForm = new EmployeeForm(updatedEmployeeInfo);
                    Close();
                }
            }
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            nextForm = new EmployeeForm(employee);
            Close();
        }
    }
}
