using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Models.Fornecedores.Factory
{
    public class FornecedorFactory
    {
        Fornecedor _fornecedor;
        CadastroFornecedorModel _cadastro;
        public FornecedorFactory(CadastroFornecedorModel cadastro)
        {
            this._fornecedor = new Fornecedor();
            this._cadastro = cadastro;
        }

        public Fornecedor Build()
        {
            _fornecedor.CNPJ = _cadastro.CNPJ;
            _fornecedor.Descricao = _cadastro.Descricao;
            _fornecedor.RazaoSocial = _cadastro.RazaoSocial;
            _fornecedor.Status = EnumStatusFornecedor.Ativo;
            return _fornecedor;
        }
    }
}
