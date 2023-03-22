using System.ComponentModel.DataAnnotations;

namespace UserManagement.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel() 
        {
            Roles = new List<string>();
        }
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public IList<string> Roles { get; set; }
    
    }
}
