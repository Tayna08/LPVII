using GestaoFrota.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFrota.Controllers
{
    public class VeiculoController : Controller
    {
        // GET: Exibe o formulário em branco
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: Recebe os dados do formulário
        [HttpPost]
        public IActionResult Cadastrar(Veiculo veiculo)
        {
            return Content($"Veículo '{veiculo.Modelo}' (Placa: {veiculo.Placa}) recebido com sucesso!");
        }
    }
}