// ============================================================
// PROJEKT: Kvíz s otázkami
// POPIS:   Program provede uživatele 5 otázkami.
//          Za každou správnou odpověď dostane bod.
//          Na konci zobrazí výsledek a hodnocení.
// TÉMATA:  pole (string[]), for cyklus, podmínky, skóre
// OBTÍŽNOST: ⭐⭐ Střední
// ============================================================

Console.Title = "Kvíz";
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║         KVÍZ                 ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.WriteLine("Odpovídej na otázky. Správné odpovědi jsou malými písmeny.");
Console.WriteLine();

// Pole otázek — každá otázka má svůj index (0, 1, 2, ...)
string[] otazky = {
    "Jaká je hlavní město Francie?",
    "Kolik planet je ve sluneční soustavě?",
    "Kdo napsal Hamlet?",
    "Jaký je chemický symbol pro vodu?",
    "V jakém roce skončila druhá světová válka?"
};

// Pole správných odpovědí — musí odpovídat indexům otázek!
string[] spravneOdpovedi = {
    "paris",
    "8",
    "shakespeare",
    "h2o",
    "1945"
};

// Počítadlo správných odpovědí
int skore = 0;

// For cyklus projde všechny otázky (index 0 až 4)
for (int i = 0; i < otazky.Length; i++)
{
    // Vypíšeme číslo otázky a samotnou otázku
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Otázka {i + 1}/{otazky.Length}: {otazky[i]}");
    Console.ResetColor();

    // Načteme odpověď a převedeme na malá písmena (pro snazší porovnání)
    Console.Write("Tvoje odpověď: ");
    string odpoved = Console.ReadLine().ToLower().Trim();

    // Porovnáme s správnou odpovědí
    if (odpoved == spravneOdpovedi[i])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✓ Správně!");
        skore += 1; // přičteme bod
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"✗ Špatně. Správná odpověď: {spravneOdpovedi[i]}");
    }

    Console.ResetColor();
    Console.WriteLine();
}

// Výpis celkového výsledku
Console.WriteLine("══════════════════════════");
Console.WriteLine($"Výsledek: {skore} / {otazky.Length} bodů");

// Hodnocení podle počtu bodů
if (skore == otazky.Length)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Perfektní skóre! Jsi šampion!");
}
else if (skore >= 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Dobrá práce! Skoro jsi to dal/a.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Příště to bude lepší. Nevzdávej se!");
}

Console.ResetColor();
