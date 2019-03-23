using ABCiencias.Models.Servicos.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back_Mobile.Controllers
{
    public class EventoController : ApiController
    {
        private IMobileEventoService _service;

        public EventoController(IMobileEventoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IHttpActionResult GetEventos()
        {
            return Ok(_service.GetEventos());
        }
    }
}
