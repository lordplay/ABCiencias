using ABCiencias.Models;
using ABCiencias.Models.Servicos.Shortener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Back_API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ShortenerController : ApiController
    {
        private IShortenerService _service;
        public ShortenerController(IShortenerService service)
        {
            _service = service;
        }

        [HttpGet]
        public ICollection<URLShortener> ObterUrlsAtivas()
        {
            return _service.ObterUrlsAtivas();
        }

        [HttpPost]
        public URLShortener ObterUrlPorId([FromBody] int id)
        {
            return _service.ObterUrlPorId(id);
        }

        [HttpPost]
        public string ObterNovaUrl()
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

    }
}
