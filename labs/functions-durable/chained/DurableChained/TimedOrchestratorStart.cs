<<<<<<< HEAD
using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;

public static class TimedOrchestratorStart
{
    [FunctionName("TimedOrchestratorStart")]
    public static async Task Run(
        [TimerTrigger("0 */2 * * * *")] TimerInfo myTimer,
        [DurableClient] IDurableOrchestrationClient starter,
        ILogger log)
    {
        var status = new AppStatus
        {
            Component = "save-handler",
            Version = "1.0.1.0",
            TimestampUtc = DateTime.UtcNow,
            StatusCode = 200,
            StatusMessage = "OK"
        };

        log.LogInformation($"Starting orchestration for: {status.Component}; at: {DateTime.UtcNow} (UTC)");
        await starter.StartNewAsync("ChainedOrchestrator", status);
    }
=======
using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;

public static class TimedOrchestratorStart
{
    [FunctionName("TimedOrchestratorStart")]
    public static async Task Run(
        [TimerTrigger("0 */2 * * * *")] TimerInfo myTimer,
        [DurableClient] IDurableOrchestrationClient starter,
        ILogger log)
    {
        var status = new AppStatus
        {
            Component = "save-handler",
            Version = "1.0.1.0",
            TimestampUtc = DateTime.UtcNow,
            StatusCode = 200,
            StatusMessage = "OK"
        };

        log.LogInformation($"Starting orchestration for: {status.Component}; at: {DateTime.UtcNow} (UTC)");
        await starter.StartNewAsync("ChainedOrchestrator", status);
    }
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
}