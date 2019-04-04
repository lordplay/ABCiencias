using System.Web;
namespace ABCiencias.Models.Servicos.Log
{
    public interface ILogService
    {
        void SaveLogRequest(LogRequest request);
    }
}