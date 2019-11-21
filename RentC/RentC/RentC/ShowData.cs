using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    class ShowData
    {
        static String connectionString = ConfigurationManager.ConnectionStrings["rentConnectionString"].ConnectionString;
        public static void showData(String table, DataGridView dataGridView)
        {

            SqlConnection connection = new SqlConnection();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Select * from "+table, connection);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    dataGridView.DataSource = dt.DefaultView;
                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Dispose();
            }

        }
    }
}
