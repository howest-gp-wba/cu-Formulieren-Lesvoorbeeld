using FormLoginViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormLoginViewModel.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UsersRegisterViewModel usersRegisterViewModel)
        {
            if (usersRegisterViewModel.Password == usersRegisterViewModel.PasswordCompare)
            {
                return RedirectToAction("RegistrationSuccess"); 
            }
            else
            {
                ViewBag.Error = "Passwords do not match";
                return View(usersRegisterViewModel);
            }
        }
        [HttpGet]
        public IActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}
