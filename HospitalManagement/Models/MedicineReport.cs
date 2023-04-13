namespace HospitalManagement.Models
{
    public class MedicineReport
    {
        public int Id { get; set; }

        public Supplier? Supplier { get; set; }
        public Medicine? Medicine { get; set; }
        public string? Company { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }

    }
}
