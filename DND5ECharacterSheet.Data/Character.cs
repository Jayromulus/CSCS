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
        public Character (string userId, string charName, int classChoice, int raceChoice, int exp, int inspiration, int maxhp)
        {
            AddedBy = userId;
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
            CharacterName = charName;
            ClassId = classChoice;
            RaceId = raceChoice;
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

        // ADD THE REAL LOGIC FOR THIS LATER
        public int Level { get { return (ExperiencePoints / 500) + 1; } }

        // ADD THE REAL LOGIC FOR THIS LATER
        public int ProficiencyBonus { get { return Level / 5; } }

        public int Inspiration { get; set; } = 0;

        // MAYBE MAKE THIS GET ONLY?
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }

    }

    
}
