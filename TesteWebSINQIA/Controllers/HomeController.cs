using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TesteWebSINQIA.Data;
using TesteWebSINQIA.Models;

namespace TesteWebSINQIA.Controllers
{
    public class HomeController : Controller
    {
        readonly private AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(string termoBusca, int pagina = 1, int itensPorPagina = 6)
        {
            var consulta = _dbContext.PontosTuristicos.AsQueryable();

            // Se um termo de busca for fornecido, filtra os resultados
            if (!string.IsNullOrWhiteSpace(termoBusca))
            {
                consulta = consulta.Where(p => p.Nome.Contains(termoBusca) ||
                                               p.Cidade.Contains(termoBusca) ||
                                               p.Estado.Contains(termoBusca));
            }

            int totalRegistros = consulta.Count();
            var totalPaginas = (int)Math.Ceiling((double)totalRegistros / itensPorPagina);

            var pontosTuristicos = consulta
                .Skip((pagina - 1) * itensPorPagina)
                .Take(itensPorPagina)
                .ToList();

            ViewBag.PaginaAtual = pagina;
            ViewBag.TotalPaginas = totalPaginas;
            ViewBag.TermoBusca = termoBusca; // Para manter o termo de busca na tela

            if (!pontosTuristicos.Any() && !string.IsNullOrEmpty(termoBusca))
            {
                ViewBag.Mensagem = "Nenhum ponto turístico encontrado para a pesquisa.";
            }

            return View(pontosTuristicos);
        }

        // public IActionResult Index(int pagina = 1)
        // {
        //     int itensPorPagina = 6;
        //     int totalItens = _dbContext.PontosTuristicos.Count();

        //     var pontosTuristicos = _dbContext.PontosTuristicos
        //         .Skip((pagina - 1) * itensPorPagina) // Pula os itens das páginas anteriores
        //         .Take(itensPorPagina) // Pega apenas os 6 itens da página atual
        //         .ToList();

        //     ViewBag.PaginaAtual = pagina;
        //     ViewBag.TotalPaginas = (int)Math.Ceiling((double)totalItens / itensPorPagina);

        //     return View(pontosTuristicos);
        // }


        // public IActionResult Index()
        // {
        //     IEnumerable<PontosTuristicosModel> pontosTuristicos = _dbContext.PontosTuristicos; // busca a model, depois define o nome "pontosTuristicos", em seguida acessa o banco, por meio da váriavel _dbContext, e logo após, acessa a tabela PontosTuristicos por meio do sufixo ".PontosTuristicos"
        //     return View(pontosTuristicos); // retorna o Inumerable pontosTuristicos dentor da view
        // }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(PontosTuristicosModel pontosTuristicos)
        {
            if (ModelState.IsValid)
            {
                _dbContext.PontosTuristicos.Add(pontosTuristicos); // Envia os dados para o banco
                _dbContext.SaveChanges(); // Salva as alterações no banco

                return RedirectToAction(nameof(Index)); // Sai da página de cadastro e automaticamente redireciona para a página index
            }

            return View(pontosTuristicos);
        }
    }
}
