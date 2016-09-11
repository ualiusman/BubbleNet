using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core.Models
{
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

}
