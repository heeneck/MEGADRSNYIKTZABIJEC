# S03 — Počet měsíců 🔀

## Popis programu

Uživatel zadá počet let, program počet vynásobí 12 a vypíše počet měsíců.
Pokud je počet let větší než 0, provede se výpočet. Pokud není, vypíše se `"CHYBA"`.

## Jak by vypadalo spuštění programu:
```
Vítejte v programu. Zadejte počet let
[uživatel zadá "5"]
Úspěšný výpočet
5 let je 60 měsíců

Vítejte v programu. Zadejte počet let
[uživatel zadá "-4"]
CHYBA

Vítejte v programu. Zadejte počet let
[uživatel zadá "1"]
Úspěšný výpočet
1 let je 12 měsíců
```

---

## 🔀 Přeházené řádky — seřaď je správně:

```
Console.WriteLine("Vítejte v programu. Zadejte počet let");
Console.WriteLine(roky + " let je " + pocetMesicu);
string rokyText = Console.ReadLine();
else
{
    [ZDE BUDE 1 Z PŘÍKAZŮ]
}
int roky = Convert.ToInt32(rokyText);
Console.WriteLine("CHYBA");
if (roky > 0)
{
    [ZDE BUDOU 3 Z PŘÍKAZŮ]
}
Console.WriteLine("Úspěšný výpočet");
int pocetMesicu = roky * 12;
```

*Tip: Uvnitř `if (roky > 0)` patří 3 příkazy — v jakém pořadí?*

---

*Řešení je v souboru `Reseni.cs`*
