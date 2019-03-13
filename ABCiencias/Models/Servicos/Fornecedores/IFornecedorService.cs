using ABCiencias.Models.Fornecedores;
using System.Collections.Generic;

namespace ABCiencias.Models.Servicos.Fornecedores
{
    public interface IFornecedorService
    {
        ICollection<FornecedoresDTO> ObterFornecedores();
        void CadastrarFornecedor(CadastroFornecedorModel cadastro);
        List<Servico> ObterServicos();
        FornecedoresDTO ObterInformacoesFornecedor(int id);
    }
}