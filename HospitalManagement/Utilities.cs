using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Utilities
    {
        public static string ConnectionString = "Server=(LocalDb)\\MSSQLLocalDB;Database=Trainee;Trusted_Connection=True;MultipleActiveResultSets=true";
        
        public static class Procedures
        {
           public static string AddUpdate = "HospitalMgmt.SP_AddUpdateUser";
          
            public static string GetCounts = "HospitalMgmt.SP_GetCounts";
            
            public static string GetSummaryDetails = "HospitalMgmt.SP_FetchSummaryDetails";

            public static string GetDropdownDetails = "HospitalMgmt.SP_GetDropdownDetails";

            public static string AddUpdateAppointment = "HospitalMgmt.SP_AddUpdateAppointment";
        }
    }
}
