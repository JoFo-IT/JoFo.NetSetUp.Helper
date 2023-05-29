using Serilog;
using Serilog.Core;

namespace JoFo.NetSetUp.Helper.Logging;

public static class StaticLogger
{
    /// <summary>
    ///     The setup of the StaticLogger.
    /// </summary>
    public static void EnsureInitialized()
    {
        if (Log.Logger is not Logger)
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();
    }
}