using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class LoginViewModel
    {
        [Key]
        [Required(ErrorMessage = "User ID is required")]
        [Display(Name = "Enter User ID")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Enter Password")]
        public string Pwd { get; set; }
    }
}