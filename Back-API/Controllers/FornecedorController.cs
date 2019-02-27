using ABCiencias.Models.Servicos.Fornecedores;
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
    public class FornecedorController : ApiController
    {
        private IFornecedorService _fornecedorService;

        public FornecedorController(IFornecedorService service)
        {
            _fornecedorService = service;
        }
        [HttpGet]
        public IHttpActionResult ObterFornecedoresAtivos()
        {
            return Ok(_fornecedorService.ObterFornecedoresAtivos());
        }
        public IHttpActionResult CadastrarFornecedor(CadastroFornecedorModel cadastro)
        {
            return Ok(_fornecedorService.)
        }

    }
}
