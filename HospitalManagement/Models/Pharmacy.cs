namespace HospitalManagement.Models
{
    public class Pharmacy : HospitalMngt
    {
        public Medicine? MedicineName { get; set; }
        public int Batch { get; set; }
        public string? Manufacturer { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int Stock { get; set; }
        public string? MedicinePrescription { get; set; }
        public Patients? PatientName { get; set; }
        public Doctors? Doctor { get; set; }
        public DateTime? DateDispendsed { get; set; }
        public Supplier? Supplier { get; set; }
        public int UnitPrice { get; set; }
        public int Total { get; set; }
       
        public ICollection<MedicineReport>? MedicineReport { get; set; }

    }
}
