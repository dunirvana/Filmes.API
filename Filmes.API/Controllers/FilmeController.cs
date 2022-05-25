using Filmes.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public void AdicionarFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);

            Console.WriteLine($"\r\n[AdicionarFilme]\r\n{filme}");
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            Console.WriteLine($"\r\n[RecuperarFilmes]\r\nTotal de filmes:{filmes.Count}");
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme RecuperarFilmePorId(int id)
        {
            var filme = filmes.FirstOrDefault(f => f.Id == id);

            Console.WriteLine($"\r\n[RecuperarFilmePorId]\r\nId procurado:{id}\r\nEncontrou:{filme}");

            return filme;
        }
    }
}
