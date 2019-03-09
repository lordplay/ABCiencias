using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Models.Fornecedores
{
    public class ObterFornecedoresModel
    {
        public int IdFornecedor { get; set; }
        public EnumStatusFornecedor Status { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ServicoFornecedorDTO> Servicos { get; set; }

    }

    public class ServicoFornecedorDTO
    {
        public int IdCategoriaServico_fk { get; set; }

        public string ServicoNome { get; set; }
        public string ServicoDescricao { get; set; }

        public string CategoriaNome { get; set; }
    }
}
