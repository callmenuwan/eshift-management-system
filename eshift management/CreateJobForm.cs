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
    public partial class CreateJobForm : Form
    {
        private DataTable productTable;

        public CreateJobForm()
        {
            InitializeComponent();
            productTable = new DataTable();
            LoadProductsIntoCombo();
            InitializeProductTable();
        }

        private void createJobBtn_Click(object sender, EventArgs e)
        {
            if (Login.LoggedInCustomer == null)
            {
                MessageBox.Show("Please log in as customer.");
                return;
            }

            string start = startLocation.Text.Trim();
            string destination = destinationLocation.Text.Trim();
            DateTime selectedJobDate = jobDate.SelectionStart;

            TransportJob job = new TransportJob
            {
                CustomerID = Login.LoggedInCustomer.UId,
                StartLocation = start,
                Destination = destination,
                JobDate = selectedJobDate,
                Status = "Pending"
            };

            int newJobID = job.SaveJobToDatabase();  // Save job and get JobID

            if (newJobID > 0)
            {
                // Now save products into JobProducts table
                //bool allInserted = true;

                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
                {
                    conn.Open();

                    foreach (DataRow row in productTable.Rows)
                    {
                        try
                        {
                            int productID = Convert.ToInt32(row["ProductID"]);
                            int quantity = Convert.ToInt32(row["Quantity"]);

                            MessageBox.Show($"Inserting: JobID={newJobID}, ProductID={productID}, Quantity={quantity}");

                            string query = "INSERT INTO JobProduct (JobID, ProductID, Quantity) VALUES (@JobID, @ProductID, @Quantity)";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@JobID", newJobID);
                                cmd.Parameters.AddWithValue("@ProductID", productID);
                                cmd.Parameters.AddWithValue("@Quantity", quantity);

                                int rows = cmd.ExecuteNonQuery();
                                MessageBox.Show($"Rows affected: {rows}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Insert failed: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to save job.");
            }
        }


        private void LoadProductsIntoCombo()
        {
            List<Product> productList = Product.GetAllProducts();

            proName.DataSource = productList;
            proName.DisplayMember = "ProductName";
            proName.ValueMember = "ProductID";
        }

        private void addProBtn_Click(object sender, EventArgs e)
        {
            if (proName.SelectedValue == null || string.IsNullOrWhiteSpace(proQTY.Text))
            {
                MessageBox.Show("Select a product and enter quantity.");
                return;
            }

            int productId = Convert.ToInt32(proName.SelectedValue);
            string productName = proName.Text;
            int quantity = int.Parse(proQTY.Text);

            productTable.Rows.Add(productId, productName, quantity);
        }

        private void InitializeProductTable()
        {
            productTable = new DataTable();
            productTable.Columns.Add("ProductID", typeof(int));
            productTable.Columns.Add("ProductName", typeof(string));
            productTable.Columns.Add("Quantity", typeof(int));

            dgvProductList.DataSource = productTable;  // Set the DataTable as data source for the grid
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header row
            {
                DialogResult result = MessageBox.Show("Do you want to remove this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Remove from DataTable (not directly from DataGridView)
                    productTable.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
