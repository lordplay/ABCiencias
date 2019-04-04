using ABCiencias.Models;
using System.Collections.Generic;

namespace ABCiencias.Models
{
    public class CadastroFornecedorDTO
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Descricao { get; set; }
        public List<Servico> Servicos { get; set; }
    }
}