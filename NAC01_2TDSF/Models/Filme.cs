using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAC01_2TDSF.Models
{
    public class Filme
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Sinopse { get; set; }

        public Genero Genero { get; set; }

        public string Descricao { get; set; }

        public int Duracao { get; set; }
    }
}
