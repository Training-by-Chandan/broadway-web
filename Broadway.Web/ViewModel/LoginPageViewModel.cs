using System;
using System.ComponentModel.DataAnnotations;

namespace Broadway.Web.ViewModel
{
    public class LoginPageViewModel
    {
        [Display(Name = "Email Address", GroupName = "One")]
        [Required(ErrorMessage = "Username is required here.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "This must be email.")]
        public string Email { get; set; }

        [Display(Name = "Phone Number", GroupName = "Two")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10, MinimumLength = 10)]
        [Range(9800000000, 9899999999)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Date of Birth", GroupName = "One")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "Password", GroupName = "One")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Display(Name = "Remember me", GroupName = "Two")]
        public bool RememberMe { get; set; }
    }
}