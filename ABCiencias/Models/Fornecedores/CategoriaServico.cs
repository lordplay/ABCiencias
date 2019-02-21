using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ABCiencias.Models
{
    [Table("CategoriaServico")]
    public class CategoriaServico
    {
        [Key]
        public int IdCategoriaServico { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }
}
