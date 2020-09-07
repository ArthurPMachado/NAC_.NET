using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NAC01_2TDSF.Models;

namespace NAC01_2TDSF.Controllers
{
    public class FilmeController : Controller
    {
        private static List<Filme> _banco = new List<Filme>();

        // Home page dos filmes
        public IActionResult Index()
        {
            return View();
        }
    }
}
