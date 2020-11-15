namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSchemaPlaner : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Planners");
            AlterColumn("dbo.Planners", "PlannerId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Planners", "PlannerId");
            DropColumn("dbo.Planners", "GoalTypeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Planners", "GoalTypeID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Planners");
            AlterColumn("dbo.Planners", "PlannerId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Planners", "GoalTypeID");
        }
    }
}
