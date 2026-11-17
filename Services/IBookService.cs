using E_book2.Models;

namespace E_book2.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();

        Task<Book?> GetBookByIdAsync(int id);

        Task AddBookAsync(Book book);

        Task UpdateBookAsync(Book book);

        Task DeleteBookAsync(int id);
    }
}