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
    public partial class UpdateCustomerScreen : Form
    {
        ValidateNewCustomerData validateNewCustomerData = new ValidateNewCustomerData();
        String connectionString = ConfigurationManager.ConnectionStrings["rentConnectionString"].ConnectionString;

        public UpdateCustomerScreen()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (validateNewCustomerData.validateAllData(connectionString, "Updated", dateTimePickerBirthDate))
            {
                updateCustomer();
                WelcomeScreen.goToMenu(this);
            }
        }

        private void updateCustomer()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateCustomer ="UPDATE Customers set Name=@Name, BirthDate=@BirthDate, Location=@Location" +
                        " where CostumerID=@CostumerIdToCheck";
                    using (SqlCommand queryUpdateCustomer = new SqlCommand(updateCustomer))
                    {
                        queryUpdateCustomer.Connection = connection;
                        queryUpdateCustomer.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = textBoxClientName.Text;
                        queryUpdateCustomer.Parameters.Add("@BirthDate", SqlDbType.Date).Value = dateTimePickerBirthDate.Value.ToString("dd/MMM/yyyy"); ;
                        queryUpdateCustomer.Parameters.Add("@Location", SqlDbType.VarChar, 50).Value = textBoxLocation.Text;
                        queryUpdateCustomer.Parameters.Add("@CostumerIdToCheck", SqlDbType.Int).Value = Int32.Parse(textBoxUpdateCustomer.Text);

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
