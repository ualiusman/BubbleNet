using BubbleNet.Core.Models;
using BubbleNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Persistence.Repositories
{
    public class CommunicationRespository:Repository<Communication>, ICommunicationRepository
    {
        public CommunicationRespository(ApplicationDbContext context)
            :base(context)
        {

        }

        public IEnumerable<Communication> Get(long from, long to)
        {
           return _context.Set<Communication>().Where(x => x.CommunicationFrom == from && x.CommunicationTo == to).ToList();
        }

        public ApplicationDbContext ApplicationContext
        {
            get { return _context as ApplicationDbContext; }
        } 
    }
}
