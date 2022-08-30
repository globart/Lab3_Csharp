using System.Text;

namespace Shop.Components;

public class MainBoard : Component
{
    public int MaxFrequency { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Name: {Name}");
        builder.AppendLine($"Max memory frequency: {MaxFrequency} MHz");
        builder.AppendLine($"Price: {Price:0.00} UAH");
        return builder.ToString();
    }
}
