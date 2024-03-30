using System;

namespace Using_Recursion
{
    class Program
    {
        static int Sum(int n, int m)
        {
            if (n == m)
            {
                return n;
            }
            else if (n > m)
            {
                return Sum(m, n);
            }
            else
            {
                return n + Sum(n + 1, m);
            }
        }

        static int CountDivisions(int number)
        {
            int count = 0;
            while (number % 2 == 0)
            {
                count++;
                number /= 2;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number m: ");
            int m = int.Parse(Console.ReadLine());
            int sum = Sum(n, m);
            Console.WriteLine(sum);

            Console.WriteLine("\nDivision");
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            int divisionCount = CountDivisions(number);
            Console.WriteLine($"Total number of divisions: {divisionCount}");

        }
    }
}
