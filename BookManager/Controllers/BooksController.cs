using Microsoft.AspNetCore.Mvc;
using BookManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookManager.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "awudwa", Author = "ytuntynut", Genre = "awectretb", PublishedYear = 1949, Description = "akwoçkdfgkdugr." },
            new Book { Id = 2, Title = "ajwdawjd", Author = "vaserv", Genre = "tyjkgugbn", PublishedYear = 1925, Description = "awamxnwjhwrc." },
            new Book { Id = 3, Title = "klajwdwia", Author = "vthrhrth", Genre = "tyjbdft", PublishedYear = 1960, Description = "lajwjeiawkdmawd." }
        };

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            return View(book);
        }
    }
}
