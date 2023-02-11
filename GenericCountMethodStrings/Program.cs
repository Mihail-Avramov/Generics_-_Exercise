using System;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                box.Add(value);
            }

            string itemToCompare = Console.ReadLine();

            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}