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

        [HttpGet]
        public IActionResult Filtrar(string nome)
        {
            var filtro = _banco;
            if(nome != null)
            {
                filtro = _banco.Where(item => item.Nome.Contains(nome)).OrderBy(item => item.Duracao).ToList();
            } 
         
            return View("Index", filtro); 
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

        [HttpPost]
        public IActionResult Atualizar(Filme filme)
        {
            var indexFilme = _banco.FindIndex(item => item.Codigo == filme.Codigo);
            _banco[indexFilme] = filme;

            TempData["msg"] = "Filme Atualizado!";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            var indexFilme = _banco.FindIndex(item => item.Codigo == id);
            _banco.RemoveAt(indexFilme);

            TempData["msg"] = "Filme removido do catálogo!";

            return RedirectToAction("Index");
        }
    }
}
