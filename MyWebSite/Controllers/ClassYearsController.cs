using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models;

namespace MyWebSite.Controllers
{
    public class ClassYearsController : Controller
    {
        private MyWebSiteContext db = new MyWebSiteContext();

        // GET: ClassYears
        public ActionResult Index()
        {
            return View(db.ClassYears.ToList());
        }

        // GET: ClassYears/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassYear classYear = db.ClassYears.Find(id);
            if (classYear == null)
            {
                return HttpNotFound();
            }
            return View(classYear);
        }

        // GET: ClassYears/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassYears/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "YearId,Year")] ClassYear classYear)
        {
            if (ModelState.IsValid)
            {
                db.ClassYears.Add(classYear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classYear);
        }

        // GET: ClassYears/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassYear classYear = db.ClassYears.Find(id);
            if (classYear == null)
            {
                return HttpNotFound();
            }
            return View(classYear);
        }

        // POST: ClassYears/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "YearId,Year")] ClassYear classYear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classYear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classYear);
        }

        // GET: ClassYears/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassYear classYear = db.ClassYears.Find(id);
            if (classYear == null)
            {
                return HttpNotFound();
            }
            return View(classYear);
        }

        // POST: ClassYears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClassYear classYear = db.ClassYears.Find(id);
            db.ClassYears.Remove(classYear);
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
