using System.Runtime.CompilerServices;
using InterfaceWithDelegate.Classes;

// ReSharper disable once CheckNamespace
namespace InterfaceWithDelegate;



internal partial class Program
{

    [ModuleInitializer]
    public static void Init()
    {
        SetupLogging.Development();

        AnsiConsole.MarkupLine("");
        Console.Title = "Code sample";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}
