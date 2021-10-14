using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CityID { get; set; }
        public int HospitalID { get; set; }
        public int DoctorID { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public string HealthQueries { get; set; }
        public int Flag { get; set; }
    }
}
