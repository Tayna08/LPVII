using EscolaSimples.Models;
using Microsoft.AspNetCore.Mvc;

namespace EscolaSimples.Controllers
{
    public class AlunoController : Controller
    {
        
        public IActionResult Criar()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Criar(Aluno aluno)
        {
            return Content($"Aluno '{aluno.Nome}' com matrícula '{aluno.Matricula}' recebido com sucesso!");
        }
    }
}