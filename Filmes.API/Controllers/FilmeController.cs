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

        [HttpPost]
        public void AdicionarFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine($"\r\n[AdicionarFilme]\r\n{filme}");
        }
    }
}
