using System.Text;

namespace Shop.Components;

public class Processor : Component
{
    public int CoresNumber { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Name: {Name}");
        builder.AppendLine($"Number of cores: {CoresNumber}");
        builder.AppendLine($"Price: {Price:0.00} UAH");
        return builder.ToString();
    }
}
