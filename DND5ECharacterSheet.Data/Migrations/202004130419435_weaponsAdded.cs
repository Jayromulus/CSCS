namespace DND5ECharacterSheet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class weaponsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DamageDieAmount = c.Int(nullable: false),
                        DamageDieSize = c.Int(nullable: false),
                        DamageType = c.Int(nullable: false),
                        Properties = c.String(),
                        IsMartialWeapon = c.Boolean(nullable: false),
                        IsMeleeWeapon = c.Boolean(nullable: false),
                        Name = c.String(),
                        WeightInPounds = c.Int(nullable: false),
                        CostInCurrency = c.Int(nullable: false),
                        CurrencyRequired = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weapons");
        }
    }
}
