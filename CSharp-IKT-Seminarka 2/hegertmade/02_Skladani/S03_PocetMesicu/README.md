# S03 — Počet měsíců 🔀

## Popis
Uživatel zadá počet let → výpočet měsíců (×12). Záporná čísla = CHYBA.

## 🔀 Přeházené řádky:
```
Console.WriteLine("Vítejte v programu. Zadejte počet let");
Console.WriteLine(roky + " let je " + pocetMesicu);
string rokyText = Console.ReadLine();
else { [ZDE BUDE 1 Z PŘÍKAZŮ] }
int roky = Convert.ToInt32(rokyText);
Console.WriteLine("CHYBA");
if (roky > 0) { [ZDE BUDOU 3 Z PŘÍKAZŮ] }
Console.WriteLine("Úspěšný výpočet");
int pocetMesicu = roky * 12;
```
*Řešení → `Reseni.cs`*
