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
            context.Classes.AddOrUpdate(
                cl => cl.ClassName,
                new ClassSelection("Barbarian", "A fierce warrior of primitive background who can enter a battle rage", 12, "Strength", new ClassProficiencies(true, false, true, false, false, false, true, true, false, true, true, true, false, true, false, true, false, false, false, true, false, false, true, true, false, false, false, false, false, true)),
                new ClassSelection("Bard", "An inspiring magician whose power echoes the music of creation", 8, "Charisma", new ClassProficiencies(false, true, false, false, false, true, true, false, false, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true)),
                new ClassSelection("Cleric", "A priestly champion who wields divine magic in service of a higher power", 8, "Wisdom", new ClassProficiencies(false, false, false, false, true,   true,   true, true, false, true, true, false, false, false, false, false, false, true, true, false, false, true, false, false, false, true, true, false, false, false)),
                new ClassSelection("Druid", "A priest of the Old Faith, weilding the powers of nature - moonlight and plant growth, fire and lightnint - and adopting animal forms", 8, "Wisdom", new ClassProficiencies(false, false, false, true, true, false, false, true, true, true, true, true, false, true, true, false, false, false, true, false, false, true, true, true, false, false, true, false, false, true)),
                new ClassSelection("Fighter", "A master of martial combat, skilled with a variety of weapons and armour", 10, "Strength or Dexterity", new ClassProficiencies(true, false, true, false, false, false, true, true, true, true, true, true, true, true, false, true, false, true, true, true, false, false, false, true, false, false, false, false, false,true)),
                new ClassSelection("Monk", "A master of martial arts, harnessing the power of the body in pursuit of physical and spiritual perfection", 8, "Dexterity and Wisdom", new ClassProficiencies(true, true, false, false, false, false, false, false, false, false, true, false, true, false, false, true, false, true, true, false, false, false, false, false, false, false, true, false, true, false)),
                new ClassSelection("Paladin", "A holy warrior bound to a sacred oath", 10, "Strength and Charisma", new ClassProficiencies(false, false, false, false, true, true, true, true, true, true, true, true, false, false, false, true, false, false, true, true, false, true, false, false, false, true, true, false, false, false)),
                new ClassSelection("Ranger", "A warrior who uses martial prowess and nature magic to combat threats on the edges of civilization", 10, "Dexterity and Wisdom", new ClassProficiencies(true, true, false, false, false, false, true, true, false, true, true, true, false, true, false, true, false, false, true, false, true, false, true, true, false, false, false, false, true, true)),
                new ClassSelection("Rogue", "A scoundrel who uses stealth and trickery to overcome obstacles and enemies", 8, "Dexterity", new ClassProficiencies(false, true, false, true, false, false, true, false, false, false, true, false, true, false, false, true, true, false, true, true, true, false, false, true, true, true, false, true, true, false)),
                new ClassSelection("Sorcerer", "A spellcaster who draws on inherent magic from a gift or bloodline", 6, "Charisma", new ClassProficiencies(false, false, true, false, false, true, false, false, false, false, false, false, false, false, true, false, true, false, true, true, false, false, false, true, false, false, true, false, false, false)),
                new ClassSelection("Warlock", "A wielder of magic that is derived from a bargain with an extraplanar entity", 6, "Charisma", new ClassProficiencies(false, false, false, false, true, true, true, false, false, false, true, false, false, false, true, false, true, true, false, true, true, false, true, false, false, false, true, false, false, false)),
                new ClassSelection("Wizard", "A scholarly magic user capable of manupulating the structure of reality", 6, "Intelligence", new ClassProficiencies(false, false, false, true, true, false, false, false, false, false, false, false, false, false, true, false, false, true, true, false, true, true, false, false, false, false, true, false, false, false))
            );
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
