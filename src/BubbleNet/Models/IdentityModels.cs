using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace BubbleNet.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserID { get; set; }
        public string FullName { get; set; }
        public string ProfilePic { get; set; }
        public string Email { get; set; }
        public string SkypeName { get; set; }
        public string MobileNumber { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public int OfficeHoursStart { get; set; }
        public int OfficeHoursEnd { get; set; }
        public string AvailabiltyHours { get; set; }
        public string BusinessDomain { get; set; }
        public string TechnologyExpertise { get; set; }
        public string Religion { get; set; }
        public string From { get; set; }
        public string Language { get; set; }
        public string Interests { get; set; }
        public string WantToCollaborate { get; set; }
        public string WantFromTeamMates { get; set; }
        public bool IsDeleted { get; set; }
    }

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

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<BubbleNet.Models.CollaborativeSite> CollaborativeSites { get; set; }

        public System.Data.Entity.DbSet<BubbleNet.Models.CommunicationMap> CommunicationMaps { get; set; }
    }
}