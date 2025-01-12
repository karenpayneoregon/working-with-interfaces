using Serilog;
using static System.DateTime;

namespace PersonSimple.Classes;

/// <summary>
/// Provides functionality for configuring logging in the application.
/// </summary>
public class SetupLogging
{
    /// <summary>
    /// Configures the logging system for development purposes.
    /// </summary>
    /// <remarks>
    /// This method sets up a logger that writes log entries to a file located in the "LogFiles" directory
    /// within the application's base directory. The log file is named based on the current date and uses
    /// a custom output template.
    /// </remarks>
    public static void Development()
    {

        Log.Logger = new LoggerConfiguration()
            .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogFiles", $"{Now.Year}-{Now.Month}-{Now.Day}", "Log.txt"),
                rollingInterval: RollingInterval.Infinite,
                outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}")
            .CreateLogger();
    }
}

