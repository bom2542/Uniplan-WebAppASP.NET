namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Goals", "GoalType_GoalTypeID", "dbo.GoalTypes");
            DropIndex("dbo.Goals", new[] { "GoalType_GoalTypeID" });
            DropColumn("dbo.Goals", "GoalType_GoalTypeID");
            DropTable("dbo.GoalTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GoalTypes",
                c => new
                    {
                        GoalTypeID = c.Int(nullable: false, identity: true),
                        GoalTypeNo = c.Int(nullable: false),
                        GoalTypeName = c.String(),
                        GoalTypeDetail = c.String(),
                    })
                .PrimaryKey(t => t.GoalTypeID);
            
            AddColumn("dbo.Goals", "GoalType_GoalTypeID", c => c.Int());
            CreateIndex("dbo.Goals", "GoalType_GoalTypeID");
            AddForeignKey("dbo.Goals", "GoalType_GoalTypeID", "dbo.GoalTypes", "GoalTypeID");
        }
    }
}
