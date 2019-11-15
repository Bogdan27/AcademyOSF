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
        ValidateData validateData = new ValidateData();

        public RegisterNewCartRentScreen()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (validateData.validateAllData(connectionString, textBoxCity.Text, dateTimePickerStartDate, dateTimePickerEndDate, textBoxClientID.Text, textBoxCartPlate.Text))
            {
                addReservation();
            }

        }

        private void RegisterNewCartRentScreen_Load(object sender, EventArgs e)
        {

        }

        private void addReservation()
        {
                try
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string saveStaff = "INSERT into Reservations (carId,costumerID,ReservStatsID,startDate,endDate,location) VALUES (@carId,@costumerId,@ReservStatsID,@startDate,@endDate,@location)";

                        using (SqlCommand queryRegisterNewCartRent = new SqlCommand(saveStaff))
                        {
                            queryRegisterNewCartRent.Connection = connection;
                            queryRegisterNewCartRent.Parameters.Add("@carId", SqlDbType.VarChar, 10).Value = textBoxCartPlate.Text;
                            queryRegisterNewCartRent.Parameters.Add("@costumerId", SqlDbType.Int).Value = Int32.Parse(textBoxClientID.Text);
                            queryRegisterNewCartRent.Parameters.Add("@ReservStatsID", SqlDbType.Int).Value = 1;
                            queryRegisterNewCartRent.Parameters.Add("@startDate", SqlDbType.Date, 30).Value = dateTimePickerStartDate.Value.ToString("dd/MMM/yyyy");
                            queryRegisterNewCartRent.Parameters.Add("@endDate", SqlDbType.Date, 30).Value = dateTimePickerEndDate.Value.ToString("dd/MMM/yyyy");
                            queryRegisterNewCartRent.Parameters.Add("@location", SqlDbType.VarChar, 50).Value = textBoxCity.Text;

                            connection.Open();
                            queryRegisterNewCartRent.ExecuteNonQuery();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception" + ex.Message);
                }
            
        }

    }
    
}
