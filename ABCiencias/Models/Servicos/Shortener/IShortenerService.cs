using System.Collections.Generic;

namespace ABCiencias.Models.Servicos.Shortener
{
    public interface IShortenerService
    {
        int AdicionarLink(URLShortener uRL);
        void Update(URLShortener uRL);
        URLShortenerDTO ObterUrls(int page);
        URLShortener ObterUrlPorId(int? id);
        URLShortener ObterNovaUrl();
        bool Delete(int id);
        URLShortener ObterUrlToRedirect(string Guid);
    }
}