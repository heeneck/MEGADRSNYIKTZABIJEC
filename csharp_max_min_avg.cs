using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ── 1. Základní pole ──────────────────────────────────────────────
        int[] cisla = { 3, 7, 2, 15, 9, 1, 42, 6 };

        int max     = cisla.Max();
        int min     = cisla.Min();
        double prům = cisla.Average();

        Console.WriteLine("=== Pole int[] ===");
        Console.WriteLine($"Čísla:   {string.Join(", ", cisla)}");
        Console.WriteLine($"Maximum: {max}");       // 42
        Console.WriteLine($"Minimum: {min}");       // 1
        Console.WriteLine($"Průměr:  {prům:F2}");   // 10,63


        // ── 2. List<double> ───────────────────────────────────────────────
        List<double> teploty = new() { 18.5, 22.0, 15.3, 30.1, 27.8 };

        Console.WriteLine("\n=== List<double> ===");
        Console.WriteLine($"Max teplota: {teploty.Max()} °C");
        Console.WriteLine($"Min teplota: {teploty.Min()} °C");
        Console.WriteLine($"Průměr:      {teploty.Average():F1} °C");


        // ── 3. Vlastní objekt – LINQ na vlastnost ─────────────────────────
        var studenti = new List<Student>
        {
            new("Alice", 92),
            new("Bob",   78),
            new("Carol", 85),
            new("Dan",   61),
        };

        int nejlepší  = studenti.Max(s => s.Body);
        int nejhorší  = studenti.Min(s => s.Body);
        double avg    = studenti.Average(s => s.Body);

        // Kdo má max/min skóre
        Student nejlepšíStudent = studenti.MaxBy(s => s.Body)!;
        Student nejhoršíStudent = studenti.MinBy(s => s.Body)!;

        Console.WriteLine("\n=== Studenti ===");
        Console.WriteLine($"Nejvyšší body: {nejlepší}  → {nejlepšíStudent.Jméno}");
        Console.WriteLine($"Nejnižší body: {nejhorší}  → {nejhoršíStudent.Jméno}");
        Console.WriteLine($"Průměr třídy:  {avg:F1}");


        // ── 4. Bez LINQ – ruční smyčka (pro pochopení principu) ───────────
        int[] hodnoty = { 5, 3, 8, 1, 9, 2 };
        int ručníMax = hodnoty[0];
        int ručníMin = hodnoty[0];
        long součet  = 0;

        foreach (int h in hodnoty)
        {
            if (h > ručníMax) ručníMax = h;
            if (h < ručníMin) ručníMin = h;
            součet += h;
        }

        double ručníPrůměr = (double)součet / hodnoty.Length;

        Console.WriteLine("\n=== Ruční smyčka (bez LINQ) ===");
        Console.WriteLine($"Max: {ručníMax}");
        Console.WriteLine($"Min: {ručníMin}");
        Console.WriteLine($"Průměr: {ručníPrůměr:F2}");


        // ── 5. Prázdná kolekce – obrana před výjimkou ─────────────────────
        int[] prázdné = Array.Empty<int>();

        int? bezpečnýMax = prázdné.Any() ? prázdné.Max() : null;
        Console.WriteLine($"\nMax prázdného pole: {bezpečnýMax?.ToString() ?? "žádná hodnota"}");
    }
}

// ── Pomocný záznam ────────────────────────────────────────────────────────────
record Student(string Jméno, int Body);


// ══════════════════════════════════════════════════════════════════════════════
//  RYCHLÝ PŘEHLED
// ══════════════════════════════════════════════════════════════════════════════
//
//  Metoda             Kde žije       Co vrátí
//  ─────────────────────────────────────────────────────────────────
//  .Max()             System.Linq    největší prvek
//  .Min()             System.Linq    nejmenší prvek
//  .Average()         System.Linq    double průměr
//  .Max(x => x.Prop)  System.Linq    max hodnota vlastnosti
//  .MaxBy(x => ...)   System.Linq    celý objekt s max hodnotou  (.NET 6+)
//  .MinBy(x => ...)   System.Linq    celý objekt s min hodnotou  (.NET 6+)
//
//  Pozor:
//  • .Max() / .Min() na prázdné kolekci hodí InvalidOperationException
//  • .Average() vrátí vždy double, i pro int kolekci
//  • Pro velká čísla v průměru hrozí přetečení – přetypuj na long/double dřív
// ══════════════════════════════════════════════════════════════════════════════
