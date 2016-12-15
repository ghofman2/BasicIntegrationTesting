namespace Vault.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileUploadExtension : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FileUploads", "Extension", c => c.String());
            AddColumn("dbo.FileUploads", "ProjectId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FileUploads", "ProjectId");
            DropColumn("dbo.FileUploads", "Extension");
        }
    }
}
