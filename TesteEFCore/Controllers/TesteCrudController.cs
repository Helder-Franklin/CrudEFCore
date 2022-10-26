using Microsoft.AspNetCore.Mvc;
using TesteEFCore.Data;
using TesteEFCore.Models;

namespace TesteEFCore.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
       
        }

        [HttpPost]

        public async Task <IActionResult> Add(AddAlunoViewModel addAlunoRequest)
        {
            var aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = addAlunoRequest.Nome,
                Email = addAlunoRequest.Email,
                DataNascimento = addAlunoRequest.DataNascimento
            };

            await _contexto.Alunos.AddAsync(aluno);
            await _contexto.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
