using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteWebSINQIA.Models; // import da Model para relacionar com a criação da tabela

namespace TesteWebSINQIA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<PontosTuristicosModel> PontosTuristicos { get; set; }
    }
}