using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CooperativeFuneralFundInc.Models.UserManagement;
using Microsoft.AspNetCore.Identity;

namespace CooperativeFuneralFundInc.Areas.Admin.Models
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
