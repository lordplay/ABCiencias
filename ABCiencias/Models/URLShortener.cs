using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCiencias.Models
{
    public class URLShortener
    {
        [Key]
        public int Id { get; set; }
        public string Guid { get; set; }
        public string UrlToRedirect { get; set; }
        public int Clicks { get; set; }
        public EnumStatusUrl Status { get; set; }
        public string Nome { get; set; }
        public string Domain { get; set; }

        public void Click()
        {
            this.Clicks += 1;
        }
    }

}
