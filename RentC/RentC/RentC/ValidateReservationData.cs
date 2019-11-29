using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    class ValidateReservationData
    {
        public string NotValidMessage { get; set; } = "";

        public bool IsValid { get; set; }

        private bool validateDate(DateTimePicker dateTimePickerStartDate, DateTimePicker dateTimePickerEndDate)
        {
            if (dateTimePickerStartDate.Value > dateTimePickerEndDate.Value)
            {
                NotValidMessage += "End Date must be after Start Date\n";
                IsValid = false;
            }
            if (dateTimePickerStartDate.Value < DateTime.Today)
            {
                NotValidMessage += "Start date must be after or equal to current date\n";
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
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE (customerId = @user)", connection);
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

        private bool validateLocation(SqlConnection connection, string city, string carPlate)
        {
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE (location = @location) AND Plate=@Plate", connection);
            check_User_Name.Parameters.AddWithValue("@location", city);
            check_User_Name.Parameters.AddWithValue("@Plate", carPlate);

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

        private bool validateCarPlate(SqlConnection connection, string carPlate, DateTimePicker dateTimePickerStartDate, DateTimePicker dateTimePickerEndDate)
        {

            SqlCommand check_Plate = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE (Plate = @Plate)", connection);
            check_Plate.Parameters.AddWithValue("@Plate", carPlate);
            int UserExist = (int)check_Plate.ExecuteScalar();
            if (UserExist > 0)
            {

                check_Plate = new SqlCommand("SELECT COUNT(*) FROM Reservations WHERE (Plate = @Plate)", connection);
                check_Plate.Parameters.AddWithValue("@Plate", carPlate);
                UserExist = (int)check_Plate.ExecuteScalar();
                if (UserExist == 0)
                {
                    IsValid = true;
                }
                else
                {
                    check_Plate = new SqlCommand("SELECT COUNT(*) FROM Reservations where Plate=@Plate AND FORMAT(@StartDate, 'yyyy-MM-dd') NOT Between  FORMAT(StartDate, 'yyyy-MM-dd') AND  FORMAT(EndDate, 'yyyy-MM-dd')", connection);
                    check_Plate.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                    check_Plate.Parameters.AddWithValue("@Plate", carPlate);

                    UserExist = (int)check_Plate.ExecuteScalar();
                    if (UserExist == 0)
                    {
                        NotValidMessage += "Car is not avilable\n";
                        IsValid = false;
                    }
                    else
                    {
                        IsValid = true;
                    }
                }



            }
            else
            {
                NotValidMessage += "Car does not exist\n";
                IsValid = false;
            }
            return IsValid;
        }


        public bool validateAllData(string connectionString,string message, string city, DateTimePicker dateTimePickerStartDate, DateTimePicker dateTimePickerEndDate,string clientId, string carPlate)
        {

            SqlConnection connection = new SqlConnection();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    IsValid = validateCarPlate(connection, carPlate, dateTimePickerStartDate, dateTimePickerEndDate) & validateCliendId(connection, clientId) & validateDate(dateTimePickerStartDate, dateTimePickerEndDate) & validateLocation(connection, city, carPlate);

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
