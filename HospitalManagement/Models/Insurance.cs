namespace HospitalManagement.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string? PolicyNumber{ get; set; }
        public ICollection<Bill>? Bill { get; set; }
    }
}
