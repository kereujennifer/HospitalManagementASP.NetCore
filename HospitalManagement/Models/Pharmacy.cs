namespace HospitalManagement.Models
{
    public class Pharmacy : HospitalMngt
    {
        public int MedicineId { get; set; }
        public string? MedicineName { get; set; }
        public string? MedicinePrescription { get; set; }
    }
}
