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

        public ActionResult Index()
        {
            return View(context.Reservations.ToList());
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
                context.Reservations.Find(Id).CostumerID = reservation.CostumerID;
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