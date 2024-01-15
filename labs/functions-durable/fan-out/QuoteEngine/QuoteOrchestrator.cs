<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace QuoteEngine
{
    public static class QuoteOrchestrator
    {
        [FunctionName("QuoteOrchestrator")]
        public static async Task<QuoteResponse> RunOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext context,
            ILogger log)
        {
            var input = context.GetInput<QuoteRequest>();

            var suppliers = new[] {"Supplier1Quote", "Supplier2Quote", "Supplier3Quote"};
            var tasks = new Task<QuoteResponse>[suppliers.Length];
            for (int i = 0; i < suppliers.Length; i++)
            {
                tasks[i] = context.CallActivityAsync<QuoteResponse>(suppliers[i], input);
            }
    
            await Task.WhenAll(tasks);
            var bestQuote = tasks.OrderBy(x=>x.Result.Quote).First().Result;

            log.LogInformation($"Best quote: {bestQuote.Quote} from supplier: {bestQuote.SupplierCode}");
            return bestQuote;
        }
    }
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace QuoteEngine
{
    public static class QuoteOrchestrator
    {
        [FunctionName("QuoteOrchestrator")]
        public static async Task<QuoteResponse> RunOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext context,
            ILogger log)
        {
            var input = context.GetInput<QuoteRequest>();

            var suppliers = new[] {"Supplier1Quote", "Supplier2Quote", "Supplier3Quote"};
            var tasks = new Task<QuoteResponse>[suppliers.Length];
            for (int i = 0; i < suppliers.Length; i++)
            {
                tasks[i] = context.CallActivityAsync<QuoteResponse>(suppliers[i], input);
            }
    
            await Task.WhenAll(tasks);
            var bestQuote = tasks.OrderBy(x=>x.Result.Quote).First().Result;

            log.LogInformation($"Best quote: {bestQuote.Quote} from supplier: {bestQuote.SupplierCode}");
            return bestQuote;
        }
    }
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
}