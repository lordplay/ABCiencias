using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Models
{
    public class RetornoOperacao
    {
        public EnumStatusOperacao StatusOperacao { get; set; }
        public Object Retorno { get; set; }
        public string Message { get; set; }
    }
}
