using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.ViewModels
{
    public class CreateRoleViewModel
    {
        [Display(Name = "Role")]
        public string? RoleName { get; set; }
    }
}
