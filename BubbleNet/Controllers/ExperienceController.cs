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
    [Authorize]
    public class ExperienceController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Experience/
        public ActionResult Index()
        {
            List<ExperienceViewModel> viewModels = new List<ExperienceViewModel>();
            foreach (var item in db.Experiences.ToList())
            {
                viewModels.Add(Convert(item));
            }
            return View(viewModels);
        }

        // GET: /Experience/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experience experience = db.Experiences.Find(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            return View(Convert(experience));
        }

        // GET: /Experience/Create
        public ActionResult Create()
        {
            ViewBag.AllUsrs = db.Users.ToList().Select(f => new SelectListItem() { Text = f.FullName, Value = f.UserID.ToString() }).ToList();
            return View();
        }

        // POST: /Experience/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExperienceId,User,UserExperience")] Experience experience)
        {
            if (ModelState.IsValid)
            {
                db.Experiences.Add(experience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(experience);
        }

        // GET: /Experience/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experience experience = db.Experiences.Find(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            ViewBag.AllUsrs = db.Users.ToList().Select(f => new SelectListItem() { Text = f.FullName, Value = f.UserID.ToString(), Selected = f.UserID == experience.User }).ToList();
            return View(experience);
        }

        // POST: /Experience/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExperienceId,User,UserExperience")] Experience experience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(experience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(experience);
        }

        // GET: /Experience/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experience experience = db.Experiences.Find(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            return View( Convert(experience));
        }

        // POST: /Experience/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Experience experience = db.Experiences.Find(id);
            db.Experiences.Remove(experience);
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

        #region private Methods
        private ExperienceViewModel Convert( Experience model)
        {
            ExperienceViewModel viewModel = new ExperienceViewModel();
            viewModel.UserExperience = model.UserExperience;
            viewModel.ExperienceId = model.ExperienceId;
            viewModel.FullName = db.Users.Where(f => f.UserID == model.User).Single().FullName;
            return viewModel;
        }
        #endregion
    }

}
