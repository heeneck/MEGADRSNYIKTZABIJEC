# 4. Generování náhodných čísel

## Random.Shared.Next

V novějších verzích C# (.NET 6+) stačí jediný příkaz — není potřeba vytvářet objekt.

```csharp
// Syntaxe: Random.Shared.Next(od, do)
// Pozor: číslo "do" JIŽ NENÍ zahrnuto!

int nahodneCislo = Random.Shared.Next(1, 11); // vygeneruje 1 až 10 (11 nezahrnuto)
Console.WriteLine("Padlo číslo: " + nahodneCislo);
```

---

## Příklady rozsahů

```csharp
int cislo1 = Random.Shared.Next(1, 7);     // 1 až 6 (hod kostkou)
int cislo2 = Random.Shared.Next(0, 101);   // 0 až 100
int cislo3 = Random.Shared.Next(100, 1000); // 100 až 999
int cislo4 = Random.Shared.Next(1, 2);     // vždy 1 (jen jedna možnost)
```

> **Pravidlo:** `Random.Shared.Next(min, max)` — výsledek je vždy **>= min** a **< max**

---

## Použití s polem

```csharp
string[] jmena = { "Alice", "Bob", "Charlie", "Dana" };
int nahodnyIndex = Random.Shared.Next(0, jmena.Length); // 0 až 3
Console.WriteLine("Vybrané jméno: " + jmena[nahodnyIndex]);
```

---

## Generování v cyklu

```csharp
// Vygeneruj 5 náhodných čísel od 1 do 100
for (int i = 1; i <= 5; i++)
{
    int cislo = Random.Shared.Next(1, 101);
    Console.WriteLine($"Číslo {i}: {cislo}");
}
```

---

## ⚠️ Důležité poznámky
- Horní mez je **výhradní** (nezahrnuje se): `Next(1, 11)` = čísla 1–10
- Dolní mez je **zahrnuta**: `Next(1, 11)` může vrátit 1
- Každé spuštění vrátí jiné číslo — to je smyslem náhodnosti
