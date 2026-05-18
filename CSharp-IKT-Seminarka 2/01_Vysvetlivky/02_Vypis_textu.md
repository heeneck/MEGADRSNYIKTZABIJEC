# 2. Výpis textu do konzole

## Console.WriteLine

Základní příkaz pro výpis textu. Každý výpis skočí na nový řádek.

```csharp
Console.WriteLine("Hello World!");
```

---

## Spojování textu a proměnných pomocí `+`

```csharp
string mesto = "Praha";
int pocetObyvatel = 1300000;

Console.WriteLine("Město " + mesto + " má " + pocetObyvatel + " obyvatel.");
// Výstup: Město Praha má 1300000 obyvatel.
```

---

## Interpolace textu (dolarový způsob) — doporučeno ✅

Před uvozovku přidáme `$` a proměnné píšeme do `{}`. Čitelnější a pohodlnější.

```csharp
string mesto = "Brno";
int pocetObyvatel = 410000;

Console.WriteLine($"Město {mesto} má {pocetObyvatel} obyvatel.");
// Výstup: Město Brno má 410000 obyvatel.
```

Interpolaci lze použít i při vytváření proměnných:

```csharp
string jmeno = "Peter";
string prijmeni = "Parker";
string celeJmeno = $"{jmeno} {prijmeni}"; // "Peter Parker"

Console.WriteLine($"Tvé jméno je {celeJmeno}");
```

---

## Rozdíl: `Console.WriteLine` vs `Console.Write`

```csharp
Console.WriteLine("Řádek 1");  // skočí na nový řádek
Console.Write("Bez");          // zůstane na stejném řádku
Console.Write("mezery");
// Výstup:
// Řádek 1
// Bezmezery
```

---

## ⚠️ Důležité poznámky
- Text musí být vždy v **uvozovkách**: `"text"` ✅
- Při použití `$` musí být `$` **hned před** uvozovkou: `$"..."` ✅
- Proměnné v `{}` **nepíšeme do uvozovek**: `$"{promena}"` ✅, `$"{"promena"}"` ❌
