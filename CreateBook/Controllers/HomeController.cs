using CreateBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CreateBook.Controllers
{
    public class HomeController : Controller
    {
        private static List<Book> books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name = "Mexrobdan Chayon",
                    Author = "Abdulla Qodir",
                    Price = 100000
                },
                new Book
                {
                    Id = 2,
                    Name = "Mexrobdan Chayon",
                    Author = "Abdulla Qodir",
                    Price = 100000
                },
                new Book
                {
                    Id = 3,
                    Name = "Mexrobdan Chayon",
                    Author = "Abdulla Qodir",
                    Price = 100000
                },
                new Book
                {
                    Id = 4,
                    Name = "Outliers",
                    Author = "Taleb Nassim",
                    Price = 100000
                },
            };

        [HttpGet]
        public IActionResult Index()
        {
            return View(books);
        }
        public IActionResult Book()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book request)
        {
            books.Add(request);
            return RedirectToAction("index");
        }
    }
}