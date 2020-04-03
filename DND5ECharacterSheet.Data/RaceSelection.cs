using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Data
{
    public class RaceSelection
    {
        public RaceSelection() { }
        public RaceSelection(string name, AbilityIncrease abil, string age, char size, int speed, bool lowlight, int? lowlightrange, bool dark, int? darkrange, string profs, string extra, string lang)
        {
            RaceName = name;
            AbilityIncreases = abil;
            AgeRange = age;
            Size = size;
            Speed = speed;
            LowLightVision = lowlight;
            LowLightRange = lowlightrange;
            DarkVision = dark;
            DarkVisionRange = darkrange;
            ExtraSkillProficiencies = profs;
            ExtraRacialAbilities = extra;
            Languages = lang;
        }

        [Key]
        //public int Id { get; set; }

        [Required]
        [Display(Name = "Race")]
        public string RaceName { get; set; }

        [Required]

        public AbilityIncrease AbilityIncreases { get; set; }

        public string AgeRange { get; set; }

        public char Size { get; set; }

        public int Speed { get; set; }

        public bool LowLightVision { get; set; }

        public int? LowLightRange { get; set; }

        public bool DarkVision { get; set; }

        public int? DarkVisionRange { get; set; }

        public string ExtraSkillProficiencies { get; set; }

        // name only for now, maybe make another class for 
        public string ExtraRacialAbilities { get; set; }

        public string Languages { get; set; }
    }

    public class AbilityIncrease
    {
        public AbilityIncrease() { }
        public AbilityIncrease(int? abil1, int? abil2, int? abil3, int? abil4, int? abil5, int? abil6)
        {
            Strength = abil1;
            Dexterity = abil2;
            Constitution = abil3;
            Intelligence = abil4;
            Wisdom = abil5;
            Charisma = abil6;
        }

        [Key]
        public int IncreaseId { get; set; }

        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Constitution { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }
    }
}