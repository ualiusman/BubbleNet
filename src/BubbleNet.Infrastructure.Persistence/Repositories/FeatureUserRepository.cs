using BubbleNet.Core.Models;
using BubbleNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Persistence.Repositories
{
    public class FeatureUserRepository:Repository<FeatureUser>, IFeatureUserRepository
    {
        public FeatureUserRepository(ApplicationDbContext context)
            :base(context)
        {

        }

        public ApplicationDbContext ApplicationContext
        {
            get { return _context as ApplicationDbContext; }
        }
    }
}
