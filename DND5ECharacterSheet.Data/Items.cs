using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Data
{
    public enum Currency { Copper = 1, Silver, Electrum, Gold, Platinum }

    public abstract class Item
    {
        public Item() { }
        public Item(string name, int weight, int cost, int currency)
        {
            Name = name;
            WeightInPounds = weight;
            CostInCurrency = cost;
            CurrencyRequired = (Currency)currency;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int WeightInPounds { get; set; }
        public int CostInCurrency { get; set; }
        public Currency CurrencyRequired { get; set; }
    }

    public class Armour : Item
    {
        public Armour() { }
        public Armour(string name, int weight, int cost, int currency, int ac, int? maxdex, int? minstr, bool stealth, string type) : base(name, weight, cost, currency)
        {
            ArmourClass = ac;
            MaxDexMod = maxdex;
            MinStrength = minstr;
            StealthDisadvantage = stealth;
            ArmourType = type;
        }
        public int ArmourClass { get; set; }
        public int? MaxDexMod { get; set; }
        public int? MinStrength { get; set; }
        public bool StealthDisadvantage { get; set; }
        public string ArmourType { get; set; }
    }

    public enum DamageTypes { Bludgeoning = 1, Piercing, Slashing}

    public class Weapon : Item
    {
        public Weapon() { }
        public Weapon(string name, int weight, int cost, int currency, int dda, int dds, int dtype, bool martial, bool melee, string properties) : base(name, weight, cost, currency)
        {
            DamageDieAmount = dda;
            DamageDieSize = dds;
            DamageType = (DamageTypes)dtype;
            IsMartialWeapon = martial;
            IsMeleeWeapon = melee;
            Properties = properties;
        }

        public int DamageDieAmount { get; set; }
        public int DamageDieSize { get; set; }
        public DamageTypes DamageType { get; set; }
        public bool IsMartialWeapon { get; set; } // ASSUMES SIMPLE IF NOT MARTIAL
        public bool IsMeleeWeapon { get; set; } // ASSUMES RANGED IF NOT MELEE
        public string Properties { get; set; }
    }

}
