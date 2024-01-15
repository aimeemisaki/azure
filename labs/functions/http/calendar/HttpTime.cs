<<<<<<< HEAD
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CalendarProj
{
    public static class HttpTime
    {
        [FunctionName("HttpTime")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req, ILogger log)
        {
            log.LogInformation("HTTP Time trigger activated");
            return new OkObjectResult(DateTime.UtcNow.ToShortTimeString());
        }
    }
}
=======
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CalendarProj
{
    public static class HttpTime
    {
        [FunctionName("HttpTime")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req, ILogger log)
        {
            log.LogInformation("HTTP Time trigger activated");
            return new OkObjectResult(DateTime.UtcNow.ToShortTimeString());
        }
    }
}
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
