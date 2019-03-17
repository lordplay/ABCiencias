using ABCiencias.Models;
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


        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B9MSDME\SQLEXPRESS;Initial Catalog=ABCiencias;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
