<<<<<<< HEAD
﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Templates;

namespace ToDoList.Logging;

public static class Dependencies
{
    public static IServiceCollection AddConfiguredLogging(this IServiceCollection services, IConfiguration config)
    {
        Console.WriteLine("Configuring logging");
        if (config.GetValue<bool>("Logging:Enabled"))
        {
            var loggerConfig = new LoggerConfiguration().ReadFrom.Configuration(config);
            loggerConfig.Enrich.WithAppVersion()
                        .Enrich.WithAppName();

            Log.Logger = loggerConfig.CreateLogger();
            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(Log.Logger));

            Log.Information("Serilog configured");
            Console.WriteLine("Configured Serilog");
        }
        else 
        {
            //empty loggers:
            services.AddLogging();
        }
        return services;
    }
}
=======
﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Templates;

namespace ToDoList.Logging;

public static class Dependencies
{
    public static IServiceCollection AddConfiguredLogging(this IServiceCollection services, IConfiguration config)
    {
        Console.WriteLine("Configuring logging");
        if (config.GetValue<bool>("Logging:Enabled"))
        {
            var loggerConfig = new LoggerConfiguration().ReadFrom.Configuration(config);
            loggerConfig.Enrich.WithAppVersion()
                        .Enrich.WithAppName();

            Log.Logger = loggerConfig.CreateLogger();
            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(Log.Logger));

            Log.Information("Serilog configured");
            Console.WriteLine("Configured Serilog");
        }
        else 
        {
            //empty loggers:
            services.AddLogging();
        }
        return services;
    }
}
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
