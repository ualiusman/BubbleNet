using BubbleNet.Core;
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
             IUnitOfWork db = new BubbleNet.Infrastructure.Persistence.UnitOfWork(new Infrastructure.Persistence.ApplicationDbContext());
            name = db.Users.GetUserName(userId);
            db.Dispose();
            return name;

        }
    }
}