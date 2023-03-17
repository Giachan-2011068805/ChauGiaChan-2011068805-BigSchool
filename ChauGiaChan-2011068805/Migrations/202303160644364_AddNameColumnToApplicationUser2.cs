namespace ChauGiaChan_2011068805.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "ChauGiaChan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "ChauGiaChan", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
