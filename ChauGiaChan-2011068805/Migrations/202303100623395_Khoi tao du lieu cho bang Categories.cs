namespace ChauGiaChan_2011068805.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhoitaodulieuchobangCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (2, 'Business')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
