namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveField : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Planners");
            AlterColumn("dbo.Planners", "Topic", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Planners", "Topic");
            DropColumn("dbo.Planners", "PlannerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Planners", "PlannerId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Planners");
            AlterColumn("dbo.Planners", "Topic", c => c.String());
            AddPrimaryKey("dbo.Planners", "PlannerId");
        }
    }
}
