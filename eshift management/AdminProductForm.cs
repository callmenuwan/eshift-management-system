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
using System.Xml.Linq;

namespace eshift_management
{
    public partial class AdminProductForm : Form
    {
        private int selectedProductId = -1;

        public AdminProductForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Product ORDER BY ProductName", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            ClearForm();
        }

        private void ClearForm()
        {
            proName.Text = "";
            proDescription.Text = "";
            proWeight.Text = "";
            selectedProductId = -1;
            proAddBtn.Enabled = true;
            proDeleteBtn.Enabled = false;
            proUpdateBtn.Enabled = false;
            proUpdateBtn.Enabled = false;
        }

        private void proAddBtn_Click(object sender, EventArgs e)
        {
            if (proName.Text.Trim() == "" || proWeight.Text.Trim() == "")
            {
                MessageBox.Show("Product name and weight are required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string query = "INSERT INTO Product (ProductName, Description, UnitWeight) VALUES (@name, @desc, @weight)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", proName.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", proDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@weight", Convert.ToDecimal(proWeight.Text.Trim()));

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product added.");
            LoadProducts();
        }

        private void proUpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string query = "UPDATE Product SET ProductName = @name, Description = @desc, UnitWeight = @weight WHERE ProductID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", proName.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", proDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@weight", Convert.ToDecimal(proWeight.Text.Trim()));
                cmd.Parameters.AddWithValue("@id", selectedProductId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product updated.");
            LoadProducts();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
                proName.Text = row.Cells["ProductName"].Value.ToString();
                proDescription.Text = row.Cells["Description"].Value.ToString();
                proWeight.Text = row.Cells["UnitWeight"].Value.ToString();

                proAddBtn.Enabled = false;
                proUpdateBtn.Enabled = true;
                proDeleteBtn.Enabled = true;
            }
        }

        private void proDeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Select a product to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
                {
                    string query = "DELETE FROM Product WHERE ProductID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedProductId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product deleted.");
                LoadProducts();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            proName.Text = "";
            proDescription.Text = "";
            proWeight.Text = "";
            selectedProductId = -1;
            proAddBtn.Enabled = true;
            proDeleteBtn.Enabled = false;
            proUpdateBtn.Enabled = false;
            proUpdateBtn.Enabled = false;
        }
    }
}
