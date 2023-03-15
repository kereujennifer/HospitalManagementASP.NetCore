
using System.ComponentModel.DataAnnotations;

namespace UserManagement.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name ="Role")]
        public string? RoleName{ get; set; }
    }
}
