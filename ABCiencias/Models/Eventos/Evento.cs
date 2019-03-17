using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCiencias.Models.Eventos
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }
        public string NomeEvento { get; set; }
        public ContratoEvento Contrato { get; set; }
        public DateTime Data_Evento { get; set; }
        public EnumStatusEvento Status { get; set; }
        public string Descricao { get; set; }

    }
}
