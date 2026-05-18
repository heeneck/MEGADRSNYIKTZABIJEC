// ŘEŠENÍ — S01: Náhodná matematika
Console.WriteLine("Vítej v programu");
int cislo1 = Random.Shared.Next(1, 15);
int cislo2 = Random.Shared.Next(1, 15);
int cislo3 = Random.Shared.Next(1, 15);
Console.WriteLine("První číslo: " + cislo1);
Console.WriteLine("Druhé číslo: " + cislo2);
Console.WriteLine("Třetí číslo: " + cislo3);
int soucet = cislo1 + cislo2;
int vysledek = soucet * cislo3;
Console.WriteLine("Výsledek: " + vysledek);
