using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Data.Items
{
    class Armour : Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ArmourClass { get; set; }
        
        public int? MaxDexMod { get; set; }
        
        public int? MinStrength { get; set; }

        [Required]
        public bool StealthDisadvantage { get; set; }

        [Required]
        public int WeightInPounds { get; set; }
    }
}
