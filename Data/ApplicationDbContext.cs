
using E_book2.Models;
using E_book2.Models;
using Microsoft.EntityFrameworkCore;

namespace E_book2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<BorrowRecord> BorrowRecords { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<PromoCode> PromoCodes { get; set; }
    }
}
