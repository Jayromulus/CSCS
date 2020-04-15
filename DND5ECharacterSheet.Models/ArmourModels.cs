using DND5ECharacterSheet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Models
{
    public class ArmourCreate
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
        public int ArmourClass { get; set; }

        [Required]
        public int? MaxDexMod { get; set; }

        [Required]
        public int? MinStrength { get; set; }

        [Required]
        public bool StealthDisadvantage { get; set; }

        [Required]
        public string ArmourType { get; set; }
    }

    public class ArmourEdit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int WeightInPounds { get; set; }

        [Display(Name = "Cost")]
        public int CostInCurrency { get; set; }

        [Display(Name = "Currency")]
        public int CurrencyEnumIndex { get; set; }

        public int ArmourClass { get; set; }

        public int? MaxDexMod { get; set; }

        public int? MinStrength { get; set; }

        public bool StealthDisadvantage { get; set; }

        public string ArmourType { get; set; }
    }

    public class ArmourDetails
    {
        public int ArmourId { get; set; }
        public string Name { get; set; }

        public int WeightInPounds { get; set; }

        [Display(Name = "Cost")]
        public int CostInCurrency { get; set; }

        [Display(Name = "Currency")]
        public Currency CurrencyRequired { get; set; }

        public int ArmourClass { get; set; }

        public int? MaxDexMod { get; set; }

        public int? MinStrength { get; set; }

        public bool StealthDisadvantage { get; set; }

        public string ArmourType { get; set; }
    }

    public class ArmourListItem
    {
        public int ArmourId { get; set; }
        public string Name { get; set; }

        [Display(Name = "Cost")]
        public int CostInCurrency { get; set; }

        [Display(Name = "Currency")]
        public Currency CurrencyRequired { get; set; }

        public string ArmourType { get; set; }
    }
}
