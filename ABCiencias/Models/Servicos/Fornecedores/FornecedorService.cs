using ABCiencias.Entity;
using ABCiencias.Models.Fornecedores;
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
        public ICollection<FornecedoresDTO> ObterFornecedores()
        {
            return _context.Fornecedores.Select(x => new
            FornecedoresDTO
            {
                RazaoSocial = x.RazaoSocial,
                CNPJ = x.CNPJ,
                Descricao = x.Descricao,
                IdFornecedor = x.IdFornecedor,
                //Servicos = x.Servicos.Select(c => new ServicoFornecedorDTO { IdServicoFornecedor = c.IdServicoFornecedor, Servico = c.Servico }).ToList(),
                Status = x.Status
            }).ToList();
        }
        public int CadastrarFornecedor(CadastroFornecedorDTO cadastro)
        {
            try
            {
                //Salvar o cadastro no banco
                var fornecedor = new Fornecedor() { CNPJ = cadastro.CNPJ, Descricao = cadastro.Descricao, RazaoSocial = cadastro.RazaoSocial, Status = EnumStatusFornecedor.Ativo };
                _context.Fornecedores.Add(fornecedor);
                _context.SaveChanges();
                //Associar os servicos com o fornecedor
                foreach (var servico in cadastro.Servicos)
                {
                    var _servico = new ServicoFornecedor() { Fornecedor = fornecedor, IdServico_fk = servico.IdServico };
                    fornecedor.Servicos.Add(_servico);
                }
                _context.SaveChanges();
                return fornecedor.IdFornecedor;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public List<Servico> ObterServicos()
        {
            return _context.Servicos.Include(x => x.Categoria).ToList();
        }
        public FornecedoresDTO ObterInformacoesFornecedor(int id)
        {
            var retorno = _context.Fornecedores.Where(x => x.IdFornecedor == id)
                .Select(x => new FornecedoresDTO
                {

                    RazaoSocial = x.RazaoSocial,
                    CNPJ = x.CNPJ,
                    Descricao = x.Descricao,
                    IdFornecedor = x.IdFornecedor,
                    Servicos = x.Servicos.Select(c => new ServicoFornecedorDTO { IdServicoFornecedor = c.IdServicoFornecedor, Servico = c.Servico, Descricao = c.Descricao, Valor = c.Valor, Nota = c.Nota }).ToList(),
                    Status = x.Status
                }).FirstOrDefault();
            return retorno;
        }

        public ServicoFornecedor ObterServicoFornecedor(int idServicoFornecedor)
        {
            return _context.ServicoFornecedor.Find(idServicoFornecedor);
        }

        public void UpdateServicoFornecedor(ServicoFornecedor servico)
        {
            try
            {
                var toUpdate = _context.ServicoFornecedor.Find(servico.IdServicoFornecedor);
                toUpdate.Nota = servico.Nota;
                toUpdate.Valor = servico.Valor;
                toUpdate.Descricao = servico.Descricao;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
