using System.Text;

namespace Shop.Components;

public class Hdd : Component
{
    public double Volume { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Name: {Name}");
        builder.AppendLine($"Volume: {Volume} Tb");
        builder.AppendLine($"Price: {Price:0.00} UAH");
        return builder.ToString();
    }
}
