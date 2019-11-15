using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    class ValidateData
    {
        public string NotValidMessage { get; set; } = "";

        public bool IsValid { get; set; }

        private bool validateDate(DateTimePicker dateTimePickerStartDate, DateTimePicker dateTimePickerEndDate)
        {
            if (dateTimePickerStartDate.Value > dateTimePickerEndDate.Value)
            {
                //MessageBox.Show("End Date must be after Start Date");
                NotValidMessage += "End Date must be after Start Date";
                IsValid = false;
            }
            else
            {
                IsValid = true;
            }
            return IsValid;
        }

        private bool validateCliendId(SqlConnection connection, string clientId)
        {
            bool parseResult = Int32.TryParse(clientId, out int a);
            if (parseResult == true)
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE (costumerId = @user)", connection);
                check_User_Name.Parameters.AddWithValue("@user", clientId);
                int UserExist = (int)check_User_Name.ExecuteScalar();
                if (UserExist > 0)
                {
                    IsValid = true;
                }
                else
                {
                    NotValidMessage += "Client id does not exist\n";
                    IsValid = false;
                }
            }
            else
            {
                NotValidMessage += "Client id must be a number\n";
                IsValid = false;
            }

            return IsValid;
        }

        private bool validateLocation(SqlConnection connection, string city)
        {
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE (location = @location)", connection);
            check_User_Name.Parameters.AddWithValue("@location", city);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            if (UserExist > 0)
            {
                IsValid = true;

            }
            else
            {
                NotValidMessage += "Location is not available\n";
                IsValid = false;
            }

            return IsValid;
        }

        private bool validateCarId(SqlConnection connection, string carId)
        {

            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE (carId = @carId)", connection);
            check_User_Name.Parameters.AddWithValue("@carId", carId);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            if (UserExist > 0)
            {

                check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Reservations WHERE (carId = @carId)", connection);
                check_User_Name.Parameters.AddWithValue("@carId", carId);
                UserExist = (int)check_User_Name.ExecuteScalar();
                if (UserExist > 0)
                {
                    NotValidMessage += "Car is not avilable\n";
                    IsValid = false;
                }
                else
                {
                    IsValid = true;
                }

            }
            else
            {
                NotValidMessage += "Car does not exist\n";
                IsValid = false;
            }
            return IsValid;
        }


        public bool validateAllData(string connectionString, string city, DateTimePicker dateTimePickerStartDate, DateTimePicker dateTimePickerEndDate,string clientId, string carId)
        {

            SqlConnection connection = new SqlConnection();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    IsValid = validateCarId(connection, carId) & validateCliendId(connection, clientId) & validateDate(dateTimePickerStartDate, dateTimePickerEndDate) & validateLocation(connection, city);

                    if (IsValid)
                    {
                        MessageBox.Show("Added");
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
