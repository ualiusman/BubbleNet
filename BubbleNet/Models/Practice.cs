using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BubbleNet.Models
{
    public class Practice
    {
        public Practice()
        {
            PracticeUsers = new List<PracticeUser>();
        }
        public long PracticeId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.Text)]
        public string Team { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name="Best Practice Description")]
        public string Description { get; set; }

        [Display(Name="Participants")]
        public virtual ICollection<PracticeUser> PracticeUsers {get;set;}
    }

    public class PracticeUser
    {
        public long PracticeUserId { get; set; }

        [Required]
        [Display(Name="Team Best Practice")]
        public long PracticeId {get;set;}

        [Required]
        [Display(Name="Performed By")]
        public long UserId { get; set; }

        public virtual Practice Practice { get; set; }
    }
}