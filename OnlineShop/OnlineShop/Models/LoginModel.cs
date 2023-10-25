using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Username")]
        [Required(ErrorMessage ="Username is required!")]
        public string UserName { set; get; }
        [Required(ErrorMessage ="Username is required!")]
        public string Password { set; get; }
    }
}