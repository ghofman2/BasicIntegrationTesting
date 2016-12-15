namespace Vault.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileUploadModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FileDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FileDetails");
        }
    }
}
