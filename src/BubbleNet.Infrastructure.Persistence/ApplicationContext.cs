using BubbleNet.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureUser> FeatureUsers { get; set; }
        public DbSet<Practice> Practices { get; set; }
        public DbSet<PracticeUser> PracticeUsers { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CommunicationMap> CommunicationMaps { get; set; }
        public DbSet<CollaborativeSite> CollaborativeSites { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        

        
    }
}

