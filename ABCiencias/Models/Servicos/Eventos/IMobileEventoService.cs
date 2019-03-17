using System.Collections.Generic;
using ABCiencias.Models.Eventos;

namespace ABCiencias.Models.Servicos.Eventos
{
    public interface IMobileEventoService
    {
        ICollection<Evento> GetEventos();
    }
}