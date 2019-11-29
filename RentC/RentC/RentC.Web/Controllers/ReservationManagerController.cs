using RentC.DataAccess.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentC.Web.Controllers
{
    public class ReservationManagerController : Controller
    {
        Cart_RentEntities context = new Cart_RentEntities();

        public ActionResult Index(String sortOrder)
        {
            ViewBag.ReservationIDSortParm = String.IsNullOrEmpty(sortOrder) ? "reservationID_desc" : "";
            ViewBag.PlateSortParm = sortOrder == "Plate" ? "plate_desc" : "Plate";
            ViewBag.CustomerIDSortParm = sortOrder == "CustomerID" ? "customerID_desc" : "CustomerID";
            ViewBag.StartDateSortParm = sortOrder == "StartDate" ? "start_date_desc" : "StartDate";
            ViewBag.EndDateSortParm = sortOrder == "EndDate" ? "end_date_desc" : "EndDate";
            ViewBag.LocationSortParm = sortOrder == "Location" ? "location_desc" : "Location";

            var reservations = from r in context.Reservations
                               select r;
            switch (sortOrder)
            {
                case "reservationID_desc":
                    reservations = reservations.OrderByDescending(r => r.ReservationID);
                    break;
                case "Plate":
                    reservations = reservations.OrderBy(r => r.Plate);
                    break;
                case "plate_desc":
                    reservations = reservations.OrderByDescending(r => r.Plate);
                    break;
                case "CustomerId":
                    reservations = reservations.OrderBy(r => r.CustomerID);
                    break;
                case "customerID_desc":
                    reservations = reservations.OrderByDescending(r => r.CustomerID);
                    break;
                case "StartDate":
                    reservations = reservations.OrderBy(r => r.StartDate);
                    break;
                case "start_date_desc":
                    reservations = reservations.OrderByDescending(r => r.StartDate);
                    break;
                case "EndDate":
                    reservations = reservations.OrderBy(r => r.EndDate);
                    break;
                case "end_date_desc":
                    reservations = reservations.OrderByDescending(r => r.EndDate);
                    break;
                case "Location":
                    reservations = reservations.OrderBy(r => r.Location);
                    break;
                case "location_desc":
                    reservations = reservations.OrderByDescending(r => r.Location);
                    break;
                default:
                    reservations = reservations.OrderBy(r => r.ReservationID);
                    break;
            }
            //return View(context.Reservations.ToList());
            return View(reservations.ToList());
        }

        public ActionResult Create()
        {
            Reservation reservation = new Reservation();
            return View(reservation);
        }

        [HttpPost]
        public ActionResult Create(Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return View(reservation);
            }
            else
            {
                context.Reservations.Add(reservation);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int Id)
        {
            Reservation reservation = context.Reservations.Find(Id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(reservation);
            }
        }


        [HttpPost]
        public ActionResult Edit(Reservation reservation, int Id)
        {
            if (context.Reservations.Find(Id) == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(reservation);
                }

                context.Reservations.Find(Id).Plate = reservation.Plate;
                context.Reservations.Find(Id).CustomerID = reservation.CustomerID;
                context.Reservations.Find(Id).StartDate = reservation.StartDate;
                context.Reservations.Find(Id).EndDate = reservation.EndDate;
                context.Reservations.Find(Id).Location = reservation.Location;


                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int Id)
        {
            Reservation reservationToDelete = context.Reservations.Find(Id);
            if (reservationToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(reservationToDelete);
            }

        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int Id)
        {
            Reservation reservationToDelete = context.Reservations.Find(Id);
            if (reservationToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Reservations.Remove(reservationToDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}