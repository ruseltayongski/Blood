using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Models
{
    public class Component
    {
        public int id { get; set; }
        [Required]
        public string description { get; set; }
        public string status { get; set; }
    }
}
