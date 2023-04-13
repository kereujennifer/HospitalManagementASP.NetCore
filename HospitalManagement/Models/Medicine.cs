namespace HospitalManagement.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Cost { get; set; }
        public string? Description { get; set; }
        public ICollection<MedicineReport>? MedicineReport { get; set; }



    }
}
