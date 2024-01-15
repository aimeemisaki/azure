<<<<<<< HEAD
﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ToDoList.Logging;

public static class Extensions
{
    public static ILoggingBuilder ConfigureSerilog(this ILoggingBuilder loggingBuilder, IConfiguration configuration)
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();

        return loggingBuilder;
    }
}
=======
﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ToDoList.Logging;

public static class Extensions
{
    public static ILoggingBuilder ConfigureSerilog(this ILoggingBuilder loggingBuilder, IConfiguration configuration)
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();

        return loggingBuilder;
    }
}
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
