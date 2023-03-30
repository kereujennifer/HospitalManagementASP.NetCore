namespace HospitalManagement.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel() 
        {
            Users = new List<string>();
        }
        public int Id { get; set;}
        public string? RoleName { get; set;}
        public List<string>? Users { get; set;}  
    }
}
