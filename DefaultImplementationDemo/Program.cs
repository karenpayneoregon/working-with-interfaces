namespace DefaultImplementationDemo;

internal partial class Program
{
    static void Main(string[] args)
    {
        Demo d = new();
        d.SomeMethod();
        d.WillNotBreakExistingApplications();
        Console.ReadLine();
    }
}

internal interface ISample
{
    void SomeMethod(); 
    public void WillNotBreakExistingApplications()
    {
        Console.WriteLine("Here in the interface");
    }
}

public class Demo : ISample
{
    public void SomeMethod()
    {
        Console.WriteLine("Some method");
    }

    public void WillNotBreakExistingApplications()
    {
        Console.WriteLine("Here in the class");
    }
}