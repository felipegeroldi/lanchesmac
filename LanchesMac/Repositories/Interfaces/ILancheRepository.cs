using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces;

public interface ILancheRepository
{
    public IEnumerable<Lanche> Lanches { get; }
    public IEnumerable<Lanche> LanchesPreferidos { get; }
    public Lanche? GetLancheById(int lancheId);
}
