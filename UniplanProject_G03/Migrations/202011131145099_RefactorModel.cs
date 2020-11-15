namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Goals", "GoalType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Goals", "GoalType");
        }
    }
}
