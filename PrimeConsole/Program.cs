using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PrimeConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var amount = AskAmount();
                Stopwatch timer = new Stopwatch();
                timer.Start();
                var primes = GetPrimes(amount);
                Console.WriteLine("-----------------------------------------------------------------------");
                foreach(var prime in primes)
                {
                    Console.WriteLine(prime);
                }
                timer.Stop();

                Console.WriteLine("This process took -" + timer.Elapsed);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        public static int AskAmount()
        {
            Console.WriteLine("Please enter the amount of primes you wish to have printed");
            var input = Console.ReadLine();
            var isInt = int.TryParse(input, out int amount);
            if (isInt)
            {
                return amount;
            }
            else {
                Console.WriteLine("Entry was not correct please try again");
                return AskAmount();
            }
        }

        public static List<int> GetPrimes(int amountToPrint)
        {
            List<int> primes = new List<int>();
            var i = 1;
            while (primes.Count < amountToPrint )
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    primes.Add(i);
                }
                i++;
            }
            return primes;
        }
    }
}
