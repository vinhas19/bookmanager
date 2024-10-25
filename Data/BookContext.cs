 using Microsoft.EntityFrameworkCore;
   using BookManager.Models;

   namespace BookManager.Data
   {
       public class BookContext : DbContext
       {
           public BookContext(DbContextOptions<BookContext> options) : base(options) { }

           public DbSet<Book> Books { get; set; }
       }
   }