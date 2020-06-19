using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Models
{
    public class ComponentUser
    {
        public int id { get; set; }
        [Required]
        public int inventory_id { get; set; }
        public int component_id { get; set; }

        public DateTime CreationTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
