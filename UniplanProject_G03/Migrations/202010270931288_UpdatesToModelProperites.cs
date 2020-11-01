namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatesToModelProperites : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Dob", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Dob", c => c.String());
        }
    }
}
