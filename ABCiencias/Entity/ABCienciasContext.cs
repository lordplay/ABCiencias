using ABCiencias.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Entity
{
    public class ABCienciasContext : DbContext, IABCienciasContext
    {
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<CategoriaServico> CategoriaServico { get; set; }
        public DbSet<ServicoFornecedor> ServicoFornecedor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B9MSDME\SQLEXPRESS;Initial Catalog=ABCiencias;Integrated Security=True");
        }
    }
}
