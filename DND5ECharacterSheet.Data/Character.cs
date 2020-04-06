using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Data
{
    public class Character
    {
        public Character() { }
        public Character (string userId, string charName, int classChoice, int raceChoice, int? str, int? dex, int? con, int? inte, int? wis, int? cha, int exp, int inspiration, int maxhp)
        {
            AddedBy = userId;
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
            CharacterName = charName;
            ClassId = classChoice;
            RaceId = raceChoice;
            BaseStrength = str;
            BaseDexterity = dex;
            BaseConstitution = con;
            BaseIntelligence = inte;
            BaseWisdom = wis;
            BaseCharisma = cha;
            ExperiencePoints = exp;
            Inspiration = inspiration;
            MaxHitPoints = maxhp;
        }

        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string AddedBy { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        public string CharacterName { get; set; }


        [ForeignKey(nameof(Class))]
        public int ClassId { get; set; }
        public virtual ClassSelection Class { get; set; }

        //public string Class { get; set; }

        [Required]
        [ForeignKey(nameof(Race))]
        public int RaceId { get; set; }
        public virtual RaceSelection Race { get; set; }

        //public string Race { get; set; }

        [Required]
        public int ExperiencePoints { get; set; }

        public int? BaseStrength { get; set; }
        public int? BaseDexterity { get; set; }
        public int? BaseConstitution { get; set; }
        public int? BaseIntelligence { get; set; }
        public int? BaseWisdom { get; set; }
        public int? BaseCharisma { get; set; }


        //public int? Strength
        //{
        //    get
        //    {
        //        int? raceStrength = Race.AbilityIncreases.Strength;
        //        if (raceStrength != null)
        //            return BaseStrength + raceStrength;
        //        return BaseStrength;
        //    }
        //}


        // ADD THE REAL LOGIC FOR THIS LATER
        public int Level 
        { 
            get 
            {
                if (ExperiencePoints >= 355000)
                    return 20;
                else if (ExperiencePoints >= 305000)
                    return 19;
                else if (ExperiencePoints >= 265000)
                    return 18;
                else if (ExperiencePoints >= 225000)
                    return 17;
                else if (ExperiencePoints >= 195000)
                    return 16;
                else if (ExperiencePoints >= 165000)
                    return 15;
                else if (ExperiencePoints >= 140000)
                    return 14;
                else if (ExperiencePoints >= 120000)
                    return 13;
                else if (ExperiencePoints >= 100000)
                    return 12;
                else if (ExperiencePoints >= 85000)
                    return 11;
                else if (ExperiencePoints >= 64000)
                    return 10;
                else if (ExperiencePoints >= 48000)
                    return 9;
                else if (ExperiencePoints >= 34000)
                    return 8;
                else if (ExperiencePoints >= 23000)
                    return 7;
                else if (ExperiencePoints >= 14000)
                    return 6;
                else if (ExperiencePoints >= 6500)
                    return 5;
                else if (ExperiencePoints >= 2700)
                    return 4;
                else if (ExperiencePoints >= 900)
                    return 3;
                else if (ExperiencePoints >= 300)
                    return 2;
                else
                    return 1;
            } 
        }

        // ADD THE REAL LOGIC FOR THIS LATER
        public int ProficiencyBonus
        {
            get
            {
                switch (Level)
                {
                    case 20:
                    case 19:
                    case 18:
                    case 17:
                        return 6;
                    case 16:
                    case 15:
                    case 14:
                    case 13:
                        return 5;
                    case 12:
                    case 11:
                    case 10:
                    case 9:
                        return 4;
                    case 8:
                    case 7:
                    case 6:
                    case 5:
                        return 3;
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                        return 2;
                    default: 
                        return 6;
                }
            }
        }

        public int Inspiration { get; set; } = 0;

        // MAYBE MAKE THIS GET ONLY?
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }

    }

    
}
