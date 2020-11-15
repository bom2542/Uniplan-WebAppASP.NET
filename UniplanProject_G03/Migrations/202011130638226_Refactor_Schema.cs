namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Refactor_Schema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Curdate = c.DateTime(nullable: false),
                        Writer = c.String(),
                        Countread = c.Int(nullable: false),
                        Topic = c.String(),
                        Content1 = c.String(),
                        Content2 = c.String(),
                        UserName = c.String(),
                        Urlimg = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Topic = c.String(),
                        Description = c.String(),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(),
                        Color = c.String(),
                        Full = c.Boolean(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Topic = c.String(),
                        Detail = c.String(),
                        Percent = c.Int(nullable: false),
                        GoalTypeID = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GoalTypes", t => t.GoalTypeID, cascadeDelete: true)
                .Index(t => t.GoalTypeID);
            
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
            
            CreateTable(
                "dbo.MoodTrackers",
                c => new
                    {
                        GoalTypeID = c.Int(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        Doe = c.DateTime(),
                        Mood = c.Int(),
                        Note = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.GoalTypeID);
            
            CreateTable(
                "dbo.Planners",
                c => new
                    {
                        GoalTypeID = c.Int(nullable: false, identity: true),
                        PlannerId = c.Int(nullable: false),
                        Topic = c.String(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.GoalTypeID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "GoalTypeID", "dbo.GoalTypes");
            DropIndex("dbo.Goals", new[] { "GoalTypeID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Planners");
            DropTable("dbo.MoodTrackers");
            DropTable("dbo.GoalTypes");
            DropTable("dbo.Goals");
            DropTable("dbo.Events");
            DropTable("dbo.Blogs");
        }
    }
}
