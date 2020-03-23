using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using gamesreviewwebsite.Models;

namespace gamesreviewwebsite.Controllers
{
    public class AnDevelopersController : Controller
    {
        private AnDevelopersContext db = new AnDevelopersContext();

        // GET: AnDevelopers
        public ActionResult Index()
        {
            return View(db.AnDevelopers.ToList());
        }

        // GET: AnDevelopers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnDeveloper anDeveloper = db.AnDevelopers.Find(id);
            if (anDeveloper == null)
            {
                return HttpNotFound();
            }
            return View(anDeveloper);
        }

        // GET: AnDevelopers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnDevelopers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeveloperId,Name,Description,GameId")] AnDeveloper anDeveloper)
        {
            if (ModelState.IsValid)
            {
                db.AnDevelopers.Add(anDeveloper);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anDeveloper);
        }

        // GET: AnDevelopers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnDeveloper anDeveloper = db.AnDevelopers.Find(id);
            if (anDeveloper == null)
            {
                return HttpNotFound();
            }
            return View(anDeveloper);
        }

        // POST: AnDevelopers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeveloperId,Name,Description,GameId")] AnDeveloper anDeveloper)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anDeveloper).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anDeveloper);
        }

        // GET: AnDevelopers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnDeveloper anDeveloper = db.AnDevelopers.Find(id);
            if (anDeveloper == null)
            {
                return HttpNotFound();
            }
            return View(anDeveloper);
        }

        // POST: AnDevelopers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnDeveloper anDeveloper = db.AnDevelopers.Find(id);
            db.AnDevelopers.Remove(anDeveloper);
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
