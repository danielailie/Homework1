using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main()
        {
            var numberOfNumbers = Convert.ToInt32(Console.ReadLine());

            var primeNumber=new PrimeNumber(numberOfNumbers);
            primeNumber.PrintTheArrayOfNumbers();
        }

    }
}
