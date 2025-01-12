using PersonSimple.Classes;
using PersonSimple.Interfaces;
using PersonSimple.Models;
using Serilog;
using UtilityLibrary;

// ReSharper disable SuspiciousTypeConversion.Global

namespace PersonSimple;

internal partial class Program
{
    private static void Main(string[] args)
    {
        //ProcessAndDisplayEntitiesForIIdentity();
        //ImplementsIdentifyAndHuman1();
        //LogAndModifyPerson();
        //Demo.Show();

        GetAllClassesImplementing();
        Console.ReadLine();
    }

    private static void GetAllClassesImplementing()
    {
        Customer customer = new()
        {
            CustomerIdentifier = 2,
            FirstName = "Jane",
            LastName = "Doe",
            AccountNumber = "1234567890"
        };

        if (customer is IIdentity c)
        {
            AnsiConsole.MarkupLine($"[cyan]Id[/] " +
                                   $"{c.Id,-3}[cyan]CustomerIdentifier[/] " +
                                   $"{customer.CustomerIdentifier}");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Customer is not an IIdentity[/]");
        }

        Console.WriteLine();

        var entities = Helpers.GetAllEntities<IIdentity>();
        foreach (var entity in entities)
        {
            AnsiConsole.MarkupLine($"[cyan]{entity.Name}[/]");
        }

        Console.WriteLine();

        var entitiesMore = Helpers.ImplementsMoreThanOneInterface<Person>(
            [typeof(IIdentity), typeof(IHuman)]);

        AnsiConsole.MarkupLine(entitiesMore ?
            "[cyan]Yes[/]" :
            "[red]No[/]");

    }
    /// <summary>
    /// Logs the creation and modification of a <see cref="Person"/> instance.
    /// </summary>
    /// <remarks>
    /// This method creates a new <see cref="Person"/> object with predefined attributes, 
    /// logs its creation, modifies some of its properties, and logs the modifications.
    /// </remarks>
    private static void LogAndModifyPerson()
    {
        Log.Information($"Creating new person\n{new string('-', 80)}");
        Person newPerson = new()
        {
            PersonIdentifier = 5,
            FirstName = "Tatiana",
            LastName = "Mikhaylov",
            BirthDate = new DateOnly(1990, 5, 15),
            Gender = Gender.Female,
            Language = Language.Russian
        };

        Log.Information($"Modifying person\n{new string('-', 80)}");

        newPerson.FirstName = "Jane";
        newPerson.Language = Language.English;
        AnsiConsole.MarkupLine("[cyan]See log file[/]");
    }

    /// <summary>
    /// Demonstrates the implementation and usage of the <see cref="IIdentity"/> 
    /// and <see cref="IHuman"/> interfaces by creating a <see cref="Person"/> instance.
    /// </summary>
    /// <remarks>
    /// This method initializes a <see cref="Person"/> object with predefined attributes 
    /// and checks if it implements both <see cref="IIdentity"/> and <see cref="IHuman"/> interfaces. 
    /// If the object satisfies these interfaces, its properties are displayed in a formatted output.
    /// Otherwise, a message indicating the absence of these interfaces is shown.
    /// </remarks>
    private static void ImplementsIdentifyAndHuman1()
    {
        Person newPerson = new()
        {
            PersonIdentifier = 5,
            FirstName = "Tatiana",
            LastName = "Mikhaylov",
            BirthDate = new DateOnly(1990, 5, 15),
            Gender = Gender.Female,
            Language = Language.Russian
        };

        if (newPerson is IIdentity p and IHuman h)
        {
            AnsiConsole.MarkupLine($"[cyan]Id[/] {p.Id,-3}[cyan] " +
                                   $"First[/] {h.FirstName} [cyan] " +
                                   $"Last[/] {h.LastName} [cyan] " +
                                   $"Gender[/] {h.Gender} [cyan] " +
                                   $"Language[/] {h.Language} [cyan] " +
                                   $"Birth[/] {h.BirthDate}");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]newPerson does not use IIdentity/IHuman");
        }
    }

    /// <summary>
    /// Processes and displays information about various entities that may implement the <see cref="PersonSimple.Interfaces.IIdentity"/> interface.
    /// </summary>
    /// <remarks>
    /// This method creates instances of different entity types, such as <see cref="Person"/>, 
    /// <see cref="Customer"/>, <see cref="Product"/>, and <see cref="Category"/>.
    /// It checks if each entity implements the <see cref="PersonSimple.Interfaces.IIdentity"/> interface and displays their identifiers.
    /// If an entity does not implement the interface, a corresponding message is displayed.
    /// </remarks>
    private static void ProcessAndDisplayEntitiesForIIdentity()
    {
        Person person = new()
        {
            PersonIdentifier = 1,
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateOnly(1980, 1, 1)
        };

        if (person is IIdentity p)
        {
            AnsiConsole.MarkupLine($"[cyan]Id[/] " +
                                   $"{p.Id,-3}[cyan]PersonIdentifier[/] " +
                                   $"{person.PersonIdentifier}");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Person is not an IIdentity[/]");
        }

        Customer customer = new()
        {
            CustomerIdentifier = 2,
            FirstName = "Jane",
            LastName = "Doe",
            AccountNumber = "1234567890"
        };

        if (customer is IIdentity c)
        {
            AnsiConsole.MarkupLine($"[cyan]Id[/] " +
                                   $"{c.Id,-3}[cyan]CustomerIdentifier[/] " +
                                   $"{customer.CustomerIdentifier}");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Customer is not an IIdentity[/]");
        }

        Product product = new()
        {
            ProdId = 3,
            Name = "Widget",
            Price = 9.99m
        };

        if (product is IIdentity prod)
        {
            AnsiConsole.MarkupLine($"[cyan]Id[/] " +
                                   $"{prod.Id,-3}[cyan]ProdId[/] " +
                                   $"{product.ProdId}");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Product is not an IIdentity[/]");
        }

        Category category = new()
        {
            CategoryId = 4,
            Name = "Widgets"
        };

        if (category is IIdentity cat)
        {
            AnsiConsole.MarkupLine($"[cyan]Id[/] " +
                                   $"{cat.Id,-3}[cyan]CategoryId[/] " +
                                   $"{category.CategoryId}");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Category is not an IIdentity[/]");
        }
    }
}