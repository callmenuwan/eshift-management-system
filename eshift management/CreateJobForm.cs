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
        private Form1 mainForm;
        private DataTable productTable;

        public CreateJobForm(Form1 mainFormReference)
        {
            InitializeComponent();
            mainForm = mainFormReference;

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

            // Step 2: Save Products for this Job
            JobProduct.SaveProductsToJob(newJobID, dgvProductList);

            MessageBox.Show($"Job Created. Job ID: {newJobID}");
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
