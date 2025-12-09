using Microsoft.AspNetCore.Mvc;

namespace DevConnect.Controllers
{
    public class FeedController : Controller
    {
        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Postar(IFormCollection form)
        {
            string conteudo = form["Conteudo"];
            IFormFile imagem = form.Files.FirstOrDefault();

            // Aqui você poderá salvar no banco futuramente
            // Eu deixo isso pronto para você implementar depois

            TempData["PostCriado"] = "Publicação realizada com sucesso!";

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
