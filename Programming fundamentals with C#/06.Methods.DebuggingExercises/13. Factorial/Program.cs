using System;
using System.Numerics;
namespace _13._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactoriel(number));
        }
        static BigInteger CalculateFactoriel(BigInteger number)
        {
            BigInteger factoriel = 1;

            for (int i = 1; i <= number; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
