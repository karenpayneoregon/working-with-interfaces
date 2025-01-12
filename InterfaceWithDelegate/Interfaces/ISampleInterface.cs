using static InterfaceWithDelegate.Classes.Delegates;

namespace InterfaceWithDelegate.Interfaces;

/// <summary>
/// Defines a contract for an interface that includes events for status updates and process initiation.
/// </summary>
/// <remarks>
/// Implementers of this interface are expected to provide mechanisms to handle the <see cref="StatusUpdated"/> 
/// and <see cref="Started"/> events, enabling notification of status changes and the initiation of processes.
/// </remarks>
public interface ISampleInterface
{
    event UpdateStatusEventHandler StatusUpdated;
    event StartedEventHandler Started;
}