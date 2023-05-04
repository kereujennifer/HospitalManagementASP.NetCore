namespace HospitalManagement.Models
{
    public class Nurse
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime StartShift { get; set; }
        public string? NightShift { get; set; }
        public string? DayShift { get; set; }
        public DateTime EndShift { get; set; }
        public List<Patients>? Patients { get; set; }


    }
}
