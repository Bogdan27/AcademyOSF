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
        ValidateReservationData validateData = new ValidateReservationData();

        public RegisterNewCartRentScreen()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (validateData.validateAllData(connectionString,"Added", textBoxCity.Text, dateTimePickerStartDate, dateTimePickerEndDate, textBoxClientID.Text, textBoxCartPlate.Text))
            {
                addReservation();
                BackToMenu.goToMenu(this);
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
                    string insertReservation = "INSERT into Reservations (plate,customerID,reservStatsID,startDate,endDate,location) VALUES (@plate,@customerID,@reservStatsID,@startDate,@endDate,@location)";

                    using (SqlCommand queryRegisterNewCartRent = new SqlCommand(insertReservation))
                    {
                        queryRegisterNewCartRent.Connection = connection;
                        queryRegisterNewCartRent.Parameters.Add("@plate", SqlDbType.VarChar, 10).Value = textBoxCartPlate.Text;
                        queryRegisterNewCartRent.Parameters.Add("@customerID", SqlDbType.Int).Value = Int32.Parse(textBoxClientID.Text);
                        queryRegisterNewCartRent.Parameters.Add("@reservStatsID", SqlDbType.Int).Value = 1;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Back)
            {
                BackToMenu.goToMenu(this);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
    
}
