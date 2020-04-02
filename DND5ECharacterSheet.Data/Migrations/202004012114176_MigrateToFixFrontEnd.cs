namespace DND5ECharacterSheet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateToFixFrontEnd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "ClassId", c => c.Int(nullable: false));
            CreateIndex("dbo.Characters", "ClassId");
            AddForeignKey("dbo.Characters", "ClassId", "dbo.ClassSelections", "Id", cascadeDelete: true);
            DropColumn("dbo.Characters", "Class");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "Class", c => c.String());
            DropForeignKey("dbo.Characters", "ClassId", "dbo.ClassSelections");
            DropIndex("dbo.Characters", new[] { "ClassId" });
            DropColumn("dbo.Characters", "ClassId");
        }
    }
}
