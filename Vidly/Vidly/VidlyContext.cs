  
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    public class VidlyContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidlyContext()
            : base("MyConnection", throwIfV1Schema: false)
        {
        }

        public static VidlyContext Create()
        {
            return new VidlyContext();
        }
    }
}