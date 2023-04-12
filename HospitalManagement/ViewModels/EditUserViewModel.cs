using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Roles = new List<string>();
        }

        public string Id { get; set; }

       
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        
        public IList<string> Roles { get; set; }
    }
}
