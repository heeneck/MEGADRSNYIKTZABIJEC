# S04 — Generátor čísel 🔀

## Popis programu

V programu uživatel zadá, kolik chce vygenerovat náhodných čísel.
Uživatel zadá `BIG` nebo `SMALL`.
Program vygeneruje náhodné číslo dané velikosti tolikrát, co uživatel zadal.

- `SMALL` = číslo 1–100
- `BIG` = číslo 1–100 000 000

## Jak by vypadalo spuštění programu:
```
Vítej v programu
Zadej počet čísel
[uživatel zadá 3]
Zadej velikost čísel: BIG nebo SMALL
[uživatel zadá "SMALL"]
74
51
6

Vítej v programu
Zadej počet čísel
[uživatel zadá 3]
Zadej velikost čísel: BIG nebo SMALL
[uživatel zadá "BIG"]
741515
5189361
6497
```

---

## 🔀 Přeházené řádky — seřaď je správně:

```
string vstupPocet = Console.ReadLine();
Console.WriteLine("Zadej počet čísel");
Console.WriteLine("Vítej v programu");
int pocetCisel = Convert.ToInt32(vstupPocet);
Console.WriteLine("Zadej velikost čísel: BIG nebo SMALL");
string velikostCisel = Console.ReadLine();
Console.WriteLine(nahodneCislo);
if (velikostCisel == "BIG")
{
    [ZDE BUDOU 2 PŘÍKAZY]
}
int maleCislo = Random.Shared.Next(1, 100);
int krok = 0;
while (krok < pocetCisel)
{
    [ZDE BUDOU 2 CELKY]
    krok += 1;
}
int velkeCislo = Random.Shared.Next(1, 100000000);
Console.WriteLine(velkeCislo);
else if (velikostCisel == "SMALL")
{
    [ZDE BUDOU 2 PŘÍKAZY]
}
```

*Tip: `if/else if` bloky patří **dovnitř** `while` cyklu.*

---

*Řešení je v souboru `Reseni.cs`*
