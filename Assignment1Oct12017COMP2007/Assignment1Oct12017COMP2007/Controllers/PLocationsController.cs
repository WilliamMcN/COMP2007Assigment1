using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment1Oct12017COMP2007.Models;

namespace Assignment1Oct12017COMP2007.Controllers
{
    public class PLocationsController : Controller
    {
        private PartyModel db = new PartyModel();

        // GET: PLocations
        public ActionResult Index()
        {
            return View(db.PLocations.ToList());
        }

        // GET: PLocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLocation pLocation = db.PLocations.Find(id);
            if (pLocation == null)
            {
                return HttpNotFound();
            }
            return View(pLocation);
        }

        // GET: PLocations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocationID,City,Country,ProvinceOrState")] PLocation pLocation)
        {
            if (ModelState.IsValid)
            {
                db.PLocations.Add(pLocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pLocation);
        }

        // GET: PLocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLocation pLocation = db.PLocations.Find(id);
            if (pLocation == null)
            {
                return HttpNotFound();
            }
            return View(pLocation);
        }

        // POST: PLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocationID,City,Country,ProvinceOrState")] PLocation pLocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pLocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pLocation);
        }

        // GET: PLocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLocation pLocation = db.PLocations.Find(id);
            if (pLocation == null)
            {
                return HttpNotFound();
            }
            return View(pLocation);
        }

        // POST: PLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PLocation pLocation = db.PLocations.Find(id);
            db.PLocations.Remove(pLocation);
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
