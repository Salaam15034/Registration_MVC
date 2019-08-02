using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login_Registration.Models
{
     public class Register
     {
          public int Id { get; set; }
          [Display(Name = "First Name")]
          [MaxLength(50,ErrorMessage = "First Name should not exceed 50 character")]
          [Required(ErrorMessage = "FirstName is required")]
          public string FirstName { get; set; }
          [Display(Name = "Last Name")]
          [MaxLength(50, ErrorMessage = "Last Name should not exceed 50 character")]
          [Required(ErrorMessage = "LastName is required")]
          public string LastName { get; set; }

          [Display(Name = "Email")]
          [MaxLength(50, ErrorMessage = "Email should not exceed 50 character")]
          [Required(ErrorMessage = "Email is required")]
          [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
          public string Email { get; set; }

          [Display(Name = "Contact Number")]
          [RegularExpression(@"^(\d{10})$", ErrorMessage = "InCorrect ContactNumber")]
          [Required(ErrorMessage = "ContactNumber is required")]
          public string ContactNumber { get; set; }
          [MinLength(6,ErrorMessage ="Password should not be less than 6 character")]
          [Required(ErrorMessage = "Password is required")]
          [DataType(DataType.Password)]
          public string Password { get; set; }

          [DataType(DataType.Password)]
          [Display(Name = "Confirm Password")]
          [Required(ErrorMessage = "ConfirmPassword is required")]
          [MinLength(6, ErrorMessage = "Password should not be less than 6 character")]
          [Compare("Password", ErrorMessage = "Password and confirm password do not match")]
          public string ConfirmPassword { get; set; }
     }
}