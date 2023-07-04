namespace HospitalManagement.Models
{
    public class Staff
    {
        public int StaffId { get; set; }

        public int DepartmentId { get; set; } // Foreign key
        public Department Department { get; set; } // Navigation property
        public string? Name { get; set; }
        public string? StaffType { get; set; }
    }

}
