using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories;

public class LancheRepository : ILancheRepository
{
    public readonly AppDbContext _context;

    public LancheRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Lanche> Lanches => _context.Lanches.Include(x => x.Categoria);

    public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Include(c => c.Categoria).Where(x => x.IsLanchePreferido);

    public Lanche? GetLancheById(int lancheId) => _context.Lanches.Include(c => c.Categoria).FirstOrDefault(x => x.LancheId == lancheId);
}
