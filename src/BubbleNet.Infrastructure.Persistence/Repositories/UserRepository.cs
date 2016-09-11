using BubbleNet.Core.Models;
using BubbleNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Persistence.Repositories
{
    public class UserRepository: Repository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context)
            :base(context)
        {

        }

        public Dictionary<string,string>  GetUserList()
        {
           return _context.Set<ApplicationUser>().ToDictionary(x => x.UserID.ToString(), x => x.FullName);
        }

        public string GetUserName(long userId)
        {
            return _context.Set<ApplicationUser>().Where(x => x.UserID == userId).Select(x => x.FullName).FirstOrDefault().ToString();
        }

        public List<string> GetUsersName()
        {
            return _context.Set<ApplicationUser>().Select(x => x.FullName).ToList();
        }

        public ApplicationDbContext ApplicationContext
        {
            get { return _context as ApplicationDbContext; }
        }
    }
}
