namespace E_book2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Pending";
        public string DeliveryType { get; set; } = "Digital";

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int? PromoCodeId { get; set; }
        public PromoCode? PromoCode { get; set; }

        public ICollection<OrderItem> Items { get; set; }
            = new List<OrderItem>();
    }
}
