using System.Text;

namespace Shop.Components;

public class Memory : Component 
{
    public string? MemoryType { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Name: {Name}");
        builder.AppendLine($"Type of memory: {MemoryType}");
        builder.AppendLine($"Price: {Price:0.00} UAH");
        return builder.ToString();
    }
}
