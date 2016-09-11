using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core.Models
{
    public class Feature
    {
        public Feature()
        {
            FeatureUsers = new List<FeatureUser>();
        }
        public long FeatureId { get; set; }
        [Required]
        [Display(Name = "Project")]
        public long ProjectId { get; set; }
        [Required]
        [Display(Name = "Feature")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Discription { get; set; }
        public string Relationship { get; set; }

        public virtual Project Project { get; set; }
        [Display(Name = "Assign To")]
        public virtual ICollection<FeatureUser> FeatureUsers { get; set; }
    }

    public class FeatureUser
    {
        public long FeatureUserId { get; set; }
        [Required]
        [Display(Name = "Participant")]
        public long UserId { get; set; }
        [Required]
        [Display(Name = "Feature")]
        public long FeatureId { get; set; }

        public virtual Feature Feature { get; set; }
    }
}
