using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AcmeSystem.Presentation.ClientWeb.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nom d'utilisateur")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Display(Name = "Se souvenir du mot de passe ?")]
        public bool RememberMe { get; set; }
    }
}
