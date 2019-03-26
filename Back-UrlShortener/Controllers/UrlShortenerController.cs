using ABCiencias.Models.Servicos.Shortener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back_UrlShortener.Controllers
{
    public class UrlShortenerController : ApiController
    {
        private readonly IShortenerService _service;

        public UrlShortenerController(IShortenerService service)
        {
            _service = service;
        }
        //Get
        [HttpGet]
        [Route("{guid}")]
        public IHttpActionResult ObterUrlToRedirect(string guid)
        {
            if (!string.IsNullOrEmpty(guid))
            {
                var redirectTo = _service.ObterUrlToRedirect(guid);
                if (redirectTo != null)
                    return Redirect(redirectTo.UrlToRedirect);
            }

            return Redirect("http://www.abc.org.br");
        }
        [HttpGet]
        public IHttpActionResult ObterUrlToRedirect()
        {
            return NotFound();
        }
    }
}
