using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Back_API.Models
{
    public class APIKeyHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Headers.Contains("Access-Control-Request-Headers"))
            {
                return base.SendAsync(request, cancellationToken);
            }
            else if (request.Headers.Contains("token"))
            {
                var apikey = request.Headers.GetValues("token").FirstOrDefault();

                if (apikey == "19216801")
                    return base.SendAsync(request, cancellationToken);
            }
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            var taskObj = new TaskCompletionSource<HttpResponseMessage>();
            taskObj.SetResult(response);
            return taskObj.Task;
        }
    }
}