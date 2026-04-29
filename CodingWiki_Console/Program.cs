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

async void DeleteBook()
{
    using var context = new ApplicationDbContext();
    var books = await context.Books.FindAsync(7);
    context.Books.Remove(books);
    await context.SaveChangesAsync();
}

async void UpdateBook()
{
    try
    {
        using var context = new ApplicationDbContext();
        var books = await context.Books.FindAsync(6);
        books.ISBN = "777";
        await context.SaveChangesAsync();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

async void GetBook()
{
    try
    {
        using var context = new ApplicationDbContext();
        var books = await context.Books.Skip(0).Take(2).ToListAsync();
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} - {book.ISBN}");
        }

        books = await context.Books.Skip(4).Take(1).ToListAsync();
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

async void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = await context.Books.ToListAsync();
    foreach (var book in books)
    {
        Console.WriteLine($"{book.Title} - {book.ISBN}");
    }
}

async void AddBook()
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
    await context.SaveChangesAsync();
}