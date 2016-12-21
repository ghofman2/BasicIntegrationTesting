namespace Vault.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sync : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.FileUploads");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FileUploads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        Path = c.String(),
                        Extension = c.String(),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
