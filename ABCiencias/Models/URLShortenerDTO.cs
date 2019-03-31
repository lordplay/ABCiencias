using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Models
{
    public class URLShortenerDTO
    {
        public URLShortenerDTO()
        {
            URLShorteners = new HashSet<URLShortener>();
        }
        public ICollection<URLShortener> URLShorteners { get; set; }
        public int Count { get; set; }

    }
}
