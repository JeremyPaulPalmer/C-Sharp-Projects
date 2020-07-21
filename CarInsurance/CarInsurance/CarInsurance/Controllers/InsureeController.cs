using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/CalculateQuote

        //public ActionResult CalculateQuote(DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, bool DUI, int SpeedingTickets, string CoverageType)
        //{
            
        //}

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            Nullable<decimal> tempQuote = 50;
            if ((DateTime.Now.Year - insuree.DateOfBirth.Year) <= 18)
            {
                tempQuote = tempQuote + 100;
            }
            else if ((DateTime.Now.Year - insuree.DateOfBirth.Year) > 18 && (DateTime.Now.Year - insuree.DateOfBirth.Year) < 26)
            {
                tempQuote = tempQuote + 50;
            }
            else tempQuote = tempQuote + 25;

            if (insuree.CarYear < 2000)
            {
                tempQuote = tempQuote + 25;
            }
            else if (insuree.CarYear > 2015)
            {
                tempQuote = tempQuote + 25;
            }

            if (insuree.CarMake == "Porsche")
            {
                tempQuote = tempQuote + 25;
            }

            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                tempQuote = tempQuote + 50;
            }

            tempQuote = (insuree.SpeedingTickets * 10) + tempQuote;

            if (insuree.DUI)
            {
                tempQuote = tempQuote + (tempQuote * (1 / 4));
            }

            if (insuree.CoverageType == "Full Coverage")
            {
                tempQuote = tempQuote + (tempQuote * (1 / 2));
            }
            tempQuote = insuree.Quote;
            db.Insurees.Add(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");

            //return View(insuree);

            //if (ModelState.IsValid)
            //{
            //    db.Insurees.Add(insuree);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            //return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
