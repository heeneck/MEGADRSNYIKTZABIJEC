// ŘEŠENÍ — S04: Generátor čísel
// Správné pořadí řádků:
// Poznámka: v PDF řešení je Console.WriteLine(nahodneCislo) — ve skutečnosti
// jde o Console.WriteLine(maleCislo), proměnná maleCislo se jmenuje jinak.
// Níže je opravená verze.

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
