using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BubbleNet.Models
{
    public class AppCommon
    {
        public static string GetUser(long userId)
        {
            string name = string.Empty;
            ApplicationDbContext db = new ApplicationDbContext();
            name = db.Users.Where(f => f.UserID == userId).Single().FullName;
            db.Dispose();
            return name;

        }
    }
}