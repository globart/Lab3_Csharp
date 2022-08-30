namespace Lab3.ConsoleProcessors;

public class Reader
{
    public int ReadAnswer(int maxValue)
    {
        Console.Write($"Please, choose a component: ");
        int key = 0;
        while (!int.TryParse(Console.ReadLine(), out key) || key <= 0 || key > maxValue)
        {
            Console.Write($"Please, choose a component: ");
        }
        Console.WriteLine();

        return key;
    }
}
