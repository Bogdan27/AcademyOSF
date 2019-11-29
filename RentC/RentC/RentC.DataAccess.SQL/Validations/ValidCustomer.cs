using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DataAccess.SQL.Validations
{
    class ValidCustomer : ValidationAttribute 
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Cart_RentEntities connection = new Cart_RentEntities();
            SqlConnection con = (SqlConnection)connection.Database.Connection;
            con.Open();

            int customerID = Convert.ToInt32(value);
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE (customerId = @user)", con);
            check_User_Name.Parameters.AddWithValue("@user", customerID);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            if (UserExist > 0)
            {
                con.Close();
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Customer ID does not exist");

            }
        }
    }
}
