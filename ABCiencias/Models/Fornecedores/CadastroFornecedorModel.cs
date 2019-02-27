using ABCiencias.Models;
using System.Collections.Generic;

namespace Back_API.Controllers
{
    public class CadastroFornecedorModel
    {
        public int IdFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Descricao { get; set; }
        public List<Servico> Servicos { get; set; }
    }
}