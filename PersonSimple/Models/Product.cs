using PersonSimple.Interfaces;

namespace PersonSimple.Models;

public class Product : IIdentity
{
    public int Id
    {
        get => ProdId;
        set => ProdId = value;
    }
    public int ProdId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}