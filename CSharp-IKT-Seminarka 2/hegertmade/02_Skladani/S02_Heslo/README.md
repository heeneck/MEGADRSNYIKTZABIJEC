# S02 — Heslo 🔀

## Popis
Kontrola hesla: "XOXOXO" → otevřeno, 6 znaků → správná délka, jinak → chyba.

## 🔀 Přeházené řádky:
```
else { [ZDE BUDE 1 Z PŘÍKAZŮ] }
Console.WriteLine("Zadejte heslo a potvrďte stiskem ENTER");
else if (heslo.Length == 6) { [ZDE BUDE 1 Z PŘÍKAZŮ] }
string heslo = Console.ReadLine();
if (heslo == "XOXOXO") { [ZDE BUDE 1 Z PŘÍKAZŮ] }
Console.WriteLine("NESPRÁVNÉ HESLO");
Console.WriteLine("Správná délka hesla, ale zkuste to znovu.");
Console.WriteLine("Dveře otevřené");
```
*Řešení → `Reseni.cs`*
