using library_app.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace library_app.Data.Services
{
    public class BooksService : IBooksService
    {
        private readonly AppDbContext _context;

        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Book> AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            var books = await _context.Books.ToListAsync();
            return books;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            return book;
        }

        public Book UpdateBorrowed(string borrowerName, DateTime returnDate, Book book)
        {
            if(returnDate < DateTime.Today)
            {
                throw new InvalidOperationException("Return date cannot be in the future");
            }

            book.BorrowerName = borrowerName;
            book.ReturnDate = returnDate.Date;
            book.IsAvailable = false;

            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();

            return book;
        }
    }
}
