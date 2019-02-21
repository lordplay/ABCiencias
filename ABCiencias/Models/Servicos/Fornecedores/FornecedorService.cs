using ABCiencias.Entity;
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
        public ICollection<Fornecedor> ObterFornecedoresAtivos()
        {
           return _context.Fornecedores.Where(x => x.Status == EnumStatusFornecedor.Ativo).ToList();
        }
    }
}
