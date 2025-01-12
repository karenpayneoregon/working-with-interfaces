using InterfaceWithDelegate.Classes;
using Serilog;

namespace InterfaceWithDelegate;

internal partial class Program
{
    private static void Main(string[] args)
    {

        ExampleClass example = new();

        // Subscribe to the Started event
        example.Started += OnStarted;

        // Subscribe to the StatusUpdated event
        example.StatusUpdated += OnStatusUpdated;

        // Call the Start method to trigger events
        AnsiConsole.MarkupLine("[yellow]Calling Start[/]");
        example.Start();

        Console.ReadLine();
    }

    
    /// <summary>
    /// Handles the <see cref="ExampleClass.Started"/> event.
    /// </summary>
    /// <remarks>
    /// This method is invoked when the <see cref="ExampleClass.Started"/> event is triggered,
    /// indicating that the start process has been initiated.
    /// </remarks>
    private static void OnStarted()
    {
        AnsiConsole.MarkupLine("[cyan]Started event[/] [yellow]triggered![/]");
        Log.Information("Started");
    }

    /// <summary>
    /// Handles the <see cref="ExampleClass.StatusUpdated"/> event.
    /// </summary>
    /// <param name="status">
    /// The updated status message provided by the <see cref="ExampleClass.StatusUpdated"/> event.
    /// </param>
    /// <remarks>
    /// This method is invoked whenever the <see cref="ExampleClass.StatusUpdated"/> event is triggered,
    /// allowing the application to respond to status changes.
    /// </remarks>
    private static void OnStatusUpdated(string status)
    {
        AnsiConsole.MarkupLine($"[cyan]Status updated:[/] [yellow]{status}[/]");
        Log.Information("Status updated");
    }
}