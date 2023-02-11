using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main()
        {
            string[] personAddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] personBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] bankInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = $"{personAddress[0]} {personAddress[1]}";
            string address = personAddress[2];
            string town = string.Join(" ", personAddress[3..]);
            Tuple<string, string, string> personAddressTuple = new Tuple<string, string, string>(name, address, town);

            name = personBeer[0];
            int litters = int.Parse(personBeer[1]);
            bool isDrunk = personBeer[2] == "drunk";
            Tuple<string, int, bool> personBeerTuple = new Tuple<string, int, bool>(name, litters, isDrunk);

            name = bankInfo[0];
            double balance = double.Parse(bankInfo[1]);
            string bank = bankInfo[2];
            Tuple<string, double, string> intDoubleTuple = new Tuple<string, double, string>(name, balance, bank);
            
            Console.WriteLine(personAddressTuple);
            Console.WriteLine(personBeerTuple);
            Console.WriteLine(intDoubleTuple);
        }
    }
}