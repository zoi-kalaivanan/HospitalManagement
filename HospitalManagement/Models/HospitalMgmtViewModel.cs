using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class HospitalMgmtViewModel
    {
        public HospitalMgmtViewModel()
        {
            User = new User();

            Count = new Count();

            DoctorsList = new List<string>();

            HospitalsList = new List<string>();

            PatientsList = new List<string>();

            DoctorSummary = new List<Common>();
        }

        public User User { get; set; }

        public Count Count { get; set; }

        public List<string> DoctorsList;

        public List<string> HospitalsList;

        public List<string> PatientsList;

        public List<Common> DoctorSummary { get; set; }
    }
}
