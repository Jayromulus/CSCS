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
        public string RaceId { get; set; }
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
        public string RaceId { get; set; }
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
        public string RaceId { get; set; }
        public virtual RaceSelection Race { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Inspiration { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
    }

    public enum RaceSelectEnum
    {
        HillDwarf = 1,
        MountainDwarf = 2,
        HighElf = 3,
        WoodElf = 4,
        DarkElf = 5,
        LightfootHalfling = 6,
        StoutHalfling = 7,
        Human = 8,
        BlackDragonborn = 9,
        BlueDragonborn = 10,
        BrassDragonborn = 11,
        BronzeDragonborn = 12,
        CopperDragonborn = 13,
        GoldDragonborn = 14,
        GreenDragonborn = 15,
        RedDragonborn = 16,
        SilverDragonborn = 17,
        WhiteDragonborn = 18,
        ForestGnome = 19,
        RockGnome = 20,
        HalfElf = 21,
        HalfOrc = 22,
        Tiefling = 23
    }
}
