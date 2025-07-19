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
        private Form1 mainForm;

        public AdminJobsViewForm(Form1 mainFormReference)
        {
            InitializeComponent();
            mainForm = mainFormReference;
        }

        private void AdminJobsViewForm_Load(object sender, EventArgs e)
        {
            LoadAllJobsIntoGrid();
            LoadStatusFilterOptions();
        }


        // LoaderOptimization Jobs in to datagrid view

        private void LoadAllJobsIntoGrid(string statusFilter = "All")
        {
            string query;

            if (statusFilter == "All")
            {
                query = @"
                        SELECT 
                            J.JobID,
                            C.CusName,
                            J.JobDate,
                            J.Status,
                            J.LoadStatus
                        FROM Job J
                        INNER JOIN Customer C ON J.JobCustID = C.CustID
                        ORDER BY J.JobDate DESC";
            }
            else
            {
                query = @"
                        SELECT 
                            J.JobID,
                            C.CusName,
                            J.JobDate,
                            J.Status,
                            J.LoadStatus
                        FROM Job J
                        INNER JOIN Customer C ON J.JobCustID = C.CustID
                        WHERE J.Status = @Status
                        ORDER BY J.JobDate DESC";
            }


            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (statusFilter != "All")
                {
                    cmd.Parameters.AddWithValue("@Status", statusFilter);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAllJobs.DataSource = dt;

                ApplyStatusColors();
            }

        }
        private void ApplyStatusColors()
        {
            foreach (DataGridViewRow row in dgvAllJobs.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();

                    switch (status)
                    {
                        case "Pending":
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            break;
                        case "Approved":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Declined":
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            break;
                        default:
                            row.DefaultCellStyle.BackColor = Color.White;
                            break;
                    }
                }
            }
        }

        private void LoadStatusFilterOptions()
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.Items.Add("Approved");
            cmbStatusFilter.Items.Add("Declined");
            cmbStatusFilter.SelectedIndex = 0; // Default to "All"
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatusFilter.SelectedItem.ToString();
            LoadAllJobsIntoGrid(selectedStatus);
        }

        private void createLoadsBtn_Click(object sender, EventArgs e)
        {
            if (dgvAllJobs.CurrentRow != null)
            {
                int selectedJobID = Convert.ToInt32(dgvAllJobs.CurrentRow.Cells["JobID"].Value);
                string? currentStatus = dgvAllJobs.CurrentRow.Cells["Status"].Value.ToString();
                DateTime jobDate = Convert.ToDateTime(dgvAllJobs.CurrentRow.Cells["JobDate"].Value);

                // Open AdminLoadCreateForm and pass JobID
                mainForm.LoadChildForm(new AdminLoadCreate(mainForm, selectedJobID, currentStatus, jobDate));
            }
            else
            {
                MessageBox.Show("Please select a job from the list.");
            }
        }

        private void delineBtn_Click(object sender, EventArgs e)
        {
            if (dgvAllJobs.CurrentRow != null)
            {
                int selectedJobID = Convert.ToInt32(dgvAllJobs.CurrentRow.Cells["JobID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to decline this job?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DeclineJob(selectedJobID);
                    LoadAllJobsIntoGrid(cmbStatusFilter.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a job to decline.");
            }
        }
        private void DeclineJob(int jobID)
        {
            string query = "UPDATE Job SET Status = 'Declined' WHERE JobID = @JobID";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@JobID", jobID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void assignUnitsBtn_Click(object sender, EventArgs e)
        {
            if (dgvAllJobs.CurrentRow != null)
            {
                int selectedJobID = Convert.ToInt32(dgvAllJobs.CurrentRow.Cells["JobID"].Value);
                string? currentStatus = dgvAllJobs.CurrentRow.Cells["Status"].Value.ToString();
                DateTime jobDate = Convert.ToDateTime(dgvAllJobs.CurrentRow.Cells["JobDate"].Value);

                mainForm.LoadChildForm(new AdminLoadAssingment(mainForm, selectedJobID, currentStatus, jobDate));
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a job from the list.");
            }
        }

        private void dgvAllJobs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAllJobs.CurrentRow != null && dgvAllJobs.CurrentRow.Cells["LoadStatus"].Value != DBNull.Value)
            {
                bool loadStatus = Convert.ToBoolean(dgvAllJobs.CurrentRow.Cells["LoadStatus"].Value);

                if (loadStatus)
                {
                    // If LoadStatus == true → disable createLoads, enable assignUnits
                    createLoadsBtn.Enabled = false;
                    assignUnitsBtn.Enabled = true;
                }
                else
                {
                    // If LoadStatus == false → enable createLoads, disable assignUnits
                    createLoadsBtn.Enabled = true;
                    assignUnitsBtn.Enabled = false;
                }
            }
            else
            {
                // If no valid row selected
                createLoadsBtn.Enabled = false;
                assignUnitsBtn.Enabled = false;
            }
        }
    }
}
