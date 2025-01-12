namespace InterfaceWithDelegate.Classes;
/// <summary>
/// Represents a container for delegate definitions used for handling events related to status updates and process initiation.
/// </summary>
/// <remarks>
/// This class defines delegates that are utilized in event-driven programming to notify subscribers about specific actions or changes.
/// </remarks>
public class Delegates
{
    public delegate void UpdateStatusEventHandler(string status);
    public delegate void StartedEventHandler();
}
