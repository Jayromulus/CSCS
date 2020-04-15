using DND5ECharacterSheet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Models
{
    public class WeaponCreate
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int WeightInPounds { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int CostInCurrency { get; set; }

        [Required]
        [Display(Name = "Currency")]
        public int CurrencyEnumIndex { get; set; }

        [Required]
        public int DamageDieAmount { get; set; }

        [Required]
        public int DamageDieSize { get; set; }

        [Required]
        public int DamageTypeEnumIndex { get; set; }

        [Required]
        public bool IsMartialWeapon { get; set; }

        [Required]
        public bool IsMeleeWeapon { get; set; }

        [Required]
        public string Properties { get; set; }
    }
    public class WeaponEdit
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int WeightInPounds { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int CostInCurrency { get; set; }

        [Required]
        [Display(Name = "Currency")]
        public int CurrencyEnumIndex { get; set; }

        [Required]
        public int DamageDieAmount { get; set; }

        [Required]
        public int DamageDieSize { get; set; }

        [Required]
        public DamageTypes DamageType { get; set; }

        [Required]
        public bool IsMartialWeapon { get; set; }

        [Required]
        public bool IsMeleeWeapon { get; set; }

        [Required]
        public string Properties { get; set; }
    }
    public class WeaponDetails
    {
        public int WeaponId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int WeightInPounds { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int CostInCurrency { get; set; }

        [Required]
        [Display(Name = "Currency")]
        public Currency CurrencyRequired { get; set; }

        [Required]
        public int DamageDieAmount { get; set; }

        [Required]
        public int DamageDieSize { get; set; }

        [Required]
        public DamageTypes DamageType { get; set; }

        [Required]
        public bool IsMartialWeapon { get; set; }

        [Required]
        public bool IsMeleeWeapon { get; set; }

        [Required]
        public string Properties { get; set; }
    }
    public class WeaponListItem
    {
        public int WeaponId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int CostInCurrency { get; set; }

        [Required]
        [Display(Name = "Currency")]
        public Currency CurrencyRequired { get; set; }

        [Required]
        public bool IsMartialWeapon { get; set; }

        [Required]
        public bool IsMeleeWeapon { get; set; }
    }
}
