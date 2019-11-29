using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
   public class Service1 : IService1
    {

            public GetListData getData()
            {
                String connectionString = ConfigurationManager.ConnectionStrings["rentConnectionString"].ConnectionString;

                GetListData getListData = new GetListData();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * From Cars Where Plate Not In(Select Plate From Reservations)", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable { TableName = "Cars" };
                sqlDataAdapter.Fill(dataTable);
                getListData.userTable = dataTable;
                connection.Close();
                return getListData;
            }
    }
}
