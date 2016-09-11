using BubbleNet.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core.Repositories
{
    public interface ICommunicationRepository:IRepository<Communication>
    {
        IEnumerable<Communication> Get(long from, long to);
    }
}
