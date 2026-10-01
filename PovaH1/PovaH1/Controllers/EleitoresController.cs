using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PovaH1.Models;
using PovaH1.Repository;

namespace PovaH1.Controllers;

[ApiController]

[Route("api/[controller]")]
public class EleitoresController : ControllerBase
{
    // Variável que permite acessar o repositório
    private readonly IEleitoresRepository repository;

    // Recebe o repositório por Injeção de Dependência
    public EleitoresController(IEleitoresRepository repository)
    {
        this.repository = repository;
    }

    // Método POST para cadastrar um Eleitor
    [HttpPost]
    public IActionResult Cadastrar(Eleitores eleitores)
    {


        // adiciona o Eleitor ao repositório
        repository.AdicionarEleitores(eleitores);

        // Retorna o código HTTP 201, indicando que foi criado
        return Created("", eleitores);

        // Verifica se já existe um eleitor com o mesmo CPF
        Eleitores? existente =
            repository.BuscarPorCPF(Eleitores.cPF());


        if (existente != null)
        {
            return BadRequest("O eleitor não pode ser cadastrado mais de uma vez.");
        }
        else
        {
            return BadRequest("O eleitor não existe");
        }
    }

    // Método GET para listar todos os candidatos
    [HttpGet]
    public IActionResult Listar()
    {
        // Busca os candidatos e retorna o código HTTP 200
        return Ok(repository.Listareleitores());



        

        


    }
}

    

