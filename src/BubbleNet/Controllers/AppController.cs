using BubbleNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using BubbleNet.Core;

namespace BubbleNet.Controllers
{
    [Authorize]
    public class AppController : Controller
    {
        public IUnitOfWork _db;
        public AppController(IUnitOfWork uof)
        {
            _db = uof;
        }
        //
        // GET: /App/
        public ActionResult ROI()
        {
            return View("ROI");
        }

        public ActionResult Poster(int? page)
        {
           

            List<UserViewModel> userModel = new List<UserViewModel>();
            foreach (var user in _db.Users.GetAll())
            {
                UserViewModel um = new UserViewModel();
                um.Email = user.Email;
                um.From = user.From;
                um.ProfilePic = user.ProfilePic;
                um.FullName = user.FullName;
                var cntry = _db.Countries.Get(user.Country);
               if(cntry != null)
               {
                   um.Country = cntry.Name;
               }
               um.Interests = user.Interests;
               um.Language = user.Language;
               um.Location = user.Location;
               um.MobileNumber = user.MobileNumber;
               um.OfficeHoursEnd = user.OfficeHoursEnd;
               um.OfficeHoursStart = user.OfficeHoursStart;
               um.Religion = user.Religion;
               um.SkypeName = user.SkypeName;
               um.TechnologyExpertise = user.TechnologyExpertise;
               um.WantFromTeamMates = user.WantFromTeamMates;
               um.WantToCollaborate = user.WantToCollaborate;
               um.BusinessDomain = user.BusinessDomain;
               um.Company = user.Company;
               um.AvailabiltyHours = user.AvailabiltyHours;

               userModel.Add(um);
            }


            int pageSize = 3;
            int pageNumber = (page ?? 1);
            
            return View("Poster",userModel.ToPagedList(pageNumber,pageSize));
        }
	}
}