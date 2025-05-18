using booksDemo.Services.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booksDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly BooksClient client;

        public OrdersController(BooksClient _client)
        {
            client = _client;
        }

        [HttpGet]
        [Route("GetOrdersList")]
        public async Task<IActionResult> getOrdersList()
        {
            var result = await client.GetAllBooksAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetOrdersByID/{id}")]
        public async Task<IActionResult> GetOrdersByID(int id)
        {
            var result = await client.GetBookByIdAsync(id);
            return Ok(result);
        }
    }
}
