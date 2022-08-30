using System.Text;
using Shop.Components;

namespace Shop;

public class SystemUnit
{
    public Box? Box { get; internal set; }

    public Hdd? Hdd { get; internal set; }

    public MainBoard? MainBoard { get; internal set; }

    public Memory? Memory { get; internal set; }

    public Processor? Processor { get; internal set; }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine("Your system unit consists of:");
        builder.AppendLine($"\t{Box?.Name}");
        builder.AppendLine($"\t{Hdd?.Name}");
        builder.AppendLine($"\t{MainBoard?.Name}");
        builder.AppendLine($"\t{Memory?.Name}");
        builder.AppendLine($"\t{Processor?.Name}");
        return builder.ToString();
    }
}