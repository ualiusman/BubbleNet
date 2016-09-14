using BubbleNet.Core;
using BubbleNet.Infrastructure.Persistence;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.DI
{
    public class RepositoryModule :NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
