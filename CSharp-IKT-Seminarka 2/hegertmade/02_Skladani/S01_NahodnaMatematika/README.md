# S01 — Náhodná matematika 🔀

## Popis
3 náhodná čísla, první dvě se sečtou, součet × třetí = výsledek.

```
Vítej v programu
První číslo: 7 | Druhé číslo: 3 | Třetí číslo: 4
Výsledek: 40
```

## 🔀 Přeházené řádky:
```
Console.WriteLine("Výsledek: " + vysledek);
int vysledek = soucet * cislo3;
Console.WriteLine("Vítej v programu");
Console.WriteLine("Druhé číslo: " + cislo2);
int soucet = cislo1 + cislo2;
Console.WriteLine("První číslo: " + cislo1);
Console.WriteLine("Třetí číslo: " + cislo3);
int cislo1 = Random.Shared.Next(1, 15);
int cislo2 = Random.Shared.Next(1, 15);
int cislo3 = Random.Shared.Next(1, 15);
```
*Řešení → `Reseni.cs`*
