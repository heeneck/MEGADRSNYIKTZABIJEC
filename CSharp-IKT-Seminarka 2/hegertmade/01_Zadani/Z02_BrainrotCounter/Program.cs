// ============================================================
// PROJEKT: Brainrot counter
// Uživatel zadává věty, dokud nenapíše "STOP".
// Věty s brainrot slovíčky se ukládají do Listu.
// TÉMATA: List<string>, while, string.Contains, foreach
// ============================================================

string[] brainrotSlova = {
    "skibidi", "rizz", "sigma", "gyatt", "fanum",
    "mewing", "ohio", "aura", "delulu", "slay",
    "no cap", "fr fr", "bussin", "based", "W"
};

List<string> brainrotVety = new List<string>();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=== Brainrot Counter ===");
Console.ResetColor();
Console.WriteLine("Zadávej věty. Napiš STOP pro ukončení.");
Console.WriteLine();

// Hlavní cyklus — načítání vět
while (true)
{
    Console.Write("Věta: ");
    string veta = Console.ReadLine();

    if (veta.ToUpper() == "STOP")
        break;

    // Zkontroluj, jestli věta obsahuje brainrot slovíčko
    bool jeBrainrot = false;
    foreach (string slovo in brainrotSlova)
    {
        if (veta.ToLower().Contains(slovo.ToLower()))
        {
            jeBrainrot = true;
            break;
        }
    }

    if (jeBrainrot)
    {
        brainrotVety.Add(veta);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("  ⚠ Brainrot detekován!");
        Console.ResetColor();
    }
}

// Výpis výsledků
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=== Výsledky ===");
Console.ResetColor();

if (brainrotVety.Count == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Žádný brainrot detekován. Čistý výsledek!");
    Console.ResetColor();
}
else
{
    Console.WriteLine("Brainrot věty:");
    foreach (string v in brainrotVety)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"  - {v}");
        Console.ResetColor();
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Brainrot detekován v {brainrotVety.Count} větách.");
    Console.ResetColor();
}
