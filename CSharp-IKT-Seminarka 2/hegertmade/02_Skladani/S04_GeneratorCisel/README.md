# S04 — Generátor čísel 🔀

## Popis
Uživatel zadá počet čísel a velikost (BIG/SMALL). Program generuje čísla v cyklu.
SMALL = 1–100, BIG = 1–100 000 000.

## 🔀 Přeházené řádky:
```
string vstupPocet = Console.ReadLine();
Console.WriteLine("Zadej počet čísel");
Console.WriteLine("Vítej v programu");
int pocetCisel = Convert.ToInt32(vstupPocet);
Console.WriteLine("Zadej velikost čísel: BIG nebo SMALL");
string velikostCisel = Console.ReadLine();
int krok = 0;
while (krok < pocetCisel) { [ZDE BUDOU: if BIG + else if SMALL + krok+=1] }
if (velikostCisel == "BIG") { int velkeCislo = ...; Console.WriteLine(velkeCislo); }
else if (velikostCisel == "SMALL") { int maleCislo = ...; Console.WriteLine(maleCislo); }
```
*Tip: if/else if patří UVNITŘ while cyklu. Řešení → `Reseni.cs`*
