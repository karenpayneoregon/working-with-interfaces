#nullable disable
/*
 * For writing article only
 */
namespace VariousSamples.Models;

public abstract class Base
{
    public abstract override string ToString();
}

public interface IIdentity
{
    public int Id { get; set; }
}

public class Child : Base, IIdentity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public override string ToString() 
        => $"{Id} {Name} {Description}";
}

public interface IFoo : IFormattable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class Bar : IFoo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public override string ToString() 
        => ToString(null, System.Globalization.CultureInfo.CurrentCulture);
    public string ToString(string format, IFormatProvider formatProvider) 
        => $"{Id} {Name} {Description}";

}

public interface IMasterActions<in T> where T : class
{
    int Save(T obj);

    int Update(T obj);
}

public class StudentManager : IMasterActions<Student>
{
    public int Save(Student std)
    {
        throw new NotImplementedException();
    }

    public int Update(Student obj)
    {
        throw new NotImplementedException();
    }
}

public class Student
{
}