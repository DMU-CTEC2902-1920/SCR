using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameReview.Models;

namespace GameReview.Controllers
{
    public class AnDevelopersController : Controller
    {
        private AnGameContext db = new AnGameContext();

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

        // POST: AnDevelopers/PostCommentReply
        [HttpPost]
        public ActionResult PostCommentReply(CommentReplyViewModel obj)
        {
            int userid = 1;
            AnCommentReply reply = new AnCommentReply();
            reply.UserId = userid;
            reply.CommentReplyText = obj.AnCommentReply;
            reply.CommentId = obj.ACommentId;
            db.AnCommentReplys.Add(reply);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        // POST: AnGames/PostComment
        [HttpPost]
        public ActionResult PostComment(string AnComment)
        {
            int userid = 2;
            AnComment comment = new AnComment();
            comment.UserId = userid;
            comment.CommentText = AnComment;
            db.AnComments.Add(comment);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        //action method that allows you to delete a comment 
        // POST: AnGames/DeleteComment
        [HttpPost]
        public ActionResult DeleteComment(int id)
        {
            AnComment anComment = db.AnComments.Find(id);
            db.AnComments.Remove(anComment);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        //action method that allows you to delete a comment reply
        // POST: AnGames/DeleteCommentReply
        [HttpPost]
        public ActionResult DeleteCommentReply(int id)
        {
            AnCommentReply anCommentReply = db.AnCommentReplys.Find(id);
            db.AnCommentReplys.Remove(anCommentReply);
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
