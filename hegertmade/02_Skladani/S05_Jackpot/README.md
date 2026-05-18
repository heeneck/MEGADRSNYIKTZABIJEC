# S05 — Jackpot 🔀

## Popis programu

Program bude donekonečna vypisovat náhodná čísla (1–100).
Pokud bude číslo 50, vypíše namísto čísla text `"JACKPOT"`.

## Jak by vypadalo spuštění programu:
```
Vítej v programu
7
48
89
4
25
17
64
JACKPOT
37
92
5
33
... až do nekonečna
```

---

## 🔀 Přeházené řádky — seřaď je správně:

```
while (1 + 1 == 2)
{
    [ZDE BUDOU PŘÍKAZY]
}
Console.WriteLine(nahodneCislo);
Console.WriteLine("JACKPOT");
if (nahodneCislo == 50)
{
    [ZDE BUDE 1 PŘÍKAZ]
}
int nahodneCislo = Random.Shared.Next(1, 100);
Console.WriteLine("Vítej v programu");
else
{
    [ZDE BUDE 1 PŘÍKAZ]
}
```

*Tip: Celý blok `int nahodneCislo = ...` + `if/else` patří dovnitř `while` cyklu.*

---

*Řešení je v souboru `Reseni.cs`*
