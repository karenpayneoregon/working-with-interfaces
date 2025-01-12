
// ReSharper disable NonReadonlyMemberInGetHashCode

namespace PersonSimple.Models.Records;
/// <summary>
/// Represents a person with a first name and a last name.
/// </summary>
/// <remarks>
/// This class provides functionality to compare instances of <see cref="Person"/> for equality 
/// based on their <see cref="FirstName"/> and <see cref="LastName"/> properties.
/// </remarks>
public class Person : IEquatable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public bool Equals(Person other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return FirstName == other.FirstName && LastName == other.LastName;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Person)obj);
    }

    public override int GetHashCode() => HashCode.Combine(FirstName, LastName);
}

