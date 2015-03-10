using System;

namespace PrimeNumbers
{
    class PrimeNumber
    {
        public int NumberOfNumbers { get; set; }

        public PrimeNumber(int n)
        {
            NumberOfNumbers = n;
        }

        public void PrintTheArrayOfNumbers()
        {
            for (int i = 1; i <= NumberOfNumbers; i++)
            {
                if (isPrime(i))
                    Console.Write(i + "-prime, ");
                else
                {
                    Console.Write( i + ", ");
                }
            }
            Console.ReadLine();
        }

        private static bool isPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n%2 == 0)
                return false;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
