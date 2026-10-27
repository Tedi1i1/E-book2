namespace E_book2.Models
{
    public class PromoCode
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public decimal DiscountPercentage { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool IsActive { get; set; } = true;
        public int? MaxUses { get; set; }
        public int UsedCount { get; set; }

        public ICollection<Order> Orders { get; set; }
            = new List<Order>();
    }
}
