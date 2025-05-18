using booksDemo.Models;

namespace booksDemo.Services.Books
{
    public class BooksClient
    {
       
            private readonly HttpClient _httpClient;

            public BooksClient(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task<BooksModal?> GetBookByIdAsync(int id)
            {
                return await _httpClient.GetFromJsonAsync<BooksModal>($"https://localhost:7006/GetByID/{id}");
            }
        public async Task<List<BooksModal>?> GetAllBooksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<BooksModal>>("https://localhost:7006/getBooks");
        }
    }
}
