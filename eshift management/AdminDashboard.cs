using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift_management
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void cusRegFormBtn_Click(object sender, EventArgs e)
        {
            if (Login.LoggedInAdmin != null)
            {
                RegisterCustomerForm registerForm = new RegisterCustomerForm();
                registerForm.Show();
            }
            else
            {
                MessageBox.Show("Access denied. Please login as admin.");
            }
        }

        private void untiAssignFormBtn_Click(object sender, EventArgs e)
        {
            AdminJobsViewForm adminJobsViewForm = new AdminJobsViewForm();
            adminJobsViewForm.Show();

            //if (Login.LoggedInAdmin != null)
            //{
            //    AssignTransportUnitForm assignTransportUnitForm = new AssignTransportUnitForm();
            //    assignTransportUnitForm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Access denied. Please login as admin.");
            //}
        }
    }
}
