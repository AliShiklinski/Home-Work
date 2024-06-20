using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sarjor hecmini daxil edin:");
        int magazineCapacity = int.Parse(Console.ReadLine());

        Console.WriteLine("Cari gullelerin sayını daxil edin:");
        int currentBullets = int.Parse(Console.ReadLine());

        Console.WriteLine("Ates rejiminə daxil olun (Tek/Avtomatik):");
        string fireMode = Console.ReadLine();

        Weapon weapon = new Weapon(magazineCapacity, currentBullets, fireMode);

        while (true)
        {
            Console.WriteLine("0 - Get Information");
            Console.WriteLine("1 - Shoot");
            Console.WriteLine("2 - Fire");
            Console.WriteLine("3 - Get Remain Bullet Count");
            Console.WriteLine("4 - Reload");
            Console.WriteLine("5 - Change Fire Mode");
            Console.WriteLine("6 - Quit");
            Console.WriteLine("7 - Edit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine($"Magazine Capacity: {weapon.MagazineCapacity}, Current Bullets: {weapon.GetRemainBulletCount()}, Fire Mode: {weapon.FireMode}");
                    break;
                case 1:
                    weapon.Shoot();
                    break;
                case 2:
                    weapon.Fire();
                    break;
                case 3:
                    Console.WriteLine("Qalan gülleler: " + weapon.GetRemainBulletCount());
                    break;
                case 4:
                    weapon.Reload();
                    break;
                case 5:
                    weapon.ChangeFireMode();
                    break;
                case 6:
                    return;
                case 7:
                    Console.WriteLine("1 - Sarjor tutumunu deyisdirin");
                    Console.WriteLine("2 - Cari gulleleri deyisdirin");

                    int editChoice = int.Parse(Console.ReadLine());

                    if (editChoice == 1)
                    {
                        Console.WriteLine("Yeni sarjor tutumunu daxil edin:");
                        int newCapacity = int.Parse(Console.ReadLine());
                        weapon.EditMagazineCapacity(newCapacity);
                    }
                    else if (editChoice == 2)
                    {
                        Console.WriteLine("Yeni cari güllelerin sayını daxil edin:");
                        int newBulletCount = int.Parse(Console.ReadLine());
                        weapon.EditCurrentBullets(newBulletCount);
                    }
                    break;
                default:
                    Console.WriteLine("Yanlıs secim. Zehmet olmasa bir daha cehd edin.");
                    break;
            }
        }
    }
}
