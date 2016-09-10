using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BubbleNet.Models;
using BubbleNet;

namespace BubbleNet.Controllers
{
    [Authorize]
    public class FeatureController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Feature/
        public ActionResult Index()
        {
            return View(db.Features.ToList());
        }

        // GET: /Feature/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feature feature = db.Features.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            return View(feature);
        }

        // GET: /Feature/Create

        public ActionResult Create()
        {
            ViewBag.AllProjects = db.Projects.ToList().Select(f => new SelectListItem() { Text = f.ProjectName, Value = f.ProjectId.ToString() }).ToList();
            List<SelectListItem> relationships = new List<SelectListItem>();
            relationships.Add(new SelectListItem() { Text = "", Value = "" });
            relationships.Add(new SelectListItem() { Text = "Mandatory", Value = "Mandatory" });
            relationships.Add(new SelectListItem() { Text = "Optional", Value = "Optional" });
            relationships.Add(new SelectListItem() { Text = "Alternative ", Value = "Alternative" });
            relationships.Add(new SelectListItem() { Text = "OR", Value = "OR" });
            ViewBag.AllRelationships = relationships;
            return View();
        }

        // POST: /Feature/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FeatureId,ProjectId,Name,Discription,Relationship")] Feature feature)
        {
            if (ModelState.IsValid)
            {
                db.Features.Add(feature);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(feature);
        }

        // GET: /Feature/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feature feature = db.Features.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            ViewBag.AllProjects = db.Projects.ToList().Select(f => new SelectListItem() { Text = f.ProjectName, Value = f.ProjectId.ToString(), Selected = f.ProjectId == feature.ProjectId }).ToList();
            List<SelectListItem> relationships = new List<SelectListItem>();
            relationships.Add(new SelectListItem() { Text = "", Value = "" });
            relationships.Add(new SelectListItem() { Text = "Mandatory", Value = "Mandatory", Selected = "Mandatory" == feature.Relationship });
            relationships.Add(new SelectListItem() { Text = "Optional", Value = "Optional", Selected = "Optional" == feature.Relationship });
            relationships.Add(new SelectListItem() { Text = "Alternative ", Value = "Alternative", Selected = "Alternative" == feature.Relationship });
            relationships.Add(new SelectListItem() { Text = "OR", Value = "OR", Selected = "OR" == feature.Relationship });
            ViewBag.AllRelationships = relationships;
            return View(feature);
        }

        // POST: /Feature/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FeatureId,ProjectId,Name,Discription,Relationship")] Feature feature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feature).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feature);
        }

        // GET: /Feature/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feature feature = db.Features.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            return View(feature);
        }

        // POST: /Feature/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Feature feature = db.Features.Find(id);
            db.Features.Remove(feature);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DistributeFeatures()
        {
            ViewBag.AllUsrs = db.Users.ToList().Select(f => new SelectListItem() { Text = f.FullName, Value = f.UserID.ToString() }).ToList();
            ViewBag.AllFeaturs = db.Features.ToList().Select(f => new SelectListItem() { Text = f.Name + " (" + f.Project.ProjectName + ")", Value = f.FeatureId.ToString() }).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DistributeFeatures([Bind(Include = "FeatureId,UserId")] FeatureUser featureUser)
        {
            if (ModelState.IsValid)
            {
                if (!(db.FeatureUsers.Where(f => f.FeatureId == featureUser.FeatureId && f.UserId == featureUser.UserId).Count() > 0))
                {
                    db.FeatureUsers.Add(featureUser);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(featureUser);
        }


        public ActionResult FeaturesDistributionList()
        {
           return View(db.FeatureUsers.ToList());
        }

        public ActionResult DeleteDistribution(long id)
        {
            FeatureUser featureUser = db.FeatureUsers.Find(id);
            if(featureUser != null)
            {
                db.FeatureUsers.Remove(featureUser);
                db.SaveChanges();
            
            }
            return RedirectToAction("FeaturesDistributionList");
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
