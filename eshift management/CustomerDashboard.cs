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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void jobFormBtn_Click(object sender, EventArgs e)
        {
            if (Login.LoggedInCustomer != null)
            {
                CreateJobForm createJobForm = new CreateJobForm();
                createJobForm.Show();
            }
            else
            {
                MessageBox.Show("Access denied. Please login as Customer.");
            }
        }
    }
}
