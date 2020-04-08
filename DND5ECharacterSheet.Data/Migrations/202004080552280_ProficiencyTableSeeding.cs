namespace DND5ECharacterSheet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProficiencyTableSeeding : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ClassSelections", name: "Proficiencies_PresetProficiencyId", newName: "ProficienciesId");
            RenameIndex(table: "dbo.ClassSelections", name: "IX_Proficiencies_PresetProficiencyId", newName: "IX_ProficienciesId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ClassSelections", name: "IX_ProficienciesId", newName: "IX_Proficiencies_PresetProficiencyId");
            RenameColumn(table: "dbo.ClassSelections", name: "ProficienciesId", newName: "Proficiencies_PresetProficiencyId");
        }
    }
}
