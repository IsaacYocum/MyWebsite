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
    public class CourseYearsController : Controller
    {
        private CollegeCoursesContext db = new CollegeCoursesContext();

        // GET: CourseYears
        public ActionResult Index()
        {
            return View(db.CourseYears.ToList());
        }

        // GET: CourseYears/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseYear courseYear = db.CourseYears.Find(id);
            if (courseYear == null)
            {
                return HttpNotFound();
            }
            return View(courseYear);
        }

        // GET: CourseYears/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseYears/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseYearId,Year")] CourseYear courseYear)
        {
            if (ModelState.IsValid)
            {
                db.CourseYears.Add(courseYear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseYear);
        }

        // GET: CourseYears/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseYear courseYear = db.CourseYears.Find(id);
            if (courseYear == null)
            {
                return HttpNotFound();
            }
            return View(courseYear);
        }

        // POST: CourseYears/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseYearId,Year")] CourseYear courseYear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseYear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseYear);
        }

        // GET: CourseYears/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseYear courseYear = db.CourseYears.Find(id);
            if (courseYear == null)
            {
                return HttpNotFound();
            }
            return View(courseYear);
        }

        // POST: CourseYears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseYear courseYear = db.CourseYears.Find(id);
            db.CourseYears.Remove(courseYear);
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
