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
    public class ArmourService
    {
        private readonly ApplicationDbContext _context;
        private readonly string _userId;

        public ArmourService(string userId)
        {
            _context = new ApplicationDbContext();
            _userId = userId;
        }

        // CREATE
        public async Task<bool> CreateArmourAsync(ArmourCreate model)
        {
            Armour entity = new Armour(model.Name, model.WeightInPounds, model.CostInCurrency, model.CurrencyEnumIndex, model.ArmourClass, model.MaxDexMod, model.MinStrength, model.StealthDisadvantage, model.ArmourType);
            _context.Armours.Add(entity);
            return await _context.SaveChangesAsync() == 1;
        }

        // READ
        public async Task<List<ArmourListItem>> GetAllArmoursAsync()
        {
            var entityList = await _context.Armours.ToListAsync();

            var armourList = entityList.Select(myArm => new ArmourListItem()
            {
                ArmourId = myArm.Id,
                Name = myArm.Name,
                CostInCurrency = myArm.CostInCurrency,
                CurrencyRequired = myArm.CurrencyRequired,
                ArmourType = myArm.ArmourType
            }).ToList();

            return armourList;
        }

        public ArmourDetails GetSingleArmour(int? id)
        {
            var entity = _context.Armours.Single(e => e.Id == id);

            if (entity != null)
            {
                return new ArmourDetails()
                {
                    Name = entity.Name,
                    WeightInPounds = entity.WeightInPounds,
                    CostInCurrency = entity.CostInCurrency,
                    CurrencyRequired = entity.CurrencyRequired,
                    ArmourClass = entity.ArmourClass,
                    MaxDexMod = entity.MaxDexMod,
                    MinStrength = entity.MinStrength,
                    StealthDisadvantage = entity.StealthDisadvantage,
                    ArmourType = entity.ArmourType
                };
            }
            return null;
        }

        // UPDATE
        public async Task<bool> UpdateArmourAsync(ArmourEdit model)
        {
            if (_context.Armours.Count(e => e.Id == model.Id) != 0)
            {
                var entity = _context.Armours.Single(armour => armour.Id == model.Id);
                if (entity != null)
                {
                    entity.Name = model.Name;
                    entity.WeightInPounds = model.WeightInPounds;
                    entity.CostInCurrency = model.CostInCurrency;
                    entity.CurrencyRequired = (Currency)model.CurrencyEnumIndex;
                    entity.ArmourClass = model.ArmourClass;
                    entity.MaxDexMod = model.MaxDexMod;
                    entity.MinStrength = model.MinStrength;
                    entity.StealthDisadvantage = model.StealthDisadvantage;
                    entity.ArmourType = model.ArmourType;

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
        public async Task<bool> DeleteArmourAsync(int? id)
        {
            var entity = _context.Armours.Single(e => e.Id == id);

            if (entity != null)
            {
                _context.Armours.Remove(entity);
                return await _context.SaveChangesAsync() == 1;
            }

            return false;
        }
    }
}
