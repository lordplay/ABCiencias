using ABCiencias.Models.Fornecedores;
using System.Collections.Generic;

namespace ABCiencias.Models.Servicos.Fornecedores
{
    public interface IFornecedorService
    {
        ICollection<ObterFornecedoresModel> ObterFornecedores();
        void CadastrarFornecedor(CadastroFornecedorModel cadastro);
        List<Servico> ObterServicos();
    }
}