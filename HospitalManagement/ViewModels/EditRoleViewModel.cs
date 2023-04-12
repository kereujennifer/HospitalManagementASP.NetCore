namespace HospitalManagement.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel() 
        {
            Users = new List<string>();
        }
        public string? Id { get; set;}
        public string? RoleName { get; set;}
        public List<string>? Users { get; set;}  
    }
}
