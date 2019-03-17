using ABCiencias.Models.Servicos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back_Mobile.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public IHttpActionResult Post(UserDTO user)
        {
            var retorno = _service.Autentica(user);
            if (retorno != null)
                return Ok(retorno);
            return BadRequest();
        }

        public string Get()
        {
            return "Teste";
        }
    }
}
