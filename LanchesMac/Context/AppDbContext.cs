using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context;

public class AppDbContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; } = null!;
    public DbSet<Lanche> Lanches { get; set; } = null!;

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}
