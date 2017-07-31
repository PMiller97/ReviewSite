namespace ReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "ScreenSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "ScreenSize", c => c.Double(nullable: false));
        }
    }
}
