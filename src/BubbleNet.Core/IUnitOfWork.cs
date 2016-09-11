using BubbleNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core
{
    public interface IUnitOfWork:IDisposable
    {
        IProjectRepository Projects { get; }
        IPracticeRepository Practices { get; }
        IUserRepository Users { get; }
        IPracticeUserRepository PracticeUsers { get; }
        IFeatureRepository Features { get; }
        IFeatureUserRepository FeatureUsers { get; }
        IExperienceRepository Experiences { get; }
        ICommunicationRepository Communications { get; }
        ICountryRepository Countries { get; }

        int Complete();
    }
}
