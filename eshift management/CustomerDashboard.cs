using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace eshift_management
{
    public partial class CustomerDashboard : Form
    {
        private Form1 mainForm;

        public CustomerDashboard(Form1 mainFormReference)
        {
            InitializeComponent();
            mainForm = mainFormReference;
        }

        private void jobFormBtn_Click(object sender, EventArgs e)
        {
            if (Login.LoggedInCustomer != null)
            {
                mainForm.LoadChildForm(new CreateJobForm(mainForm));
            }
            else
            {
                MessageBox.Show("Access denied. Please login as Customer.");
            }
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            if (Login.LoggedInCustomer != null)
            {
                int customerId = Login.LoggedInCustomer.UId;
                //MessageBox.Show("Customer ID: " + customerId);

                LoadAllJobsIntoGrid(customerId);
            }
            else
            {
                MessageBox.Show("Customer not logged in. Redirecting...");
                this.Close();
            }
        }


        private void LoadAllJobsIntoGrid(int customerId)
        {
            string query = "SELECT * FROM Job WHERE JobCustID = @CustomerID ORDER BY JobDate DESC";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCusJobs.DataSource = dt;
            }

        }
    }
}
