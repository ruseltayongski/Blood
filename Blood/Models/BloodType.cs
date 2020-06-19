using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Models
{
    public class BloodType
    {
        public int id { get; set; }
        [Required]
        public string description { get; set; }
        [AllowNull]
        public string status { get; set; }
    }
}
