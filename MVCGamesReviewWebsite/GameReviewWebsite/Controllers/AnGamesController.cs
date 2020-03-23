using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameReviewWebsite.Models;

namespace GameReviewWebsite.Controllers
{
    public class AnGamesController : Controller
    {
        private AnGamesContext db = new AnGamesContext();

        // GET: AnGames
        public ActionResult Index()
        {
            var anGames = db.AnGames.Include(a => a.Genre);
            return View(anGames.ToList());
        }

        // GET: AnGames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnGame anGame = db.AnGames.Find(id);
            if (anGame == null)
            {
                return HttpNotFound();
            }
            return View(anGame);
        }

        // GET: AnGames/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.AnGenres, "GenreId", "Name");
            return View();
        }

        // POST: AnGames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameId,Name,Description,Platform,ImgSrc,Price,GenreId")] AnGame anGame)
        {
            if (ModelState.IsValid)
            {
                db.AnGames.Add(anGame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(db.AnGenres, "GenreId", "Name", anGame.GenreId);
            return View(anGame);
        }

        // GET: AnGames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnGame anGame = db.AnGames.Find(id);
            if (anGame == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreId = new SelectList(db.AnGenres, "GenreId", "Name", anGame.GenreId);
            return View(anGame);
        }

        // POST: AnGames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameId,Name,Description,Platform,ImgSrc,Price,GenreId")] AnGame anGame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anGame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.AnGenres, "GenreId", "Name", anGame.GenreId);
            return View(anGame);
        }

        // GET: AnGames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnGame anGame = db.AnGames.Find(id);
            if (anGame == null)
            {
                return HttpNotFound();
            }
            return View(anGame);
        }

        // POST: AnGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnGame anGame = db.AnGames.Find(id);
            db.AnGames.Remove(anGame);
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
