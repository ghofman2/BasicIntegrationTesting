namespace Vault.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomFields : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FieldNumber = c.Int(nullable: false),
                        FieldName = c.String(),
                        DbType = c.Int(nullable: false),
                        CabinetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cabinets", t => t.CabinetId, cascadeDelete: true)
                .Index(t => t.CabinetId);
            
            AddColumn("dbo.Folders", "Field1", c => c.String());
            AddColumn("dbo.Folders", "Field2", c => c.String());
            AddColumn("dbo.Folders", "Field3", c => c.String());
            AddColumn("dbo.Folders", "Field4", c => c.String());
            AddColumn("dbo.Folders", "Field5", c => c.String());
            AddColumn("dbo.Folders", "Field6", c => c.String());
            AddColumn("dbo.Folders", "Field7", c => c.String());
            AddColumn("dbo.Folders", "Field8", c => c.String());
            AddColumn("dbo.Folders", "Field9", c => c.String());
            AddColumn("dbo.Folders", "Field10", c => c.String());
            AddColumn("dbo.Folders", "Field11", c => c.String());
            AddColumn("dbo.Folders", "Field12", c => c.String());
            AddColumn("dbo.Folders", "Field13", c => c.String());
            AddColumn("dbo.Folders", "Field14", c => c.String());
            AddColumn("dbo.Folders", "Field15", c => c.String());
            AddColumn("dbo.Folders", "Field16", c => c.String());
            AddColumn("dbo.Folders", "Field17", c => c.String());
            AddColumn("dbo.Folders", "Field18", c => c.String());
            AddColumn("dbo.Folders", "Field19", c => c.String());
            AddColumn("dbo.Folders", "Field20", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomFields", "CabinetId", "dbo.Cabinets");
            DropIndex("dbo.CustomFields", new[] { "CabinetId" });
            DropColumn("dbo.Folders", "Field20");
            DropColumn("dbo.Folders", "Field19");
            DropColumn("dbo.Folders", "Field18");
            DropColumn("dbo.Folders", "Field17");
            DropColumn("dbo.Folders", "Field16");
            DropColumn("dbo.Folders", "Field15");
            DropColumn("dbo.Folders", "Field14");
            DropColumn("dbo.Folders", "Field13");
            DropColumn("dbo.Folders", "Field12");
            DropColumn("dbo.Folders", "Field11");
            DropColumn("dbo.Folders", "Field10");
            DropColumn("dbo.Folders", "Field9");
            DropColumn("dbo.Folders", "Field8");
            DropColumn("dbo.Folders", "Field7");
            DropColumn("dbo.Folders", "Field6");
            DropColumn("dbo.Folders", "Field5");
            DropColumn("dbo.Folders", "Field4");
            DropColumn("dbo.Folders", "Field3");
            DropColumn("dbo.Folders", "Field2");
            DropColumn("dbo.Folders", "Field1");
            DropTable("dbo.CustomFields");
        }
    }
}
