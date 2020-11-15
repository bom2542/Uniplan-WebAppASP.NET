namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAI2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Planners");
            AddColumn("dbo.Planners", "PlannerId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Planners", "Topic", c => c.String());
            AddPrimaryKey("dbo.Planners", "PlannerId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Planners");
            AlterColumn("dbo.Planners", "Topic", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Planners", "PlannerId");
            AddPrimaryKey("dbo.Planners", "Topic");
        }
    }
}
