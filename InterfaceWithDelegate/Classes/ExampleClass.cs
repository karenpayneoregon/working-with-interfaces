using InterfaceWithDelegate.Interfaces;
using static InterfaceWithDelegate.Classes.Delegates;

namespace InterfaceWithDelegate.Classes;

/// <summary>
/// Represents a class that implements the <see cref="ISampleInterface"/> interface, 
/// providing functionality to trigger events such as <see cref="Started"/> and <see cref="StatusUpdated"/>.
/// </summary>
/// <remarks>
/// This class is responsible for invoking the <see cref="Started"/> event when the start process is initiated 
/// and the <see cref="StatusUpdated"/> event to notify about status changes.
/// </remarks>
public class ExampleClass : ISampleInterface
{

    public event UpdateStatusEventHandler StatusUpdated;
    public event StartedEventHandler Started;

    public void Start()
    {
        Started?.Invoke();
        StatusUpdated?.Invoke("Started");
    }
}