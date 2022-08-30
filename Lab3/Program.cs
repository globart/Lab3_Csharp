using Lab3;
using Lab3.ConsoleProcessors;
using Shop;

var printer = new Printer();
var reader = new Reader();

var context = new DataContext();

var unitBuilder = new SystemUnitBuilder();

Console.WriteLine("Please, choose a box:");
printer.PrintList(context.Boxes);
var index = reader.ReadAnswer(context.Boxes.Count);
unitBuilder.SetBox(context.Boxes[index-1]);

Console.WriteLine("Please, choose a HDD:");
printer.PrintList(context.Hdds);
index = reader.ReadAnswer(context.Hdds.Count);
unitBuilder.SetHdd(context.Hdds[index - 1]);

Console.WriteLine("Please, choose a main board:");
printer.PrintList(context.MainBoards);
index = reader.ReadAnswer(context.MainBoards.Count);
unitBuilder.SetMainBoard(context.MainBoards[index - 1]);

Console.WriteLine("Please, choose a memory:");
printer.PrintList(context.Memories);
index = reader.ReadAnswer(context.Memories.Count);
unitBuilder.SetMemory(context.Memories[index - 1]);

Console.WriteLine("Please, choose a processor:");
printer.PrintList(context.Processors);
index = reader.ReadAnswer(context.Processors.Count);
unitBuilder.SetProcessor(context.Processors[index - 1]);

var order = new Order()
{
    SystemUnit = unitBuilder.GetSystemUnit()
};

Console.WriteLine($"\tYour order: \n{order}");
Console.WriteLine($"Total price: {order.CalculateTotalPrice()} UAH");

unitBuilder.Reset();
