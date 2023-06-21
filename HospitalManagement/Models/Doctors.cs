using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class Doctors 
    {
        [Key]
        public int DoctorId { get; set; }
       

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime StartShift { get; set; }
        public string? NightShift { get; set; }
        public string? DayShift { get; set; }
        public DateTime EndShift { get; set; }
        public string? Speciality { get; set; }
        public string DepartmentName { get;  set; }

        public List<Department>? Department { get; set; }


    }
}
