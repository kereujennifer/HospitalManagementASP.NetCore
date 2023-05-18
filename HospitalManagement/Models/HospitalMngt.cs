using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Models
{
    public class HospitalMngt 
    {
        public int Id { get; set; }
        public string? Wards { get; set; }
        public string? Beds { get; set; }
        public string? WardCategory { get; set; }
        public string? Floors { get; set; }
        public string? Department { get; set; }
        public bool IsOccupied { get; set; }

        
        public string? Stations { get; set; }
    }
}
