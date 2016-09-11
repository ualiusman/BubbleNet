using BubbleNet.Core.Models;
using BubbleNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Persistence.Repositories
{
    public class CountryRepository:Repository<Country>,ICountryRepository
    {
        public CountryRepository(ApplicationDbContext context)
            :base(context)
        {

        }

        public Country Get(string code)
        {
           return _context.Set<Country>().Where(x => x.Code == code).FirstOrDefault();
        }

        public Dictionary<string,string> GetCountryList()
        {
            return _context.Set<Country>().ToDictionary(x => x.Code, x => x.Name);
        }

        public ApplicationDbContext ApplicationContext
        {
            get { return _context as ApplicationDbContext; }
        }
    }
}
