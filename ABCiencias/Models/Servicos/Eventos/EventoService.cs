using ABCiencias.Entity;
using ABCiencias.Models.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCiencias.Models.Servicos.Eventos
{
    public class EventoService
    {
        private IABCienciasContext _context;
        public EventoService(IABCienciasContext context)
        {
            _context = context;
        }

        //Criar Evento
        public void CadastrarEvento(Evento evento, List<ServicoFornecedor> servicos)
        {
            //Adicionar o evento na base
            _context.Eventos.Add(evento);
            _context.SaveChanges();

            //Criar um contrato para o evento
            evento.Contrato = RegistrarContratoEvento(servicos, evento);
            _context.SaveChanges();

        }

        public ContratoEvento RegistrarContratoEvento(List<ServicoFornecedor> servicos, Evento evento)
        {
            ContratoEvento contrato = new ContratoEvento();
            foreach (var servico in servicos)
            {
                ServicoEventoFornecedor servicoEvento = new ServicoEventoFornecedor();
                servicoEvento.ServicoFornecedor = servico;
                contrato.Servicos.Add(servicoEvento);
            }
            return contrato;
        }

        //Update Evento
        public bool UpdateEvento(Evento evento)
        {
            var _evento = _context.Eventos.Where(x => x.IdEvento == evento.IdEvento).FirstOrDefault();
            _evento = evento;
            _context.SaveChanges();
            return true;
        }

        //ObterEventos
        

    }
}
