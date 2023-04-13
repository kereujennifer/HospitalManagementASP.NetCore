using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int BillNumber { get; set; }
        public IdentityUser? Patient { get;set; }
        public Insurance? Insurance { get; set; }    
        public int DoctorCharge { get;set; }
        public int MedicineCharge { get; set; }
        public int LabaratoryCharge { get; set; }
        public decimal TotalBill { get; set; }
    }
}
