using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CooperativeFuneralFundInc.Models.UserManagement
{
    public class User:IdentityUser
    {
        // Inherits all IdentityUser properties
        [NotMapped]
        public IList<string> RoleNames { get; set; }

        
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        

        

        [Required]
        [Display(Name = "Number Type")]
        public string numberType { get; set; }

    }
}
