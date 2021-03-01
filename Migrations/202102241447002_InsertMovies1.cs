namespace dbStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Hangover', 5,2017-11-03, 2017-12-12,3)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Die Hard',1,2017-11-03, 2017-12-12,3)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('The Terminator', 1,2017-11-03, 2017-12-12,3)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Toy Story ', 3,2017-11-03, 2017-12-12,3)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Titanic', 4,2017-11-03, 2017-12-12,3)");

        }
        
        public override void Down()
        {
        }
    }
}
