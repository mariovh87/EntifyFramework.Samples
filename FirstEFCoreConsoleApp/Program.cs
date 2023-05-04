using FirstEFCoreConsoleApp;
using FirstEFCoreConsoleApp.Model;
using Microsoft.EntityFrameworkCore;

await using var context = new LibraryContext();
//await context.Database.EnsureCreatedAsync();
//var author = new Author() { Name = "Stephen", LastName = "King" };
//var book = new Book() { Title = "The Shining", Sinopsis = "A family goes to a hotel", Author = author };
//context.Authors.Add(author);
//context.Books.Add(book); 
//await context.SaveChangesAsync();
var bookkFromDb = await context.Books.FirstOrDefaultAsync(b=>b.Title== "The Shining");
var tittle = bookkFromDb.Title;
