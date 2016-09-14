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
    public class CommunicationController : Controller
    {
        private IUnitOfWork db;

        public CommunicationController(IUnitOfWork uof)
        {
            db = uof;
        }

        // GET: /Communication/
        public ActionResult Index()
        {
            return View(db.Communications.GetAll());
        }

        // GET: /Communication/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Communication communication = db.Communications.Get(id.Value);
            if (communication == null)
            {
                return HttpNotFound();
            }
            return View(communication);
        }

        // GET: /Communication/Create
        public ActionResult Create()
        {
            ViewBag.AllUsrs = db.Users.GetUserList().Select(f => new SelectListItem() { Text = f.Value, Value = f.Key }).ToList();
            ViewBag.Status = new List<SelectListItem>() { 
                                                          new SelectListItem(){ Text ="Good", Value="Good"},
                                                          new SelectListItem(){ Text="Medium", Value="Medium"},
                                                          new SelectListItem(){ Text="Bad", Value="Bad"}
                                                        };
            return View();
        }

        // POST: /Communication/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CommunicationId,CommunicationFrom,CommunicationTo,Satus")] Communication communication)
        {
            if (ModelState.IsValid)
            {
                if (communication.CommunicationFrom != communication.CommunicationTo)
                {
                    if (!(db.Communications.Get(communication.CommunicationFrom,communication.CommunicationTo).Count() > 0))
                    {
                        db.Communications.Add(communication);
                        db.Complete();
                        return RedirectToAction("Index");
                    }
                }
            }
            ViewBag.AllUsrs = db.Users.GetUserList().Select(f => new SelectListItem() { Text = f.Value, Value = f.Key }).ToList();
            ViewBag.Status = new List<SelectListItem>() { 
                                                          new SelectListItem(){ Text ="Good", Value="Good"},
                                                          new SelectListItem(){ Text="Medium", Value="Medium"},
                                                          new SelectListItem(){ Text="Bad", Value="Bad"}
                                                        };
            return View(communication);
        }

        // GET: /Communication/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Communication communication = db.Communications.Get(id.Value);
            if (communication == null)
            {
                return HttpNotFound();
            }
            ViewBag.AllUsrsFrom = db.Users.GetUserList().Select(f => new SelectListItem() { Text = f.Value, Value = f.Key.ToString(), Selected = f.Key == communication.CommunicationFrom.ToString() }).ToList();
            ViewBag.AllUsrsTo = db.Users.GetUserList().Select(f => new SelectListItem()
            {
                Text = f.Value,
                Value = f.Key,
                Selected = f.Key
                == communication.CommunicationTo.ToString() }).ToList();
            ViewBag.Status = new List<SelectListItem>() { 
                                                          new SelectListItem(){ Text ="Good", Value="Good", Selected = "Good" == communication.Satus},
                                                          new SelectListItem(){ Text="Medium", Value="Medium", Selected = "Medium" == communication.Satus},
                                                          new SelectListItem(){ Text="Bad", Value="Bad", Selected = "Bad" == communication.Satus}
                                                        };

            return View(communication);
        }

        // POST: /Communication/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CommunicationId,CommunicationFrom,CommunicationTo,Satus")] Communication communication)
        {
            if (ModelState.IsValid)
            {
                var c = db.Communications.Get(communication.CommunicationId);
                if(c != null)
                {
                    c.CommunicationFrom = communication.CommunicationFrom;
                    c.CommunicationTo = communication.CommunicationTo;
                    c.Satus = communication.Satus;
                    db.Complete();

                }
                return RedirectToAction("Index");
            }
            return View(communication);
        }

        // GET: /Communication/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Communication communication = db.Communications.Get(id.Value);
            if (communication == null)
            {
                return HttpNotFound();
            }
            return View(communication);
        }

        // POST: /Communication/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Communication communication = db.Communications.Get(id);
            db.Communications.Remove(communication);
            db.Complete();
            return RedirectToAction("Index");
        }


        public ActionResult CommunicationStatus()
        {
            List<string> comTo = db.Users.GetUsersName();
            List<string> comFrom = comTo;

            List<CommunicationStatus> communicationStatus = new List<CommunicationStatus>();
            foreach (var usr in db.Users.GetAll())
            {
                CommunicationStatus cs = new CommunicationStatus();
                cs.CommunicationFrom = usr.FullName;
                foreach (var u in db.Users.GetAll())
                {
                    Communication c = db.Communications.Get(usr.UserID, u.UserID).FirstOrDefault();
                    if(c != null)
                    {
                        cs.Status.Add(c.Satus);
                    }
                    else
                    {
                        cs.Status.Add(string.Empty);
                    }
                }

                communicationStatus.Add(cs);
            }

            ViewBag.To = comTo;
            ViewBag.From = communicationStatus;
            return View();
        }


        public ActionResult CollaborativeSites()
        {
            List<CollaborativeSite> sites = new List<CollaborativeSite>();
            foreach (var user in db.Users.GetAll())
            {
                CollaborativeSite site = new CollaborativeSite();
                site.Id = user.UserID;
                site.Location = user.Location;
                site.UserName = user.FullName;
                var contry = db.Countries.Get(user.Country);
                if (contry != null)
                {
                    site.Country = contry.Name;
                    site.TimeZone = contry.TimeZone;
                }

                sites.Add(site);
            }
            return View(sites);
        }

        public ActionResult CommunicationMap()
        {
            List<CommunicationMap> maps = new List<CommunicationMap>();
            foreach (var user in db.Users.GetAll())
            {
                CommunicationMap map = new CommunicationMap();
                map.Id = user.UserID;
                map.Location = user.Location;
                Country country = db.Countries.Get(user.Country);
                if (country != null)
                {
                    float offset = country.UtcOffset;
                    for (int i = 0; i < 24; i++)
                    {
                        map.Hours.Add(getNum(i + offset));
                        
                    }
                }
                maps.Add(map);
            }
            
            return View(maps);
        }

        private string getNum(float i)
        {
            if(i > 23)
            {
                i = i - 24;
            }
            else if( i < 0)
            {
                i = i + 24;
            }
            return (i).ToString();
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
