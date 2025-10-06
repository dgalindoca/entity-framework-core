using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5); // Configuring precision and scale for decimal property
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "C# Programming", ISBN = "1234567890", Price = 29.990m },
                new Book { BookId = 2, Title = "ASP.NET Core Guide", ISBN = "0987654321", Price = 39.99m }
            );

            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "Fake Sunday", ISBN = "77652", Price = 19.990m},
                new Book { BookId = 4, Title = "Cookie Jar", ISBN = "CC12B12", Price = 25.99m },
                new Book { BookId = 5, Title = "Cloudy Forest", ISBN = "90392B33", Price = 40.99m }
            };

            modelBuilder.Entity<Book>().HasData(bookList);
        }
    }
}
