using Microsoft.EntityFrameworkCore;
using PractiseMVCproject3.Models;

namespace PractiseMVCproject3.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public  DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }
        public DbSet<Feature> Features { get; set; }

    }
}
