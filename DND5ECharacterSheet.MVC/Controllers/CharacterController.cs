using DND5ECharacterSheet.Data;
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
    public class CharacterController : Controller
    {
        // GET: Character
        public async Task<ActionResult> Index()
        {
            var service = GetCharacterService();
            return View(await service.GetAllCharactersAsync());
        }

        //GET: Character/Create
        public ActionResult Create()
        {
            var service = GetCharacterService();
            var raceList = new SelectList(service.GetRaceNames(), "RaceId", "RaceName");
            var classList = new SelectList(service.GetClassNames(), "ClassId", "ClassName");

            ViewBag.RaceId = raceList;
            ViewBag.ClassId = classList;
            return View();
        }

        // POST: Character/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CharacterCreate model)
        {
            if (ModelState.IsValid)
            {
                var service = GetCharacterService();
                if (await service.CreateCharacterAsync(model))
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }

        // GET: Character/Edit/{id}
        public ActionResult Edit(int? id)
        {
            var service = GetCharacterService();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var single = service.GetSingleCharacter(id);
            CharacterEdit character = new CharacterEdit()
            {
                Id = single.Id,
                User = single.User,
                CharacterName = single.CharacterName,
                ClassId = single.ClassId,
                RaceId = single.RaceId,
                ExperiencePoints = single.ExperiencePoints,
                Inspiration = single.Inspiration,
                CurrentHitPoints = single.CurrentHitPoints,
                TemporaryHitPoints = single.TemporaryHitPoints
            };

            if (character == null)
            {
                return HttpNotFound();
            }

            var raceList = new SelectList(service.GetRaceNames(), "RaceId", "RaceName");
            var classList = new SelectList(service.GetClassNames(), "ClassId", "ClassName");

            ViewBag.RaceId = raceList;
            ViewBag.ClassId = classList;
            return View(character);
        }

        // POST: Character/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CharacterEdit model)
        {
            if (ModelState.IsValid)
            {
                var service = GetCharacterService();
                if (await service.EditCharacterAsync(model))
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }

        // GET: Character/Details/{id}
        public ActionResult Details(int? id)
        {
            var service = GetCharacterService();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharacterDetail character = service.GetSingleCharacter(id);
            

            if (character == null)
            {
                return HttpNotFound();
            }

            return View(character);
        }

        //GET: Character/Delete/{id}
        public ActionResult Delete(int? id)
        {
            var service = GetCharacterService();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharacterDetail character = service.GetSingleCharacter(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        //POST: Restaurant/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var service = GetCharacterService();

            _ = service.DeleteCharacterAsync(id);
            return RedirectToAction("Index");
        }

        // SERVICE
        private CharacterService GetCharacterService()
        {
            var userId = User.Identity.GetUserId();
            var service = new CharacterService(userId);
            return service;
        }
    }
}