
namespace E_book2.Models

{
    public class BorrowRecord : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }

        public int BookId { get; set; }

        public Book? Book { get; set; }

        public DateTime BorrowDate { get; set; }
            = DateTime.UtcNow;

        public DateTime ExpiryDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public bool IsReturned { get; set; }
    }
}
