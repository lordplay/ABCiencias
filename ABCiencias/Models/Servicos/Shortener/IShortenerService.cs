using System.Collections.Generic;

namespace ABCiencias.Models.Servicos.Shortener
{
    public interface IShortenerService
    {
        int AdicionarLink(URLShortener uRL);
        void Update(URLShortener uRL);
        ICollection<URLShortener> ObterUrlsAtivas();
        URLShortener ObterUrlPorId(int? id);
        string ObterNovaUrl();
        bool Delete(int id);
    }
}