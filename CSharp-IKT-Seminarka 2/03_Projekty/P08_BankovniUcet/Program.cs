// ============================================================
// PROJEKT: Bankovní účet
// POPIS:   Simulace bankovního účtu s menu.
//          Hráč může vkládat peníze, vybírat a zobrazit historii.
// TÉMATA:  double, while, podmínky, List pro historii transakcí
// OBTÍŽNOST: ⭐⭐⭐ Těžší
// ============================================================

Console.Title = "Bankovní účet";
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║       BANKOVNÍ ÚČET          ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.WriteLine();

// Počáteční zůstatek a historie transakcí
double zustatek = 1000.00;
List<string> historie = new List<string>();
historie.Add("Počáteční vklad: +1000.00 Kč");

Console.Write("Zadej své jméno: ");
string jmeno = Console.ReadLine();

Console.WriteLine($"\nVítej, {jmeno}! Tvůj počáteční zůstatek je 1000,00 Kč.");

string volba = "";

// Hlavní menu banky
while (volba != "4")
{
    Console.WriteLine();
    Console.WriteLine("══════════════════════");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Zůstatek: {zustatek:F2} Kč");
    Console.ResetColor();
    Console.WriteLine("══════════════════════");
    Console.WriteLine("1. Vložit peníze");
    Console.WriteLine("2. Vybrat peníze");
    Console.WriteLine("3. Zobrazit historii");
    Console.WriteLine("4. Odhlásit se");
    Console.Write("Volba: ");
    volba = Console.ReadLine();

    if (volba == "1")
    {
        // === VKLAD ===
        Console.Write("Kolik chceš vložit (Kč): ");
        double castka = Convert.ToDouble(Console.ReadLine());

        if (castka <= 0)
        {
            // Záporná nebo nulová částka nemá smysl
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chyba: Částka musí být kladná!");
            Console.ResetColor();
        }
        else
        {
            zustatek += castka; // přičteme k zůstatku
            string zaznam = $"Vklad: +{castka:F2} Kč (zůstatek: {zustatek:F2} Kč)";
            historie.Add(zaznam);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✓ Vloženo {castka:F2} Kč. Nový zůstatek: {zustatek:F2} Kč");
            Console.ResetColor();
        }
    }
    else if (volba == "2")
    {
        // === VÝBĚR ===
        Console.Write("Kolik chceš vybrat (Kč): ");
        double castka = Convert.ToDouble(Console.ReadLine());

        if (castka <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chyba: Částka musí být kladná!");
            Console.ResetColor();
        }
        else if (castka > zustatek)
        {
            // Nelze vybrat více, než je na účtu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Chyba: Nedostatek prostředků! Máš jen {zustatek:F2} Kč.");
            Console.ResetColor();
        }
        else
        {
            zustatek -= castka; // odečteme ze zůstatku
            string zaznam = $"Výběr: -{castka:F2} Kč (zůstatek: {zustatek:F2} Kč)";
            historie.Add(zaznam);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"✓ Vybráno {castka:F2} Kč. Nový zůstatek: {zustatek:F2} Kč");
            Console.ResetColor();
        }
    }
    else if (volba == "3")
    {
        // === VÝPIS HISTORIE ===
        Console.WriteLine("\n--- Historie transakcí ---");
        foreach (string zaznam in historie)
        {
            Console.WriteLine($"  • {zaznam}");
        }
    }
    else if (volba != "4")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Neplatná volba. Zadej číslo 1–4.");
        Console.ResetColor();
    }
}

// Závěrečný souhrn
Console.WriteLine($"\nNashledanou, {jmeno}!");
Console.WriteLine($"Tvůj závěrečný zůstatek: {zustatek:F2} Kč");
