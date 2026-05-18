# S02 — Heslo 🔀

## Popis programu

Program vyzve k zadání hesla a od uživatele získá heslo. To si uloží do proměnné `heslo`.

- Pokud je heslo rovno `"XOXOXO"`, program vypíše `"Dveře otevřené"`
- Jinak pokud má 6 znaků, program vypíše `"Správná délka hesla, ale zkuste to znovu."`
- Pokud ani jedna podmínka neplatí, program vypíše `"NESPRÁVNÉ HESLO"`

## Jak by vypadalo spuštění programu:
```
Zadejte heslo a potvrďte stiskem ENTER
[uživatel zadá "LALALA"]
Správná délka hesla, ale zkuste to znovu.

Zadejte heslo a potvrďte stiskem ENTER
[uživatel zadá "XOXOXO"]
Dveře otevřené

Zadejte heslo a potvrďte stiskem ENTER
[uživatel zadá "HEHEHEHE"]
NESPRÁVNÉ HESLO
```

---

## 🔀 Přeházené řádky — seřaď je správně:

```
else
{
    [ZDE BUDE 1 Z PŘÍKAZŮ]
}
Console.WriteLine("Zadejte heslo a potvrďte stiskem ENTER");
else if (heslo.Length == 6)
{
    [ZDE BUDE 1 Z PŘÍKAZŮ]
}
string heslo = Console.ReadLine();
if (heslo == "XOXOXO")
{
    [ZDE BUDE 1 Z PŘÍKAZŮ]
}
Console.WriteLine("NESPRÁVNÉ HESLO");
Console.WriteLine("Správná délka hesla, ale zkuste to znovu.");
Console.WriteLine("Dveře otevřené");
```

*Tip: Zjisti, které `Console.WriteLine` patří do které větve `if/else if/else`.*

---

*Řešení je v souboru `Reseni.cs`*
