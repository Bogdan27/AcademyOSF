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
    public partial class RegisterNewCustomerScreen : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["rentConnectionString"].ConnectionString;
        ValidateNewCustomerData validateNewCustomerData = new ValidateNewCustomerData();

        public RegisterNewCustomerScreen()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (validateNewCustomerData.validateAllData(connectionString,"Added",dateTimePickerBirthDate))
            {
                addCustomer();
                BackToMenu.goToMenu(this);
            } 

        }


        private void addCustomer()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string insertCustomer = "INSERT into Customers (name,birthDate,location) VALUES (@name,@birthDate,@location)";

                    using (SqlCommand queryRegisterNewCustomer = new SqlCommand(insertCustomer))
                    {
                        queryRegisterNewCustomer.Connection = connection;
                        queryRegisterNewCustomer.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = textBoxClientName.Text;
                        queryRegisterNewCustomer.Parameters.Add("@birthDate", SqlDbType.Date, 30).Value = dateTimePickerBirthDate.Value.ToString("dd/MMM/yyyy");
                        queryRegisterNewCustomer.Parameters.Add("@location", SqlDbType.VarChar, 50).Value = textBoxLocation.Text;

                        connection.Open();
                        queryRegisterNewCustomer.ExecuteNonQuery();
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
