using RentC.DataAccess.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentC.Web.Controllers
{
    public class AvailableCarsManagerController : Controller
    {
        Cart_RentEntities context = new Cart_RentEntities();

        // GET: AvailableCarsManager
        public ActionResult Index()
        {
            ServiceReference.WebService1SoapClient webService = new ServiceReference.WebService1SoapClient();
            return View(context.Customers.ToList());
        }
    }
}