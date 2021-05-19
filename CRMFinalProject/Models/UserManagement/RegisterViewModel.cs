using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CooperativeFuneralFundInc.Models.UserManagement
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }


        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }


        [Required]
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }


        [Required]
        [Display(Name = "Number Type")]
        public string numberType { get; set; }


    }
}