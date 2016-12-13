namespace Vault.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeletedFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cabinets", "IsDeleted", c => c.String());
            AddColumn("dbo.Folders", "IsDeleted", c => c.String());
            AddColumn("dbo.Files", "IsDeleted", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "IsDeleted");
            DropColumn("dbo.Folders", "IsDeleted");
            DropColumn("dbo.Cabinets", "IsDeleted");
        }
    }
}
