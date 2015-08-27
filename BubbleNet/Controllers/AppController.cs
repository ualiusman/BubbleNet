using BubbleNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BubbleNet.Controllers
{
    [Authorize]
    public class AppController : Controller
    {
        //
        // GET: /App/
        public ActionResult ROI()
        {
            return View();
        }

        public ActionResult Poster()
        {
            var _db = new ApplicationDbContext();

            List<UserViewModel> userModel = new List<UserViewModel>();
            foreach (var user in _db.Users)
            {
                UserViewModel um = new UserViewModel();
                um.Email = user.Email;
                um.From = user.From;
                um.FullName = user.FullName;
                var cntry = _db.Countries.Where(f => f.Code == user.Country).FirstOrDefault();
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
            return View(userModel);
        }
	}
}