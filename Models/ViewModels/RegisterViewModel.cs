using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExp2.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression("([0-9])", ErrorMessage = "Só pode Conter números")]
        public string TelephoneNumber { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme password")]
        [Compare("Password", ErrorMessage = "As password de confirmação não é igual")]
        public string ConfirmPassword { get; set; }
       
        [NotMapped]
        [Display(Name = "Role")]
        public string RoleId { get; set; }

        [NotMapped]
        public string RoleName { get; set; }

       // [NotMapped]
       // public IEnumerable<SelectListItem> RoleList { get; set; }

    }
}

