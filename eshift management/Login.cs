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
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = loginEmail.Text.Trim();
            string password = loginPassword.Text.Trim();
            string role = loginRole.SelectedItem.ToString();

            AuthSystem auth = new AuthSystem();
            Admin adminUser = new Admin("admin@eshift.com", "admin123");

            string result = auth.LoginUser(adminUser, loginEmail.Text, loginPassword.Text);
            MessageBox.Show(result);

        }
    }
}
