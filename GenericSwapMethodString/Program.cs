using System;
using System.Linq;

namespace GenericSwapMethodString
{
    public class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                box.Add(value);
            }

            int[] commandArguments = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.Swap(commandArguments[0], commandArguments[1]);

            Console.WriteLine(box.ToString());
        }
    }
}