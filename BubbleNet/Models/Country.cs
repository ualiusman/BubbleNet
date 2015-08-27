using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BubbleNet.Models
{
    public class Country
    {
        public long CountryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TimeZone { get; set; }
        public float UtcOffset { get; set; }
    }
}