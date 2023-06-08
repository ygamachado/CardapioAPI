using CardapioAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Produto>? Produtos { get; set; }

    }
}
