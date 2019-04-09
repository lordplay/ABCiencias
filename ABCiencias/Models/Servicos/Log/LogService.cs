using ABCiencias.Entity;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using System.Text;

namespace ABCiencias.Models.Servicos.Log
{
    public class LogService : ILogService
    {
        public IABCienciasContext _context;

        public LogService(IABCienciasContext context)
        {
            _context = context;
        }

        public void SaveLogRequest(LogRequest request)
        {
            _context.LogRequests.Add(request);
            _context.SaveChanges();

        }
    }
}
