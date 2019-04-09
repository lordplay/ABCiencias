using ABCiencias.Models.Servicos.Log;
using ABCiencias.Models.Servicos.Shortener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Back_UrlShortener.Controllers
{
    public class UrlShortenerController : ApiController
    {
        private readonly IShortenerService _service;
        private readonly ILogService _logService;

        public UrlShortenerController(IShortenerService service, ILogService logService)
        {
            _service = service;
            _logService = logService;
        }
        //Get
        [HttpGet]
        [Route("{guid}")]
        public IHttpActionResult ObterUrlToRedirect(string guid)
        {
            var ip = HttpContext.Current.Request;

            if (!string.IsNullOrEmpty(guid))
            {
                var redirectTo = _service.ObterUrlToRedirect(guid);
                if (redirectTo != null)
                {
                    _logService.SaveLogRequest(new LogRequest(HttpContext.Current.Request.UserHostAddress.ToString(), HttpContext.Current.Request.HttpMethod.ToString(), redirectTo));
                    return Redirect(redirectTo.UrlToRedirect);
                }
            }

            _logService.SaveLogRequest(new LogRequest(HttpContext.Current.Request.UserHostAddress.ToString(), HttpContext.Current.Request.HttpMethod.ToString(), HttpContext.Current.Request.Url.AbsoluteUri.ToString()));
            return Redirect("http://www.abc.org.br");
        }
        [HttpGet]
        public IHttpActionResult ObterUrlToRedirect()
        {
            return Redirect("http://www.abc.org.br");
        }

    }
}
