<<<<<<< HEAD
using FulfilmentProcessor;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();        
        services.AddSingleton(new RoleNameInitializer("FulfilmentProcessor"));
        services.AddApplicationInsightsTelemetryWorkerService();
    })
    .Build();

await host.RunAsync();
=======
using FulfilmentProcessor;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();        
        services.AddSingleton(new RoleNameInitializer("FulfilmentProcessor"));
        services.AddApplicationInsightsTelemetryWorkerService();
    })
    .Build();

await host.RunAsync();
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
