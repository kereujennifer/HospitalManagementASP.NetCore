using HospitalManagement.Models;

namespace HospitalManagement.ViewModels
{
   
    public class DashboardVM
    {
        public int DoctorCount { get; set; }
        public int PatientCount { get; set; }
        public int PharmacyCount { get; set; }
        public int LaboratoryCount { get; set; }

        public List<Appointment>? Appointments { get; set; }
        public decimal TotalRevenue { get; set; }
        public int AppointmentsToday { get; set; }

      
        


    }
}
