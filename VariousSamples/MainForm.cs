using System.Diagnostics;
using System.Globalization;
using VariousSamples.Classes;
using VariousSamples.Models;
using static VariousSamples.Classes.ConstrainSample;

namespace VariousSamples;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void INumberSumButton_Click(object sender, EventArgs e)
    {
        Debug.WriteLine("INumber Sum");
        Debug.WriteLine(Sum([1, 2, 3, 4, 5]));
        Debug.WriteLine(Sum([5, 5]));
        Debug.WriteLine(Sum([10.541, 2.645]));
        Debug.WriteLine(Sum([1.55f, 5, 9.41f, 7]));

        // This will not compile
        //Debug.WriteLine(Sum(["A", "B","C"]));
    }

    private void GroupBooksButton_Click(object sender, EventArgs e)
    {
        BookOperations.BooksGroupings();
    }

    private void IParsablePersonButton_Click(object sender, EventArgs e)
    {
        List<string> list =
        [
            "1|John|Doe|1990-01-01|Male|English",
            "2|Mary|Doe|1992-02-01|Female|English",
            "3|Mark|Smith|2000-02-01|Female|Spanish"
        ];

        List<Person> people = list.Select(x =>
            Person.Parse(x, CultureInfo.InvariantCulture))
            .ToList();

        foreach (var p in people)
        {
            Debug.WriteLine($"{p.Id,-3}{p.FirstName} {p.LastName} {p.Gender} {p.DateOfBirth} {p.Language}");
        }

    }
}
