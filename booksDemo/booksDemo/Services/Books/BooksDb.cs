using booksDemo.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace booksDemo.Services.Books
{
    public class BooksDb : ControllerBase
    {
        private readonly List<BooksModal> books = new List<BooksModal>()
        {
            new BooksModal(){Id = 1, Author= "James" ,Description = "genere is comedy", Title="FunToo"},
            new BooksModal(){Id = 2, Author= "Mike" ,Description = "genere is Horrer", Title="HorrerToo"},
            new BooksModal(){Id = 3, Author= "Jessy" ,Description = "genere is Romance", Title="RomanceToo"},
            new BooksModal(){Id = 4, Author= "Ash" ,Description = "genere is Action", Title="ACtionToo"},
        };

        [HttpGet]
        [Route("getBooks")]
        public List<BooksModal> getBooks()
        {
            return books;
        }

        [HttpGet]
        [Route("GetByID/{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok(books.FirstOrDefault(b => b.Id == id));
        }
    }
}
