namespace E_book2.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public bool IsCurrentlyValid =>
            IsActive &&
            StartDate <= DateTime.UtcNow &&
            EndDate > DateTime.UtcNow;
    }
}
