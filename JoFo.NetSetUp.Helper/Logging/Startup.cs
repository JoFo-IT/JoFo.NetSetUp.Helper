using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace JoFo.NetSetUp.Helper.Logging;

public static class Startup
{
    public static void AddSeriLog(this IHostBuilder builder, IConfiguration configuration)
    {
        builder.UseSerilog((_, config) =>
        {
            config.ReadFrom.Configuration(configuration);
            config.WriteTo.Console();
        });
    }
}