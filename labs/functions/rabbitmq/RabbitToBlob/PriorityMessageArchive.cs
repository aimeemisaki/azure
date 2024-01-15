<<<<<<< HEAD
using System.IO;
using System.Text.Json;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.RabbitMQ;
using Microsoft.Azure.WebJobs.Extensions.Storage.Blobs;
using Microsoft.Extensions.Logging;

namespace RabbitToBlob
{
    public class PriorityMessageArchive
    {
        [FunctionName("PriorityMessageArchive")]
        [StorageAccount("CustomerOutputStorageConnectionString")]
        public static void Run(
            [RabbitMQTrigger("customerevents", ConnectionStringSetting = "InputRabbitMQConnectionString")] CustomerMessage message,
            [Blob("complaints/{DateTime}.json", FileAccess.Write)] out string blobOutput,
            ILogger logger
            )
        {
            logger.LogInformation($"Received customer message with event type: {message.EventType}");
            if (message.EventType.ToLower() == "complaint")
            {                
                blobOutput = JsonSerializer.Serialize(message);
                logger.LogInformation($"Archiving complaint message for customer: {message.CustomerId}");
            }
            else
            {
                blobOutput = null;
                logger.LogInformation($"Ignoring message for customer: {message.CustomerId}");
            }
        }
    }
}       
=======
using System.IO;
using System.Text.Json;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.RabbitMQ;
using Microsoft.Azure.WebJobs.Extensions.Storage.Blobs;
using Microsoft.Extensions.Logging;

namespace RabbitToBlob
{
    public class PriorityMessageArchive
    {
        [FunctionName("PriorityMessageArchive")]
        [StorageAccount("CustomerOutputStorageConnectionString")]
        public static void Run(
            [RabbitMQTrigger("customerevents", ConnectionStringSetting = "InputRabbitMQConnectionString")] CustomerMessage message,
            [Blob("complaints/{DateTime}.json", FileAccess.Write)] out string blobOutput,
            ILogger logger
            )
        {
            logger.LogInformation($"Received customer message with event type: {message.EventType}");
            if (message.EventType.ToLower() == "complaint")
            {                
                blobOutput = JsonSerializer.Serialize(message);
                logger.LogInformation($"Archiving complaint message for customer: {message.CustomerId}");
            }
            else
            {
                blobOutput = null;
                logger.LogInformation($"Ignoring message for customer: {message.CustomerId}");
            }
        }
    }
}       
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
             