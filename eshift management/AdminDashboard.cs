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
using ScottPlot;
using ScottPlot.WinForms;

namespace eshift_management
{
    public partial class AdminDashboard : Form
    {
        private Form1 mainForm;

        public AdminDashboard(Form1 mainFormReference)
        {
            InitializeComponent();
            mainForm = mainFormReference;
        }

        private void cusRegFormBtn_Click(object sender, EventArgs e)
        {
            if (Login.LoggedInAdmin != null)
            {
                mainForm.LoadChildForm(new RegisterCustomerForm());
            }
            else
            {
                MessageBox.Show("Access denied. Please login as admin.");
            }
        }

        private void untiAssignFormBtn_Click(object sender, EventArgs e)
        {
            mainForm.LoadChildForm(new AdminJobsViewForm(mainForm));
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadJobsChart();
        }


        private void LoadJobsChart()
        {
            string connStr = Properties.Settings.Default.conn;
            string query = @"SELECT CAST(JobDate AS DATE) AS JobDay, COUNT(*) AS JobCount
                         FROM Job
                         WHERE MONTH(JobDate) = MONTH(GETDATE()) 
                           AND YEAR(JobDate) = YEAR(GETDATE())
                         GROUP BY CAST(JobDate AS DATE)
                         ORDER BY JobDay";

            List<string> dateLabels = new List<string>();
            List<double> jobCounts = new List<double>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime day = reader.GetDateTime(0);
                    int count = reader.GetInt32(1);

                    dateLabels.Add(day.ToString("MMM d"));
                    jobCounts.Add(count);
                }
            }

            var formsPlot = new FormsPlot();
            formsPlot.Dock = DockStyle.Fill;
            
            formsPlot.Plot.Clear();
            formsPlot.Plot.AddBar(jobCounts.ToArray());
            formsPlot.Plot.XTicks(dateLabels.ToArray());
            formsPlot.Plot.Title("Jobs This Month");
            formsPlot.Plot.XLabel("Date");
            formsPlot.Plot.YLabel("Number of Jobs");
            formsPlot.Refresh();
            panelChart.Controls.Clear();
            panelChart.Controls.Add(formsPlot);
        }


    }
}
