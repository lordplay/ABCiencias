using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCiencias.Models.Eventos
{
    public class ContratoEvento
    {
        public ContratoEvento()
        {
            Servicos = new HashSet<ServicoEventoFornecedor>();
        }
        [Key]
        public int IdContratoEvento { get; set; }

        [ForeignKey("IdEvento_fk")]
        public Evento Evento { get; set; }
        public int IdEvento_fk { get; set; }

        public decimal Valor { get; set; }
        public EnumStatusContrato Status { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<ServicoEventoFornecedor> Servicos { get; set; }
    }
}