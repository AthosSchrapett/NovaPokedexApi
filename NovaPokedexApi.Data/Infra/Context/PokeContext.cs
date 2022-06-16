using Microsoft.EntityFrameworkCore;
using NovaPokedexApi.Models;

namespace NovaPokedexApi.Infra.Context
{
    public class PokeContext : DbContext
    {

        public PokeContext(DbContextOptions<PokeContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Database=NovaPokedexApiDB;User Id=postgres;Password=1234;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
            .Property(p => p.Id).IsRequired();

            builder.Entity<User>()
            .Property(p => p.CreatedIn).IsRequired();
            builder.Entity<User>()
            .Property(p => p.CreatedIn).HasColumnType("Date");
        }
    }
}
