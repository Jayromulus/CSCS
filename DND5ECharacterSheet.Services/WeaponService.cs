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
    public class WeaponService
    {
        private readonly ApplicationDbContext _context;
        private readonly string _userId;

        public WeaponService(string userId)
        {
            _context = new ApplicationDbContext();
            _userId = userId;
        }

        // CREATE
        public async Task<bool> CreateWeaponAsync(WeaponCreate model)
        {
            Weapon entity = new Weapon(model.Name, model.WeightInPounds, model.CostInCurrency, model.CurrencyEnumIndex, model.DamageDieAmount, model.DamageDieSize, model.DamageTypeEnumIndex, model.IsMartialWeapon, model.IsMeleeWeapon, model.Properties);
            _context.Weapons.Add(entity);
            return await _context.SaveChangesAsync() == 1;
        }

        // READ
        public async Task<List<WeaponListItem>> GetAllWeaponsAsync()
        {
            var entityList = await _context.Weapons.ToListAsync();

            var WeaponList = entityList.Select(myArm => new WeaponListItem()
            {
                WeaponId = myArm.Id,
                Name = myArm.Name,
                CostInCurrency = myArm.CostInCurrency,
                CurrencyRequired = myArm.CurrencyRequired,
                IsMartialWeapon = myArm.IsMartialWeapon,
                IsMeleeWeapon = myArm.IsMeleeWeapon,
            }).ToList();

            return WeaponList;
        }

        public WeaponDetails GetSingleWeapon(int? id)
        {
            var entity = _context.Weapons.Single(e => e.Id == id);

            if (entity != null)
            {
                return new WeaponDetails()
                {
                    WeaponId = entity.Id,
                    Name = entity.Name,
                    WeightInPounds = entity.WeightInPounds,
                    CostInCurrency = entity.CostInCurrency,
                    CurrencyRequired = entity.CurrencyRequired,
                    IsMartialWeapon = entity.IsMartialWeapon,
                    IsMeleeWeapon = entity.IsMeleeWeapon,
                    DamageDieAmount = entity.DamageDieAmount,
                    DamageDieSize = entity.DamageDieSize,
                    DamageType = entity.DamageType,
                    Properties = entity.Properties
                };
            }
            return null;
        }

        // UPDATE
        public async Task<bool> UpdateWeaponAsync(WeaponEdit model)
        {
            if (_context.Weapons.Count(e => e.Id == model.Id) != 0)
            {
                var entity = _context.Weapons.Single(Weapon => Weapon.Id == model.Id);
                if (entity != null)
                {
                    entity.Name = model.Name;
                    entity.WeightInPounds = model.WeightInPounds;
                    entity.CostInCurrency = model.CostInCurrency;
                    entity.CurrencyRequired = (Currency)model.CurrencyEnumIndex;
                    entity.IsMartialWeapon = model.IsMartialWeapon;
                    entity.IsMeleeWeapon = model.IsMeleeWeapon;
                    entity.DamageDieAmount = model.DamageDieAmount;
                    entity.DamageDieSize = model.DamageDieSize;
                    entity.DamageType = model.DamageType;

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
        public async Task<bool> DeleteWeaponAsync(int? id)
        {
            var entity = _context.Weapons.Single(e => e.Id == id);

            if (entity != null)
            {
                _context.Weapons.Remove(entity);
                return await _context.SaveChangesAsync() == 1;
            }
            return false;
        }
    }
}
