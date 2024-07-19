using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] sayilar = { 10, 20, 5, 25, 8, 30 };

        int enBoyuk = EnBuyukSayiyiBul(sayilar);

        Console.WriteLine("En boyuk sayı: " + enBoyuk);
    }

    static int EnBuyukSayiyiBul(int[] sayilar)
    {
        int enBoyuk = sayilar[0];

        foreach (int sayi in sayilar)
        {
            if (sayi > enBoyuk)
            {
                enBoyuk = sayi;
            }
        }

        return enBoyuk;
    }
}
