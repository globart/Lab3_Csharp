namespace Lab3.ConsoleProcessors;

public class Printer
{
    public void PrintList<T>(List<T>? list) where T : class
    {
        if(list == null || list.Count == 0)
            Console.WriteLine("A list of items is empty.");
        else
        {
            for(int i = 0; i < list.Count; i++)
                Console.WriteLine($"\t{i+1} - Component: \n{list[i]}");
        }
    }
}
