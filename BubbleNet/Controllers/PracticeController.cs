using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BubbleNet.Models;

namespace BubbleNet.Controllers
{
    public class PracticeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Practice/
        public ActionResult Index()
        {
            return View(db.Practices.ToList());
        }

        // GET: /Practice/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Practice practice = db.Practices.Find(id);
            if (practice == null)
            {
                return HttpNotFound();
            }
            return View(practice);
        }

        // GET: /Practice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Practice/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="PracticeId,Name,Team,Description")] Practice practice)
        {
            if (ModelState.IsValid)
            {
                db.Practices.Add(practice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(practice);
        }

        // GET: /Practice/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Practice practice = db.Practices.Find(id);
            if (practice == null)
            {
                return HttpNotFound();
            }
            return View(practice);
        }

        // POST: /Practice/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="PracticeId,Name,Team,Description")] Practice practice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(practice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(practice);
        }

        // GET: /Practice/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Practice practice = db.Practices.Find(id);
            if (practice == null)
            {
                return HttpNotFound();
            }
            return View(practice);
        }

        // POST: /Practice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Practice practice = db.Practices.Find(id);
            db.Practices.Remove(practice);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AssignParticipantToPractice()
        {
            ViewBag.AllUsrs = db.Users.ToList().Select(f => new SelectListItem() { Text = f.FullName, Value = f.UserID.ToString() }).ToList();
            ViewBag.AllPractices = db.Practices.ToList().Select(f => new SelectListItem() { Text = f.Name, Value = f.PracticeId.ToString() }).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssignParticipantToPractice([Bind(Include = "PracticeId,UserId")] PracticeUser practiceUser)
        {
            if (ModelState.IsValid)
            {
                if (!(db.PracticeUsers.Where(f => f.PracticeId == practiceUser.PracticeId && f.UserId == practiceUser.UserId).Count() > 0))
                {
                    db.PracticeUsers.Add(practiceUser);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(practiceUser);
        }

        public ActionResult PracticeParticipantList()
        {
            return View(db.PracticeUsers.ToList());
        }

        public ActionResult DeletePracticeParticipant(long id)
        {
            PracticeUser practiceUser = db.PracticeUsers.Find(id);
            if (practiceUser != null)
            {
                db.PracticeUsers.Remove(practiceUser);
                db.SaveChanges();

            }
            return RedirectToAction("PracticeParticipantList");
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
