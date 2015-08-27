using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BubbleNet.Models
{
    public class Experience
    {
        public long ExperienceId { get; set; }
        [Required]
        [Display( Name="Participant")]
        public long User { get; set; }
        [Required]
        [Display(Name = "Experience")]
        public string UserExperience { get; set; }
    }

    public class ExperienceViewModel
    {
        public long ExperienceId { get; set; }
        [Display(Name = "Participant")]
        public string FullName { get; set; }
        [Display(Name = "Experience")]
        public string UserExperience { get; set; }
    }

}