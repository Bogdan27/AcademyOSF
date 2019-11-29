using RentC.DataAccess.SQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentC.Web.Controllers
{
    public class AvailableCarsManagerController : Controller
    {
      //  Cart_RentEntities context = new Cart_RentEntities();
        WcfServiceReference.Service1Client client = new WcfServiceReference.Service1Client();




        //public ActionResult Index()
        //{
        //    Cart_RentEntities rentEntities = new Cart_RentEntities();
        //    SqlConnection connection = (SqlConnection)rentEntities.Database.Connection;
        //    SqlCommand cmd = new SqlCommand("Select * From Cars Where Plate Not In(Select Plate From Reservations)", connection);

        //    var model = new List<Car>();
        //    using (connection)
        //    {
        //        connection.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            var car = new Car();
        //            car.CarID = (int)rdr["CarId"];
        //            car.Plate =(string) rdr["Plate"];
        //            car.Model = (string)rdr["Model"];
        //            car.Manufacturer = (string)rdr["Manufacturer"];
        //            car.PricePerDay = (decimal)rdr["PricePerDay"];
        //            car.Location =(string) rdr["Location"];
        //            model.Add(car);
        //        }


        //    }

        //    return View(model);
        //}




        public ActionResult Index()
        {
            //var cars= context.Cars.ToList();
            //return View(cars);

            WcfServiceReference.GetListData getListData = new WcfServiceReference.GetListData();
            getListData = client.getData();
            DataTable dataTable = new DataTable();
            dataTable = getListData.userTable;

            List<DataRow> list = dataTable.AsEnumerable().ToList();
            var model = new List<Car>();

            //context.Cars.ToList();

            return View(list.ToList());

            // return View(list.Select(s => new Car(s)));

        }

    }
}