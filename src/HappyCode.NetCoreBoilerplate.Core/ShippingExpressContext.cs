using HappyCode.NetCoreBoilerplate.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyCode.NetCoreBoilerplate.Core
{
    public partial class ShippingExpressContext : DbContext
    {
        public ShippingExpressContext(DbContextOptions<ShippingExpressContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Express> Express { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<Express>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.Type).IsUnicode(false);
            });
        }
    }
}
