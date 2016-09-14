using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BubbleNet.Core.Models;
using BubbleNet.Core;

namespace BubbleNet.Controllers
{
    [Authorize]
    public class PracticeController : Controller
    {
        private IUnitOfWork db;

        public PracticeController(IUnitOfWork uof)
        {
            db = uof;
        }

        // GET: /Practice/
        public ActionResult Index()
        {
            return View(db.Practices.GetAll());
        }

        // GET: /Practice/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Practice practice = db.Practices.Get(id.Value);
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
                db.Complete();
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
            Practice practice = db.Practices.Get(id.Value);
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
                var p = db.Practices.Get(practice.PracticeId);
                if( p != null)
                {
                    p.Name = practice.Name;
                    p.Team = practice.Team;
                    p.Description = practice.Description;

                    db.Complete();
                }
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
            Practice practice = db.Practices.Get(id.Value);
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
            Practice practice = db.Practices.Get(id);
            db.Practices.Remove(practice);
            db.Complete();
            return RedirectToAction("Index");
        }

        public ActionResult AssignParticipantToPractice()
        {
            ViewBag.AllUsrs = db.Users.GetUserList().Select(f => new SelectListItem() { Text = f.Value, Value = f.Key }).ToList();
            ViewBag.AllPractices = db.Practices.GetPracticeList().Select(f => new SelectListItem() { Text = f.Value, Value = f.Key }).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssignParticipantToPractice([Bind(Include = "PracticeId,UserId")] PracticeUser practiceUser)
        {
            if (ModelState.IsValid)
            {
                var p = db.Practices.Get(practiceUser.PracticeId);
                if (!(p.PracticeUsers.Count() > 0))
                {
                    p.PracticeUsers.Add(practiceUser);
                    db.Complete();
                }
                return RedirectToAction("Index");
            }
            return View(practiceUser);
        }

        public ActionResult PracticeParticipantList()
        {
            return View(db.PracticeUsers.GetAll());
        }

        public ActionResult DeletePracticeParticipant(long id)
        {
            PracticeUser practiceUser = db.PracticeUsers.Get(id);
            if (practiceUser != null)
            {
                db.PracticeUsers.Remove(practiceUser);
                db.Complete();

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
