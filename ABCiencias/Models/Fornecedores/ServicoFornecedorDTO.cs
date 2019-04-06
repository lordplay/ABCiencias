using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Models.Fornecedores
{
    public class ServicoFornecedorDTO
    {
        public int IdServicoFornecedor { get; set; }
        public decimal Valor { get; set; }
        public float Nota { get; set; }
        public string Descricao { get; set; }
        public Servico Servico { get; set; }
    }
}
