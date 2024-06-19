using System;

public class Weapon
{
    public int MagazineCapacity { get; private set; }
    public int CurrentBullets { get; private set; }
    public string FireMode { get; private set; }

    public Weapon(int magazineCapacity, int currentBullets, string fireMode)
    {
        if (magazineCapacity <= 0 || currentBullets < 0 || string.IsNullOrEmpty(fireMode))
        {
            throw new ArgumentException("Invalid arguments for Weapon creation.");
        }

        MagazineCapacity = magazineCapacity;
        CurrentBullets = currentBullets;
        FireMode = fireMode;
    }

    public void Shoot()
    {
        if (CurrentBullets > 0)
        {
            CurrentBullets--;
            Console.WriteLine("Bir gulle atıldı. Qalan gulleler: " + CurrentBullets);
        }
        else
        {
            Console.WriteLine("Atılmaga gulle qalmadı.");
        }
    }

    public void Fire()
    {
        if (CurrentBullets > 0)
        {
            Console.WriteLine(CurrentBullets + " gulleler atıldı.");
            CurrentBullets = 0;
        }
        else
        {
            Console.WriteLine("Ates ucun gulle qalmadı.");
        }
    }

    public int GetRemainBulletCount()
    {
        return CurrentBullets;
    }

    public void Reload()
    {
        CurrentBullets = MagazineCapacity;
        Console.WriteLine("Magazine reloaded. Bullets: " + CurrentBullets);
    }

    public void ChangeFireMode()
    {
        FireMode = FireMode == "Tek" ? "Automatic" : "Tek";
        Console.WriteLine("Fire mode changed to: " + FireMode);
    }

    public void EditMagazineCapacity(int newCapacity)
    {
        if (newCapacity > 0)
        {
            MagazineCapacity = newCapacity;
            Console.WriteLine("Magazine capacity changed to: " + MagazineCapacity);
        }
        else
        {
            Console.WriteLine("Invalid magazine capacity.");
        }
    }

    public void EditCurrentBullets(int newBulletCount)
    {
        if (newBulletCount >= 0 && newBulletCount <= MagazineCapacity)
        {
            CurrentBullets = newBulletCount;
            Console.WriteLine("Current bullets count changed to: " + CurrentBullets);
        }
        else
        {
            Console.WriteLine("Invalid bullet count.");
        }
    }
}
