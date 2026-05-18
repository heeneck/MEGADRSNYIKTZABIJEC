// ============================================================
// PROJEKT: Virtuální mazlíček (Tamagotchi)
// POPIS:   Hráč pečuje o virtuálního mazlíčka — krmí ho,
//          hraje si s ním a nechává ho spát. Každá akce
//          mění stav mazlíčka. Hra skončí, pokud mazlíček
//          zemře hlady nebo nudou.
// TÉMATA:  proměnné, while, podmínky, Random, barvy
// OBTÍŽNOST: ⭐⭐⭐ Těžší
// ============================================================

Console.Title = "Virtuální mazlíček";

// === NASTAVENÍ MAZLÍČKA ===
Console.Write("Jak se bude jmenovat tvůj mazlíček? ");
string jmeno = Console.ReadLine();

// Stavové proměnné (0 = špatné, 100 = perfektní)
int hlad = 70;     // čím vyšší, tím více nasycený
int stesti = 70;   // čím vyšší, tím šťastnější
int energie = 70;  // čím vyšší, tím více odpočinutý

int kolo = 0;      // číslo herního kola

Console.Clear();

// === HLAVNÍ HERNÍ SMYČKA ===
// Hra běží, dokud mazlíček "žije" (hlad a stesti > 0)
while (hlad > 0 && stesti > 0)
{
    kolo++;

    // Výpis stavu mazlíčka
    Console.Clear();
    Console.WriteLine($"╔══════════════════════════════════╗");
    Console.WriteLine($"║  Mazlíček: {jmeno,-22}║");
    Console.WriteLine($"║  Kolo: {kolo,-26}║");
    Console.WriteLine($"╚══════════════════════════════════╝");
    Console.WriteLine();

    // Vykreslení ukazatelů barevně
    VypisUkazatel("Hlad (sytost)", hlad);
    VypisUkazatel("Štěstí       ", stesti);
    VypisUkazatel("Energie      ", energie);

    Console.WriteLine();

    // Varování při nízkých hodnotách
    if (hlad < 25)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"⚠ {jmeno} má hlad! Rychle ho nakrm!");
        Console.ResetColor();
    }
    if (stesti < 25)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"⚠ {jmeno} je smutný! Zahraj si s ním!");
        Console.ResetColor();
    }

    Console.WriteLine();
    Console.WriteLine("Co chceš dělat?");
    Console.WriteLine("1. Nakrmit");
    Console.WriteLine("2. Hrát si");
    Console.WriteLine("3. Spát (obnovit energii)");
    Console.WriteLine("4. Ukončit hru");
    Console.Write("Volba: ");
    string volba = Console.ReadLine();

    if (volba == "1")
    {
        // === KRMENÍ ===
        int nasite = Random.Shared.Next(15, 30);
        hlad += nasite;
        if (hlad > 100) hlad = 100; // maximum je 100
        stesti -= 5;                // jídlo mírně sníží štěstí (banalita)
        energie -= 5;

        Console.WriteLine($"{jmeno} se najedl! Sytost +{nasite}");
    }
    else if (volba == "2")
    {
        // === HRA ===
        int radost = Random.Shared.Next(10, 25);
        stesti += radost;
        if (stesti > 100) stesti = 100;
        hlad -= 15;    // hraní unaví a zvýší hlad
        energie -= 20;

        Console.WriteLine($"Super hra! Štěstí +{radost}");
    }
    else if (volba == "3")
    {
        // === SPÁNEK ===
        int odpocinek = Random.Shared.Next(20, 40);
        energie += odpocinek;
        if (energie > 100) energie = 100;
        hlad -= 10;    // i spánek mírně sníží sytost
        stesti -= 5;

        Console.WriteLine($"{jmeno} spal a odpočinul si! Energie +{odpocinek}");
    }
    else if (volba == "4")
    {
        break; // přerušíme while cyklus
    }

    // Po každém kole se hodnoty přirozeně snižují
    hlad -= Random.Shared.Next(5, 12);
    stesti -= Random.Shared.Next(3, 8);
    energie -= Random.Shared.Next(2, 6);

    // Minimální hodnota je 0
    if (hlad < 0) hlad = 0;
    if (stesti < 0) stesti = 0;
    if (energie < 0) energie = 0;

    Thread.Sleep(500);
}

// === KONEC HRY ===
Console.Clear();
if (hlad <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{jmeno} zemřel hlady... 😢");
}
else if (stesti <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{jmeno} zemřel smutkem... 😢");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Hra ukončena. Přežil jsi {kolo} kol!");
}
Console.ResetColor();

// === POMOCNÁ METODA PRO VYKRESLENÍ UKAZATELE ===
void VypisUkazatel(string nazev, int hodnota)
{
    Console.Write($"{nazev}: [{hodnota,3}/100] ");
    if (hodnota >= 60) Console.ForegroundColor = ConsoleColor.Green;
    else if (hodnota >= 30) Console.ForegroundColor = ConsoleColor.Yellow;
    else Console.ForegroundColor = ConsoleColor.Red;

    // Vykreslíme pruh (10 bloků celkem)
    int bloky = hodnota / 10;
    Console.Write("[" + new string('█', bloky) + new string('░', 10 - bloky) + "]");
    Console.ResetColor();
    Console.WriteLine();
}
