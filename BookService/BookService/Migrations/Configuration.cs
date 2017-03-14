namespace BookService.Migrations
{
    using System.Data.Entity.Migrations;
    using BookService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            context.Authors.AddOrUpdate(x => x.Id,
                new Author() {Id = 1, Name = "Alex Scarrow"},
                new Author() {Id = 2, Name = "Travis Thrasher"},
                new Author() {Id = 3, Name = "Pittacus Lore"}
            );

            context.Books.AddOrUpdate(x => x.Id,
                new Book() { Id = 1, Title = "TimeRiders", Year = 2010, AuthorId = 1, Price = 9.99M, Genre = "Time travel thriller" },
                new Book() { Id = 2, Title = "Solitary Tales", Year = 2010, AuthorId = 2, Price = 6.95M, Genre = "Suspense horror" },
                new Book() { Id = 2, Title = "Marvelous", Year = 2014, AuthorId = 2, Price = 8.95M, Genre = "Suspense" },
                new Book() { Id = 4, Title = "I Am Number Four", Year = 2010, AuthorId = 3,Price = 12.99M, Genre = "Alien thriller" }
            );
        }
    }
}
