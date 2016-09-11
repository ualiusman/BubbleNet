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
    public class ExperienceController : Controller
    {
        private IUnitOfWork db = new BubbleNet.Infrastructure.Persistence.UnitOfWork(new Infrastructure.Persistence.ApplicationDbContext());

        // GET: /Experience/
        public ActionResult Index()
        {
            List< BubbleNet.Models.ExperienceViewModel> viewModels = new List<BubbleNet.Models.ExperienceViewModel>();
            foreach (var item in db.Experiences.GetAll())
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
            Experience experience = db.Experiences.Get(id.Value);
            if (experience == null)
            {
                return HttpNotFound();
            }
            return View(Convert(experience));
        }

        // GET: /Experience/Create
        public ActionResult Create()
        {
            ViewBag.AllUsrs = db.Users.GetUserList().Select(f => new SelectListItem() { Text = f.Value, Value = f.Key }).ToList();
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
                db.Complete();
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
            Experience experience = db.Experiences.Get(id.Value);
            if (experience == null)
            {
                return HttpNotFound();
            }
            ViewBag.AllUsrs = db.Users.GetUserList().Select(f => new SelectListItem() { Text = f.Value, Value = f.Key, Selected = f.Key == experience.User.ToString() }).ToList();
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
                var e = db.Experiences.Get(experience.ExperienceId);
                if(e != null)
                {
                    e.User = experience.User;
                    e.UserExperience = experience.UserExperience;
                    db.Complete();
                }
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
            Experience experience = db.Experiences.Get(id.Value);
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
            Experience experience = db.Experiences.Get(id);
            db.Experiences.Remove(experience);
            db.Complete();
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
        private BubbleNet.Models.ExperienceViewModel Convert( Experience model)
        {
            BubbleNet.Models.ExperienceViewModel viewModel = new BubbleNet.Models.ExperienceViewModel();
            viewModel.UserExperience = model.UserExperience;
            viewModel.ExperienceId = model.ExperienceId;
            viewModel.FullName = BubbleNet.Models.AppCommon.GetUser(model.User);
            return viewModel;
        }
        #endregion
    }

}
