using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CadAlunoTorloni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CadlunoTorloni.Controllers
{
    public class FrutaController : Controller
    {
        private readonly ILogger<FrutaController> _logger;

        public FrutaController(ILogger<FrutaController> logger)
        {
            _logger = logger;
        }



        // Criar uma lista de frutas
        private static List<Fruta> Frutas = new List<Fruta>()
        {
            new Fruta() { id = 1, Nome = "Maça", Cor = "Vermelho", Categoria="Cítrica" },
            new Fruta() { id = 2, Nome = "Banana", Cor = "Amarela", Categoria="Tropical" },
            new Fruta() { id = 3, Nome = "Uva", Cor = "Roxa", Categoria="Cítrica" },
            new Fruta() { id = 4, Nome = "Abacaxi", Cor = "Amarela", Categoria="Tropical" },
            new Fruta() { id = 5, Nome = "Limão", Cor = "Verde", Categoria="Cítrica" },
        };

        public IActionResult Index()
        {
            return View(Frutas);
        }
        public IActionResult FrutasCitricas()
        {
            return View();
        }
        public IActionResult FrutasTropicais()
        {
            return View();
        }
        // action pra cadastrar nova fruta
        public IActionResult Create()
        {
            return View();
        }
        // metodo pra salvar uma fruta
        [HttpPost]
        public IActionResult Create(Fruta fruta)
        {
            // cria um id novo
            fruta.id = Frutas.Max(f => f.id) + 1;
            // salvar no array
            Frutas.Add(fruta);
            // redirecionar o usuario para a index
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}