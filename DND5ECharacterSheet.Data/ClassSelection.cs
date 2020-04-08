using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Data
{
    public class ClassSelection
    {
        public ClassSelection() { }
        public ClassSelection(string name, string desc, int dice, string primary, int profs)
        {
            ClassName = name;
            Description = desc;
            HitDieSize = dice;
            PrimaryAbility = primary;
            ProficienciesId = profs;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Class")]
        public string ClassName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int HitDieSize { get; set; }

        [Required]
        public string PrimaryAbility { get; set; }

        [Required]
        [ForeignKey(nameof(Proficiencies))]
        public int ProficienciesId { get; set; }
        
        public virtual ClassProficiencies Proficiencies { get; set; }
    }

    public class ClassProficiencies
    {
        [Key]
        public int PresetProficiencyId { get; set; }
        public ClassProficiencies() {}
        public ClassProficiencies(bool str, bool dex, bool con, bool sma, bool wis, bool cha, bool la, bool ma, bool ha, bool sh, bool sw, bool mw, bool acro, bool anim, bool arc, bool ath, bool dec, bool his, bool ins, bool scare, bool invest, bool med, bool nat, bool perc, bool perf, bool pers, bool rel, bool soh, bool ste, bool sur)
        {
            StrengthSave = str;
            DexteritySave = dex;
            ConstitutionSave = con;
            IntelligenceSave = sma;
            WisdomSave = wis;
            CharismaSave = cha;
            LightArmour = la;
            MediumArmour = ma;
            HeavyArmour = ha;
            Shield = sh;
            SimpleWeapons = sw;
            MartialWeapons = mw;
            Acrobatics = acro;
            AnimalHandling = anim;
            Arcana = arc;
            Athletics = ath;
            Deception = dec;
            History = his;
            Insight = ins;
            Intimidation = scare;
            Investigation = invest;
            Medicine = med;
            Nature = nat;
            Perception = perc;
            Performance = perf;
            Persuasion = pers;
            Religion = rel;
            SleightOfHand = soh;
            Stealth = ste;
            Survival = sur;
        }

        public bool StrengthSave { get; set; }
        public bool DexteritySave { get; set; }
        public bool ConstitutionSave { get; set; }
        public bool IntelligenceSave { get; set; }
        public bool WisdomSave { get; set; }
        public bool CharismaSave { get; set; }

        public bool LightArmour { get; set; }
        public bool MediumArmour { get; set; }
        public bool HeavyArmour { get; set; }
        public bool Shield { get; set; }

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
