using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Models.Fornecedores
{
    public class FornecedoresDTO
    {
        public int IdFornecedor { get; set; }
        public EnumStatusFornecedor Status { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ServicoFornecedorDTO> Servicos { get; set; }

    }
}
