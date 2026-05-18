// ŘEŠENÍ — S04: Generátor čísel
Console.WriteLine("Vítej v programu");
Console.WriteLine("Zadej počet čísel");
string vstupPocet = Console.ReadLine();
int pocetCisel = Convert.ToInt32(vstupPocet);
Console.WriteLine("Zadej velikost čísel: BIG nebo SMALL");
string velikostCisel = Console.ReadLine();
int krok = 0;
while (krok < pocetCisel)
{
    if (velikostCisel == "BIG")
    {
        int velkeCislo = Random.Shared.Next(1, 100000000);
        Console.WriteLine(velkeCislo);
    }
    else if (velikostCisel == "SMALL")
    {
        int maleCislo = Random.Shared.Next(1, 100);
        Console.WriteLine(maleCislo);
    }
    krok += 1;
}
