using System.Windows.Forms;

namespace EmployeesRegistration.Forms
{
    public partial class BaseForm : Form
    {
        protected Form nextForm;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nextForm != null)
            {
                nextForm?.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
