using Microsoft.Data.SqlClient;

namespace eshift_management
{
    public class JobProduct
    {
        public static void SaveProductsToJob(int jobId, DataGridView dgv)
        {
            try {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                        string query = "INSERT INTO JobProduct (JobID, ProductID, Quantity) " +
                                       "VALUES (@JobID, @ProductID, @Quantity)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@JobID", jobId);
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
