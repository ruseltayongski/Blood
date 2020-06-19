using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Models
{
    public class Test1
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string division { get; set; }
        public string section { get; set; }
        
        public string position { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
