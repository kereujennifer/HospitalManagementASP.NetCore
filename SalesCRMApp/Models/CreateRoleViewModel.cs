using System.ComponentModel.DataAnnotations;

namespace SalesCRMApp.Models
{
    public class CreateRoleViewModel
    {
        [Display(Name = "Role")]
        public string? RoleName { get; set; }
    }
}
