using System;

 public class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        if (IsPrime(n))
        {
            Console.WriteLine($"{n} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{n} is a composite number.");
        }
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        if (n <= 3)
        {
            return true;
        }
        if (n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }
}
