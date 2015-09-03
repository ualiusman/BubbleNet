using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BubbleNet.Models
{
    public class UserViewModel
    {
        public UserViewModel() { }
        public UserViewModel(ApplicationUser user)
        {
            UserName = user.UserName;
            ProfilePic = user.ProfilePic;
            FullName = user.FullName;
            SkypeName = user.SkypeName;
            MobileNumber = user.MobileNumber;
            Email = user.Email;
            Company = user.Company;
            Location = user.Location;
            Country = user.Country;
            OfficeHoursEnd = user.OfficeHoursEnd;
            OfficeHoursStart = user.OfficeHoursStart;
            AvailabiltyHours = user.AvailabiltyHours;
            BusinessDomain = user.BusinessDomain;
            TechnologyExpertise = user.TechnologyExpertise;
            Interests = user.Interests;
            WantToCollaborate = user.WantToCollaborate;
            WantFromTeamMates = user.WantFromTeamMates;
            Religion = user.Religion;
            From = user.From;
            Language = user.Language;
        }

        [Display(Name = "Profile Image")]
        public string ProfilePic { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Skype")]
        public string SkypeName { get; set; }
        [Display(Name = "Mobile")]
        public string MobileNumber { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        [Display(Name = "Office Hours Start")]
        [Range(0, 23, ErrorMessage="Number should be between 0 to 23")]
        public int OfficeHoursStart { get; set; }
        [Display(Name = "Office Hours End")]
        [Range(0, 23, ErrorMessage = "Number should be between 0 to 23")]
        public int OfficeHoursEnd { get; set; }
        [Display(Name = "Availabilty Hours")]
        public string AvailabiltyHours { get; set; }
        [Display(Name = "Business Domain")]
        public string BusinessDomain { get; set; }
        [Display(Name = "Technology Expertise")]
        public string TechnologyExpertise { get; set; }
        public string Religion { get; set; }
        public string From { get; set; }
        public string Language { get; set; }
        public string Interests { get; set; }
        [Display(Name = "What do I bring to the collaboration")]
        public string WantToCollaborate { get; set; }
        [Display(Name = "What do I want from my teammates")]
        public string WantFromTeamMates { get; set; }

    }
}