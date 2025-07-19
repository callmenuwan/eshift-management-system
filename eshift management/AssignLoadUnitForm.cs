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
    public partial class AssignLoadUnitForm : Form
    {
        private int jobID;
        private string currentStatus;
        private DateTime jobDate;

        public AssignLoadUnitForm(int jobID, string currentStatus, DateTime jobDate)
        {
            InitializeComponent();
            this.jobID = jobID;
            this.currentStatus = currentStatus;
            this.jobDate = jobDate;
        }

        private void AssignLoadUnitForm_Load(object sender, EventArgs e)
        {
            jobDatePicker.Value = jobDate;
            JobID.Text = jobID.ToString();
            curStatus.Text = currentStatus;

            ShowLoadsToGrid();
            LoadAvailableUnits(jobDatePicker.Value);
            LoadNext7DaysAvailability();
        }

        private void ShowLoadsToGrid()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string query = "SELECT LoadID FROM Load WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", JobID.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvLoadAssignments.Rows.Add(reader["LoadID"].ToString());
                }
            }
        }

        private void LoadAvailableUnits(DateTime selectedDate)
        {
            DataTable dtDriver = GetAvailableUnitTable("Driver", selectedDate);
            DataTable dtAssistant = GetAvailableUnitTable("Assistant", selectedDate);
            DataTable dtLorry = GetAvailableUnitTable("Lorry", selectedDate);
            DataTable dtContainer = GetAvailableUnitTable("Container", selectedDate);

            int loadCount = dgvLoadAssignments.Rows.Count;

            if (dtDriver.Rows.Count < loadCount ||
                dtAssistant.Rows.Count < loadCount ||
                dtLorry.Rows.Count < loadCount ||
                dtContainer.Rows.Count < loadCount)
            {
                MessageBox.Show("Not enough units for all loads. Please decline the job.");
                assignUnitsbtn.Enabled = false;
                dgvLoadAssignments.Enabled = false;
                return;
            }

            assignUnitsbtn.Enabled = true;
            dgvLoadAssignments.Enabled = true;

            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["DriverColumn"]).DataSource = dtDriver;
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["DriverColumn"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["DriverColumn"]).ValueMember = "ID";

            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["AssistantColumn"]).DataSource = dtAssistant;
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["AssistantColumn"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["AssistantColumn"]).ValueMember = "ID";

            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["LorryColumn"]).DataSource = dtLorry;
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["LorryColumn"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["LorryColumn"]).ValueMember = "ID";

            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["ContainerColumn"]).DataSource = dtContainer;
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["ContainerColumn"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["ContainerColumn"]).ValueMember = "ID";
        }

        private DataTable GetAvailableUnitTable(string unitType, DateTime date)
        {
            DataTable dt = new DataTable();

            string idColumn = "";
            string nameColumn = "";

            // Map correct ID and Name columns
            if (unitType == "Driver")
            {
                idColumn = "DriverID";
                nameColumn = "DriverName";
            }
            else if (unitType == "Assistant")
            {
                idColumn = "AssistantID";
                nameColumn = "AssistantName";
            }
            else if (unitType == "Lorry")
            {
                idColumn = "LorryID";
                nameColumn = "LorryNumber";
            }
            else if (unitType == "Container")
            {
                idColumn = "ContainerID";
                nameColumn = "ContainerCode";
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string query = $@"
            SELECT {idColumn} AS ID, {nameColumn} AS Name
            FROM {unitType}
            WHERE {idColumn} NOT IN (
                SELECT {idColumn} FROM LoadAssignment WHERE AssignmentDate = @Date
            )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", date);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        private void jobDatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableUnits(jobDatePicker.Value);
        }




        //---------------------------------------------------------//
        // Additional Feature:  Show unit availabilit in Grid View //
        //---------------------------------------------------------//


        private void LoadNext7DaysAvailability()
        {
            DateTime today = jobDatePicker.Value.Date;

            DataTable table = new DataTable();
            table.Columns.Add("Date");
            table.Columns.Add("Drivers");
            table.Columns.Add("Assistants");
            table.Columns.Add("Lorries");
            table.Columns.Add("Containers");

            for (int i = 0; i < 7; i++)
            {
                DateTime checkDate = today.AddDays(i);

                int availableDrivers = GetAvailableCount("Driver", "DriverID", checkDate);
                int availableAssistants = GetAvailableCount("Assistant", "AssistantID", checkDate);
                int availableLorries = GetAvailableCount("Lorry", "LorryID", checkDate);
                int availableContainers = GetAvailableCount("Container", "ContainerID", checkDate);

                table.Rows.Add(checkDate.ToString("yyyy-MM-dd"), availableDrivers, availableAssistants, availableLorries, availableContainers);
            }

            dgvNext7DaysAvailability.DataSource = table;
        }

        private int GetAvailableCount(string tableName, string idField, DateTime date)
        {
            string connStr = Properties.Settings.Default.conn;
            string query = $@"
                            SELECT COUNT(*) 
                            FROM {tableName} 
                            WHERE {idField} NOT IN (
                                SELECT {idField} 
                                FROM LoadAssignment
                                WHERE AssignmentDate = @JobDate AND {idField} IS NOT NULL
                            )";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobDate", date);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private void assignUnitsbtn_Click(object sender, EventArgs e)
        {
            // 1. Basic checks
            if (dgvLoadAssignments.Rows.Count == 0)
            {
                MessageBox.Show("No loads to assign units.");
                return;
            }

            // 2. Create tracking DataTables to detect duplicates
            DataTable assignedDrivers = new DataTable();
            assignedDrivers.Columns.Add("ID", typeof(int));

            DataTable assignedAssistants = new DataTable();
            assignedAssistants.Columns.Add("ID", typeof(int));

            DataTable assignedLorries = new DataTable();
            assignedLorries.Columns.Add("ID", typeof(int));

            DataTable assignedContainers = new DataTable();
            assignedContainers.Columns.Add("ID", typeof(int));

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvLoadAssignments.Rows)
                {
                    int loadId = Convert.ToInt32(row.Cells["LoadID"].Value);
                    object driverObj = row.Cells["DriverCombo"].Value;
                    object assistantObj = row.Cells["AssistantCombo"].Value;
                    object lorryObj = row.Cells["LorryCombo"].Value;
                    object containerObj = row.Cells["ContainerCombo"].Value;

                    // 3. Check all selections made
                    if (driverObj == null || assistantObj == null || lorryObj == null || containerObj == null)
                    {
                        MessageBox.Show($"Please assign all units for Load ID {loadId}.");
                        return;
                    }

                    int driverId = Convert.ToInt32(driverObj);
                    int assistantId = Convert.ToInt32(assistantObj);
                    int lorryId = Convert.ToInt32(lorryObj);
                    int containerId = Convert.ToInt32(containerObj);

                    // 4. Check duplicates
                    if (assignedDrivers.Select("ID = " + driverId).Length > 0 ||
                        assignedAssistants.Select("ID = " + assistantId).Length > 0 ||
                        assignedLorries.Select("ID = " + lorryId).Length > 0 ||
                        assignedContainers.Select("ID = " + containerId).Length > 0)
                    {
                        MessageBox.Show($"Duplicate assignment found on Load ID {loadId}. Each unit must be used only once.");
                        return;
                    }

                    // Add to duplicate check tables
                    assignedDrivers.Rows.Add(driverId);
                    assignedAssistants.Rows.Add(assistantId);
                    assignedLorries.Rows.Add(lorryId);
                    assignedContainers.Rows.Add(containerId);

                    // 5. Insert into DB
                    string insertQuery = @"
                INSERT INTO LoadAssignment (LoadID, AssignmentDate, DriverID, AssistantID, LorryID, ContainerID)
                VALUES (@LoadID, @Date, @DriverID, @AssistantID, @LorryID, @ContainerID)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@LoadID", loadId);
                    cmd.Parameters.AddWithValue("@Date", jobDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@DriverID", driverId);
                    cmd.Parameters.AddWithValue("@AssistantID", assistantId);
                    cmd.Parameters.AddWithValue("@LorryID", lorryId);
                    cmd.Parameters.AddWithValue("@ContainerID", containerId);

                    cmd.ExecuteNonQuery();
                }

                // 6. Mark Job as Accepted
                string updateJob = "UPDATE Job SET Status = 'Accepted' WHERE JobID = @JobID";
                SqlCommand updateCmd = new SqlCommand(updateJob, conn);
                updateCmd.Parameters.AddWithValue("@JobID", jobDatePicker); // you must define this at form load
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Units assigned and job accepted successfully.");
                this.Close();
            }
        }
    }
}
