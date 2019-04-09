using ABCiencias.Models;
using ABCiencias.Models.Relatorios;
using ABCiencias.Models.Servicos.Shortener;
using ABCiencias.Models.UrlShorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ABCiencias.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ShortenerController : ApiController
    {
        private IShortenerService _service;
        public ShortenerController(IShortenerService service)
        {
            _service = service;
        }

        [HttpPost]
        public URLShortenerDTO ObterUrls([FromBody] ObterUrlsDTO obj)
        {
            return _service.ObterUrls(obj.Page, obj.Search);
        }

        [HttpPost]
        public URLShortener ObterUrlPorId([FromBody] int id)
        {
            return _service.ObterUrlPorId(id);
        }

        [HttpPost]
        public URLShortener ObterNovaUrl()
        {
            return _service.ObterNovaUrl();
        }

        [HttpPost]
        public IHttpActionResult AtualizarUrl([FromBody]URLShortener objeto)
        {
            _service.Update(objeto);
            return Ok();
        }
        [HttpPost]
        public int CadastrarUrl([FromBody] URLShortener cadastro)
        {
            return _service.AdicionarLink(cadastro);
        }
        public bool DeletarUrl([FromBody] int id)
        {
            return _service.Delete(id);
        }
        public IHttpActionResult GerarRelatorio([FromBody] RelatorioFilter filter)
        {
            return Ok(_service.GerarRelatorio(filter));
        }
    }
}
