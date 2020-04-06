namespace DND5ECharacterSheet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedContent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        AddedBy = c.String(nullable: false, maxLength: 128),
                        CharacterName = c.String(nullable: false),
                        ClassId = c.Int(nullable: false),
                        RaceId = c.Int(nullable: false),
                        ExperiencePoints = c.Int(nullable: false),
                        BaseStrength = c.Int(),
                        BaseDexterity = c.Int(),
                        BaseConstitution = c.Int(),
                        BaseIntelligence = c.Int(),
                        BaseWisdom = c.Int(),
                        BaseCharisma = c.Int(),
                        Inspiration = c.Int(nullable: false),
                        MaxHitPoints = c.Int(nullable: false),
                        CurrentHitPoints = c.Int(nullable: false),
                        TemporaryHitPoints = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassSelections", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.RaceSelections", t => t.RaceId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.AddedBy, cascadeDelete: true)
                .Index(t => t.AddedBy)
                .Index(t => t.ClassId)
                .Index(t => t.RaceId);
            
            CreateTable(
                "dbo.ClassSelections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassName = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        HitDieSize = c.Int(nullable: false),
                        PrimaryAbility = c.String(nullable: false),
                        Proficiencies_PresetProficiencyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassProficiencies", t => t.Proficiencies_PresetProficiencyId, cascadeDelete: true)
                .Index(t => t.Proficiencies_PresetProficiencyId);
            
            CreateTable(
                "dbo.ClassProficiencies",
                c => new
                    {
                        PresetProficiencyId = c.Int(nullable: false, identity: true),
                        StrengthSave = c.Boolean(nullable: false),
                        DexteritySave = c.Boolean(nullable: false),
                        ConstitutionSave = c.Boolean(nullable: false),
                        IntelligenceSave = c.Boolean(nullable: false),
                        WisdomSave = c.Boolean(nullable: false),
                        CharismaSave = c.Boolean(nullable: false),
                        LightArmour = c.Boolean(nullable: false),
                        MediumArmour = c.Boolean(nullable: false),
                        HeavyArmour = c.Boolean(nullable: false),
                        Shield = c.Boolean(nullable: false),
                        SimpleWeapons = c.Boolean(nullable: false),
                        MartialWeapons = c.Boolean(nullable: false),
                        Acrobatics = c.Boolean(nullable: false),
                        AnimalHandling = c.Boolean(nullable: false),
                        Arcana = c.Boolean(nullable: false),
                        Athletics = c.Boolean(nullable: false),
                        Deception = c.Boolean(nullable: false),
                        History = c.Boolean(nullable: false),
                        Insight = c.Boolean(nullable: false),
                        Intimidation = c.Boolean(nullable: false),
                        Investigation = c.Boolean(nullable: false),
                        Medicine = c.Boolean(nullable: false),
                        Nature = c.Boolean(nullable: false),
                        Perception = c.Boolean(nullable: false),
                        Performance = c.Boolean(nullable: false),
                        Persuasion = c.Boolean(nullable: false),
                        Religion = c.Boolean(nullable: false),
                        SleightOfHand = c.Boolean(nullable: false),
                        Stealth = c.Boolean(nullable: false),
                        Survival = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PresetProficiencyId);
            
            CreateTable(
                "dbo.RaceSelections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RaceName = c.String(nullable: false),
                        IncreaseId = c.Int(nullable: false),
                        AgeRange = c.String(),
                        Speed = c.Int(nullable: false),
                        LowLightVision = c.Boolean(nullable: false),
                        LowLightRange = c.Int(),
                        DarkVision = c.Boolean(nullable: false),
                        DarkVisionRange = c.Int(),
                        ExtraSkillProficiencies = c.String(),
                        ExtraRacialAbilities = c.String(),
                        Languages = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AbilityIncreases", t => t.IncreaseId, cascadeDelete: true)
                .Index(t => t.IncreaseId);
            
            CreateTable(
                "dbo.AbilityIncreases",
                c => new
                    {
                        IncreaseId = c.Int(nullable: false, identity: true),
                        Strength = c.Int(),
                        Dexterity = c.Int(),
                        Constitution = c.Int(),
                        Intelligence = c.Int(),
                        Wisdom = c.Int(),
                        Charisma = c.Int(),
                    })
                .PrimaryKey(t => t.IncreaseId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Characters", "AddedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Characters", "RaceId", "dbo.RaceSelections");
            DropForeignKey("dbo.RaceSelections", "IncreaseId", "dbo.AbilityIncreases");
            DropForeignKey("dbo.Characters", "ClassId", "dbo.ClassSelections");
            DropForeignKey("dbo.ClassSelections", "Proficiencies_PresetProficiencyId", "dbo.ClassProficiencies");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.RaceSelections", new[] { "IncreaseId" });
            DropIndex("dbo.ClassSelections", new[] { "Proficiencies_PresetProficiencyId" });
            DropIndex("dbo.Characters", new[] { "RaceId" });
            DropIndex("dbo.Characters", new[] { "ClassId" });
            DropIndex("dbo.Characters", new[] { "AddedBy" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AbilityIncreases");
            DropTable("dbo.RaceSelections");
            DropTable("dbo.ClassProficiencies");
            DropTable("dbo.ClassSelections");
            DropTable("dbo.Characters");
        }
    }
}
