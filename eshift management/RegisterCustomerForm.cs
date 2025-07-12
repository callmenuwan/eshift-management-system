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
    public partial class RegisterCustomerForm : Form
    {
        public RegisterCustomerForm()
        {
            InitializeComponent();
        }

        private void cusRegBtn_Click(object sender, EventArgs e)
        {
            string name     = cusRegName.Text.Trim();
            string email    = cusRegEmail.Text.Trim();
            string password = cusRegPassword.Text.Trim();

            if (Login.LoggedInAdmin != null)
            {
                Customer addCustomer = Login.LoggedInAdmin.RegisterCustomer(name, email, password);

                // Show success
                MessageBox.Show($"Customer  created successfully!");
            }
            else
            {
                MessageBox.Show("Unauthorized action.");
                this.Close();
            }
        }
    }
}
