using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ABCiencias.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        public Fornecedor()
        {
            this.Servicos = new HashSet<ServicoFornecedor>();
            this.Data_Cadastro = DateTime.Now;
        }

        [Key]
        public int IdFornecedor { get; set; }
        public EnumStatusFornecedor Status { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public virtual ICollection<ServicoFornecedor> Servicos { get; set; }

    }
}
