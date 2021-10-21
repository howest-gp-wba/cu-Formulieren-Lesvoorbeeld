using FormLoginViewModel.Models;
using FormLoginViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormLoginViewModel.Controllers
{
    public class FoodController : Controller
    {
        [HttpGet]
        public IActionResult Order()
        {
            //instantiate viewmodel
            FoodOrderViewModel foodOrderViewModel
                = new();

            //fill the list
            foodOrderViewModel.Items =
                new List<SelectListItem>
                { 
                    new SelectListItem{Value="",Text=""},
                    new SelectListItem{Value = "1",Text="Spaghetti Carbonara" },
                    new SelectListItem{Value = "2",Text="Spaghetti Puttanesca" },
                    new SelectListItem{Value = "3",Text="Spaghetti alle vongole" },
                };
            //fill the sauces
            foodOrderViewModel.Sauces = new List<CheckboxModel>
            {
                new CheckboxModel{Id=1,Name = "Mayo"},
                new CheckboxModel{Id=1,Name = "AppleSauce"},
                new CheckboxModel{Id=1,Name = "Host sauce"}
            };
            //send to the view
            return View(foodOrderViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Order(FoodOrderViewModel foodOrderViewModel)
        {
            //custom validation
            //check if food is empty
            if(foodOrderViewModel.SelectedItem == 0)
            {
                //add a custom errormessage to ModelState
                ModelState.AddModelError("SelectedItem", "Please select a type of food");
            }
            if(!ModelState.IsValid)
            {
                foodOrderViewModel.Items =
                new List<SelectListItem>
                {
                    new SelectListItem{Value="",Text=""},
                    new SelectListItem{Value = "1",Text="Spaghetti Carbonara" },
                    new SelectListItem{Value = "2",Text="Spaghetti Puttanesca" },
                    new SelectListItem{Value = "3",Text="Spaghetti alle vongole" },
                };
                return View(foodOrderViewModel);
            }
            //if all is validated, redirect
            return RedirectToAction("Index","Home");
        }
    }
}
