namespace Vault.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIsDeletedType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cabinets", "IsDeleted", c => c.Int(nullable: false));
            AlterColumn("dbo.Folders", "IsDeleted", c => c.Int(nullable: false));
            AlterColumn("dbo.Files", "IsDeleted", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Files", "IsDeleted", c => c.String());
            AlterColumn("dbo.Folders", "IsDeleted", c => c.String());
            AlterColumn("dbo.Cabinets", "IsDeleted", c => c.String());
        }
    }
}
