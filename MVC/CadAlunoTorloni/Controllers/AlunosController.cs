

using CadAlunoTorloni.Models;
using CadlunoTorloni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CadAlunoTorloni.Controllers
{
    
    public class AlunosController : Controller
    {
        public static List<Aluno> Alunos = new List<Aluno>()
        {
            // new Aluno { Id = 1, Nome = "Nathan", Idade = 20 },
            // new Aluno { Id = 2, Nome = "Felipe", Idade = 24 },
            // new Aluno { Id = 3, Nome = "Eloysa", Idade = 15 },
            // new Aluno { Id = 4, Nome = "Barney", Idade = 10 }
        };

        private readonly CadAlunoTorloniContext _context;
        
        
        private readonly ILogger<AlunosController> _logger;

        public AlunosController(ILogger<AlunosController> logger, CadAlunoTorloniContext context)
        {
            _logger = logger;
            _context = context;
        }

        // public IActionResult Index()
        // {
        //     return View(Alunos);
        // }
        public async Task<IActionResult> Index()
        {
            var Alunos = await _context.Alunos.ToListAsync();
            return View(Alunos);
        }
        [HttpGet]

        [HttpGet]
        public IActionResult Create(Aluno aluno)
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Aluno aluno)
        {
            Aluno novoAluno = new Aluno();
            novoAluno.Id = Alunos.Count + 1;
            novoAluno.Nome = aluno.Nome;
            novoAluno.Idade = aluno.Idade;
            Alunos.Add(novoAluno);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}