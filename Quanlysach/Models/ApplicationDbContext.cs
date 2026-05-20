using Microsoft.EntityFrameworkCore;

namespace Quanlysach.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Category
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Công nghệ"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Lập trình"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Kinh doanh"
                }
            );

            // Seed Book
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "ASP.NET Core MVC",
                    Author = "Khanh",
                    Price = 100,
                    Description = "Học ASP.NET Core",
                    Image = "book1.jpg",
                    CategoryId = 1
                },

                new Book
                {
                    Id = 2,
                    Title = "C# Advanced",
                    Author = "Tong",
                    Price = 200,
                    Description = "Lập trình C# nâng cao",
                    Image = "book2.jpg",
                    CategoryId = 2
                },

                new Book
                {
                    Id = 3,
                    Title = "Startup 2026",
                    Author = "Bao Khanh",
                    Price = 150,
                    Description = "Kinh doanh hiện đại",
                    Image = "book3.jpg",
                    CategoryId = 3
                }
            );
        }
    }
}