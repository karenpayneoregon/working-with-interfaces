using PersonSimple.Models;

namespace PersonSimple.Interfaces;

/// <summary>
/// Represents a human entity with basic personal attributes.
/// </summary>
/// <remarks>
/// This interface defines the essential properties that describe a human, 
/// such as their name, birthdate, gender, and preferred language.
/// It is intended to be implemented by classes that model human-related entities.
/// </remarks>
public interface IHuman
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public Gender Gender { get; set; }
    public Language Language { get; set; }
}