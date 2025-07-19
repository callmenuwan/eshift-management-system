using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace eshift_management
{
    public partial class AdminLoadAssingment : Form
    {
        private Form1 mainForm;
        private int jobID;
        private string currentStatus;
        private DateTime jobSetDate;

        public AdminLoadAssingment(Form1 mainFormReference, int jobID, string currentStatus, DateTime jobDate)
        {
            InitializeComponent();
            mainForm = mainFormReference;

            this.jobID = jobID;
            this.currentStatus = currentStatus;
            this.jobSetDate = jobDate;

        }

        private void AdminLoadAssingment_Load(object sender, EventArgs e)
        {
            jobDatePicker.Value = jobSetDate;
            JobID.Text = jobID.ToString();
            curStatus.Text = currentStatus;

            ShowLoadIDs();
            GetLoadCountForJob(jobID);
            GetUnitCountForDate();
            LoadNext7DaysAvailability();
        }


        private int GetLoadCountForJob(int jobID)
        {
            string query = "SELECT COUNT(*) FROM Load WHERE JobID = @JobID";
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@JobID", jobID);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private bool GetUnitCountForDate()
        {
            DateTime today = jobDatePicker.Value.Date;

            int driversCount = GetAvailableCount("Driver", "DriverID", today);
            int assistantsCount = GetAvailableCount("Assistant", "AssistantID", today);
            int lorriesCount = GetAvailableCount("Lorry", "LorryID", today);
            int containersCount = GetAvailableCount("Container", "ContainerID", today);

            int loadCount = GetLoadCountForJob(jobID);

            if (driversCount >= loadCount && assistantsCount >= loadCount && lorriesCount >= loadCount && containersCount >= loadCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetAvailableCount(string tableName, string idField, DateTime jobSetDate)
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
                cmd.Parameters.AddWithValue("@JobDate", jobSetDate);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private void ShowLoadIDs()
        {
            loadIDCombo.Items.Clear();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string query = "SELECT LoadID FROM Load WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobID); // Set when opening form
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loadIDCombo.Items.Add(reader["LoadID"].ToString());
                }
                conn.Close();
            }
        }
        private void LoadAllAvailableUnits()
        {
            DateTime jobDate = jobDatePicker.Value;

            LoadAvailableCombo("Driver", "DriverID", "DriverName", jobDate, cmbDriver);
            LoadAvailableCombo("Assistant", "AssistantID", "AssistantName", jobDate, cmbAssistant);
            LoadAvailableCombo("Lorry", "LorryID", "LorryNumber", jobDate, cmbLorry);
            LoadAvailableCombo("Container", "ContainerID", "ContainerCode", jobDate, cmbContainer);
        }

        //General Method to Load Combo Boxes
        private void LoadAvailableCombo(string tableName, string idField, string nameField, DateTime jobDate, ComboBox comboBox)
        {

            // Query to get available units not assigned on selected date
            string query = $@"
        SELECT {idField}, {nameField} 
        FROM {tableName} 
        WHERE {idField} NOT IN (
            SELECT {idField} FROM LoadAssignment 
            WHERE AssignmentDate = @JobDate AND {idField} IS NOT NULL
        )";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobDate", jobDate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox.DataSource = dt;
                comboBox.DisplayMember = nameField;
                comboBox.ValueMember = idField;

                comboBox.SelectedIndex = -1; // default to nothing selected
            }
        }

        private void assignUnitsbtn_Click(object sender, EventArgs e)
        {
            if (loadIDCombo.SelectedItem == null ||
        cmbDriver.SelectedItem == null ||
        cmbAssistant.SelectedItem == null ||
        cmbLorry.SelectedItem == null ||
        cmbContainer.SelectedItem == null)
            {
                MessageBox.Show("Please select all fields.");
                return;
            }

            string loadID = loadIDCombo.SelectedItem.ToString();
            string driverID = cmbDriver.SelectedItem.ToString();
            string assistantID = cmbAssistant.SelectedItem.ToString();
            string lorryID = cmbLorry.SelectedItem.ToString();
            string containerID = cmbContainer.SelectedItem.ToString();

            // Duplicate validation (same driver etc. already assigned)
            foreach (DataGridViewRow row in dgvAssignments.Rows)
            {
                if (row.Cells["LoadID"].Value.ToString() == loadID)
                {
                    MessageBox.Show("This load is already assigned.");
                    return;
                }

                if (row.Cells["DriverID"].Value.ToString() == driverID)
                {
                    MessageBox.Show("This driver is already used.");
                    return;
                }

                if (row.Cells["AssistantID"].Value.ToString() == assistantID)
                {
                    MessageBox.Show("This assistant is already used.");
                    return;
                }

                if (row.Cells["LorryID"].Value.ToString() == lorryID)
                {
                    MessageBox.Show("This lorry is already used.");
                    return;
                }

                if (row.Cells["ContainerID"].Value.ToString() == containerID)
                {
                    MessageBox.Show("This container is already used.");
                    return;
                }
            }

            // Add to temporary grid
            dgvAssignments.Rows.Add(loadID, driverID, assistantID, lorryID, containerID);

            // Optionally remove items from ComboBoxes
            loadIDCombo.Items.Remove(loadID);
            cmbDriver.Items.Remove(driverID);
            cmbAssistant.Items.Remove(assistantID);
            cmbLorry.Items.Remove(lorryID);
            cmbContainer.Items.Remove(containerID);

            // Clear selection after adding
            loadIDCombo.SelectedIndex = -1;
            cmbDriver.SelectedIndex = -1;
            cmbAssistant.SelectedIndex = -1;
            cmbLorry.SelectedIndex = -1;
            cmbContainer.SelectedIndex = -1;
        }

        private void jobDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime newDate = jobDatePicker.Value;

            if (!GetUnitCountForDate())
            {
                MessageBox.Show("Not enough units available for new date.");
                assignUnitsbtn.Enabled = false;
            }
            else
            {
                LoadAllAvailableUnits();
                assignUnitsbtn.Enabled = true;
            }
        }

        private void jobAcceptBtn_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.Rows.Count == 0)
            {
                MessageBox.Show("No assignments to save.");
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Open();

            foreach (DataGridViewRow row in dgvAssignments.Rows)
            {
                string query = @"INSERT INTO LoadAssignment 
                         (LoadID, AssignmentDate, DriverID, AssistantID, LorryID, ContainerID)
                         VALUES (@LoadID, @Date, @DriverID, @AssistantID, @LorryID, @ContainerID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoadID", Convert.ToInt32(row.Cells["LoadID"].Value));
                cmd.Parameters.AddWithValue("@Date", jobDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@DriverID", Convert.ToInt32(row.Cells["DriverID"].Value));
                cmd.Parameters.AddWithValue("@AssistantID", Convert.ToInt32(row.Cells["AssistantID"].Value));
                cmd.Parameters.AddWithValue("@LorryID", Convert.ToInt32(row.Cells["LorryID"].Value));
                cmd.Parameters.AddWithValue("@ContainerID", Convert.ToInt32(row.Cells["ContainerID"].Value));
                cmd.ExecuteNonQuery();
            }

            // Update job to Accepted
            SqlCommand updateCmd = new SqlCommand("UPDATE Job SET Status = 'Accepted' WHERE JobID = @JobID", conn);
            updateCmd.Parameters.AddWithValue("@JobID", jobID);
            updateCmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Units assigned successfully!");
            mainForm.LoadChildForm(new AdminDashboard(mainForm));
            this.Close();
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

        private void jobDeclineBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
