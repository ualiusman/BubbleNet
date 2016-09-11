using BubbleNet.Core.Models;
using BubbleNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Persistence.Repositories
{
    public class PracticeRepository: Repository<Practice>, IPracticeRepository
    {
        public PracticeRepository(ApplicationDbContext context)
            :base(context)
        {

        }

        public Dictionary<string, string> GetPracticeList()
        {
            return _context.Set<Practice>().ToDictionary(x => x.PracticeId.ToString(), x => x.Name);
        }

        public ApplicationDbContext ApplicationContext
        {
            get { return _context as ApplicationDbContext; }
        } 
    }
}
