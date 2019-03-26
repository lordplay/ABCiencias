using ABCiencias.Models;
using ABCiencias.Models.Config;
using ABCiencias.Models.Eventos;
using ABCiencias.Models.User;
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
        public DbSet<ContratoEvento> ContratoEventos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<ServicoEventoFornecedor> ServicoEventoFornecedor { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<URLShortener> Urls { get; set; }
        public DbSet<Config> Configs { get; set; }


        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=abcdb.cwg2u9ksin9u.us-east-2.rds.amazonaws.com,1433;Initial Catalog=db_abc_dev;Persist Security Info=True;User ID=sansone;Password=MSP#1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
