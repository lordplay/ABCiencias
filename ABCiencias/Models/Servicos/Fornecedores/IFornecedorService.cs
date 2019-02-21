using System.Collections.Generic;

namespace ABCiencias.Models.Servicos.Fornecedores
{
    public interface IFornecedorService
    {
        ICollection<Fornecedor> ObterFornecedoresAtivos();
    }
}