using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Core.Models
{
    public class Communication
    {
        public long CommunicationId { get; set; }
        [Required]
        [Display(Name = "Communication From")]
        public long CommunicationFrom { get; set; }
        [Required]
        [Display(Name = "Communication To")]
        public long CommunicationTo { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Satus { get; set; }
    }

    public class CommunicationStatus
    {
        public CommunicationStatus()
        {
            Status = new List<string>();
        }
        public string CommunicationFrom { get; set; }
        public List<string> Status { get; set; }
    }


    public class CollaborativeSite
    {
        public long Id { get; set; }
        [Display(Name = "Participant")]
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        [Display(Name = "Time Zone")]
        public string TimeZone { get; set; }
    }

    public class CommunicationMap
    {
        public CommunicationMap()
        {
            Hours = new List<string>();
        }
        public long Id { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Time")]
        public List<string> Hours { get; set; }
    }
}
