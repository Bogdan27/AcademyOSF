using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using RentC.Core;
using RentC.DataAccess.InMemory;
using RentC.Core.Contracts;
using RentC.DataAccess.SQL;

namespace RentC.Web.Controllers
{
    public class CustomerManagerController : Controller
    {
        //  IRepository<Customer> context;
        Cart_RentEntities context =new Cart_RentEntities();

        //public CustomerManagerController(Cart_RentEntities customerContext)
        //{
        //    context = customerContext;
        //}
        // GET: CustomerManager
        public ActionResult Index()
        {
           // List<Customer> customers = context.Customers.ToList();
            return View(context.Customers.ToList());
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

                //context.(customer);
                context.Customers.Add(customer);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(string Id)
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
        public ActionResult Edit(Customer customer, string Id)
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

        public ActionResult Delete(string Id)
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
        public ActionResult ConfirmDelete(string Id)
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