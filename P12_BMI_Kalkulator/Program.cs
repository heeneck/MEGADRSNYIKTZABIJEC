// ============================================================
// PROJEKT: BMI Kalkulátor
// POPIS:   Uživatel zadá výšku (cm) a váhu (kg).
//          Program vypočítá BMI a zařadí ho do kategorie.
//          Vzorec: BMI = váha / (výška v metrech)²
// TÉMATA:  double, Convert.ToDouble, matematika, podmínky
// OBTÍŽNOST: ⭐ Lehká
// ============================================================

Console.Title = "BMI Kalkulátor";
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║       BMI KALKULÁTOR         ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.WriteLine("Body Mass Index — měření tělesné hmotnosti vůči výšce.");
Console.WriteLine();

// Načtení výšky v centimetrech
Console.Write("Zadej svou výšku v cm (např. 175): ");
double vyskaCm = Convert.ToDouble(Console.ReadLine());

// Načtení váhy v kilogramech
Console.Write("Zadej svou váhu v kg (např. 70): ");
double vahyKg = Convert.ToDouble(Console.ReadLine());

// Výpočet BMI
// Výška musí být v metrech → vydělíme 100
double vyskaMeiry = vyskaCm / 100.0;

// Vzorec: BMI = váha / výška²
double bmi = vahyKg / (vyskaMeiry * vyskaMeiry);

Console.WriteLine();
Console.WriteLine("══════════════════════════════");

// Výpis výsledku — F1 = 1 desetinné místo
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Tvoje BMI: {bmi:F1}");
Console.ResetColor();

Console.WriteLine();

// Zařazení do kategorie podle WHO stupnice
if (bmi < 18.5)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Kategorie: Podváha");
    Console.WriteLine("Tip: Je vhodné navštívit lékaře nebo nutričního specialistu.");
}
else if (bmi < 25.0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Kategorie: Normální váha ✓");
    Console.WriteLine("Výborně! Tvoje váha je v ideálním rozmezí.");
}
else if (bmi < 30.0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Kategorie: Nadváha");
    Console.WriteLine("Tip: Mírné změny v jídelníčku a pohyb mohou pomoci.");
}
else if (bmi < 35.0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Kategorie: Obezita 1. stupně");
    Console.WriteLine("Tip: Doporučujeme konzultaci s lékařem.");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Kategorie: Obezita 2. stupně nebo vyšší");
    Console.WriteLine("Tip: Navštiv lékaře pro odbornou pomoc.");
}

Console.ResetColor();
Console.WriteLine("══════════════════════════════");
Console.WriteLine();

// Přehledná stupnice BMI
Console.WriteLine("Stupnice BMI (WHO):");
Console.WriteLine("  < 18.5  → Podváha");
Console.WriteLine("  18.5–25 → Normální váha");
Console.WriteLine("  25–30   → Nadváha");
Console.WriteLine("  30–35   → Obezita 1. stupně");
Console.WriteLine("  > 35    → Obezita 2. stupně+");
