using System.Threading.Tasks;
using DevConnect.Context;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Controllers
{
    public class FeedController : Controller
    {
        private readonly DevConnectContext _context = new DevConnectContext();
        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.PublicacaoCadastrado = "";
            TempData["PublicacaoCadastrado"] = "";
            var publicacoes = _context.TbPublicacao.ToList();
            List<TbPublicacao> publicacaos = await _context.TbPublicacao.ToListAsync();
            return View(publicacaos);
        }





        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbPublicacao novaPublicacao = new TbPublicacao
            {
                Descricao = form["Descricao"].ToString(),
                DataPublicacao = DateOnly.FromDateTime(DateTime.Now),
            };

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                var path = Path.Combine(folder, file.FileName);


                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novaPublicacao.ImagemUrl = file.FileName;
            }

            try
            {
                List<TbPublicacao> publicacaos = await _context.TbPublicacao.
                Include(p => p.IdUsuarioNavigation).
                ToListAsync();
                _context.TbPublicacao.Add(novaPublicacao);
                await _context.SaveChangesAsync();

                ViewBag.PublicacaoCadastrado = "Não foi possível cadastrar!";

                return RedirectToAction(nameof(Index));
            }

            catch (Exception)
            {
                ViewBag.PublicacaoCadastrado = "Publicação cadastrada com sucesso!";
                return RedirectToAction(nameof(Index));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");


        }
        }
    }
    