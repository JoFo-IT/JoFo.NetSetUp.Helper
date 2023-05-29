using Microsoft.Extensions.Configuration;

namespace JoFo.NetSetUp.Helper.Configurations;

public static class Startup
{
    public static void AddConfigurations(this IConfigurationBuilder config)
    {
        const string configurationsDirectory = "Configurations";

        foreach (var file in Directory.GetFiles(configurationsDirectory,
                     "*.json",
                     SearchOption.AllDirectories))
        {
            config.AddJsonFile($"./{file}", false, true);
        }
    }
}