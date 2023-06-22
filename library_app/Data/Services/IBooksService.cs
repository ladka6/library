using library_app.Models;

namespace library_app.Data.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task<Book> AddAsync(Book book);

        Book UpdateBorrowed(string borrowerName,DateTime borrowedDate,Book book);
   
    }
}
