﻿using ABCiencias.Models;
using ABCiencias.Models.Servicos.Fornecedores;
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
            return Ok(_fornecedorService.ObterFornecedores());
        }
        [HttpPost]
        public IHttpActionResult CadastrarFornecedor([FromBody]CadastroFornecedorDTO cadastro)
        {
            var retorno = _fornecedorService.CadastrarFornecedor(cadastro);
            return Ok(retorno);
        }
        [HttpGet]
        public IHttpActionResult ObterServicosDisponiveis()
        {
            return Ok(_fornecedorService.ObterServicos());
        }
        public IHttpActionResult ObterInformacoesFornecedor([FromBody] int id)
        {
            return Ok(_fornecedorService.ObterInformacoesFornecedor(id));
        }
        public IHttpActionResult ObterServicoFornecedor([FromBody] int id)
        {
            return Ok(_fornecedorService.ObterServicoFornecedor(id));
        }
        public IHttpActionResult UpdateServicoFornecedor([FromBody]ServicoFornecedor servico)
        {
            _fornecedorService.UpdateServicoFornecedor(servico);
            return Ok();
        }
    }
}
