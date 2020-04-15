using DND5ECharacterSheet.Models;
using DND5ECharacterSheet.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        //GET: Armour/Create
        public ActionResult Create()
        {
            var service = GetArmourService();

            // possibly dropdown list of the potential armour types

            return View();
        }

        // POST: Armour/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ArmourCreate model){
            if (ModelState.IsValid)
            {
                var service = GetArmourService();
                if(await service.CreateArmourAsync(model))
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }

        // GET: Armuor/Edit/{id}
        public ActionResult Edit(int? id)
        {
            var service = GetArmourService();
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var single = service.GetSingleArmour(id);
            ArmourEdit armour = new ArmourEdit()
            {
                ArmourClass = single.ArmourClass,
                ArmourType = single.ArmourType,
                CostInCurrency = single.CostInCurrency,
                CurrencyEnumIndex = (int)single.CurrencyRequired,
                MaxDexMod = single.MaxDexMod,
                MinStrength = single.MinStrength,
                Name = single.Name,
                StealthDisadvantage = single.StealthDisadvantage,
                WeightInPounds = single.WeightInPounds
            };

            if (armour == null)
                return HttpNotFound();

            return View(armour);
        }

        //POST: Armour/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ArmourEdit model)
        {
            if (ModelState.IsValid)
            {
                var service = GetArmourService();
                if (await service.UpdateArmourAsync(model))
                    return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        //GET: Armour/Details/{id}
        public ActionResult Details(int? id)
        {
            var service = GetArmourService();
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ArmourDetails armour = service.GetSingleArmour(id);

            if (armour == null)
                return HttpNotFound();

            return View(armour);
        }

        //GET: Armour/Delete/{id}
        public ActionResult Delete(int? id)
        {
            var service = GetArmourService();
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            ArmourDetails armour = service.GetSingleArmour(id);
            if (armour == null)
                return HttpNotFound();
            return View(armour);
        }

        //POST: Armour/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var service = GetArmourService();
            _ = service.DeleteArmourAsync(id);
            return RedirectToAction("Index");
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