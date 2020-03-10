using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AnGameModelsController : Controller
    {
        private AnGameContext db = new AnGameContext();

        // GET: AnGameModels
        public ActionResult Index()
        {
            return View(db.AnGameModels.ToList());
        }

        // GET: AnGameModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnGameModel anGameModel = db.AnGameModels.Find(id);
            if (anGameModel == null)
            {
                return HttpNotFound();
            }
            return View(anGameModel);
        }

        // GET: AnGameModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnGameModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Genre,Platform,Price,Name,Description")] AnGameModel anGameModel)
        {
            if (ModelState.IsValid)
            {
                db.AnGameModels.Add(anGameModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anGameModel);
        }

        // GET: AnGameModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnGameModel anGameModel = db.AnGameModels.Find(id);
            if (anGameModel == null)
            {
                return HttpNotFound();
            }
            return View(anGameModel);
        }

        // POST: AnGameModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Genre,Platform,Price,Name,Description")] AnGameModel anGameModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anGameModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anGameModel);
        }

        // GET: AnGameModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnGameModel anGameModel = db.AnGameModels.Find(id);
            if (anGameModel == null)
            {
                return HttpNotFound();
            }
            return View(anGameModel);
        }

        // POST: AnGameModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnGameModel anGameModel = db.AnGameModels.Find(id);
            db.AnGameModels.Remove(anGameModel);
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
