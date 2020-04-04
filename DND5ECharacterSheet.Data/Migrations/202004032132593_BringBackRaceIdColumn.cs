namespace DND5ECharacterSheet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BringBackRaceIdColumn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Characters", "RaceName", "dbo.RaceSelections");
            DropIndex("dbo.Characters", new[] { "RaceName" });
            RenameColumn(table: "dbo.Characters", name: "RaceName", newName: "RaceId");
            DropPrimaryKey("dbo.RaceSelections");
            AddColumn("dbo.RaceSelections", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Characters", "RaceId", c => c.Int(nullable: false));
            AlterColumn("dbo.RaceSelections", "RaceName", c => c.String(nullable: false));
            AddPrimaryKey("dbo.RaceSelections", "Id");
            CreateIndex("dbo.Characters", "RaceId");
            AddForeignKey("dbo.Characters", "RaceId", "dbo.RaceSelections", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "RaceId", "dbo.RaceSelections");
            DropIndex("dbo.Characters", new[] { "RaceId" });
            DropPrimaryKey("dbo.RaceSelections");
            AlterColumn("dbo.RaceSelections", "RaceName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Characters", "RaceId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.RaceSelections", "Id");
            AddPrimaryKey("dbo.RaceSelections", "RaceName");
            RenameColumn(table: "dbo.Characters", name: "RaceId", newName: "RaceName");
            CreateIndex("dbo.Characters", "RaceName");
            AddForeignKey("dbo.Characters", "RaceName", "dbo.RaceSelections", "RaceName", cascadeDelete: true);
        }
    }
}
