namespace UniplanProject_G03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DetailStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Nick", c => c.String());
            AddColumn("dbo.AspNetUsers", "Dob", c => c.String());
            AddColumn("dbo.AspNetUsers", "Sex", c => c.String());
            AddColumn("dbo.AspNetUsers", "StudentID", c => c.String());
            AddColumn("dbo.AspNetUsers", "University", c => c.String());
            AddColumn("dbo.AspNetUsers", "Institute", c => c.String());
            AddColumn("dbo.AspNetUsers", "Branch", c => c.String());
            AddColumn("dbo.AspNetUsers", "Year", c => c.String());
            AddColumn("dbo.AspNetUsers", "Motto", c => c.String());
            AddColumn("dbo.AspNetUsers", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Url");
            DropColumn("dbo.AspNetUsers", "Motto");
            DropColumn("dbo.AspNetUsers", "Year");
            DropColumn("dbo.AspNetUsers", "Branch");
            DropColumn("dbo.AspNetUsers", "Institute");
            DropColumn("dbo.AspNetUsers", "University");
            DropColumn("dbo.AspNetUsers", "StudentID");
            DropColumn("dbo.AspNetUsers", "Sex");
            DropColumn("dbo.AspNetUsers", "Dob");
            DropColumn("dbo.AspNetUsers", "Nick");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
