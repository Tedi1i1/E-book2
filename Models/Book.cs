using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace E_book2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsEBook { get; set; }
        public string? FileFormat { get; set; }
        public string? FileUrl { get; set; }
        public string? PreviewUrl { get; set; }
        public DateTime PublishedAt { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; }
            = new List<OrderItem>();


        public ICollection<Review> Reviews { get; set; }
            = new List<Review>();
    }
}
