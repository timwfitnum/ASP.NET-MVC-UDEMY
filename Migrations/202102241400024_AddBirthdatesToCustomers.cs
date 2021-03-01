namespace dbStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdatesToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate ='15/06/1998' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
