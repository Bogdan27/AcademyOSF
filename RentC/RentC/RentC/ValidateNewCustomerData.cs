using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    class ValidateNewCustomerData
    {
        public string NotValidMessage { get; set; } = "";

        public bool IsValid { get; set; }

        public bool validateClientId(SqlConnection connection, string clientId)
        {
            bool parseResult = Int32.TryParse(clientId, out int a);
            if (parseResult == true)
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE (CustomerID = @user)", connection);
                check_User_Name.Parameters.AddWithValue("@user", clientId);
                int UserExist = (int)check_User_Name.ExecuteScalar();
                if (UserExist > 0)
                {
                    NotValidMessage += "Client id already exists\n";
                    IsValid = false;
                }
                else
                {
                    IsValid = true;
                }
            }
            else
            {
                NotValidMessage += "Client id must be a number\n";
                IsValid = false;
            }

            return IsValid;
        }


        public bool validateDate(DateTimePicker dateTimePickerBirthDate)
        {
            if (dateTimePickerBirthDate.Value > DateTime.Today)
            {
                NotValidMessage += "Birth date can not be after current date";
                IsValid = false;
            }
            else
            {
                IsValid = true;
            }
            return IsValid;
        }

        public bool validateAllData(string connectionString, string message, DateTimePicker dateTimePickerBirthDate)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    IsValid = validateDate( dateTimePickerBirthDate);
                    if (IsValid)
                    {
                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show(NotValidMessage);
                    }
                    NotValidMessage = "";

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

            return IsValid;
        }
    }
}
