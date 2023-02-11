using System;

namespace GenericTuple
{
    public class StartUp
    {
        static void Main()
        {
            string[] personAddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] personBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] intDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = $"{personAddress[0]} {personAddress[1]}";
            string address = personAddress[2];
            Tuple<string, string> personAddressTuple = new Tuple<string, string>(name, address);

            name = personBeer[0];
            int litters = int.Parse(personBeer[1]);
            Tuple<string, int> personBeerTuple = new Tuple<string, int>(name, litters);

            int intNymber = int.Parse(intDouble[0]);
            double doubleNumber = double.Parse(intDouble[1]);
            Tuple<int, double> intDoubleTuple = new Tuple<int, double>(intNymber, doubleNumber);


            Console.WriteLine(personAddressTuple);
            Console.WriteLine(personBeerTuple);
            Console.WriteLine(intDoubleTuple);

        }
    }
}