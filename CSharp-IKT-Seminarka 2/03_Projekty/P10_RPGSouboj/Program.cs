// ============================================================
// PROJEKT: RPG Souboj
// POPIS:   Tahový RPG souboj hráče proti nepříteli.
//          Hráč má na výběr: útok, silný útok, obrana, léčení.
//          Každá akce spotřebovává manu nebo má cooldown.
//          Hra skončí, když jeden z bojovníků padne.
// TÉMATA:  proměnné, while, podmínky, Random, barvy, výpis stavu
// OBTÍŽNOST: ⭐⭐⭐⭐ Nejtěžší
// ============================================================

Console.Title = "RPG Souboj";

// === NASTAVENÍ HRÁČE ===
Console.Write("Zadej jméno svého hrdiny: ");
string jmenoHrace = Console.ReadLine();

int hpHrace = 100;        // životy hráče
int manaHrace = 50;       // mana pro speciální akce
int obranaTah = 0;        // blokuje zranění na 1 tah, pokud > 0

// === NASTAVENÍ NEPŘÍTELE ===
string jmenoNepritele = "Drak Karthus";
int hpNepritele = 120;    // nepřítel má víc životů
int utokNepritele = 15;   // základní útok nepřítele

int kolo = 0;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("═══════════════════════════════════════");
Console.WriteLine($"  ⚔  SOUBOJ: {jmenoHrace}  vs  {jmenoNepritele}  ⚔");
Console.WriteLine("═══════════════════════════════════════");
Console.ResetColor();
Thread.Sleep(1500);

// === HLAVNÍ HERNÍ SMYČKA ===
while (hpHrace > 0 && hpNepritele > 0)
{
    kolo++;

    Console.Clear();

    // --- VÝPIS STAVU ---
    Console.WriteLine($"══ KO L O  {kolo} ══");
    Console.WriteLine();

    VypisHP(jmenoHrace, hpHrace, 100, ConsoleColor.Cyan);
    Console.WriteLine($"   Mana: {manaHrace}/50");
    Console.WriteLine();
    VypisHP(jmenoNepritele, hpNepritele, 120, ConsoleColor.Red);
    Console.WriteLine();

    // --- VÝBĚR AKCE HRÁČE ---
    Console.WriteLine("Vyber akci:");
    Console.WriteLine("1. Útok          (zranění 10–20, zdarma)");
    Console.WriteLine("2. Silný útok    (zranění 25–40, stojí 15 many)");
    Console.WriteLine("3. Obrana        (blokuje příští útok, stojí 10 many)");
    Console.WriteLine("4. Léčení        (obnova 20–35 HP, stojí 20 many)");
    Console.Write("Volba: ");
    string volba = Console.ReadLine();

    Console.WriteLine();

    // --- AKCE HRÁČE ---
    if (volba == "1")
    {
        // Základní útok — vždy dostupný
        int zraneni = Random.Shared.Next(10, 21);
        hpNepritele -= zraneni;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"⚔ {jmenoHrace} zaútočil za {zraneni} zranění!");
        Console.ResetColor();
    }
    else if (volba == "2")
    {
        if (manaHrace >= 15)
        {
            // Silný útok — spotřebuje manu
            int zraneni = Random.Shared.Next(25, 41);
            hpNepritele -= zraneni;
            manaHrace -= 15;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"💥 SILNÝ ÚTOK! {jmenoHrace} zasadil {zraneni} zranění! (-15 many)");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nedostatek many! Silný útok není dostupný.");
            Console.ResetColor();
        }
    }
    else if (volba == "3")
    {
        if (manaHrace >= 10)
        {
            // Obrana — aktivní na tento tah
            obranaTah = 1;
            manaHrace -= 10;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"🛡 {jmenoHrace} zaujal obranný postoj! (-10 many)");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nedostatek many! Obrana není dostupná.");
            Console.ResetColor();
        }
    }
    else if (volba == "4")
    {
        if (manaHrace >= 20)
        {
            // Léčení — obnoví HP
            int leceni = Random.Shared.Next(20, 36);
            hpHrace += leceni;
            if (hpHrace > 100) hpHrace = 100; // max 100 HP
            manaHrace -= 20;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✨ {jmenoHrace} se vyléčil za {leceni} HP! (-20 many)");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nedostatek many! Léčení není dostupné.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Neplatná volba! Ztratil jsi tah.");
        Console.ResetColor();
    }

    // Zkontrolujeme, zda nepřítel ještě žije
    if (hpNepritele <= 0) break;

    // --- ÚTOK NEPŘÍTELE ---
    Console.WriteLine();

    // Nepřítel má 25% šanci na silný útok
    int silnyUtokSance = Random.Shared.Next(1, 5);

    int utokHodnota;
    if (silnyUtokSance == 1)
    {
        utokHodnota = Random.Shared.Next(25, 40); // silný útok
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"🔥 {jmenoNepritele} použil OHNIVÝ DECH za {utokHodnota} zranění!");
    }
    else
    {
        utokHodnota = Random.Shared.Next(10, utokNepritele + 1); // normální útok
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"👊 {jmenoNepritele} zaútočil za {utokHodnota} zranění!");
    }

    // Zkontrolujeme obranu hráče
    if (obranaTah > 0)
    {
        Console.WriteLine(" → ZABLOKOVÁNO štítem!");
        obranaTah = 0; // obrana se spotřebuje
    }
    else
    {
        hpHrace -= utokHodnota;
        Console.WriteLine();
    }
    Console.ResetColor();

    // Každé 3 kola nepřítel zesílí
    if (kolo % 3 == 0)
    {
        utokNepritele += 2;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"⬆ {jmenoNepritele} zesílil! (+2 útok)");
        Console.ResetColor();
    }

    // Mana se pomalu obnovuje (5 za kolo)
    manaHrace += 5;
    if (manaHrace > 50) manaHrace = 50;

    Thread.Sleep(400);
}

// === VÝSLEDEK SOUBOJE ===
Console.Clear();
Console.WriteLine("═══════════════════════════════════════");
if (hpHrace <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"💀 {jmenoHrace} byl poražen v kole {kolo}!");
    Console.WriteLine($"   {jmenoNepritele} zvítězil...");
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"🏆 {jmenoHrace} zvítězil nad {jmenoNepritele}!");
    Console.WriteLine($"   Souboj trval {kolo} kol. Zbývající HP: {hpHrace}");
}
Console.ResetColor();
Console.WriteLine("═══════════════════════════════════════");

// === POMOCNÁ METODA PRO VÝPIS HP ===
void VypisHP(string jmeno, int hp, int maxHp, ConsoleColor barva)
{
    Console.ForegroundColor = barva;
    Console.Write($"{jmeno,20}: [{hp,3}/{maxHp}] ");

    // Pruhový ukazatel HP
    int bloky = (hp * 10) / maxHp;
    if (bloky < 0) bloky = 0;
    Console.Write("[" + new string('█', bloky) + new string('░', 10 - bloky) + "]");
    Console.ResetColor();
    Console.WriteLine();
}
