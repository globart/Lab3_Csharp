using System.Text;

namespace Shop.Components;

public class Box : Component
{
    public int CoolersNumber { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Name: {Name}");
        builder.AppendLine($"Number of coolers: {CoolersNumber}");
        builder.AppendLine($"Price: {Price:0.00} UAH");
        return builder.ToString();
    }
}
