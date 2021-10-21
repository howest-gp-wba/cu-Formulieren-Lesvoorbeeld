using FormLoginViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormLoginViewModel.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            //declare viewmodel
            AccountLoginViewModel accountLoginViewModel
                = new AccountLoginViewModel();
            accountLoginViewModel.RememberMe = true;
            return View(accountLoginViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult 
            Login(AccountLoginViewModel accountLoginViewModel)
        {
            //check and validate
            //process data
            //redirect
            //Post-Get-Redirect Pattern
            return RedirectToAction("Admin","Account");
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}
