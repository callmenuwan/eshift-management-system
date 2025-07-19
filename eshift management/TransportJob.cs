using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace eshift_management
{
    public class TransportJob
    {
        public int JobID { get; set; }
        public int CustomerID { get; set; }
        public string? StartLocation { get; set; }
        public string? Destination { get; set; }
        public DateTime JobDate { get; set; }
        public string Status { get; set; } = "Pending";

        public int SaveJobToDatabase()
        {
            try
            {
                // Insert transport Job details to database and return newJobID

                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
                {
                    conn.Open();
                    string query = "INSERT INTO Job (JobCustID, StartLocation, Destination, JobDate, Status) " +
                                   "VALUES (@CustomerID, @StartLocation, @Destination, @JobDate, @Status);" +
                                   "SELECT CAST(SCOPE_IDENTITY() AS int);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@StartLocation", StartLocation);
                    cmd.Parameters.AddWithValue("@Destination", Destination);
                    cmd.Parameters.AddWithValue("@JobDate", JobDate);
                    cmd.Parameters.AddWithValue("@Status", Status);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int newJobID))
                    {
                        return newJobID;
                    }
                    else
                    {
                        return -1; // Failed to insert or retrieve ID
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1; // Fallback return if exception occurred
        }
    }
}
