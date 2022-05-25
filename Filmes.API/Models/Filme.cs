using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes.API.Models
{
    public class Filme
    {
        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [StringLength(60)]
        public string Genero{ get; set; }

        [Required]
        [StringLength(100)]
        public string Diretor { get; set; }

        [Required]
        [Range(1, 600)]
        public int Duracao { get; set; }

        public override string ToString()
        {
            return $"Filme:{Titulo} - {Genero}\r\nDiretor:{Diretor} Duracao:{Duracao}";
        }
    }
}
