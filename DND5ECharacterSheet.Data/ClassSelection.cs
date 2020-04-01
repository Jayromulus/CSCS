using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Data
{
    public class ClassSelection
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ClassName { get; set; }

        [Required]
        public int HitDieSize { get; set; }

        [Required]
        public string ClassSkills { get; set; }

        [Required]
        public ClassProficiencies Proficiencies { get; set; }
    }

    public class ClassProficiencies
    {
        public bool StrengthSave { get; set; }
        public bool DexteritySave { get; set; }
        public bool ConstitutionSave { get; set; }
        public bool IntelligenceSave { get; set; }
        public bool WisdomSave { get; set; }
        public bool CharismaSave { get; set; }

        public bool LightArmour { get; set; }
        public bool MediumArmour { get; set; }
        public bool HeavyArmour { get; set; }

        public bool SimpleWeapons { get; set; }
        public bool MartialWeapons { get; set; }

        public bool Acrobatics { get; set; }
        public bool AnimalHandling { get; set; }
        public bool Arcana { get; set; }
        public bool Athletics { get; set; }
        public bool Deception { get; set; }
        public bool History { get; set; }
        public bool Insight { get; set; }
        public bool Intimidation { get; set; }
        public bool Investigation { get; set; }
        public bool Medicine { get; set; }
        public bool Nature { get; set; }
        public bool Perception { get; set; }
        public bool Performance { get; set; }
        public bool Persuasion { get; set; }
        public bool Religion { get; set; }
        public bool SleightOfHand { get; set; }
        public bool Stealth { get; set; }
        public bool Survival { get; set; }
    }

}
