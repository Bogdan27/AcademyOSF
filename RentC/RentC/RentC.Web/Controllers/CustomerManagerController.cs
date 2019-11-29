using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentC.DataAccess.SQL;

namespace RentC.Web.Controllers
{
    public class CustomerManagerController : Controller
    {
        Cart_RentEntities context =new Cart_RentEntities();
        public ActionResult Index(string sortOrder)
        {
            ViewBag.CostumerIdSortParm = String.IsNullOrEmpty(sortOrder) ? "costumerID_desc" : "";
            ViewBag.NameSortParm = sortOrder == "Name" ? "name_desc" : "Name";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.LocationSortParm = sortOrder == "Location" ? "location_desc" : "Location";

            var customers = from c in context.Customers
                           select c;
            switch (sortOrder)
            {
                case "costumerID_desc":
                    customers = customers.OrderByDescending(c => c.CustomerID);
                    break;
                case "Name":
                    customers = customers.OrderBy(c => c.Name);
                    break;
                case "name_desc":
                    customers = customers.OrderByDescending(c => c.Name);
                    break;
                case "Date":
                    customers = customers.OrderBy(c => c.BirthDate);
                    break;
                case "date_desc":
                    customers = customers.OrderByDescending(c => c.BirthDate);
                    break;
                case "Location":
                    customers = customers.OrderBy(c => c.Location);
                    break;
                case "location_desc":
                    customers = customers.OrderByDescending(c => c.Location);
                    break;
                default:
                    customers = customers.OrderBy(c => c.CustomerID);
                    break;
            }
            return View(customers.ToList());

        }

        public ActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            else
            {

                context.Customers.Add(customer);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int Id)
        {
            Customer customer = context.Customers.Find(Id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }


        [HttpPost]
        public ActionResult Edit(Customer customer, int Id)
        {
            //Customer customerToEdit = context.Customers.Find(Id);
            if (context.Customers.Find(Id) == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(customer);
                }

                context.Customers.Find(Id).Name = customer.Name;
                context.Customers.Find(Id).BirthDate = customer.BirthDate;
                context.Customers.Find(Id).Location = customer.Location;

                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int Id)
        {
            Customer customerToDelete = context.Customers.Find(Id);
            if (customerToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customerToDelete);
            }

        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int Id)
        {
            Customer customerToDelete = context.Customers.Find(Id);
            if (customerToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Customers.Remove(customerToDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}