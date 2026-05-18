# 10. Pole (array) a List

Pole a List slouží k uchování **více hodnot stejného datového typu** v jedné proměnné.
Každá položka má **index** — pořadové číslo začínající od **0** (ne od 1!).

---

## POLE (array) — pevná velikost

Pole má pevnou velikost — po vytvoření **nelze přidávat ani odebírat** prvky.

### Vytvoření s hodnotami

```csharp
string[] mesta = { "Praha", "Brno", "Ostrava", "Plzeň" };
int[] cisla = { 10, 20, 30, 40, 50 };
```

### Vytvoření prázdného pole (dané velikosti)

```csharp
int[] skore = new int[5];       // 5 čísel, vše 0
string[] jmena = new string[3]; // 3 texty, vše null/prázdné
```

### Čtení a zápis hodnot

```csharp
string[] mesta = { "Praha", "Brno", "Ostrava", "Plzeň" };

Console.WriteLine(mesta[0]); // Praha  (první → index 0)
Console.WriteLine(mesta[2]); // Ostrava (třetí → index 2)

mesta[1] = "Liberec"; // přepsání hodnoty na indexu 1
Console.WriteLine(mesta[1]); // Liberec
```

### Užitečné příkazy pro pole

```csharp
// Pozor: vyžaduje "using System.Linq;" na začátku souboru
int[] cisla = { 5, 3, 8, 1, 9, 2 };

Console.WriteLine(cisla.Length); // 6   — počet prvků
Console.WriteLine(cisla.Sum());  // 28  — součet
Console.WriteLine(cisla.Min());  // 1   — minimum
Console.WriteLine(cisla.Max());  // 9   — maximum
```

---

## LIST — flexibilní velikost

List umožňuje **přidávat a odebírat** prvky za běhu programu.
Indexování od 0 funguje stejně jako u pole.

### Vytvoření prázdného Listu a přidávání

```csharp
List<string> jidla = new List<string>();

jidla.Add("Pizza");
jidla.Add("Burger");
jidla.Add("Sushi");

Console.WriteLine(jidla[0]); // Pizza
Console.WriteLine(jidla[2]); // Sushi
```

### Vytvoření Listu s hodnotami rovnou

```csharp
List<int> body = new List<int> { 100, 250, 75, 300 };
Console.WriteLine(body[1]); // 250
```

### Odebrání prvků

```csharp
List<string> jidla = new List<string> { "Pizza", "Burger", "Sushi" };

jidla.Remove("Burger");  // odebere "Burger" (první výskyt)
jidla.RemoveAt(0);       // odebere prvek na indexu 0 ("Pizza")
jidla.Clear();           // vyprázdní celý List
```

### Počet prvků — .Count

```csharp
List<string> jidla = new List<string> { "Pizza", "Burger", "Sushi" };
Console.WriteLine(jidla.Count); // 3  (u Listu se používá .Count, ne .Length)
```

### Vložení na konkrétní index

```csharp
List<string> jidla = new List<string> { "Pizza", "Sushi" };
jidla.Insert(1, "Burger"); // vloží "Burger" na index 1, ostatní se posunou
// Výsledek: Pizza (0), Burger (1), Sushi (2)
```

### Obsahuje pole/List danou hodnotu? — .Contains()

```csharp
List<string> jidla = new List<string> { "Tacos", "Quesadilla", "Burrito" };
string zadane = Console.ReadLine();

if (jidla.Contains(zadane))
{
    Console.WriteLine("Jídlo je v nabídce");
}
else
{
    Console.WriteLine("Toto jídlo nenabízíme");
}
```

---

## Procházení pomocí foreach

```csharp
string[] mesta = { "Praha", "Brno", "Ostrava" };

foreach (string mesto in mesta) // 'mesto' postupně nabývá každé hodnoty
{
    Console.WriteLine(mesto);
}
// Vypíše: Praha, Brno, Ostrava
```

## Procházení pomocí for (s indexem)

```csharp
string[] mesta = { "Praha", "Brno", "Ostrava", "Plzeň" };

for (int i = 0; i < mesta.Length; i++)
{
    Console.WriteLine($"Index {i}: {mesta[i]}");
}
// Index 0: Praha
// Index 1: Brno
// ...
```

---

## Porovnání: Pole vs. List

| | Pole (array) | List |
|--|-------------|------|
| Velikost | **Pevná** – nelze měnit | **Flexibilní** – Add/Remove |
| Deklarace | `int[] cisla = { 1, 2 }` | `List<int> cisla = new List<int>()` |
| Počet prvků | `.Length` | `.Count` |
| Přidání prvku | ❌ Nelze | ✅ `.Add(hodnota)` |
| Odebrání prvku | ❌ Nelze | ✅ `.Remove()` / `.RemoveAt()` |
| Kdy použít | Pevný seznam (dny v týdnu, barvy…) | Proměnný seznam (nákupní lístek, hráči…) |

---

## ⚠️ Časté chyby

```csharp
string[] mesta = { "Praha", "Brno", "Ostrava" };

Console.WriteLine(mesta[3]); // ❌ CHYBA — index 3 neexistuje! Největší je 2.
Console.WriteLine(mesta[0]); // ✅ OK — vždy začínáme od 0
```
