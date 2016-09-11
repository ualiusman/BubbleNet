using BubbleNet.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core.Repositories
{
    public interface ICountryRepository:IRepository<Country>
    {
        Country Get(string code);
        Dictionary<string, string> GetCountryList();
    }
}
