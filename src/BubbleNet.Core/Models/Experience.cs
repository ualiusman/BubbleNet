using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core.Models
{
    public class Experience
    {
        public long ExperienceId { get; set; }
        [Required]
        [Display(Name = "Participant")]
        public long User { get; set; }
        [Required]
        [Display(Name = "Experience")]
        public string UserExperience { get; set; }
    }
}
