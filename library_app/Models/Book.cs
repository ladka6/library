using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace library_app.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "name")]
        public string Name { get; set; }

        [Display(Name = "author")]
        public string Author { get; set; }

        [Display(Name = "url")]
        public string ImageUrl { get; set; }

        [Display(Name = "available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "borrower")]
        public string? BorrowerName { get; set; }

        [Display(Name = "returnDate")]
        public DateTime? ReturnDate { get; set; }

        public Book()
        {
            IsAvailable = true;
        }
    }
}
