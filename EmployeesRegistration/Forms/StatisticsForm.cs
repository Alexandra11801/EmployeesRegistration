using EmployeesRegistration.Models;
using EmployeesRegistration.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesRegistration.Forms
{
    public partial class StatisticsForm : BaseForm
    {
        private List<Department> departments;

        public StatisticsForm()
        {
            InitializeComponent();
            departments = DepartmentsService.GetAllDepartments();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            periodBox.SelectedIndex = 0;
            departmentBox.Items.AddRange(departments.Select(d => d.Name).ToArray());
            departmentBox.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            nextForm = new MainMenuForm();
            Close();
        }

        private void showStatisticsButton_Click(object sender, EventArgs e)
        {
            DateTime sinceDate;
            switch (periodBox.SelectedIndex)
            {
                case 0:
                    sinceDate = DateTime.MinValue;
                    break;
                case 1:
                    sinceDate = DateTime.Now.Subtract(TimeSpan.FromDays(30));
                    break;
                case 2:
                    sinceDate = DateTime.Now.Subtract(TimeSpan.FromDays(365));
                    break;
                default:
                    sinceDate = DateTime.MinValue;
                    break;
            }
            int recruited, fired;
            if(departmentBox.SelectedIndex == 0)
            {
                recruited = EmployeesService.GetRecruitedEmployeesCount(sinceDate);
                fired = EmployeesService.GetFiredEmployeesCount(sinceDate);
            }
            else
            {
                var departmentId = departments[departmentBox.SelectedIndex - 1].Id;
                recruited = EmployeesService.GetRecruitedEmployeesCount(sinceDate, departmentId);
                fired = EmployeesService.GetFiredEmployeesCount(sinceDate, departmentId);
            }
            recruitedLabel.Text = "Принято: " + recruited;
            firedLabel.Text = "Уволено: " + fired;
        }
    }
}
