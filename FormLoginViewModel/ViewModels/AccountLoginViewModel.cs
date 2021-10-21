using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormLoginViewModel.ViewModels
{
    public class AccountLoginViewModel
    {
        [Display(Name = "Emailadres")]
        public string Email { get; set; }
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }
        
        [DisplayName("Onthouden")]
        public bool RememberMe { get; set; }
    }
}
