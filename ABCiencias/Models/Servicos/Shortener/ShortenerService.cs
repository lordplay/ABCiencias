using ABCiencias.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCiencias.Models.Servicos.Shortener
{
    public class ShortenerService : IShortenerService
    {
        private IURLShortenerContext _context;
        public ShortenerService(IURLShortenerContext context)
        {
            _context = context;
        }

        public ICollection<URLShortener> ObterUrlsAtivas()
        {
            return _context.Urls.Where(x => x.Status == EnumStatusUrl.Ativa).ToList();
        }
        public int AdicionarLink(URLShortener uRL)
        {
            _context.Urls.Add(uRL);
            _context.SaveChanges();
            return _context.Urls.Where(x => x.Guid == uRL.Guid).FirstOrDefault().Id;
        }
        public void Update(URLShortener uRL)
        {
            try
            {
                _context.Urls.Update(uRL);
                _context.SaveChanges();
            }
            catch (Exception)
            {

            }
        }
        public URLShortener ObterUrlPorId(int? id)
        {
            return _context.Urls.Where(x => x.Id == id).FirstOrDefault();
        }

        public string ObterNovaUrl()
        {
            string domain = "http://localhost:49379/";
            var IsValid = false;
            while (!IsValid)
            {
                var url = GerarGuid(domain);
                if (IsValidGuid(url))
                {
                    IsValid = true;
                    return url;
                }
            }
            return null;
        }

        public string GerarGuid(string domain)
        {
            var maxvalue = 8;
            Random r = new Random();
            var url = domain;
            List<int> ints = new List<int>();

            for (int i = 0; i < maxvalue; i++)
            {
                if ((r.Next(0, 99) % 2) > 0)
                {
                    ints.Add(r.Next(65, 90));
                }
                else
                {
                    ints.Add(r.Next(97, 122));
                }
            }

            foreach (var numero in ints)
            {
                url += String.Join(url, Convert.ToChar(numero).ToString());
            }

            return url;
        }

        public bool IsValidGuid(string url)
        {
            if (_context.Urls.Where(x => x.Equals(url)).FirstOrDefault() == null)
                return true;
            return false;
        }

    }
}
