using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DataAccess.SQL.Validations
{
    class ValidPlate : ValidationAttribute
    {
        protected override ValidationResult
        IsValid(object value, ValidationContext validationContext)
        {
            Cart_RentEntities connection = new Cart_RentEntities();
            SqlConnection con = (SqlConnection)connection.Database.Connection;
            Reservation reservation = new Reservation();
            con.Open();
            string plate = Convert.ToString(value);
            SqlCommand check_Plate = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE (Plate = @Plate)", con);
            check_Plate.Parameters.AddWithValue("@Plate", plate);
            int UserExist = (int)check_Plate.ExecuteScalar();
            

            if (UserExist > 0)
            {
                con.Close();
                return ValidationResult.Success;

            }
            else
            {
                return new ValidationResult("Car does not exist.");
            }

        }
    }
}














//check_Plate = new SqlCommand("SELECT COUNT(*) FROM Reservations WHERE (Plate = @Plate)", con);
//check_Plate.Parameters.AddWithValue("@Plate", plate);
//UserExist = (int)check_Plate.ExecuteScalar();
//if (UserExist == 0)
//{
//    con.Close();
//    return ValidationResult.Success;
//}
//else
//{
//    check_Plate = new SqlCommand("SELECT COUNT(*) FROM Reservations where Plate=@Plate AND FORMAT(@StartDate, 'yyyy-MM-dd') NOT Between  FORMAT(StartDate, 'yyyy-MM-dd') AND  FORMAT(EndDate, 'yyyy-MM-dd')", con);
//    check_Plate.Parameters.AddWithValue("@StartDate",reservation.StartDate.Date);
//    check_Plate.Parameters.AddWithValue("@Plate", plate);

//    UserExist = (int)check_Plate.ExecuteScalar();
//    if (UserExist == 0)
//    {
//        return new ValidationResult("Car is not available.");
//    }
//    else
//    {
//        con.Close();
//        return ValidationResult.Success;
//    }
//}