using ABCiencias.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCiencias.Models.Servicos.Shortener
{
    public class ShortenerService : IShortenerService
    {
        private IABCienciasContext _context;
        public ShortenerService(IABCienciasContext context)
        {
            _context = context;
        }

        public URLShortenerDTO ObterUrls(int page)
        {
            page = page - 1;

            URLShortenerDTO retorno = new URLShortenerDTO();

            var links = _context.Urls.Skip(page * 25).Take(25).ToList();
            retorno.URLShorteners = links;
            retorno.Count = _context.Urls.Count();

            return retorno;
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

        public URLShortener ObterNovaUrl()
        {
            var IsValid = false;
            while (!IsValid)
            {
                var Guid = GerarGuid();
                if (IsValidGuid(Guid))
                {
                    IsValid = true;
                    var retorno = new URLShortener() { Domain = _context.Configs.Single().BackUrlShortenerDomain, Guid = Guid };
                    return retorno;
                }
            }
            return null;
        }

        public string GerarGuid()
        {
            var maxvalue = 8;
            Random r = new Random();
            var Guid = "";
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
                Guid += String.Join(Guid, Convert.ToChar(numero).ToString());
            }

            return Guid;
        }

        public bool IsValidGuid(string url)
        {
            if (_context.Urls.Where(x => x.Guid.Equals(url)).FirstOrDefault() == null)
                return true;
            return false;
        }
        public bool Delete(int id)
        {
            var ToDelete = _context.Urls.Where(x => x.Id == id).FirstOrDefault();
            if (ToDelete != null)
            {
                _context.Urls.Remove(ToDelete);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public URLShortener ObterUrlToRedirect(string Guid)
        {
            var retono = _context.Urls.FirstOrDefault(x => x.Guid == Guid && x.Status == EnumStatusUrl.Ativa);
            if (retono != null)
                Click(ref retono);

            return retono;
        }
        public void Click(ref URLShortener uRL)
        {
            uRL.Click();
            _context.SaveChanges();
        }
    }
}
