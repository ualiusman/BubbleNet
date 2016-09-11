using BubbleNet.Core;
using BubbleNet.Core.Repositories;
using BubbleNet.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Persistence
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Projects = new ProjectRepository(_context);
            Practices = new PracticeRepository(_context);
            Users = new UserRepository(_context);
            PracticeUsers = new PracticeUserRepository(_context);
            Features = new FeatureRepository(_context);
            FeatureUsers = new FeatureUserRepository(_context);
            Experiences = new ExperienceRepository(_context);
            Communications = new CommunicationRespository(_context);
            Countries = new CountryRepository(_context);
        }

        public int Complete()
        {
         return   _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IProjectRepository Projects { get;private set;}
        public IPracticeRepository Practices { get; private set; }
        public IUserRepository Users { get; private set; }
        public IPracticeUserRepository PracticeUsers { get; private set; }
        public IFeatureRepository Features { get; private set; }
        public IFeatureUserRepository FeatureUsers { get; private set; }
        public IExperienceRepository Experiences { get; private set; }
        public ICommunicationRepository Communications { get; private set; }
        public ICountryRepository Countries { get; private set; }
    }
}
