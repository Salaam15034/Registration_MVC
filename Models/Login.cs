﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login_Registration.Models
{
     public class Login
     {
          [Required(ErrorMessage ="UserName is required")]
          [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
          public string UserName { get; set; }
          [Required(ErrorMessage = "Password is required")]
          [DataType(DataType.Password)]
          public string Password { get; set; }
     }
}