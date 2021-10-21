using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormLoginViewModel.ViewModels
{
    public class UsersRegisterViewModel
    {
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string PasswordCompare { get; set; }
    }
}
