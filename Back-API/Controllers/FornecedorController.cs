using ABCiencias.Models.Servicos.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back_API.Controllers
{
    public class FornecedorController : ApiController
    {
        private IFornecedorService _fornecedorService;

        public FornecedorController(IFornecedorService service)
        {
            _fornecedorService = service;
        }
        public IHttpActionResult GetObterForncedoresAtivos()
        {
            return Ok(_fornecedorService.ObterFornecedoresAtivos());
        }

    }
}
