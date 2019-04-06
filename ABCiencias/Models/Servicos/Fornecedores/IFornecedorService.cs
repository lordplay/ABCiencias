using ABCiencias.Models.Fornecedores;
using System.Collections.Generic;

namespace ABCiencias.Models.Servicos.Fornecedores
{
    public interface IFornecedorService
    {
        ICollection<FornecedoresDTO> ObterFornecedores();
        int CadastrarFornecedor(CadastroFornecedorDTO cadastro);
        List<Servico> ObterServicos();
        FornecedoresDTO ObterInformacoesFornecedor(int id);
        ServicoFornecedor ObterServicoFornecedor(int id);
        void UpdateServicoFornecedor(ServicoFornecedor servico);
    }
}