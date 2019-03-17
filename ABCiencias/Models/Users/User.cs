using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCiencias.Models.User
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Passoword { get; set; }
    }
}
