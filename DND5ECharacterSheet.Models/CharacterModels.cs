using DND5ECharacterSheet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Models
{
    public class CharacterCreate
    {
        [Required]
        public string CharacterName { get; set; }
        [Required]
        public int ClassId { get; set; }
        [Required]
        public int RaceId { get; set; }
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
        public string CharacterName { get; set; }
        public int ClassId { get; set; }
        public virtual ClassSelection Class { get; set; }
        public int RaceId { get; set; }
        public virtual RaceSelection Race { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Inspiration { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
    }
}
