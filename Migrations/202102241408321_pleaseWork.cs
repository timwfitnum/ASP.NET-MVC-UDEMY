namespace dbStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pleaseWork : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1980-01-01' AS DATETIME) WHERE Id = 1");
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.String());
        }
    }
}
