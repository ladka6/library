using library_app.Data.Services;
using library_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace library_app.Controllers
{
    public class BookController : Controller
    {
        private readonly IBooksService _service;
        public BookController(IBooksService service)
        {
            _service = service;
        }

        [HttpGet]
        public async  Task<IActionResult> Index() 
        { 
            var books = await _service.GetAllAsync();
            return View(books); 
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([Bind("Name,Author,ImageUrl")]Book book)
        {
            if(!ModelState.IsValid)
            {
                return View(book);
            }
            await _service.AddAsync(book);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public  IActionResult Borrow(int id) 
        {
            ViewData["Id"] = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Borrow([Bind("Id,BorrowerName,ReturnDate")]Book book)
        {
            var id = book.Id;
            var borrowedBook = await _service.GetByIdAsync(id);
            if (borrowedBook == null)
            {
                return NotFound();
            }
            _service.UpdateBorrowed(book.BorrowerName, (DateTime)book.ReturnDate, borrowedBook);
            return RedirectToAction(nameof(Index));
        }
    }
}
