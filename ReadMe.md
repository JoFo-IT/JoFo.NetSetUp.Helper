![](./Logo/repository-open-graph.png)

# JoFo.NetSetUp.Helper

## Project description

This project is a .NET class library developed in C# that serves as a helpful tool for creating programs. It contains
several small helper functions to simplify the development process.

## Features include

**StaticLogger**: This helper class simplifies program startup by providing logging capabilities.

**AddSeriLog**: The project provides a startup class to configure and set up Serilog for logging purposes.

**AddConfigurations**: The project provides a startup class to read configuration settings from JSON
files using the Configurations folder.

### StaticLogger

```csharp
StaticLogger.EnsureInitialized();
Log.Information("Server Booting Up...");
try
{
    // ...
    Console.WriteLine("Server Up");
}
catch (Exception ex) when (!ex.GetType().Name.Equals("StopTheHostException", StringComparison.Ordinal))
{
    StaticLogger.EnsureInitialized();
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    StaticLogger.EnsureInitialized();
    Log.Information("Server Shutting down...");
    Log.CloseAndFlush();
}
```

### AddSeriLog

```csharp
ConfigurationBuilder config = new ConfigurationBuilder();
// ...
var builder = Host.CreateDefaultBuilder().AddSeriLog(config.Build());
```

### AddConfigurations

```csharp
ConfigurationBuilder config = new ConfigurationBuilder();
config.AddConfigurations();
```

## Contributing

Contributions to this project are welcome. If you have any suggestions, bug fixes, or additional features to contribute,
please submit a pull request.