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
using static eshift_management.Models;

namespace eshift_management
{
    public partial class AdminLoadCreate : Form
    {
        private int jobID;
        private string currentStatus;
        private DateTime jobDate;
        private int loadCounter = 1;

        private List<LoadProduct> allProducts = new List<LoadProduct>();
        private List<LoadProduct> currentLoad = new List<LoadProduct>();
        private List<Load> loadList = new List<Load>();

        public AdminLoadCreate(int jobID, string currentStatus, DateTime jobDate)
        {
            InitializeComponent();

            this.jobID = jobID;
            this.currentStatus = currentStatus;
            this.jobDate = jobDate;
            LoadAllProductsFromJob();
            SetupGrids();
        }

        private void LoadAllProductsFromJob()
        {
            allProducts.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
                {
                    conn.Open();
                    string query = @"SELECT p.ProductID, p.ProductName, p.UnitWeight, jp.Quantity 
                             FROM JobProduct jp
                             INNER JOIN Product p ON jp.ProductID = p.ProductID
                             WHERE jp.JobID = @jobID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@jobID", jobID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        allProducts.Add(new LoadProduct
                        {
                            ProductID = (int)reader["ProductID"],
                            ProductName = reader["ProductName"].ToString(),
                            UnitWeight = (decimal)reader["UnitWeight"],
                            Quantity = (int)reader["Quantity"]
                        });
                    }

                    reader.Close();
                }

                dgvAllProducts.DataSource = null;
                dgvAllProducts.DataSource = allProducts;

                //MessageBox.Show("Loaded " + allProducts.Count + " products.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }

            //RefreshAllGrids();
        }

        private void SetupGrids()
        {
            dgvAllProducts.AutoGenerateColumns = true;
            dgvCurrentLoadProducts.AutoGenerateColumns = true;
            dgvLoadSummary.AutoGenerateColumns = false;

            dgvLoadSummary.Columns.Clear();
            dgvLoadSummary.Columns.Add("LoadNumber", "Load No");
            dgvLoadSummary.Columns.Add("ProductCount", "Products");
            dgvLoadSummary.Columns.Add("TotalWeight", "Total Weight");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshAllGrids()
        {
            dgvAllProducts.DataSource = null;
            dgvAllProducts.DataSource = allProducts;

            dgvCurrentLoadProducts.DataSource = null;
            dgvCurrentLoadProducts.DataSource = currentLoad;

            dgvLoadSummary.Rows.Clear();
            foreach (var load in loadList)
            {
                int productCount = load.Products.Count;
                decimal totalWeight = load.Products.Sum(p => p.TotalWeight);
                dgvLoadSummary.Rows.Add(load.LoadNumber, productCount, totalWeight);
            }
        }

        private void addProBtn_Click(object sender, EventArgs e)
        {
            if (dgvAllProducts.SelectedRows.Count == 0) return;

            foreach (DataGridViewRow row in dgvAllProducts.SelectedRows)
            {
                int prodId = (int)row.Cells["ProductID"].Value;
                var prod = allProducts.First(p => p.ProductID == prodId);
                currentLoad.Add(prod);
                allProducts.Remove(prod);
            }

            RefreshAllGrids();
        }

        private void removeProBtn_Click(object sender, EventArgs e)
        {
            if (dgvCurrentLoadProducts.SelectedRows.Count == 0) return;

            foreach (DataGridViewRow row in dgvCurrentLoadProducts.SelectedRows)
            {
                int prodId = (int)row.Cells["ProductID"].Value;
                var prod = currentLoad.First(p => p.ProductID == prodId);
                allProducts.Add(prod);
                currentLoad.Remove(prod);
            }

            RefreshAllGrids();
        }

        private void createTempLoad_Click(object sender, EventArgs e)
        {
            if (currentLoad.Count == 0)
            {
                MessageBox.Show("Please add products to the current load.");
                return;
            }

            Load newLoad = new Load
            {
                LoadNumber = loadCounter++,
                Products = new List<LoadProduct>(currentLoad)
            };

            loadList.Add(newLoad);
            currentLoad.Clear();
            RefreshAllGrids();
        }

        private void assignUnitBtn_Click(object sender, EventArgs e)
        {
            AssignTransportUnitForm assignTransportUnitForm = new AssignTransportUnitForm(jobID, currentStatus, jobDate);
            assignTransportUnitForm.ShowDialog();
        }
    }
}
