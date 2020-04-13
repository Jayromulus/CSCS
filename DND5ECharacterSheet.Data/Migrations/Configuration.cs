namespace DND5ECharacterSheet.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DND5ECharacterSheet.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DND5ECharacterSheet.Data.ApplicationDbContext context)
        {
            context.ClassProficiencyList.AddOrUpdate(
                cprof => cprof.PresetProficiencyId,
                new ClassProficiencies
                    (
                        true,  // STRENGTH
                        false, // DEXTERITY 
                        true,  // CONSTITUTION
                        false, // INTELLIGENCE
                        false, // WISDOM
                        false, // CHARISMA
                        true,  // LIGHT ARMOUR
                        true,  // MEDIUM ARMOUR
                        false, // HEAVY ARMOUR
                        true,  // SHIELD
                        true,  // SIMPLE WEAPONS
                        true,  // MARTIAL WEAPONS
                        false, // ACROBATICS
                        true,  // ANIMAL HANDLING
                        false, // ARCANA
                        true,  // ATHLETICS
                        false, // DECEPTION
                        false, // HISTORY
                        false, // INSIGHT
                        true,  // INTIMIDATION
                        false, // INVESTIGATION
                        false, // MEDICINE
                        true,  // NATURE
                        true,  // PERCEPTION
                        false, // PERFORMANCE
                        false, // PERSUASION
                        false, // RELIGION
                        false, // SLEIGHT OF HAND
                        false, // STEALTH
                        true   // SURVIVAL
                    ),
                new ClassProficiencies(false, true, false, false, false, true, true, false, false, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true),
                new ClassProficiencies(false, false, false, false, true, true, true, true, false, true, true, false, false, false, false, false, false, true, true, false, false, true, false, false, false, true, true, false, false, false),
                new ClassProficiencies(false, false, false, true, true, false, false, true, true, true, true, true, false, true, true, false, false, false, true, false, false, true, true, true, false, false, true, false, false, true),
                new ClassProficiencies(true, false, true, false, false, false, true, true, true, true, true, true, true, true, false, true, false, true, true, true, false, false, false, true, false, false, false, false, false, true),
                new ClassProficiencies(true, true, false, false, false, false, false, false, false, false, true, false, true, false, false, true, false, true, true, false, false, false, false, false, false, false, true, false, true, false),
                new ClassProficiencies(false, false, false, false, true, true, true, true, true, true, true, true, false, false, false, true, false, false, true, true, false, true, false, false, false, true, true, false, false, false),
                new ClassProficiencies(true, true, false, false, false, false, true, true, false, true, true, true, false, true, false, true, false, false, true, false, true, false, true, true, false, false, false, false, true, true),
                new ClassProficiencies(false, true, false, true, false, false, true, false, false, false, true, false, true, false, false, true, true, false, true, true, true, false, false, true, true, true, false, true, true, false),
                new ClassProficiencies(false, false, true, false, false, true, false, false, false, false, false, false, false, false, true, false, true, false, true, true, false, false, false, true, false, false, true, false, false, false),
                new ClassProficiencies(false, false, false, false, true, true, true, false, false, false, true, false, false, false, true, false, true, true, false, true, true, false, true, false, false, false, true, false, false, false),
                new ClassProficiencies(false, false, false, true, true, false, false, false, false, false, false, false, false, false, true, false, false, true, true, false, true, true, false, false, false, false, true, false, false, false)
            );
            //context.SaveChanges();

            context.RaceBonuses.AddOrUpdate
            (
                b => b.IncreaseId,
                new AbilityIncrease
                (
                    0, // STRENGTH
                    0, // DEXTERITY
                    2, // CONSTITUTION
                    0, // INTELLIGENCE
                    1, // WISDOM
                    0  // CHARISMA
                ),
                new AbilityIncrease(2, 0, 2, 0, 0, 0),
                new AbilityIncrease(0, 2, 0, 1, 0, 0),
                new AbilityIncrease(0, 2, 0, 0, 1, 0),
                new AbilityIncrease(0, 2, 0, 0, 0, 1),
                new AbilityIncrease(0, 2, 1, 0, 0, 0),
                new AbilityIncrease(1, 1, 1, 1, 1, 1),
                new AbilityIncrease(2, 0, 0, 0, 0, 1),
                new AbilityIncrease(0, 1, 0, 2, 0, 0),
                new AbilityIncrease(0, 0, 1, 2, 0, 0),
                new AbilityIncrease(0, 0, 0, 0, 0, 2),
                new AbilityIncrease(2, 0, 1, 0, 0, 0),
                new AbilityIncrease(0, 0, 0, 1, 0, 2)
            );
            //context.SaveChanges();

            context.Classes.AddOrUpdate(
                cl => cl.Id,
                new ClassSelection
                (
                    "Barbarian", // CLASS NAME
                    "A fierce warrior of primitive background who can enter a battle rage", // DESCRIPTION
                    12, // HIT DIE SIZE
                    "Strength", // PRIMARY ABILITY
                    1 // PROFICIENCY ID
                ),
                new ClassSelection("Bard", "An inspiring magician whose power echoes the music of creation", 8, "Charisma", 2),
                new ClassSelection("Cleric", "A priestly champion who wields divine magic in service of a higher power", 8, "Wisdom", 3),
                new ClassSelection("Druid", "A priest of the Old Faith, weilding the powers of nature - moonlight and plant growth, fire and lightnint - and adopting animal forms", 8, "Wisdom", 4),
                new ClassSelection("Fighter", "A master of martial combat, skilled with a variety of weapons and armour", 10, "Strength or Dexterity", 5),
                new ClassSelection("Monk", "A master of martial arts, harnessing the power of the body in pursuit of physical and spiritual perfection", 8, "Dexterity and Wisdom", 6),
                new ClassSelection("Paladin", "A holy warrior bound to a sacred oath", 10, "Strength and Charisma", 7),
                new ClassSelection("Ranger", "A warrior who uses martial prowess and nature magic to combat threats on the edges of civilization", 10, "Dexterity and Wisdom", 8),
                new ClassSelection("Rogue", "A scoundrel who uses stealth and trickery to overcome obstacles and enemies", 8, "Dexterity", 9),
                new ClassSelection("Sorcerer", "A spellcaster who draws on inherent magic from a gift or bloodline", 6, "Charisma", 10),
                new ClassSelection("Warlock", "A wielder of magic that is derived from a bargain with an extraplanar entity", 6, "Charisma", 11),
                new ClassSelection("Wizard", "A scholarly magic user capable of manupulating the structure of reality", 6, "Intelligence", 12)
            );
            //context.SaveChanges();

            context.Races.AddOrUpdate(
                ra => ra.Id,
                new RaceSelection(
                    "Hill Dwarf", // RACE NAME (SUBRACE)
                    1, // ABILITY SCORE BOOST
                    "50 - 350", // AGE RANGE
                    'M', // SIZE
                    25, // SPEED
                    false, // LOWLIGHT BOOLEAN
                    null, // LOWLIGHT RANGE
                    true, // DARKVISION BOOLEAN
                    60, // DARKVISION RANGE
                    "Battleaxe, Handaxe, Throwing Hammer, Warhammer, Smith's Tools, Brewer's Tools, Mason's Tools", // EXTRA PROFICIENCIES
                    "Dwarven Resilience, Stonecunning, Dwarven Toughness", // EXTRA SKILLS
                    "Dwarven, Common" // LANGUAGES
                ),
                new RaceSelection("Mountain Dwarf", 2, "50 - 350", 'M', 25, false, null, true, 60, "Battleaxe, Handaxe, Throwing Hammer, Warhammer, Light Armour, Medium Armour, Smith's Tools, Brewer's Tools, Mason's Tools", "Dwarven Resilience, Stonecunning", "Dwarven, Common"),
                new RaceSelection("Mountain Dwarf", 2, "50 - 350", 'M', 25, false, null, true, 60, "Battleaxe, Handaxe, Throwing Hammer, Warhammer, Light Armour, Medium Armour, Smith's Tools, Brewer's Tools, Mason's Tools", "Dwarven Resilience, Stonecunning", "Dwarven, Common"),
                new RaceSelection("High Elf", 3, "100 - 750", 'M', 35, false, null, true, 60, "Perception, Longsword, Shortsword, Longbow, Shortbow", "Fey Ancestry, Trance, Cantrip, Extra Language", "Common, Elvish"),
                new RaceSelection("Wood Elf", 4, "100 - 750", 'M', 30, false, null, true, 60, "Perception, Longsword, Shortsword, Longbow, Shortbow", "Fey Ancestry, Trance, Mask of the Wild", "Common, Elvish"),
                new RaceSelection("Dark Elf", 5, "100 - 750", 'M', 30, false, null, true, 120, "Perception, Rapier, Shortsword, Hand Crossbow", "Fey Ancestry, Trance, Sunlight Sensitivity, Drow Magic", "Common, Elvish"),
                new RaceSelection("Lightfoot Halfling", 5, "20-150", 'S', 25, false, null, false, null, "No Bonus Proficiencies", "Lucky, Brave, Halfling Nimbleness, Naturally Stealthy", "Common, Halfling"),
                new RaceSelection("Stout Halfling", 6, "20-150", 'S', 25, false, null, false, null, "No Bonus Proficiencies", "Lucky, Brave, Halfling Nimbleness, Stout Resilience", "Common, Halfling"),
                new RaceSelection("Human", 7, "18-80", 'M', 30, false, null, false, null, "1 Language of your choice", "No Bonus Abilities", "Common"),
                new RaceSelection("Black Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 5 x 30ft Line (Dex. save) [Acid], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Blue Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 5 x 30ft Line (Dex. save) [Lightning], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Brass Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 5 x 30ft Line (Dex. save) [Fire], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Bronze Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 5 x 30ft Line (Dex. save) [Lightning], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Copper Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 5 x 30ft Line (Dex. save) [Acid], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Gold Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 15ft Cone (Dex. save) [Fire], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Green Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 15ft Cone (Con. save) [Poison], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Red Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 15ft Cone (Dex. save) [Fire], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Silver Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 15ft Cone (Con. save) [Cold], Damage Resistance", "Common, Draconic"),
                new RaceSelection("White Dragonborn", 8, "15-80", 'M', 30, false, null, false, null, "No Bonus Proficiencies", "Breath Weapon: 15ft Cone (Con. save) [Cold], Damage Resistance", "Common, Draconic"),
                new RaceSelection("Forest Gnome", 9, "40 - 450", 'S', 25, false, null, true, 60, "Artisan's Tools", "Gnome Cunning, Artificer's Lore, Tinker", "Common, Gnomish"),
                new RaceSelection("Rock Gnome", 10, "40 - 450", 'S', 25, false, null, true, 60, "No Bonus Proficiencies", "Gnome Cunning, Natural Illusionist, Speak with Small Beasts", "Common, Gnomish"),
                new RaceSelection("Half-Elf", 11, "20 - 180", 'M', 30, false, null, true, 60, "2 Skills of your choice", "+1 to 2 Ability Scores, Fey Ancestry", "Common, Elvish"),
                new RaceSelection("Half-Orc", 12, "14 - 70", 'M', 30, false, null, true, 60, "Intimidation", "Relentless Endurance, Savage Attacks", "Common, Orc"),
                new RaceSelection("Tiefling", 13, "18 - 85", 'M', 30, false, null, true, 60, "No Bonus Proficiencies", "Hellish Resistance, Infernal Legacy", "Common, Infernal")
            );
            //context.SaveChanges();

            context.Armours.AddOrUpdate(
                a => a.Id,
                new Armour
                (
                    "Padded", // NAME
                    8, // WEIGHT
                    5, // COST
                    4, // CURRENCY REQUIRED (ENUM INDEX) [1 = copper, 2 = silver, 3 = electrum, 4 = gold, 5 = platinum]
                    11, // ARMOUR CLASS
                    null, // MAX DEXTERITY
                    null, // MIN STRENGTH
                    true, // STEALTH DISADVANTAGE
                    "Light" // ARMOUR TYPE
                ),
                new Armour("Leather", 10, 10, 4, 11, null, null, false, "Light"),
                new Armour("Studded Leather", 13, 45, 4, 12, null, null, false, "Light"),
                new Armour("Hide", 12, 10, 4, 12, 2, null, false, "Medium"),
                new Armour("Chain Shirt", 20, 50, 4, 13, 2, null, false, "Medium"),
                new Armour("Scale Mail", 45, 50, 4, 14, 2, null, true, "Medium"),
                new Armour("Breastplate", 20, 400, 4, 14, 2, null, false, "Medium"),
                new Armour("Half Plate", 40, 750, 4, 15, 2, null, true, "Medium"),
                new Armour("Ring Mail", 40, 30, 4, 14, 0, null, true, "Heavy"),
                new Armour("Chain Mail", 55, 75, 4, 16, 0, 13, true, "Heavy"),
                new Armour("Splint", 60, 200, 4, 17, 0, 13, true, "Heavy"),
                new Armour("Plate", 65, 1500, 4, 18, 0, 15, true, "Heavy"),
                new Armour("Shield", 6, 10, 4, 2, 0, null, false, "Shield")
            );

            context.Weapons.AddOrUpdate(
                wea => wea.Id,
                new Weapon
                (
                    "Club", 
                    2, // WEIGHT
                    1, // COST
                    2, // CURRENCY REQUIRED (ENUM INDEX) [1 = copper, 2 = silver, 3 = electrum, 4 = gold, 5 = platinum]
                    1, // DAMAGE DIE AMOUNT
                    4, // DAMAGE DIE SIZE
                    1, // DAMAGE TYPE [1 = bludgeoning, 2 = piercing, 3 = slashing]
                    false, // MARTIAL
                    true, // MELEE
                    "Light" // PROPERTIES
                ),
                new Weapon("Dagger", 2, 1, 2, 1, 4, 1, false, true, "Light")
                // the rest of the weapon seeding goes here when you finish making the weapon/armour crud or if you are being a lazy bum who should get back to work instead of slacking off or sleeping on the job wow how lazy can you really get
            );


            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
