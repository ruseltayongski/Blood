using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Models
{
    public class Inventory
    {
        public int id { get; set; }
        public string encoded_by { get; set; }
        public string serial_no { get; set; }
        public string created_by { get; set; }
        public int qty { get; set; }
        public string mbd { get; set; }
        public string blood_type { get; set; }
        public DateTime date_coltd { get; set; }
        public DateTime date_released { get; set; }
        public string stakeholder { get; set; }
        public DateTime date_transfuse { get; set; }
        public string key_test { get; set; }
        public int age { get; set; }
        public DateTime expiry_date { get; set; }
        public string status { get; set; }
        public string amount { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
    
}
