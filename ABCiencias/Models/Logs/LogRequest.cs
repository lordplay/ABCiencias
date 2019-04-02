using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCiencias.Models.Servicos.Log
{
    public class LogRequest
    {
        public LogRequest(string ip, string method, string uri)
        {
            DateRequest = DateTime.Now;
            UserHostAddress = ip;
            Method = method;
            Uri = uri;
        }
        public LogRequest()
        {
            DateRequest = DateTime.Now;
        }
        [Key]
        public int IdLogRequest { get; set; }
        public string UserHostAddress { get; set; }
        public string Method { get; set; }
        public string Uri { get; set; }
        public DateTime? DateRequest { get; set; }

    }
}
