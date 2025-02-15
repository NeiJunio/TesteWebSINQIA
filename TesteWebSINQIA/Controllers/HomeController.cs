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

        public IActionResult Index(string termoBusca, int pagina = 1, int itensPorPagina = 6) // a string termoBusca vem com o valor que foi captado no front, dentro do input identificado com name="termoBusca", ou seja, através dessa identificação no front, armazena-se o valor na variável, e aqui no método esse valor é recuperado
        {
            var consulta = _dbContext.PontosTuristicos.AsQueryable(); // navega até o banco, e transforma a tabela PontosTurísticos em uma tabela "consultável"


            if (!_dbContext.PontosTuristicos.Any())
            {
                ViewBag.Mensagem = "Nenhum ponto turístico cadastrado ainda.";
                return View(new List<PontosTuristicosModel>()); // Retorna uma lista vazia para a View
            }

            // Se um termo de busca for fornecido, filtra os resultados
            if (!string.IsNullOrWhiteSpace(termoBusca)) // como condição, não pode ser null, vazio ou conter apenas espaços 
            {
                consulta = consulta.Where(pontoTuristico => pontoTuristico.Nome.Contains(termoBusca) ||
                                                            pontoTuristico.Cidade.Contains(termoBusca) ||
                                                            pontoTuristico.Estado.Contains(termoBusca) ||
                                                            pontoTuristico.Descricao.Contains(termoBusca) ||
                                                            pontoTuristico.Endereco.Contains(termoBusca) ||
                                                            pontoTuristico.Referencia.Contains(termoBusca));
            }

            consulta = consulta.OrderByDescending(pontoTuristico => pontoTuristico.DataCriacao); // ordena listagem por data decrescente de criação

            int totalRegistros = consulta.Count(); // conta quantos registros existe
            var totalPaginas = (int)Math.Ceiling((double)totalRegistros / itensPorPagina); // TOTAL DE PÁGINAS: divide o número total de registros pelo valor da variável itensPorPagina(6) que foi passado no parâmetro do método. O resultado, se for um resultado decimal, "arredonda" para o próximo número inteiro

            var pontosTuristicos = consulta
                .Skip((pagina - 1) * itensPorPagina) // SKIP significa pular, e nesse caso é usado para "pular" as páginas anteriores;  pagina sempre começa com valor 1, conforme definido por parametro, e após isso, cada vez que avança na paginação, +1 é adicionado ao valor da variável pagina la no front por meio da propriedade asp-route-pagina, e esse novo valor é recuperado aqui no método 
                .Take(itensPorPagina)
                .ToList(); // Converte a resposta em uma lista para exibição

            ViewBag.PaginaAtual = pagina; // PaginaAtual sempre fica atualizado conforme o valor da var pagina é atualizado e recebido pela url
            ViewBag.TotalPaginas = totalPaginas;
            ViewBag.TermoBusca = termoBusca; // Para manter o termo de busca na tela

            if (!pontosTuristicos.Any() && !string.IsNullOrEmpty(termoBusca))
            {
                ViewBag.Mensagem = "Nenhum ponto turístico encontrado para a pesquisa.";
            }

            return View(pontosTuristicos);
        }
    }
}
