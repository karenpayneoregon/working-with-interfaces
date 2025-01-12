using PersonSimple.Interfaces;
using System.ComponentModel;

namespace PersonSimple.Models;
/// <summary>
/// Represents a person with identifiable and human-related attributes.
/// </summary>
/// <remarks>
/// This class implements the <see cref="IIdentity"/> and 
/// <see cref="IHuman"/> interfaces, providing properties 
/// for unique identification and personal details such as name, birthdate, gender, 
/// and language. It also supports property change notifications through 
/// <see cref="INotifyPropertyChanged"/>.
/// </remarks>
public partial class Person : IIdentity, IHuman, INotifyPropertyChanged
{
    public int Id
    {
        get => PersonIdentifier;
        set => PersonIdentifier = value;
    }

    public int PersonIdentifier { get; set; }
    public string FirstName
    {
        get => field.TrimEnd();
        set => SetField(ref field, value, nameof(FirstName));
    }

    public string LastName
    {
        get => field.TrimEnd();
        set => SetField(ref field, value, nameof(LastName));
    }

    public DateOnly BirthDate
    {
        get;
        set => SetField(ref field, value, nameof(BirthDate));
    }
    public Gender Gender
    {
        get;
        set => SetField(ref field, value, nameof(Gender));
    }

    public Language Language
    {
        get;
        set => SetField(ref field, value, nameof(Language));
    }
}