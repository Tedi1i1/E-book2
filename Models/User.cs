using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Data;

namespace E_book2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

        public ICollection<Order> Orders { get; set; }
           

        public ICollection<Review> Reviews { get; set; }
            = new List<Review>();

        public ICollection<Subscription> Subscriptions { get; set; }
            = new List<Subscription>();
    }
}
