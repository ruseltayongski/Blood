using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Models
{
    public class Test
    {
        public int id { get; set; }
        [Required]
        public string encoded_by { get; set; }

        public DateTime CreationTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
