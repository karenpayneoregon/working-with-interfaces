using PersonSimple.Classes;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace PersonSimple
{
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
}
