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
    public class ProjectController : Controller
    {
        private IUnitOfWork db;


        public ProjectController(IUnitOfWork uof)
        {
            db = uof;
        }
        // GET: /Project/
        public ActionResult Index()
        {
            //return View(db.Projects.ToList());
            return View(db.Projects.GetAll());
        }

        // GET: /Project/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Get(id.Value);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: /Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Project/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ProjectId,ProjectName,Discription")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(project);
                db.Complete();
                return RedirectToAction("Index");
            }

            return View(project);
        }

        // GET: /Project/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Get(id.Value);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: /Project/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ProjectId,ProjectName,Discription")] Project project)
        {
            if (ModelState.IsValid)
            {
               var p =  db.Projects.Get(project.ProjectId);
                if(p !=null)
                {
                    p.ProjectName = project.ProjectName;
                    p.Discription = project.Discription;
                    db.Complete();
                }
                return RedirectToAction("Index");
            }
            return View(project);
        }

        // GET: /Project/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Get(id.Value);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: /Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Project project = db.Projects.Get(id);
            db.Projects.Remove(project);
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
    }
}
