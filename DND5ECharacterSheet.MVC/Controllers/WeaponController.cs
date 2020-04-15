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
    public class WeaponController : Controller
    {
        // GET: Weapon
        public async Task<ActionResult> Index()
        {
            var service = GetArmourService();
            return View(await service.GetAllWeaponsAsync());
        }

        //GET: Weapon/Create
        public ActionResult Create()
        {
            var service = GetArmourService();

            // possibly dropdown list of the potential armour types

            return View();
        }

        // POST: Weapon/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(WeaponCreate model)
        {
            if (ModelState.IsValid)
            {
                var service = GetArmourService();
                if (await service.CreateWeaponAsync(model))
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }

        // GET: Weapon/Edit/{id}
        public ActionResult Edit(int? id)
        {
            var service = GetArmourService();
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var single = service.GetSingleWeapon(id);
            WeaponEdit weapon = new WeaponEdit()
            {
                Name = single.Name,
                WeightInPounds = single.WeightInPounds,
                CostInCurrency = single.CostInCurrency,
                CurrencyEnumIndex = (int)single.CurrencyRequired,
                IsMartialWeapon = single.IsMartialWeapon,
                IsMeleeWeapon = single.IsMeleeWeapon,
                DamageDieAmount = single.DamageDieAmount,
                DamageDieSize = single.DamageDieSize,
                DamageType = single.DamageType
            };

            if (weapon == null) 
                return HttpNotFound();

            return View(weapon);
        }

        //POST: Weapon/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(WeaponEdit model)
        {
            if (ModelState.IsValid)
            {
                var service = GetArmourService();
                if (await service.UpdateWeaponAsync(model))
                    return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        //GET: Weapon/Details/{id}
        public ActionResult Details(int? id)
        {
            var service = GetArmourService();
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            WeaponDetails armour = service.GetSingleWeapon(id);

            if (armour == null)
                return HttpNotFound();

            return View(armour);
        }

        //GET: Weapon/Delete/{id}
        public ActionResult Delete(int? id)
        {
            var service = GetArmourService();
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            WeaponDetails armour = service.GetSingleWeapon(id);
            if (armour == null)
                return HttpNotFound();
            return View(armour);
        }

        //POST: Weapon/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var service = GetArmourService();
            _ = service.DeleteWeaponAsync(id);
            return RedirectToAction("Index");
        }

        // SERVICE
        private WeaponService GetArmourService()
        {
            var userId = User.Identity.GetUserId();
            var service = new WeaponService(userId);
            return service;
        }
    }
}