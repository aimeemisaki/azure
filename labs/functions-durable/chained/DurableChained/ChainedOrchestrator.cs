<<<<<<< HEAD
using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;
public static class ChainedOrchestrator
{
    [FunctionName("ChainedOrchestrator")]
    public static async Task RunOrchestrator(
        [OrchestrationTrigger] IDurableOrchestrationContext context,
        ILogger log)
    {
        var status = context.GetInput<AppStatus>();
        log.LogInformation($"Orchestrator received staus for: {status.Component} with timestamp: {status.TimestampUtc}");

        var blobName = await context.CallActivityAsync<string>("WriteBlob", status);
        await context.CallActivityAsync("NotifySubscribers", blobName);
        await context.CallActivityAsync("WriteLog", new Tuple<AppStatus,string>(status, blobName));
        
        log.LogInformation($"Orchestrator completed.");
    }
=======
using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;
public static class ChainedOrchestrator
{
    [FunctionName("ChainedOrchestrator")]
    public static async Task RunOrchestrator(
        [OrchestrationTrigger] IDurableOrchestrationContext context,
        ILogger log)
    {
        var status = context.GetInput<AppStatus>();
        log.LogInformation($"Orchestrator received staus for: {status.Component} with timestamp: {status.TimestampUtc}");

        var blobName = await context.CallActivityAsync<string>("WriteBlob", status);
        await context.CallActivityAsync("NotifySubscribers", blobName);
        await context.CallActivityAsync("WriteLog", new Tuple<AppStatus,string>(status, blobName));
        
        log.LogInformation($"Orchestrator completed.");
    }
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
}