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


            // Remove if already exists
            if (dgvJobs.Columns.Contains("DeclineBtn"))
                dgvJobs.Columns.Remove("DeclineBtn");

            // Create decline button column
            DataGridViewButtonColumn declineBtn = new DataGridViewButtonColumn();
            declineBtn.Name = "DeclineBtn";
            declineBtn.HeaderText = "Decline";
            declineBtn.Text = "Decline";
            declineBtn.UseColumnTextForButtonValue = true;
            dgvJobs.Columns.Add(declineBtn);

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
            if (e.RowIndex < 0)
                return;

            string columnName = dgvJobs.Columns[e.ColumnIndex].Name;
            int jobID = Convert.ToInt32(dgvJobs.Rows[e.RowIndex].Cells["JobID"].Value);
            string currentStatus = dgvJobs.Rows[e.RowIndex].Cells["Status"].Value?.ToString() ?? "";
            DateTime jobDate = Convert.ToDateTime(dgvJobs.Rows[e.RowIndex].Cells["JobDate"].Value);

            // Handle Change Status (Assign)
            if (columnName == "ChangeStatus")
            {
                AdminLoadCreate assignForm = new AdminLoadCreate(jobID, currentStatus, jobDate);
                assignForm.ShowDialog();

                //AssignTransportUnitForm assignForm = new AssignTransportUnitForm(jobID, currentStatus, jobDate);
                //assignForm.ShowDialog();
            }

            // Handle Decline (only if pending)
            else if (columnName == "DeclineBtn")
            {
                if (currentStatus != "Pending")
                {
                    MessageBox.Show("Only pending jobs can be declined.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to decline this job?", "Confirm Decline", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE Job SET Status = 'Declined' WHERE JobID = @JobID";
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@JobID", jobID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Job has been declined.");
                    LoadAllJobsIntoGrid(); // Refresh
                }
            }
        }

        private void dgvJobs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvJobs.Columns[e.ColumnIndex].Name == "DeclineBtn" && e.RowIndex >= 0)
            {
                var status = dgvJobs.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
                if (status != "Pending")
                {
                    dgvJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                    dgvJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Gray;
                    dgvJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.Gray;
                }
            }
        }
    }
}
