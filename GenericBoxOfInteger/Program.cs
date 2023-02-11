using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main()
        {
            Box<int> box = new Box<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                box.Add(value);
            }

            Console.WriteLine(box.ToString());
        }
    }
}