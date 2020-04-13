using DND5ECharacterSheet.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DND5ECharacterSheet.MVC.Controllers
{
    public class ArmourController : Controller
    {
        // GET: Armour
        public async Task<ActionResult> Index()
        {
            var service = GetArmourService();
            return View(await service.GetAllArmoursAsync());
        }


        // SERVICE
        private ArmourService GetArmourService()
        {
            var userId = User.Identity.GetUserId();
            var service = new ArmourService(userId);
            return service;
        }
    }
}