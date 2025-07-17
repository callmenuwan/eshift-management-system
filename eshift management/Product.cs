using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace eshift_management
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal UnitWeight { get; set; }


        // Load all products from DB and return as List<Product>
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            string query = "SELECT ProductID, ProductName FROM Product";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString()
                    });
                }
            }

            return products;
        }
    }
}
