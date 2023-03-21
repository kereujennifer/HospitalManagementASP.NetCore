namespace CrudOperations.ViewModels
{
    public class UpdateEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Department { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
