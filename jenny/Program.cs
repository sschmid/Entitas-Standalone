using DesperateDevs.Cli.Utils;
using DesperateDevs.Serialization.Cli.Utils;
using Jenny.Generator;
using Jenny.Generator.Cli;

namespace MyProject.Jenny;

public static class Program
{
    public static void Main(string[] args)
    {
        AbstractPreferencesCommand.DefaultPropertiesPath = CodeGenerator.DefaultPropertiesPath;
        new CliProgram("Jenny", typeof(ServerCommand), args).Run();
    }
}
