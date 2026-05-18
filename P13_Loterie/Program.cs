// ============================================================
// PROJEKT: Loterie
// POPIS:   Hra loterie — hráč si vybere 6 čísel (1–49),
//          program vylosuje 6 čísel a porovná shody.
//          Výhra závisí na počtu shodných čísel.
// TÉMATA:  pole, for, foreach, Contains, Random, podmínky
// OBTÍŽNOST: ⭐⭐ Střední
// ============================================================

Console.Title = "Loterie";
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║         LOTERIE 6/49         ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.WriteLine("Vyber 6 různých čísel od 1 do 49.");
Console.WriteLine();

// Pole pro čísla hráče — přesně 6 čísel
int[] cislaHrace = new int[6];

// Načtení 6 čísel od hráče
for (int i = 0; i < 6; i++)
{
    bool platne = false;

    // Opakujeme, dokud hráč nezadá platné (nové) číslo
    while (!platne)
    {
        Console.Write($"Číslo {i + 1}: ");
        int zadane = Convert.ToInt32(Console.ReadLine());

        // Zkontrolujeme rozsah 1–49
        if (zadane < 1 || zadane > 49)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Číslo musí být od 1 do 49!");
            Console.ResetColor();
            continue; // zpátky na začátek while
        }

        // Zkontrolujeme, zda číslo nebylo zadáno dvakrát
        bool duplicita = false;
        for (int j = 0; j < i; j++)
        {
            if (cislaHrace[j] == zadane)
            {
                duplicita = true;
                break;
            }
        }

        if (duplicita)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Toto číslo jsi již zadal/a. Zadej jiné.");
            Console.ResetColor();
        }
        else
        {
            cislaHrace[i] = zadane; // uložíme číslo
            platne = true;          // číslo je v pořádku → ukončíme while
        }
    }
}

// === LOSOVÁNÍ ===
Console.WriteLine();
Console.WriteLine("🎰 Losuju...");
Thread.Sleep(1500);

// Vygenerujeme 6 unikátních losovaných čísel
int[] losovana = new int[6];
int pocetVylosovanych = 0;

while (pocetVylosovanych < 6)
{
    int nahodne = Random.Shared.Next(1, 50); // 1–49

    // Zkontrolujeme, zda číslo ještě nebylo vylosováno
    bool jizVylosovano = false;
    for (int i = 0; i < pocetVylosovanych; i++)
    {
        if (losovana[i] == nahodne)
        {
            jizVylosovano = true;
            break;
        }
    }

    if (!jizVylosovano)
    {
        losovana[pocetVylosovanych] = nahodne;
        pocetVylosovanych++;
    }
}

// === VÝPIS VÝSLEDKŮ ===
Console.WriteLine();
Console.Write("Tvoje čísla:    ");
Console.ForegroundColor = ConsoleColor.Cyan;
foreach (int c in cislaHrace) Console.Write($"{c,3}");
Console.ResetColor();
Console.WriteLine();

Console.Write("Losovaná čísla: ");
Console.ForegroundColor = ConsoleColor.Yellow;
foreach (int c in losovana) Console.Write($"{c,3}");
Console.ResetColor();
Console.WriteLine();

// === POČÍTÁNÍ SHOD ===
int shody = 0;

Console.WriteLine();
Console.Write("Shody: ");
Console.ForegroundColor = ConsoleColor.Green;

foreach (int hraceCislo in cislaHrace)
{
    // Zkontrolujeme, zda hráčovo číslo je v losovaných
    foreach (int losovaneCislo in losovana)
    {
        if (hraceCislo == losovaneCislo)
        {
            Console.Write($"{hraceCislo,3}✓"); // označíme shodu
            shody++;
            break;
        }
    }
}

Console.ResetColor();
Console.WriteLine($"\nCelkem shod: {shody}/6");

// === VÝHRA ===
Console.WriteLine();
if (shody == 6)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("🏆 JACKPOT! Uhodl/a jsi všech 6 čísel! Neuvěřitelné!");
}
else if (shody == 5)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("🎉 5 shod — výhra 2. kategorie! Skvělé!");
}
else if (shody == 4)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("😊 4 shody — výhra 3. kategorie!");
}
else if (shody == 3)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("😐 3 shody — malá výhra. Aspoň něco!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("😢 Méně než 3 shody — tentokrát nevyhráváš. Zkus to znovu!");
}
Console.ResetColor();
