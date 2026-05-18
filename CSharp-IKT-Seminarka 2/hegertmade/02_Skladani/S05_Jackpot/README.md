# S05 — Jackpot 🔀

## Popis
Nekonečný cyklus vypisuje náhodná čísla (1–100). Číslo 50 = "JACKPOT".

## 🔀 Přeházené řádky:
```
while (1 + 1 == 2) { [ZDE BUDOU PŘÍKAZY] }
Console.WriteLine(nahodneCislo);
Console.WriteLine("JACKPOT");
if (nahodneCislo == 50) { [ZDE BUDE 1 PŘÍKAZ] }
int nahodneCislo = Random.Shared.Next(1, 100);
Console.WriteLine("Vítej v programu");
else { [ZDE BUDE 1 PŘÍKAZ] }
```
*Tip: vše od int nahodneCislo dál patří UVNITŘ while. Řešení → `Reseni.cs`*
