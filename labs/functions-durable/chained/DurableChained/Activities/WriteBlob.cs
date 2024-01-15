<<<<<<< HEAD
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;

public class WriteBlob
{
    [FunctionName("WriteBlob")]
    [StorageAccount("StorageConnectionString")]
    public async Task<string> Run(
        [ActivityTrigger] AppStatus status,
        Binder binder,
        ILogger log)
    {
        log.LogInformation($"WriteBlob received status for: {status.Component} with timestamp: {status.TimestampUtc}");

        var blobName = $"heartbeat/{DateTime.UtcNow.ToString("yyyyMMddHHmmss")}";
        using (var writer = await binder.BindAsync<TextWriter>(new BlobAttribute(blobName)))
        {
            writer.Write(JsonSerializer.Serialize(status));
        }

        log.LogInformation($"Created blob: {blobName}");
        return blobName;
    }
}
=======
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;

public class WriteBlob
{
    [FunctionName("WriteBlob")]
    [StorageAccount("StorageConnectionString")]
    public async Task<string> Run(
        [ActivityTrigger] AppStatus status,
        Binder binder,
        ILogger log)
    {
        log.LogInformation($"WriteBlob received status for: {status.Component} with timestamp: {status.TimestampUtc}");

        var blobName = $"heartbeat/{DateTime.UtcNow.ToString("yyyyMMddHHmmss")}";
        using (var writer = await binder.BindAsync<TextWriter>(new BlobAttribute(blobName)))
        {
            writer.Write(JsonSerializer.Serialize(status));
        }

        log.LogInformation($"Created blob: {blobName}");
        return blobName;
    }
}
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
