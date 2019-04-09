using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Models.Relatorios
{
    public class RelatorioFilter
    {
        public int Modo { get; set; }
        public DateTime Date_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
        public int IdObjeto { get; set; }
    }
}
