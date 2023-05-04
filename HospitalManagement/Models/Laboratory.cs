using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Models
{
    public class Laboratory : HospitalMngt
    {

        public string? TestPerformed { get; set; }
        public string? TestPerformedBy { get; set; }
        public string? Report { get; set; }
        public string? Test { get; set; }
        public string? TestType { get; set; }
        public string? Equipment { get; set; }
        public IdentityUser? Patient { get; set; }
    }
}
