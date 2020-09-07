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
            return View(_banco);
        }

        [HttpPost]
        public IActionResult Cadastrar(Filme filme)
        {
            if (_banco.Any())
            {
                filme.Codigo = _banco[_banco.Count - 1].Codigo + 1;
            } else
            {
                filme.Codigo = 1;
            }

            _banco.Add(filme);
            TempData["msg"] = "Filme adicionado no catálogo!";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var filme = _banco.Find(item => item.Codigo == id);

            return View(filme);
        }
    }
}
