using PovaH1.Models;

namespace PovaH1.Repository
{
    // Classe responsável por armazenar e manipular os dados
    public class CandidatoRepository : IEleitoresRepository
    {
        // Lista que armazena os candidatos em memória
        private static List<Eleitores> candidatos = [];


        // Adiciona um candidato na lista
        public void AdicionarEleitores(Eleitores eleitores)
        {
            candidatos.Add(eleitores);
        }

        public Eleitores? BuscarPorCPF(string cPF)
        {
            throw new NotImplementedException();
        }

        public Eleitores? BuscarPorCPF(object cPF)
        {
            throw new NotImplementedException();
        }

        // Retorna a lista completa de Eleitores
        public List<Eleitores> ListarEleitores()
        {
            return Listareleitores;
        }

        public object? Listareleitores()
        {
            throw new NotImplementedException();
        }
    }
}