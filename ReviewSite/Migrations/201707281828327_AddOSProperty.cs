namespace ReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOSProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "OS", c => c.String());
            DropColumn("dbo.Categories", "Model");
            DropColumn("dbo.Categories", "ReleaseYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "ReleaseYear", c => c.DateTime(nullable: false));
            AddColumn("dbo.Categories", "Model", c => c.String());
            AlterColumn("dbo.Categories", "OS", c => c.Boolean(nullable: false));
        }
    }
}
