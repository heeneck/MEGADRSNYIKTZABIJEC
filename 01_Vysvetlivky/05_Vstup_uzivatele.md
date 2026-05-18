# 5. Vstup od uživatele

## Console.ReadLine()

Příkaz `Console.ReadLine()` čeká, až uživatel napíše text a stiskne Enter. Vždy vrací **string** (text).

```csharp
Console.WriteLine("Zadej barvu (cervena/modra):");
string barva = Console.ReadLine(); // načte, co uživatel napíše

if (barva == "cervena")
{
    Console.WriteLine("Zadal jsi barvu lásky a krve.");
}
else if (barva == "modra")
{
    Console.WriteLine("Zadal jsi barvu oblohy.");
}
else
{
    Console.WriteLine("Tuto barvu neznám.");
}
```

---

## Typický postup: Zeptat se → Načíst → Použít

```csharp
Console.WriteLine("Jak se jmenuješ?");  // 1. Zeptej se
string jmeno = Console.ReadLine();       // 2. Načti odpověď
Console.WriteLine($"Ahoj, {jmeno}!");   // 3. Použij hodnotu
```

---

## Kombinace s podmínkou ToLower() — ignoruje velká/malá písmena

```csharp
Console.WriteLine("Chceš pokračovat? (ano/ne)");
string odpoved = Console.ReadLine();
odpoved = odpoved.ToLower(); // převede na malá písmena

if (odpoved == "ano")
{
    Console.WriteLine("Pokračuji...");
}
else
{
    Console.WriteLine("Ukončuji program.");
}
```

---

## ⚠️ Důležité poznámky
- `Console.ReadLine()` **vždy vrací string** — i když uživatel napíše číslo
- Pro čísla je potřeba převod pomocí `Convert` (viz kapitola 6)
- Pokud uživatel stiskne Enter bez zadání, proměnná bude prázdný string `""`
- Porovnávání stringů je citlivé na velká/malá písmena: `"Ano" != "ano"`
