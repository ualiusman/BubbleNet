using BubbleNet.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core.Repositories
{
    public interface IUserRepository:IRepository<ApplicationUser>
    {
        Dictionary<string,string> GetUserList();
        List<string> GetUsersName();
        string GetUserName(long userId);
    }
}
