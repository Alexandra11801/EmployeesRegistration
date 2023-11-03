using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System;
using System.Windows.Forms;

namespace EmployeesRegistration.Forms
{
    public partial class EmployeeForm : BaseForm
    {
        private Employee employee;
        private Department employeeDepartment;

        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            employeeDepartment = DepartmentsService.GetDepartmentById(employee.DepartmentId);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            RefreshEmployeeView();
        }

        private void RefreshEmployeeView()
        {
            nameLabel.Text = employee.Name;
            personnelNumberLabel.Text = "Табельный номер: " + employee.PersonnelNumber;
            titleLabel.Text = "Должность: " + employee.Title;
            departmentLink.Text = "Подразделение: " + employeeDepartment.Name + 
                (employeeDepartment.Active ? "" : " (недейст.)");
            departmentLink.LinkArea = new LinkArea(15, departmentLink.Text.Length - 1);
            emailLabel.Text = "Email: " + employee.Email;
            phoneNumberLabel.Text = "Телефон: " + employee.PhoneNumber;
            recruitDateLabel.Text = "Дата приёма: " + employee.RecruitDate.ToString("dd.MM.yyyy");
            fireDateLabel.Text = "Дата увольнения: " + (employee.FireDate == null ? ""
                : employee.FireDate.Value.ToString("dd.MM.yyyy"));
            statusLabel.Text = "Состояние записи: " + (employee.Active ? "действительна" : "недействительна");
            buttonsPanel.Visible = employee.Active;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            nextForm = new EmployeesListForm();
            Close();
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            var updatedEmployee = EmployeesService.FireEmployee(employee.Id);
            if (updatedEmployee != null)
            {
                employee = updatedEmployee;
                RefreshEmployeeView();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            nextForm = new EditEmployeeForm(employee);
            Close();
        }

        private void departmentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nextForm = new DepartmentForm(employeeDepartment);
            Close();
        }
    }
}
