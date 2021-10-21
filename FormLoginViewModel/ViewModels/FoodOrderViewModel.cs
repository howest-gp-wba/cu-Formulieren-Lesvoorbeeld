using FormLoginViewModel.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormLoginViewModel.ViewModels
{
    public class FoodOrderViewModel
    {

        [Required(ErrorMessage = "We need your firstname!")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "We need your lastname!")]
        public string Lastname { get; set; }
        [DisplayName("Your email:")]
        [Required(ErrorMessage = "We need your email!")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Please provide a valid Email address")]
        public string Email { get; set; }

        [DisplayName("Pick your food:")]
        public int SelectedItem { get; set; }
        public List<SelectListItem> Items { get; set; }
        public List<CheckboxModel> Sauces { get; set; }
    }
}
