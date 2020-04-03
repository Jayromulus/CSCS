using DND5ECharacterSheet.Data;
using DND5ECharacterSheet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Services
{
    public class CharacterService
    {
        private readonly ApplicationDbContext _context;
        private readonly string _userId;

        public CharacterService(string userId)
        {
            _context = new ApplicationDbContext();
            _userId = userId;
        }

        // CREATE
        public async Task<bool> CreateCharacterAsync(CharacterCreate model)
        {
            Character entity = new Character(_userId, model.CharacterName, model.ClassId, model.RaceId, model.Experience, model.Inspiration, model.MaxHP);
            _context.Characters.Add(entity);
            return await _context.SaveChangesAsync() == 1;
        }

        // GET ALL
        public async Task<List<CharacterListItem>> GetAllCharactersAsync()
        {
            var entityList = await _context.Characters.ToListAsync();
            // .Where(entity => entity.User.Id == _userId)
            var characterList = entityList.Select(myChar => new CharacterListItem()
            {
                CharacterId = myChar.Id,
                CharacterName = myChar.CharacterName,
                ClassName = myChar.Class.ClassName,
                RaceName = myChar.Race.RaceName,
                Level = myChar.Level
            }).ToList();

            return characterList;
        }

        // GET FULL CHARACTER
        public Character GetCharacterFromContext(int id)
        {
            Character entity = _context.Characters.Find(id);
            return entity;
        }

        // GET ONE BY ID
        public CharacterDetail GetSingleCharacter(int? id)
        {
            var entity = _context.Characters.Single(e => e.Id == id);

            if (entity != null)
            {
                return new CharacterDetail()
                {
                    Id = entity.Id,
                    User = entity.User,
                    AddedBy = entity.User.UserName,
                    CharacterName = entity.CharacterName,
                    ClassId = entity.ClassId,
                    Class = entity.Class,
                    RaceId = entity.RaceId,
                    Race = entity.Race,
                    Level = entity.Level,
                    ExperiencePoints = entity.ExperiencePoints,
                    Inspiration = entity.Inspiration,
                    MaxHP = entity.MaxHitPoints,
                    CurrentHitPoints = entity.CurrentHitPoints,
                    TemporaryHitPoints = entity.TemporaryHitPoints
                };
            }

            return null;
        }

        // UPDATE
        public async Task<bool> EditCharacterAsync(CharacterEdit model)
        {
            if (_context.Characters.Count(e => e.Id == model.Id) != 0)
            {
                var entity = _context.Characters.Single(myChar => myChar.Id == model.Id);
                if (entity != null)
                {

                    entity.CharacterName = model.CharacterName;
                    entity.ClassId = model.ClassId;
                    entity.RaceId = model.RaceId;
                    entity.ExperiencePoints = model.ExperiencePoints;
                    entity.Inspiration = model.Inspiration;
                    entity.CurrentHitPoints = model.CurrentHitPoints;
                    entity.TemporaryHitPoints = model.TemporaryHitPoints;

                    if (await _context.SaveChangesAsync() == 1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        // DELETE
        public async Task<bool> DeleteCharacterAsync(int? id)
        {
            var entity = _context.Characters.Single(e => e.Id == id);

            if (entity != null)
            {
                _context.Characters.Remove(entity);
                return await _context.SaveChangesAsync() == 1;
            }

            return false;
        }
    }
}
