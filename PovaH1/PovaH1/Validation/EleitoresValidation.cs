using PovaH1.Models;
using PovaH1.Repository;
using System.Collections.Generic;
using System.ComponentModel;
namespace PovaH1.Validation
{
    public class EleitoresValidation
    {
        Eleitores? eleitores =
    IEleitoresRepoository.BuscarPorCPF(Eleitores.CPF);

    }
    }
