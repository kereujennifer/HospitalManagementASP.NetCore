using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UserManagement.ViewModels
{
    public class ResetViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Register email address")]
        public string? Email { get; set; }
       public bool EmailSent { get; set; }
      
    }
}
