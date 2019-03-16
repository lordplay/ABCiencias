using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCiencias.Models.Eventos
{
    [Table("ServicoEventoFornecedor")]
    public class ServicoEventoFornecedor
    {
        [Key]
        public int IdServicoEventoFornecedor { get; set; }

        [ForeignKey("IdServicoFornecedor_fk")]
        public ServicoFornecedor ServicoFornecedor { get; set; }
        public int IdServicoFornecedor_fk { get; set; }

        [ForeignKey("IdContratoEvento_fk")]
        public ContratoEvento Contrato { get; set; }
        public int IdContratoEvento_fk { get; set; }

        public decimal ValorCobrado { get; set; }

    }
}