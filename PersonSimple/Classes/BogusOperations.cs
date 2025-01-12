using Bogus;
using PersonSimple.Models;
using static Bogus.Randomizer;
using Person = PersonSimple.Models.Person;

namespace PersonSimple.Classes;
internal class BogusOperations
{
    public static List<Person> CreatePeopleList(int count, int identifier, bool random = true)
    {
        if (!random)
        {
            Seed = new Random(338);
        }

        var id = identifier;

        var faker = new Faker<Person>()
            .RuleFor(c => c.Id, f => id++)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(c => c.BirthDate, u => u.Date.BetweenDateOnly(new DateOnly(1950, 1, 1), new DateOnly(2010, 1, 1)))
            .RuleFor(c => c.Gender, f => f.PickRandom<Gender>());

        return faker.Generate(count);

    }
}
