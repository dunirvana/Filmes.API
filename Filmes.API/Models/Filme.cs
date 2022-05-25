using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes.API.Models
{
    public class Filme
    {
        public string Titulo { get; set; }

        public string Genero{ get; set; }

        public string Diretor { get; set; }

        public int Duracao { get; set; }

        public override string ToString()
        {
            return $"Filme:{Titulo} - {Genero}\r\nDiretor:{Diretor} Duracao:{Duracao}";
        }
    }
}
