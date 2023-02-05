namespace BookStoreApp.Migrations
{
    using BookStoreApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStoreApp.Models.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStoreApp.Models.BookDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(i => i.Title,
                new Book
                {
                    Id = "1",
                    Title = "CQRS for Dummies",
                    PublishedDate = DateTime.Parse("2023-1-11"),
                    Author = "John Doe",
                    ISBN = "0-3527-2003-4",
                    BookID = "9b0896fa-3880-4c2e-bfd6-925c87f22878"
                },

                new Book
                {
                    Id = "2",
                    Title = "Visual Studio Tips",
                    PublishedDate = DateTime.Parse("2022-4-21"),
                    Author = "Mary Smith",
                    ISBN = "0-5582-6570-7",
                    BookID = "0550818d-36ad-4a8d-9c3a-a715bf15de76"
                },


                new Book
                {
                    Id = "3",
                    Title = "Visual Studio Tips",
                    PublishedDate = DateTime.Parse("2022-2-13"),
                    Author = "Mary Smith",
                    ISBN = "0-6922-3033-5",
                    BookID = "8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1"
                }
            );
        }
    }
}
