<<<<<<< HEAD
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;

public class NotifySubscribers
{
    [FunctionName("NotifySubscribers")]
    public async Task Run(
        [ActivityTrigger] string blobName,
        [ServiceBus("HeartbeatCreated", Connection = "ServiceBusConnectionString")] IAsyncCollector<dynamic> messages,
        ILogger log
    )
    {
        log.LogInformation($"New heartbeat blob uploaded: {blobName}");

        var message = new HeartbeatCreatedMessage
        {
            BlobName = blobName
        };
        await messages.AddAsync(message);

        log.LogInformation("Published heartbeat message");
    }
}
=======
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;

public class NotifySubscribers
{
    [FunctionName("NotifySubscribers")]
    public async Task Run(
        [ActivityTrigger] string blobName,
        [ServiceBus("HeartbeatCreated", Connection = "ServiceBusConnectionString")] IAsyncCollector<dynamic> messages,
        ILogger log
    )
    {
        log.LogInformation($"New heartbeat blob uploaded: {blobName}");

        var message = new HeartbeatCreatedMessage
        {
            BlobName = blobName
        };
        await messages.AddAsync(message);

        log.LogInformation("Published heartbeat message");
    }
}
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
