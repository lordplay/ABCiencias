using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCiencias.Models
{
    [Table("ServicoFornecedor")]
    public class ServicoFornecedor
    {

        [Key]
        public int IdServicoFornecedor { get; set; }

        public int IdFornecedor_fk { get; set; }

        public int IdServico_fk { get; set; }

        public decimal Valor { get; set; }
        public float Nota { get; set; }
        public string Descricao { get; set; }

        [ForeignKey("IdServico_fk")]
        public Servico Servico { get; set; }
        [ForeignKey("IdFornecedor_fk")]
        public Fornecedor Fornecedor { get; set; }
    }
}