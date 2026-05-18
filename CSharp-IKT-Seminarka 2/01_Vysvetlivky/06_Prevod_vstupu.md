# 6. Převod vstupu od uživatele na číslo

## Proč převádět?

`Console.ReadLine()` vždy vrátí **text (string)**. Pokud chceme s číslem počítat (sečíst, porovnat…), musíme ho převést na číselný typ pomocí `Convert`.

---

## Convert.ToInt32 — převod na celé číslo (int)

```csharp
Console.WriteLine("Zadej rok narození:");
string vstup = Console.ReadLine();
int rokNarozeni = Convert.ToInt32(vstup); // převede text na int

int aktualniRok = 2026;
int vypocitanyVek = aktualniRok - rokNarozeni;

Console.WriteLine("Tvůj věk je zhruba " + vypocitanyVek + " let.");
```

---

## Convert.ToDouble — převod na desetinné číslo (double)

```csharp
Console.WriteLine("Zadej počet euro:");
string vstupEuro = Console.ReadLine();
double pocetEuro = Convert.ToDouble(vstupEuro);

double prevedeneNaCZK = pocetEuro * 25.0; // kurz
Console.WriteLine($"Zadaná částka v euro je {prevedeneNaCZK} korun českých.");
```

> ⚠️ Při zadávání desetinných čísel záleží na **nastavení počítače** — může být potřeba čárka nebo tečka.

---

## Zkrácený zápis (bez pomocné proměnné)

Obě operace lze zapsat na jeden řádek:

```csharp
int vek = Convert.ToInt32(Console.ReadLine());
double cena = Convert.ToDouble(Console.ReadLine());
```

---

## Přehled Convert metod

| Příkaz | Převádí na | Použití |
|--------|-----------|---------|
| `Convert.ToInt32(text)` | `int` | Celá čísla |
| `Convert.ToDouble(text)` | `double` | Desetinná čísla |
| `Convert.ToBool(text)` | `bool` | `"true"` / `"false"` |
| `Convert.ToString(cislo)` | `string` | Číslo → text |

---

## ⚠️ Důležité poznámky
- Pokud uživatel zadá text místo čísla (např. `"ahoj"`), program **spadne s chybou**
- Vždy říkej uživateli, co má zadat: `Console.WriteLine("Zadej číslo:")`
- `Convert.ToInt32` neumí desetinná čísla — pro ta používej `Convert.ToDouble`
