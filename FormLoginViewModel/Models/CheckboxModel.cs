using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormLoginViewModel.Models
{
    public class CheckboxModel
    {
        public bool IsSelected { get; set; }
        [HiddenInput]
        public string Name { get; set; }
        [HiddenInput]
        public int Id { get; set; }
    }
}
