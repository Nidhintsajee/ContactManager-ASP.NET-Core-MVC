using Microsoft.EntityFrameworkCore;

namespace MvcContact.Models
{
    public class MvcContactContext : DbContext
    {
        public MvcContactContext (DbContextOptions<MvcContactContext> options)
            : base(options)
        {
        }

        public DbSet<MvcContact.Models.Contact> Contact { get; set; }
        public DbSet<MvcContact.Models.Address> Address { get; set; }

    }
}