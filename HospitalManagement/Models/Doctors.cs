namespace HospitalManagement.Models
{
    public class Doctors : HospitalMngt
    {

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

        public int DepartmentId { get; set; }

        // Navigation property
        public Department Department { get; set; }
    }
}
