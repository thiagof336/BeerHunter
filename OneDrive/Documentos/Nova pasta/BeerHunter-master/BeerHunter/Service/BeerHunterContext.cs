using BeerHunter.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerHunter.Service
{
    class BeerHunterContext: DbContext
    {
        public BeerHunterContext() : base("PgBeerHunter")
        {
        }
        public DbSet<Cerveja> Cerveja{ get; set; }
        public DbSet<Avaliacao> Avaliacaos { get; set; }
        public DbSet<CadastraCerveja> CadastraCerveja { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
