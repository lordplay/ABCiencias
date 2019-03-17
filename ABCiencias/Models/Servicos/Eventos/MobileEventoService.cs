using ABCiencias.Entity;
using ABCiencias.Models.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCiencias.Models.Servicos.Eventos
{
    public class MobileEventoService : IMobileEventoService
    {
        private IABCienciasContext _context;
        public MobileEventoService(IABCienciasContext context)
        {
            _context = context;
        }

        public ICollection<Evento> GetEventos()
        {
            return _context.Eventos.Where(x => x.Status == EnumStatusEvento.Ativo).Select(c => new Evento { Status = c.Status, Data_Evento = c.Data_Evento, Descricao = c.Descricao, IdEvento = c.IdEvento, NomeEvento = c.NomeEvento }).ToList();
        }
    }
}
