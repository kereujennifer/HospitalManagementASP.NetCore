using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Models
{
    public class Appointment
    {
public int Id { get; set; }
        public string? Number { get; set; }
        public string? Type { get; set; }

        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public List<Patients>? Patient { get; set; }
        public List<Doctors>? Doctor { get; set; }



    }
}
