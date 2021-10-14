using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class Common
    {
        public int ID { get; set; }
        public string Name { get; set; }       
        public int? HospitalID { get; set; }
        public int? LocationID { get; set; }
        public string? HospitalName { get; set; }
        public string? LocationName { get; set; }
    }
}
