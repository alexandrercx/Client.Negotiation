using Microsoft.EntityFrameworkCore;
using Client.Negotiation.Domain.Entity;

namespace Client.Negotiation.Infrastructure.Context
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }           
        
        public DbSet<FinancialProduct> FinancialProducts { get; set; }

        public DbSet<ProductClient> ProductClient { get; set; }

        public DbSet<Domain.Entity.Client> Client {get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
