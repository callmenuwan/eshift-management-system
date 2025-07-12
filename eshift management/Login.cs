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
    public partial class Login : Form
    {
        public static Admin? LoggedInAdmin; // accessible globally
        public static Customer? LoggedInCustomer; // accessible globally

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string enteredEmail = loginEmail.Text.Trim();          // input from textbox
            string enteredPassword = loginPassword.Text.Trim();    // input from textbox

            // Safely get the selected role from dropdown (bcan be null)
            string? selectedRole = loginRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role before logging in.");
                return; // Exit if role is not selected
            }

            // Admin Login

            if (selectedRole == "Admin")
            {
                Admin adminUser = new Admin();

                if (adminUser.Login(enteredEmail, enteredPassword))
                {
                    LoggedInAdmin = adminUser;
                    MessageBox.Show("Admin login successful!");

                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Admin credentials.");
                }
            }
            else if (selectedRole == "Customer")
            {
                Customer customerUser = new Customer();

                if (customerUser.Login(enteredEmail, enteredPassword))
                {
                    LoggedInCustomer = customerUser;
                    MessageBox.Show("Customer login successful!");

                    CustomerDashboard customerDashboard = new CustomerDashboard();
                    customerDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Customer credentials.");
                }
            }
        }
    }
}
