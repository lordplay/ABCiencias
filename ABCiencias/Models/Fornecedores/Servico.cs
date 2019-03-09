using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ABCiencias.Models
{
    [Table("Servico")]
    public class Servico
    {
        [Key]
        public int IdServico { get; set; }
        [ForeignKey("IdCategoriaServico_fk")]
        public virtual CategoriaServico Categoria { get; set; }
        public int IdCategoriaServico_fk { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }
}
