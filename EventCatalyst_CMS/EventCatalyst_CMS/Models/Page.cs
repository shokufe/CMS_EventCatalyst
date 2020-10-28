using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalyst_CMS.Models
{
    public class Page
    {
        [Key]
        public String Title { get; set; }
        public String Content { get; set; }
        public TimestampAttribute CreateDate { get; set; }
    }
}
