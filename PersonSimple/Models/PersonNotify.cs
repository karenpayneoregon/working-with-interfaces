using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Serilog;

namespace PersonSimple.Models;

/// <summary>
/// Implements <see cref="INotifyPropertyChanged"/> interfaces.
/// </summary>
public partial class Person
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new(propertyName));

    /// <summary>
    /// Updates the specified field with a new value and raises the <see cref="OnPropertyChanged"/> event if the value changes.
    /// </summary>
    /// <typeparam name="T">The type of the field being updated.</typeparam>
    /// <param name="field">A reference to the field to be updated.</param>
    /// <param name="value">The new value to assign to the field.</param>
    /// <param name="propertyName">
    /// The name of the property associated with the field. This parameter is optional and is automatically provided by the compiler.
    /// </param>
    /// <returns>
    /// <c>true</c> if the field value was updated and the <see cref="OnPropertyChanged"/> event was raised; otherwise, <c>false</c>.
    /// </returns>
    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
    {
        if (Debugger.IsAttached)
            Log.Information("Property: {P}", propertyName);

        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;

        if (Debugger.IsAttached)
            Log.Information("   Value: {V}", value);
        OnPropertyChanged(propertyName);
        return true;
    }
}