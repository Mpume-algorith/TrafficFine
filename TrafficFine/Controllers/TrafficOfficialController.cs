using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrafficFine.DAL;
using TrafficFine.Models;

namespace TrafficFine.Controllers
{
    public class TrafficOfficialController : Controller
    {
        private TrafficContext db = new TrafficContext();

        // GET: TrafficOfficial
        public ActionResult Index()
        {
            return View(db.TrafficOfficials.ToList());
        }

        // GET: TrafficOfficial/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrafficOfficial trafficOfficial = db.TrafficOfficials.Find(id);
            if (trafficOfficial == null)
            {
                return HttpNotFound();
            }
            return View(trafficOfficial);
        }

        // GET: TrafficOfficial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrafficOfficial/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,Name,LastName,DateOfBirth,Sex")] TrafficOfficial trafficOfficial)
        {
            if (ModelState.IsValid)
            {
                db.TrafficOfficials.Add(trafficOfficial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trafficOfficial);
        }

        // GET: TrafficOfficial/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrafficOfficial trafficOfficial = db.TrafficOfficials.Find(id);
            if (trafficOfficial == null)
            {
                return HttpNotFound();
            }
            return View(trafficOfficial);
        }

        // POST: TrafficOfficial/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,Name,LastName,DateOfBirth,Sex")] TrafficOfficial trafficOfficial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trafficOfficial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trafficOfficial);
        }

        // GET: TrafficOfficial/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrafficOfficial trafficOfficial = db.TrafficOfficials.Find(id);
            if (trafficOfficial == null)
            {
                return HttpNotFound();
            }
            return View(trafficOfficial);
        }

        // POST: TrafficOfficial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TrafficOfficial trafficOfficial = db.TrafficOfficials.Find(id);
            db.TrafficOfficials.Remove(trafficOfficial);
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
