using PovaH1.Models;

namespace PovaH1.Repository
{
    public interface IEleitoresRepository
    {
        void AdicionarEleitores(Eleitores eleitores);
        Eleitores? BuscarPorCPF(string cPF);
        Eleitores? BuscarPorCPF(object cPF);
        object? Listareleitores();
    }
}