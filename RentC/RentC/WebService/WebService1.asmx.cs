using RentC.DataAccess.SQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Car> getData()
        {

            Cart_RentEntities rentEntities = new Cart_RentEntities();
            //String connectionString = ConfigurationManager.ConnectionStrings["Cart_RentEntities"].ConnectionString;

            SqlConnection connection = (SqlConnection)rentEntities.Database.Connection;
            SqlCommand cmd = new SqlCommand("Select * From Cars Where Plate Not In(Select Plate From Reservations)", connection);

            var model = new List<Car>();
            using (connection)
            {
                connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var car = new Car();
                    car.CarID = (int)rdr["CarId"];
                    car.Plate = (string)rdr["Plate"];
                    car.Model = (string)rdr["Model"];
                    car.Manufacturer = (string)rdr["Manufacturer"];
                    car.PricePerDay = (decimal)rdr["PricePerDay"];
                    car.Location = (string)rdr["Location"];

                    //student.FirstName = rdr[""];
                    //student.LastName = rdr["LastName"];
                    //student.Class = rdr["Class"];

                    model.Add(car);
                }


            }

            return model;


            //  String connectionString = ConfigurationManager.ConnectionStrings["rentConnectionString"].ConnectionString;
            //Cart_RentEntities connection = new Cart_RentEntities();
            //SqlConnection con = (SqlConnection)connection.Database.Connection;
            //DataTable dataTable = new DataTable { TableName = "Cars" };

            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * From Cars Where Plate Not In(Select Plate From Reservations)", con);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            //sqlDataAdapter.Fill(dataTable);
            //con.Close();
            
            //return dataTable;
        }
    }
}
