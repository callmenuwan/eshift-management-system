using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift_management
{
    public partial class AdminJobsViewForm : Form
    {

        public AdminJobsViewForm()
        {
            InitializeComponent();
            this.dgvJobs.RowPrePaint += dgvJobs_RowPrePaint;
        }

        private void AdminJobsViewForm_Load(object sender, EventArgs e)
        {
            LoadAllJobsIntoGrid();
        }


        // LoaderOptimization Jobs in to datagrid view

        private void LoadAllJobsIntoGrid()
        {
            string query = "SELECT * FROM Job ORDER BY JobDate DESC";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvJobs.DataSource = dt;
            }


            // First remove existing button column to avoid duplicates
            if (dgvJobs.Columns.Contains("ChangeStatus"))
                dgvJobs.Columns.Remove("ChangeStatus");

            // Create a new button column
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Action";
            btnColumn.Name = "ChangeStatus";
            btnColumn.Text = "Change Status";
            btnColumn.UseColumnTextForButtonValue = true;

            dgvJobs.Columns.Add(btnColumn);

        }

        // Add color for each row according to status

        private void dgvJobs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
            {
                string status = rowView["Status"].ToString();

                switch (status)
                {
                    case "Pending":
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case "Approved":
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "Declined":
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        break;
                }
            }
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvJobs.Columns[e.ColumnIndex].Name == "ChangeStatus")
            {
                // Get selected job ID and status
                int jobID = Convert.ToInt32(dgvJobs.Rows[e.RowIndex].Cells["JobID"].Value);
                string currentStatus = dgvJobs.Rows[e.RowIndex].Cells["Status"].Value?.ToString() ?? "";

                // Create instance of AssignTransportUnitForm and pass data
                AssignTransportUnitForm assignForm = new AssignTransportUnitForm(jobID, currentStatus);

                // Show form as dialog or normal window based on your need
                assignForm.ShowDialog();
            }
        }
    }
}
