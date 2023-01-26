using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassPopulacao;

namespace PopulacaoAPI.Data
{
    public class PopulacaoAPIContext : DbContext
    {
        public PopulacaoAPIContext (DbContextOptions<PopulacaoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ClassPopulacao.Country> Country { get; set; } = default!;
    }
}
