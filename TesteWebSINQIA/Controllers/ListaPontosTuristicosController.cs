using Microsoft.AspNetCore.Mvc;
using TesteWebSINQIA.Data;
using TesteWebSINQIA.Models;

namespace TesteWebSINQIA.Controllers
{
    public class ListaPontosTuristicosController : Controller
    {
        readonly private AppDbContext _dbContext;

        public ListaPontosTuristicosController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(PontosTuristicosModel pontosTuristicos)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine($"Estado: {pontosTuristicos.Estado}, Cidade: {pontosTuristicos.Cidade}");

                _dbContext.PontosTuristicos.Add(pontosTuristicos); // Envia os dados para o banco
                _dbContext.SaveChanges(); // Salva as alterações no banco

                return RedirectToAction("Index", "Home");
                // Sai da página de cadastro e automaticamente redireciona para a página index
            }

            return View(pontosTuristicos);
        }


        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound(); // Se o Id for nulo ou igual a zero, retornará a mensagem de erro (NotFound)
            }

            var pontoTuristico = _dbContext.PontosTuristicos.FirstOrDefault(pontoTuristico => pontoTuristico.Id == id);

            if (pontoTuristico == null)
            {
                return NotFound(); // Se não encontrar o ponto turístico, retornará a mensagem de erro (NotFound)
            }

            return View(pontoTuristico);
        }


        [HttpPost]
        public IActionResult Editar(PontosTuristicosModel pontosTuristico)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Update(pontosTuristico); // Atualiza os dados no banco
                _dbContext.SaveChanges(); // Salva as alterações no banco

                return RedirectToAction("Index", "Home"); // Sai da página de edição e automaticamente redireciona para a página index
            }

            return View(pontosTuristico);
        }


        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound(); // Se o Id for nulo ou igual a zero, retornará a mensagem de erro (NotFound)
            }

            var pontoTuristico = _dbContext.PontosTuristicos.FirstOrDefault(pontoTuristico => pontoTuristico.Id == id);

            if (pontoTuristico == null)
            {
                return NotFound(); // Se não encontrar o ponto turístico, retornará a mensagem de erro (NotFound)
            }

            return View(pontoTuristico);
        }


    }
}

