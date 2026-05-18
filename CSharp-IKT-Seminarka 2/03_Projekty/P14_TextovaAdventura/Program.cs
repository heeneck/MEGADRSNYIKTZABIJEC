// ============================================================
// PROJEKT: Textová adventura
// POPIS:   Krátká větvená textová hra. Hráč se rozhoduje,
//          jakou cestu zvolí, a každá volba vede k jinému
//          konci. Hra má 3 různé konce.
// TÉMATA:  vstup, podmínky, string, while, barvy
// OBTÍŽNOST: ⭐⭐ Střední
// ============================================================

Console.Title = "Textová adventura";

// Pomocná metoda pro dramatický výpis textu (znak po znaku)
void VypisPomaluNovyRadek(string text, ConsoleColor barva = ConsoleColor.White)
{
    Console.ForegroundColor = barva;
    foreach (char znak in text)
    {
        Console.Write(znak);
        Thread.Sleep(18); // krátká pauza mezi znaky
    }
    Console.WriteLine();
    Console.ResetColor();
}

// Pomocná metoda pro výpis voleb
string ZeptejSe(string[] volby)
{
    for (int i = 0; i < volby.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"  [{i + 1}] ");
        Console.ResetColor();
        Console.WriteLine(volby[i]);
    }
    Console.WriteLine();

    string odpoved = "";
    while (odpoved != "1" && odpoved != "2")
    {
        Console.Write("Tvoje volba (1 nebo 2): ");
        odpoved = Console.ReadLine().Trim();
    }
    return odpoved;
}

// ============================
// === ZAČÁTEK PŘÍBĚHU ===
// ============================

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║        ZTRACENÝ V LESE               ║");
Console.WriteLine("║      — Textová adventura —           ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();
Thread.Sleep(1000);
Console.WriteLine();

VypisPomaluNovyRadek("Probouzíš se uprostřed tmavého lesa. Nevíš, jak ses sem dostal/a.");
VypisPomaluNovyRadek("Měsíc osvětluje dvě cesty před tebou.");
Console.WriteLine();

// === PRVNÍ ROZHODNUTÍ ===
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Která cesta tě láká více?");
Console.ResetColor();
Console.WriteLine();

string volba1 = ZeptejSe(new string[] {
    "Cesta doleva — slyšíš vzdálený zvuk vody",
    "Cesta doprava — vidíš záblesk světla"
});

// ============================
// === VĚTEV A: DOLEVA (voda) ===
// ============================
if (volba1 == "1")
{
    Console.Clear();
    VypisPomaluNovyRadek("Vydáš se doleva. Po chvíli narazíš na malý potok.", ConsoleColor.Cyan);
    VypisPomaluNovyRadek("Vedle potoka sedí starý rybář a vypadá přátelsky.");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Co uděláš?");
    Console.ResetColor();
    Console.WriteLine();

    string volba2A = ZeptejSe(new string[] {
        "Oslovíš rybáře a požádáš ho o pomoc",
        "Potichu proplíženáš kolem a pokračuješ dál sám/sama"
    });

    if (volba2A == "1")
    {
        // === KONEC 1 — DOBRÝ ===
        Console.Clear();
        Thread.Sleep(500);
        VypisPomaluNovyRadek("Rybář se usměje. \"Ztratil ses? To se stává.\"", ConsoleColor.Green);
        VypisPomaluNovyRadek("Ukáže ti zkratku z lesa a pozve tě na horkou polévku.");
        VypisPomaluNovyRadek("Za hodinu jsi doma, v teple, s plným břichem.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║  KONEC 1/3 — Šťastný konec  ║");
        Console.WriteLine("║  Pomoc ostatních se vyplácí. ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.ResetColor();
    }
    else
    {
        // === KONEC 2 — NEUTRÁLNÍ ===
        Console.Clear();
        Thread.Sleep(500);
        VypisPomaluNovyRadek("Plíženáš se kolem, ale šlápneš na větev.", ConsoleColor.Yellow);
        VypisPomaluNovyRadek("Rybář se otočí, ale jen pokrčí rameny a vrátí se k rybaření.");
        VypisPomaluNovyRadek("Bloudíš celou noc, ale ráno narazíš na silnici a dostaneš se domů.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔══════════════════════════════════╗");
        Console.WriteLine("║  KONEC 2/3 — Únava, ale v pořádku║");
        Console.WriteLine("║  Někdy je lepší požádat o pomoc. ║");
        Console.WriteLine("╚══════════════════════════════════╝");
        Console.ResetColor();
    }
}

// ============================
// === VĚTEV B: DOPRAVA (světlo) ===
// ============================
else
{
    Console.Clear();
    VypisPomaluNovyRadek("Vydáš se doprava za světlem.", ConsoleColor.Yellow);
    VypisPomaluNovyRadek("Po chvíli uvidíš starou opuštěnou chatu. Oknem prosvítá svíčka.");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Chata vypadá opuštěně. Co uděláš?");
    Console.ResetColor();
    Console.WriteLine();

    string volba2B = ZeptejSe(new string[] {
        "Zaklepeš na dveře",
        "Vrátíš se zpátky na křižovatku"
    });

    if (volba2B == "1")
    {
        // === KONEC 3 — PŘEKVAPIVÝ ===
        Console.Clear();
        Thread.Sleep(500);
        VypisPomaluNovyRadek("Dveře se otevřou. Stojí tam stará žena s mapou v ruce.", ConsoleColor.Magenta);
        VypisPomaluNovyRadek("\"Čekala jsem na tebe,\" říká záhadně.");
        VypisPomaluNovyRadek("Ukáže ti cestu domů — ale přidá tajemný úsměv.");
        VypisPomaluNovyRadek("Nikdy se nedozvíš, jak věděla, že přijdeš...");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔══════════════════════════════════╗");
        Console.WriteLine("║  KONEC 3/3 — Záhadný konec      ║");
        Console.WriteLine("║  Některé věci zůstanou nevyřešeny║");
        Console.WriteLine("╚══════════════════════════════════╝");
        Console.ResetColor();
    }
    else
    {
        // Vrátí se zpět → přesměrujeme na větev A (potok)
        Console.Clear();
        VypisPomaluNovyRadek("Vrátíš se na křižovatku a zkusíš cestu doleva.", ConsoleColor.Cyan);
        VypisPomaluNovyRadek("U potoka narazíš na rybáře, který ti ukáže cestu domů.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("╔══════════════════════════════════╗");
        Console.WriteLine("║  KONEC 1/3 — Šťastný konec      ║");
        Console.WriteLine("║  Někdy je nejlepší jít jinou cestou║");
        Console.WriteLine("╚══════════════════════════════════╝");
        Console.ResetColor();
    }
}

Console.WriteLine();
Console.WriteLine("Chceš hrát znovu? (ano/ne)");
if (Console.ReadLine().ToLower().Trim() == "ano")
{
    // Restartu dosáhneme jednoduše opětovným spuštěním programu
    Console.WriteLine("Spusť program znovu pro novou hru. Nashledanou!");
}
else
{
    Console.WriteLine("Díky za hraní!");
}
