using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCiencias.Models.Config
{
    public class Config
    {
        [Key]
        public int IdConfig { get; set; }
        public string BackUrlShortenerDomain { get; set; }
    }
}
