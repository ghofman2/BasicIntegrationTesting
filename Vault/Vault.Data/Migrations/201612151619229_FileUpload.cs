namespace Vault.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileUpload : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.FileDetails", newName: "FileUploads");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.FileUploads", newName: "FileDetails");
        }
    }
}
