using DND5ECharacterSheet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace DND5ECharacterSheet.Models
{
    public class CharacterCreate
    {
        [Required]
        public string CharacterName { get; set; }

        [Required]
        public int ClassId { get; set; }

        [Required]
        //[ForeignKey(nameof(Races))]
        public int RaceId { get; set; }
        //public virtual RaceSelection Races { get; set; }

        public int BaseStrength { get; set; }
        public int BaseDexterity { get; set; }
        public int BaseConstitution { get; set; }
        public int BaseIntelligence { get; set; }
        public int BaseWisdom { get; set; }
        public int BaseCharisma { get; set; }

        [Required]
        public int Experience { get; set; }
        
        [Required]
        public int Inspiration { get; set; }
        
        [Required]
        public int MaxHP { get; set; }
    }

    public class CharacterListItem
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
        //public virtual ClassSelection Class { get; set; }
        //public virtual RaceSelection Race { get; set; }
        public string ClassName { get; set; }
        public string RaceName { get; set; }
        public int Level { get; set; }
    }

    public class CharacterEdit
    {
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string CharacterName { get; set; }
        public int ClassId { get; set; }
        public int RaceId { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDexterity { get; set; }
        public int BaseConstitution { get; set; }
        public int BaseIntelligence { get; set; }
        public int BaseWisdom { get; set; }
        public int BaseCharisma { get; set; }
        public int ExperiencePoints { get; set; }
        public int Inspiration { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; } = 0;
    }

    public class CharacterDetail
    {
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string AddedBy { get; set; }
        [Display(Name = "Character Name")]
        public string CharacterName { get; set; }
        public int ClassId { get; set; }
        public virtual ClassSelection Class { get; set; }
        public int RaceId { get; set; }
        public virtual RaceSelection Race { get; set; }

        public int Strength { get; set; }
        public int StrengthMod { get { return (Strength - 10) / 2; } }
        public int Dexterity { get; set; }
        public int DexterityMod { get { return (Dexterity - 10) / 2; } }
        public int Constitution { get; set; }
        public int ConstitutionMod { get { return (Constitution - 10) / 2; } }
        public int Intelligence { get; set; }
        public int IntelligenceMod { get { return (Intelligence- 10) / 2; } }
        public int Wisdom { get; set; }
        public int WisdomMod { get { return (Wisdom - 10) / 2; } }
        public int Charisma { get; set; }
        public int CharismaMod { get { return (Charisma - 10) / 2; } }
        public int BaseStrength { get; set; }
        public int BaseDexterity { get; set; }
        public int BaseConstitution { get; set; }
        public int BaseIntelligence { get; set; }
        public int BaseWisdom { get; set; }
        public int BaseCharisma { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int ProficiencyBonus { get; set; }
        public int Inspiration { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }

        public int StrengthSave { get; set; }
        public int DexteritySave { get; set; }
        public int ConstitutionSave { get; set; }
        public int IntelligenceSave { get; set; }
        public int WisdomSave { get; set; }
        public int CharismaSave { get; set; }
        public string LightArmour { get; set; }
        public string MediumArmour { get; set; }
        public string HeavyArmour { get; set; }
        public string Shield { get; set; }
        public string SimpleWeapons { get; set; }
        public string MartialWeapons { get; set; }
        public string Acrobatics { get; set; }
        public string AnimalHandling { get; set; }
        public string Arcana { get; set; }
        public string Athletics { get; set; }
        public string Deception { get; set; }
        public string History { get; set; }
        public string Insight { get; set; }
        public string Intimidation { get; set; }
        public string Investigation { get; set; }
        public string Medicine { get; set; }
        public string Nature { get; set; }
        public string Perception { get; set; }
        public string Performance { get; set; }
        public string Persuasion { get; set; }
        public string Religion { get; set; }
        public string SleightOfHand { get; set; }
        public string Stealth { get; set; }
        public string Survival { get; set; }
    }
}
