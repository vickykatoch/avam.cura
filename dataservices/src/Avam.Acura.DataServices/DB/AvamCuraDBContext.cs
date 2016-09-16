
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Avam.Acura.DataServices.DB{
    public class AvamCuraDBContext : DbContext {
        public AvamCuraDBContext(DbContextOptions<AvamCuraDBContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.MapProduct();
            base.OnModelCreating(modelBuilder);
        }
    }


}