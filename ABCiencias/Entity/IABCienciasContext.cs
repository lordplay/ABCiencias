using ABCiencias.Models;
using ABCiencias.Models.Eventos;
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
        int SaveChanges();
    }
}