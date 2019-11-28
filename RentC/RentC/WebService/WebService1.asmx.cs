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
        public DataTable getData()
        {
          //  String connectionString = ConfigurationManager.ConnectionStrings["rentConnectionString"].ConnectionString;
            Cart_RentEntities connection = new Cart_RentEntities();
            SqlConnection con = (SqlConnection)connection.Database.Connection;
            DataTable dataTable = new DataTable { TableName = "Cars" };

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Cars Where Plate Not In(Select Plate From Reservations)", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
    }
}
