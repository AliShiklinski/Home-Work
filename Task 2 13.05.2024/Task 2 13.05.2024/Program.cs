using System;

  public class Program
{
    static void Main()
    {

        int n = 23452;
        Console.WriteLine("The number of floors is: " + CountFloors(n));

        n = 456;
        Console.WriteLine("The number of floors is: " + CountFloors(n));
    }

    static int CountFloors(int n)
    {

        string numberStr = n.ToString();


        return numberStr.Length;
    }
}
