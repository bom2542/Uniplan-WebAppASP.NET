namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveFieldGoalTb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Goals", "GoalTypeID", "dbo.GoalTypes");
            DropIndex("dbo.Goals", new[] { "GoalTypeID" });
            RenameColumn(table: "dbo.Goals", name: "GoalTypeID", newName: "GoalType_GoalTypeID");
            AlterColumn("dbo.Goals", "GoalType_GoalTypeID", c => c.Int());
            CreateIndex("dbo.Goals", "GoalType_GoalTypeID");
            AddForeignKey("dbo.Goals", "GoalType_GoalTypeID", "dbo.GoalTypes", "GoalTypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "GoalType_GoalTypeID", "dbo.GoalTypes");
            DropIndex("dbo.Goals", new[] { "GoalType_GoalTypeID" });
            AlterColumn("dbo.Goals", "GoalType_GoalTypeID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Goals", name: "GoalType_GoalTypeID", newName: "GoalTypeID");
            CreateIndex("dbo.Goals", "GoalTypeID");
            AddForeignKey("dbo.Goals", "GoalTypeID", "dbo.GoalTypes", "GoalTypeID", cascadeDelete: true);
        }
    }
}
