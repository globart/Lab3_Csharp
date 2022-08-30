using Shop;

namespace Lab3;

public class Order
{
    public SystemUnit? SystemUnit { get; set; }

    private readonly IEnumerable<Component>? _components;

    public Order()
    {
        _components = typeof(SystemUnit).GetProperties()
            .Where(c => c.PropertyType.IsSubclassOf(typeof(Component)))
            .Select(c => c.GetValue(SystemUnit)).Cast<Component>();
    }

    public decimal CalculateTotalPrice()
    {
        return SystemUnit is null ? 0 : _components?.Sum(c => c.Price) ?? 0;
    }

    public override string ToString()
    {
        return SystemUnit?.ToString() ?? string.Empty;
    }
}
