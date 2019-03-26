using ABCiencias.Models;
using ABCiencias.Models.Config;
using ABCiencias.Models.Eventos;
using ABCiencias.Models.User;
using Microsoft.EntityFrameworkCore;

namespace ABCiencias.Entity
{
    public interface IABCienciasContext
    {
        DbSet<CategoriaServico> CategoriaServico { get; set; }
        DbSet<Fornecedor> Fornecedores { get; set; }
        DbSet<ServicoFornecedor> ServicoFornecedor { get; set; }
        DbSet<Servico> Servicos { get; set; }
        DbSet<ContratoEvento> ContratoEventos { get; set; }
        DbSet<Evento> Eventos { get; set; }
        DbSet<ServicoEventoFornecedor> ServicoEventoFornecedor { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<URLShortener> Urls { get; set; }
        DbSet<Config> Configs { get; set; }
        int SaveChanges();
    }
}