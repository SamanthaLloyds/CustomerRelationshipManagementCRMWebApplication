using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using CooperativeFuneralFundInc.Models;
using CooperativeFuneralFundInc.Models.SupplyRequest;
using CooperativeFuneralFundInc.Models.TasksManagement;
using CooperativeFuneralFundInc.Models.UserManagement;
using CooperativeFuneralFundInc.Areas.Admin.Models;

namespace CooperativeFuneralFundInc.Areas.Admin.Controllers
{

    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

     
    }
}
