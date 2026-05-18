// ============================================================
// PROJEKT: Generátor násobilky
// POPIS:   Uživatel zadá číslo a program vypíše celou násobilku
//          (1× až 10×) přehledně do tabulky. Pak se nabídne
//          procvičovací režim — náhodné příklady s odpověďmi.
// TÉMATA:  for cyklus, vstup, Convert, podmínky, Random
// OBTÍŽNOST: ⭐ Lehká
// ============================================================

Console.Title = "Násobilka";
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║         NÁSOBILKA            ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.WriteLine();

// --- ČÁST 1: Výpis násobilky ---
Console.Write("Zadej číslo (1–20), jehož násobilku chceš vypsat: ");
int cislo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"  Násobilka čísla {cislo}:");
Console.WriteLine("  ─────────────────────");
Console.ResetColor();

// For cyklus projde hodnoty 1 až 10
for (int i = 1; i <= 10; i++)
{
    int vysledek = cislo * i;

    // Zarovnání pro hezký výpis — {i,2} zarovná číslo na 2 znaky zprava
    Console.WriteLine($"  {cislo} × {i,2} = {vysledek,3}");
}

// --- ČÁST 2: Procvičovací režim ---
Console.WriteLine();
Console.WriteLine("Chceš si násobilku procvičit? (ano/ne)");
string odpoved = Console.ReadLine().ToLower().Trim();

if (odpoved == "ano")
{
    int spravne = 0;   // počítadlo správných odpovědí
    int celkem = 5;    // celkový počet příkladů

    Console.WriteLine($"\nOdpověz správně na {celkem} příkladů:");
    Console.WriteLine();

    for (int i = 0; i < celkem; i++)
    {
        // Vygenerujeme náhodný příklad z rozsahu 1–10
        int a = Random.Shared.Next(1, 11);
        int b = Random.Shared.Next(1, 11);
        int spravnaOdpoved = a * b;

        Console.Write($"  {a} × {b} = ? ");
        int tipUzivatele = Convert.ToInt32(Console.ReadLine());

        if (tipUzivatele == spravnaOdpoved)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ✓ Správně!");
            Console.ResetColor();
            spravne++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  ✗ Špatně. Správná odpověď: {spravnaOdpoved}");
            Console.ResetColor();
        }
    }

    // Výsledek procvičování
    Console.WriteLine();
    Console.WriteLine($"Výsledek: {spravne}/{celkem} správně.");

    if (spravne == celkem)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Perfektní! Násobilku ovládáš na výbornou!");
    }
    else if (spravne >= 3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dobrá práce! Ještě trošku procvičit a budeš mít.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Je potřeba více procvičovat. Nevzdávej to!");
    }
    Console.ResetColor();
}
else
{
    Console.WriteLine("Dobře, nashledanou!");
}
