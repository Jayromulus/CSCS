using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Data.Items
{
    public enum WeaponCategories { SimpleMelee, SimpleRanged, MartialMelee, MartialRanged }
    public enum DamageTypes { Bludgeoning, Piercing, Slashing }

    public class Weapon : Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public WeaponCategories WeaponCategory { get; set; }
        
        [Required]
        public int DamageDieSize { get; set; }

        [Required]
        public int DamageDieCount { get; set; }

        [Required]
        public DamageTypes DamageType { get; set; }
        
        [Required]
        public int WeightInPounds { get; set; }
        
        public string Properties { get; set; }
    }
}
