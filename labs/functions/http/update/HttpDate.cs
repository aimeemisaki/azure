<<<<<<< HEAD
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CalendarProj
{
    public static class HttpDate
    {
        [FunctionName("HttpDate")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req, ILogger log)
        {
            log.LogInformation("HTTP Date trigger activated");
            return new OkObjectResult(DateTime.UtcNow.ToShortDateString());
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
    public static class HttpDate
    {
        [FunctionName("HttpDate")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req, ILogger log)
        {
            log.LogInformation("HTTP Date trigger activated");
            return new OkObjectResult(DateTime.UtcNow.ToShortDateString());
        }
    }
}
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
