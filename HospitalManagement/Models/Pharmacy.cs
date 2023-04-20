using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Pharmacy : HospitalMngt
    {
        public String? MedicineName { get; set; }
        public int Batch { get; set; }
        public string? Manufacturer { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ExpiryDate { get; set; }
        public int Stock { get; set; }
    
        public String? Supplier { get; set; }
        public int UnitPrice { get; set; }
        public int Total { get; set; }
       
        public ICollection<MedicineReport>? MedicineReport { get; set; }


    }
}
