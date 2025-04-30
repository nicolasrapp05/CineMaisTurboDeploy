using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineTurbo.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public int AvaliacaoImdb { get; set; }
        public int AvaliacaoTomates { get; set; }
        public string Foto { get; set; }
        public string Genero { get; set; }
        public int Avaliacao { get; set; }
        public string Duracao { get; set; }
        public DateTime Lancamento { get; set; }
    }
}