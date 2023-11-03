using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EmployeesRegistration.Forms
{
    public partial class DepartmentForm : BaseForm
    {
        private Department department;
        private Department headDepartment;
        private Employee head;
        private List<Employee> employees;
        private Font employeeFont = new Font("Microsoft Sans Serif", 10f, FontStyle.Underline);

        public DepartmentForm(Department department)
        {
            InitializeComponent();
            this.department = department;
            headDepartment = DepartmentsService.GetDepartmentById(department.HeadDepartmentId);
            head = EmployeesService.GetEmployeeById(department.HeadId);
            employees = EmployeesService.GetEmployeesFromDepartment(department.Id).OrderBy(emp => emp.Active ? 0 : 1)
                .ThenBy(emp => emp.Name).ToList();
        }

        private void DepartmentForm_Load(object sender, System.EventArgs e)
        {
            RefreshDepartmentView();
            FillEmployeesList();
        }

        private void RefreshDepartmentView()
        {
            nameLabel.Text = department.Name;
            headDepartmentLink.Text = "Головное подразделение: " + headDepartment?.Name
                + (headDepartment != null && !headDepartment.Active ? " (недейст.)" : "");
            headDepartmentLink.LinkArea = new LinkArea(24, headDepartmentLink.Text.Length - 1);
            headLink.Text = "Руководитель: " + head?.Name + (head != null && !head.Active ? " (недейст.)" : "");
            headLink.LinkArea = new LinkArea(14, headLink.Text.Length - 1);
            statusLabel.Text = "Состояние записи: " + (department.Active ? "действительна" : "недействительна");
            buttonsPanel.Visible = department.Active;
        }

        private void FillEmployeesList()
        {
            foreach(var employee in employees)
            {
                var link = new LinkLabel();
                link.AutoSize = true;
                link.Padding = new Padding(15, 0, 0, 10);
                link.Text = employee.Name + (employee.Active ? "" : " (недейст.)");
                link.LinkColor = Color.Black;
                link.VisitedLinkColor = Color.Black;
                link.Font = employeeFont;
                link.LinkClicked += new LinkLabelLinkClickedEventHandler(OpenEmployeePage);
                employeesLayoutPanel.Controls.Add(link);
            }
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            nextForm = new DepartmentsListForm();
            Close();
        }

        private void OpenEmployeePage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var employee = employees[employeesLayoutPanel.Controls.IndexOf((Control)sender) - 1];
            nextForm = new EmployeeForm(employee);
            Close();
        }

        private void headDepartmentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nextForm = new DepartmentForm(headDepartment);
            Close();
        }

        private void headLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nextForm = new EmployeeForm(head);
            Close();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            var updatedDepartmentInfo = DepartmentsService.DeleteDepartment(department.Id);
            if(updatedDepartmentInfo != null)
            {
                department = updatedDepartmentInfo;
                RefreshDepartmentView();
            }
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            nextForm = new EditDepartmentForm(department);
            Close();
        }
    }
}
