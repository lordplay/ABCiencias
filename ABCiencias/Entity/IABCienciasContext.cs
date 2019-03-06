using ABCiencias.Models;
using Microsoft.EntityFrameworkCore;

namespace ABCiencias.Entity
{
    public interface IABCienciasContext
    {
        DbSet<CategoriaServico> CategoriaServico { get; set; }
        DbSet<Fornecedor> Fornecedores { get; set; }
        DbSet<ServicoFornecedor> ServicoFornecedor { get; set; }
        DbSet<Servico> Servicos { get; set; }
        int SaveChanges();
    }
}