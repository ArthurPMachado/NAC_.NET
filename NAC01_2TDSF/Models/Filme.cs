using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NAC01_2TDSF.Models
{
    public class Filme
    {
        [HiddenInput]
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Sinopse { get; set; }

        public Genero Genero { get; set; }

        public string Descricao { get; set; }

        [Display(Name = "Duração em minutos")]
        public int Duracao { get; set; }
    }
}
