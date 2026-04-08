// See https://aka.ms/new-console-template for more information
using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

Console.WriteLine("Hello, World!");

//using(ApplicationDbContext context= new())
//{
//    context.Database.EnsureCreated();
//    if(context.Database.GetPendingMigrations().Count() > 0)
//    {
//        context.Database.Migrate();
//    }
//}

//AddBook();
//GetAllBooks();
//GetBook();
//UpdateBook();
DeleteBook();

void DeleteBook()
{
    using var context = new ApplicationDbContext();
    var books = context.Books.Find(7);
    context.Books.Remove(books);
    context.SaveChanges();
}

void UpdateBook()
{
    try
    {
        using var context = new ApplicationDbContext();
        var books = context.Books.Find(6);
        books.ISBN = "777";
        context.SaveChanges();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void GetBook()
{
    try
    {
        using var context = new ApplicationDbContext();
        var books = context.Books.Skip(0).Take(2);
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} - {book.ISBN}");
        }

        books = context.Books.Skip(4).Take(1);
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} - {book.ISBN}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = context.Books.ToList();
    foreach (var book in books)
    {
        Console.WriteLine($"{book.Title} - {book.ISBN}");
    }
}

void AddBook()
{
    Book book = new Book
    {
        Title = "New EF Core Book",
        ISBN = "1231231212",
        Price = 10.93m,
        Publisher_Id = 1
    };

    using var context = new ApplicationDbContext();
    var books = context.Books.Add(book);
    context.SaveChanges();
}