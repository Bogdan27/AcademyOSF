using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    public partial class RegisterNewCartRentScreen : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["rentConnectionString"].ConnectionString;


        public RegisterNewCartRentScreen()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            addReservation();
          //  string s=
               
        }

        private void RegisterNewCartRentScreen_Load(object sender, EventArgs e)
        {

        }

        private void addReservation()
        {
                try
                {

                    using (SqlConnection openCon = new SqlConnection(connectionString))
                    {
                        string saveStaff = "INSERT into Reservations (carId,costumerID,ReservStatsID,startDate,endDate,location) VALUES (@carId,@costumerId,@ReservStatsID,@startDate,@endDate,@location)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@carId", SqlDbType.Int).Value = Int32.Parse(textBoxCartPlate.Text);
                            querySaveStaff.Parameters.Add("@costumerId", SqlDbType.Int).Value = Int32.Parse(textBoxClientID.Text);
                            querySaveStaff.Parameters.Add("@ReservStatsID", SqlDbType.Int).Value = 1;
                            querySaveStaff.Parameters.Add("@startDate", SqlDbType.Date, 30).Value = dateTimePickerStartDate.Value.ToString("dd/MMM/yyyy");
                            querySaveStaff.Parameters.Add("@endDate", SqlDbType.Date, 30).Value = dateTimePickerEndDate.Value.ToString("dd/MMM/yyyy");
                            querySaveStaff.Parameters.Add("@location", SqlDbType.VarChar, 50).Value = textBoxCity.Text;



                            openCon.Open();

                            int result = querySaveStaff.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Adaugat");

                            }
                            else
                            {
                                MessageBox.Show("Eroare");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceptie" + ex.Message);
                }
            
        }

        private bool ValidateDate()
        {
            bool ok = true;
            //if ()
            //{

            //}
            return ok;
        }

    }
}
