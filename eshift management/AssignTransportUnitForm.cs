using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace eshift_management
{
    public partial class AssignTransportUnitForm : Form
    {

        private int jobIDc;
        private string currentStatusx;
        private DateTime jobDate;
        private Form AdminJobsViewForm;
        //private Form? parent;

        public AssignTransportUnitForm(int jobID, string currentStatus, DateTime jobDate)
        {
            InitializeComponent();
            //this.AdminJobsViewForm = parent;

            this.jobIDc = jobID;
            this.currentStatusx = currentStatus;
            this.jobDate = jobDate;

            //jobDatePicker.ValueChanged += jobDatePicker_ValueChanged;

            // Optionally, load job details here using jobID
            LoadJobDetails();



            InitializeLoadAssignmentGrid();
        }

        private void InitializeLoadAssignmentGrid()
        {
            dgvLoadAssignments.Columns.Clear();

            dgvLoadAssignments.Columns.Add("LoadID", "Load ID");
            dgvLoadAssignments.Columns["LoadID"].ReadOnly = true;

            AddComboBoxColumn("Driver", "Driver");
            AddComboBoxColumn("Assistant", "Assistant");
            AddComboBoxColumn("Lorry", "Lorry");
            AddComboBoxColumn("Container", "Container");
        }

        private void AddComboBoxColumn(string name, string header)
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.Name = name + "Column";
            cmb.HeaderText = header;
            cmb.DataSource = null; // will bind later
            cmb.DisplayMember = "Name"; // custom class property
            cmb.ValueMember = "ID";
            dgvLoadAssignments.Columns.Add(cmb);
        }

        private void AssignTransportUnitForm_Load(object sender, EventArgs e)
        {
            LoadJobDetails();
            LoadAllAvailableUnits();
            LoadNext7DaysAvailability();


            jobDatePicker.Value = jobDate;

            InitializeLoadAssignmentGrid();

            List<int> loadIDs = ShowLoadIDsForJob(jobIDc);
            foreach (int loadID in loadIDs)
            {
                dgvLoadAssignments.Rows.Add(loadID);
            }

            LoadAvailableUnitsForDate(jobDatePicker.Value);
        }

        private List<int> ShowLoadIDsForJob(int jobId)
        {
            List<int> loadIDs = new List<int>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string query = "SELECT LoadID FROM Load WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loadIDs.Add(reader.GetInt32(0));
                }
            }
            return loadIDs;
        }

        private void LoadAvailableUnitsForDate(DateTime date)
        {
            var drivers = GetAvailableUnits("Driver", date);
            var assistants = GetAvailableUnits("Assistant", date);
            var lorries = GetAvailableUnits("Lorrie", date);
            var containers = GetAvailableUnits("Container", date);

            // Check counts
            int loadCount = dgvLoadAssignments.Rows.Count;
            if (drivers.Count < loadCount || assistants.Count < loadCount || lorries.Count < loadCount || containers.Count < loadCount)
            {
                MessageBox.Show("Not enough available units to assign all loads. Please decline the job.");
                assignUnitsbtn.Enabled = false;
                dgvLoadAssignments.Enabled = false;
                return;
            }

            assignUnitsbtn.Enabled = true;
            dgvLoadAssignments.Enabled = true;

            // Bind to each ComboBox column
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["DriverColumn"]).DataSource = drivers;
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["AssistantColumn"]).DataSource = assistants;
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["LorryColumn"]).DataSource = lorries;
            ((DataGridViewComboBoxColumn)dgvLoadAssignments.Columns["ContainerColumn"]).DataSource = containers;
        }

        public class UnitItem
        {
            public int ID { get; set; }
            //public string? Name { get; set; } // Example: "John (Driver1)"
        }

        private List<UnitItem> GetAvailableUnits(string type, DateTime date)
        {
            List<UnitItem> list = new List<UnitItem>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string query = $"SELECT {type}ID FROM {type} WHERE {type}ID NOT IN (SELECT {type}ID FROM JobAssignment WHERE AssignmentDate = @Date)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", date);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new UnitItem
                    {
                        ID = reader.GetInt32(0),
                        //Name = reader.GetString(1)
                    });
                }
            }
            return list;
        }








        //General Method to Load Combo Boxes
        private void LoadAvailableCombo(string tableName, string idField, string nameField, DateTime jobDate, ComboBox comboBox)
        {

            // Query to get available units not assigned on selected date
            string query = $@"
        SELECT {idField}, {nameField} 
        FROM {tableName} 
        WHERE {idField} NOT IN (
            SELECT {idField} FROM JobAssignment 
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

        //Method to Load All Units for Job Date
        private void LoadAllAvailableUnits()
        {
            DateTime jobDate = jobDatePicker.Value;

            LoadAvailableCombo("Driver", "DriverID", "DriverName", jobDate, cmbDriver);
            LoadAvailableCombo("Assistant", "AssistantID", "AssistantName", jobDate, cmbAssistant);
            LoadAvailableCombo("Lorrie", "LorryID", "LorryNumber", jobDate, cmbLorry);
            LoadAvailableCombo("Container", "ContainerID", "ContainerCode", jobDate, cmbContainer);
        }


        private void LoadJobDetails()
        {
            JobID.Text = jobIDc.ToString();
            curStatus.Text = currentStatusx;
            jobDatePicker.Text = jobDate.ToString();
        }


        //Reload Available Units on Job Date Change
        private void jobDatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadAllAvailableUnits();
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
                int availableLorries = GetAvailableCount("Lorrie", "LorryID", checkDate);
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
                                FROM JobAssignment
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




        private void assignBtn_Click(object sender, EventArgs e)
        {
            if (cmbDriver.SelectedValue == null || cmbAssistant.SelectedValue == null ||
        cmbLorry.SelectedValue == null || cmbContainer.SelectedValue == null)
            {
                MessageBox.Show("Please select all transport units.");
                return;
            }

            int driverId = Convert.ToInt32(cmbDriver.SelectedValue);
            int assistantId = Convert.ToInt32(cmbAssistant.SelectedValue);
            int lorryId = Convert.ToInt32(cmbLorry.SelectedValue);
            int containerId = Convert.ToInt32(cmbContainer.SelectedValue);
            DateTime selectedDate = jobDatePicker.Value;

            TransportAssignment assign = new TransportAssignment(jobIDc, driverId, assistantId, lorryId, containerId, selectedDate);

            if (assign.AssignmentRecordOnDb())
            {
                MessageBox.Show("Job successfully assigned and approved.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }



        private void cmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminJobsViewForm.Show(); // only needed if it was hidden
            this.Close();
        }

        private void dgvLoadAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void jobDatePicker_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvNext7DaysAvailability_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
