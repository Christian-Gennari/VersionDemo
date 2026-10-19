using System.Reflection;

if (args.Contains("-v") || args.Contains("--version"))
{
    var version = Assembly
        .GetEntryAssembly()
        ?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
        ?.InformationalVersion;
    Console.WriteLine(version);
    return 0;
}
Console.WriteLine("Hello World");
return 0;
