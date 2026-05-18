# 8. Práce s textem (string)

Stringy (texty) mají v C# spoustu vestavěných příkazů pro analýzu a úpravu.

---

## ToUpper() a ToLower() — velká/malá písmena

```csharp
string text = "Ahoj Světe";
Console.WriteLine(text.ToUpper()); // AHOJ SVĚTE
Console.WriteLine(text.ToLower()); // ahoj světe
```

**Praktické použití** — ignoruj velikost písmen při porovnání:

```csharp
string vstup = Console.ReadLine();
if (vstup.ToLower() == "ano")  // funguje pro "ano", "ANO", "Ano", "aNo"...
{
    Console.WriteLine("Rozumím, že souhlasíš.");
}
```

---

## Trim() — oříznutí mezer

Odstraní mezery (a Enter) na **začátku a konci** textu.

```csharp
string textik = "   Ahoj   ";
textik = textik.Trim();
Console.WriteLine(textik); // "Ahoj" — mezery pryč
```

---

## Length — délka textu

Vrátí počet znaků (jako `int`).

```csharp
string text = "Alibaba";
int delka = text.Length;
Console.WriteLine(delka); // 7

// Kontrola délky hesla
string heslo = Console.ReadLine();
if (heslo.Length >= 8)
{
    Console.WriteLine("Heslo je dostatečně dlouhé");
}
else
{
    Console.WriteLine("Heslo je příliš krátké");
}
```

---

## StartsWith() a EndsWith() — začátek a konec

```csharp
string soubor = "dokument.txt";
Console.WriteLine(soubor.StartsWith("dok")); // true
Console.WriteLine(soubor.EndsWith(".txt"));  // true
Console.WriteLine(soubor.EndsWith(".pdf"));  // false
```

**Praktické použití:**

```csharp
string soubor = Console.ReadLine();

if (soubor.EndsWith(".jpg") || soubor.EndsWith(".png"))
{
    Console.WriteLine("Obrázek");
}
else if (soubor.EndsWith(".txt"))
{
    Console.WriteLine("Textový soubor");
}
else
{
    Console.WriteLine("Neznámý typ");
}
```

---

## Contains() — obsahuje daný text?

```csharp
string veta = "Every day is not a day";
Console.WriteLine(veta.Contains("day")); // true
Console.WriteLine(veta.Contains("night")); // false
```

**Praktické použití:**

```csharp
string veta = Console.ReadLine();
if (veta.Contains("ahoj") || veta.Contains("hello"))
{
    Console.WriteLine("Pozdrav nalezen!");
}
```

---

## Replace() — nahrazení textu

Nahradí **všechny výskyty** hledaného textu jiným textem.

```csharp
string veta = "Ahoj světe, mám tě rád světe";
string novaVeta = veta.Replace("světe", "Karle");
Console.WriteLine(novaVeta); // Ahoj Karle, mám tě rád Karle
```

---

## Řetězení příkazů

Příkazy, které vrací string, lze **psát za sebe**:

```csharp
string veta = " Good morning New York!  ";
string novaVeta = veta.Trim()
                      .Replace("morning", "night")
                      .Replace("New York", "Miami")
                      .ToUpper();

Console.WriteLine(novaVeta); // GOOD NIGHT MIAMI!
```

---

## Přehled příkazů

| Příkaz | Co dělá | Vrací |
|--------|---------|-------|
| `text.ToUpper()` | Převede na VELKÁ | `string` |
| `text.ToLower()` | Převede na malá | `string` |
| `text.Trim()` | Odstraní mezery na okrajích | `string` |
| `text.Length` | Počet znaků | `int` |
| `text.StartsWith("x")` | Začíná na "x"? | `bool` |
| `text.EndsWith("x")` | Končí na "x"? | `bool` |
| `text.Contains("x")` | Obsahuje "x"? | `bool` |
| `text.Replace("x","y")` | Nahradí "x" za "y" | `string` |
