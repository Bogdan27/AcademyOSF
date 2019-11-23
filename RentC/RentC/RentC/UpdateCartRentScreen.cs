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
    public partial class UpdateCartRentScreen : Form
    {
        ValidateReservationData validateReservationData = new ValidateReservationData();
        String connectionString = ConfigurationManager.ConnectionStrings["rentConnectionString"].ConnectionString;

        public UpdateCartRentScreen()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (validateReservationData.validateAllData(connectionString,"Updated", textBoxCity.Text, dateTimePickerStartDate, dateTimePickerEndDate, textBoxClientID.Text, textBoxCartPlate.Text))
            {
                updateReservation();
                WelcomeScreen.goToMenu(this);
            }
        }

        private void updateReservation()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateCustomer = "UPDATE Reservations set Plate=@Plate, CostumerId=@CostumerId, StartDate=@StartDate, EndDate=@EndDate, Location=@Location" +
                        " where ReservationID=@ReservationID";
                    using (SqlCommand queryUpdateCustomer = new SqlCommand(updateCustomer))
                    {
                        queryUpdateCustomer.Connection = connection;
                        queryUpdateCustomer.Parameters.Add("@Plate", SqlDbType.VarChar, 50).Value = textBoxCartPlate.Text;
                        queryUpdateCustomer.Parameters.Add("@CostumerId", SqlDbType.Int).Value = Int32.Parse(textBoxClientID.Text);
                        queryUpdateCustomer.Parameters.Add("@StartDate", SqlDbType.Date).Value = dateTimePickerStartDate.Value.ToString("dd/MMM/yyyy");
                        queryUpdateCustomer.Parameters.Add("@EndDate", SqlDbType.Date).Value = dateTimePickerEndDate.Value.ToString("dd/MMM/yyyy");
                        queryUpdateCustomer.Parameters.Add("@Location", SqlDbType.VarChar, 50).Value = textBoxCity.Text;
                        queryUpdateCustomer.Parameters.Add("@ReservationId", SqlDbType.Int).Value = Int32.Parse(textBoxReservationToUpdate.Text);

                        connection.Open();
                        queryUpdateCustomer.ExecuteNonQuery();
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
