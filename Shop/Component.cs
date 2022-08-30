namespace Shop;

public abstract class Component
{
    public string? Name { get; internal set; }

    public decimal Price { get; internal set; }
}
