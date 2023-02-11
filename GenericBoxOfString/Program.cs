﻿using System;

namespace GenericBoxOfString
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

            Console.WriteLine(box.ToString());
        }
    }
}