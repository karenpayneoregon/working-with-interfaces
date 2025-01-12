using PersonSimple.Interfaces;

namespace PersonSimple.Models;

/// <summary>
/// Represents a customer entity with personal and account-related attributes.
/// </summary>
/// <remarks>
/// This class implements both the <see cref="IIdentity"/> and 
/// <see cref="IHuman"/> interfaces, providing a unique identifier 
/// and essential human-related properties. Additionally, it includes customer-specific 
/// attributes such as an account number.
/// </remarks>
public class Customer : IIdentity, IHuman
{
    public int Id
    {
        get => CustomerIdentifier;
        set => CustomerIdentifier = value;
    }
    public int CustomerIdentifier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public Gender Gender { get; set; }
    public Language Language { get; set; }
    public string AccountNumber { get; set; }
}