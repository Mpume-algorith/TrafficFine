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
    public class MotoristController : Controller
    {
        private TrafficContext db = new TrafficContext();

        // GET: Motorist
        public ActionResult Index()
        {
            return View(db.Motorists.ToList());
        }

        // GET: Motorist/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorist motorist = db.Motorists.Find(id);
            if (motorist == null)
            {
                return HttpNotFound();
            }
            return View(motorist);
        }

        // GET: Motorist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motorist/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDNumber,Debt,Name,LastName,DateOfBirth,Sex")] Motorist motorist)
        {
            if (ModelState.IsValid)
            {
                db.Motorists.Add(motorist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motorist);
        }

        // GET: Motorist/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorist motorist = db.Motorists.Find(id);
            if (motorist == null)
            {
                return HttpNotFound();
            }
            return View(motorist);
        }

        // POST: Motorist/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDNumber,Debt,Name,LastName,DateOfBirth,Sex")] Motorist motorist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motorist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motorist);
        }

        // GET: Motorist/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorist motorist = db.Motorists.Find(id);
            if (motorist == null)
            {
                return HttpNotFound();
            }
            return View(motorist);
        }

        // POST: Motorist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Motorist motorist = db.Motorists.Find(id);
            db.Motorists.Remove(motorist);
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
