using ABCiencias.Entity;
using ABCiencias.Models.Fornecedores;
using ABCiencias.Models.Fornecedores.Factory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCiencias.Models.Servicos.Fornecedores
{
    public class FornecedorService : IFornecedorService
    {
        private IABCienciasContext _context;

        public FornecedorService(IABCienciasContext context)
        {
            _context = context;
        }
        public ICollection<ObterFornecedoresModel> ObterFornecedores()
        {
            return _context.Fornecedores.Select(x => new
            ObterFornecedoresModel
            {
                RazaoSocial = x.RazaoSocial,
                CNPJ = x.CNPJ,
                Descricao = x.Descricao,
                IdFornecedor = x.IdFornecedor,
                Servicos = x.Servicos.Select(c => new ServicoFornecedorDTO { IdServicoFornecedor = c.IdServicoFornecedor, Servico = c.Servico }).ToList(),
                Status = x.Status
            }).ToList();
        }
        public void CadastrarFornecedor(CadastroFornecedorModel cadastro)
        {
            //Cadastrar somente o fornecedor no banco
            var fact = new FornecedorFactory(cadastro);
            _context.Fornecedores.Add(fact.Build());

            _context.SaveChanges();

            //Cadastrar os servicos
            CadastrarFornecedorServico(fact.Build(), cadastro.Servicos);
        }

        public void CadastrarFornecedorServico(Fornecedor fornecedor, List<Servico> servicos)
        {
            foreach (var servico in servicos)
            {
                var servicoFornecedor = new ServicoFornecedor();
                servicoFornecedor.Fornecedor = fornecedor;
                servicoFornecedor.Servico = _context.Servicos.Where(x => x.IdServico == servico.IdServico).FirstOrDefault();
                _context.ServicoFornecedor.Add(servicoFornecedor);
            }
            _context.SaveChanges();
        }

        public List<Servico> ObterServicos()
        {
            return _context.Servicos.ToList();
        }

    }
}
