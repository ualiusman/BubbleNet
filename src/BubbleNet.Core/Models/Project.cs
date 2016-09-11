using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core.Models
{
    public class Project
    {
        public Project()
        {
            Features = new List<Feature>();
        }
        public long ProjectId { get; set; }
        [Required]
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Display(Name = "Project Description")]
        public string Discription { get; set; }

        [Display(Name = "Features List")]
        public virtual ICollection<Feature> Features { get; set; }
    }
}
