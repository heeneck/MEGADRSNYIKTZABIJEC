// ============================================================
// PROJEKT: Oběšenec (Hangman)
// POPIS:   Klasická slovní hra. Program vybere tajné slovo,
//          hráč hádá písmeno po písmenu. Má 6 pokusů.
// TÉMATA:  pole, string, while, for, Contains
// OBTÍŽNOST: ⭐⭐⭐ Těžší
// ============================================================

Console.Title = "Oběšenec";

// Pole tajných slov, ze kterých se náhodně vybere
string[] slova = {
    "programovani", "klavesnice", "promenna", "podminka",
    "pocitac", "konzole", "databaze", "algoritmus",
    "smycka", "promenná"
};

// Náhodný výběr slova
int indexSlova = Random.Shared.Next(0, slova.Length);
string tajneSlovo = slova[indexSlova];

// Pole pro aktuálně uhodnuté znaky (zpočátku samá podtržítka)
char[] uhodnuteZnaky = new char[tajneSlovo.Length];
for (int i = 0; i < tajneSlovo.Length; i++)
{
    uhodnuteZnaky[i] = '_'; // každé písmeno zatím neznáme
}

int zbyvaPokysu = 6;           // maximum pokusů
List<string> hadanaPismena = new List<string>(); // co už hráč házel
bool vyhral = false;

Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║         OBĚŠENEC             ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.WriteLine($"Slovo má {tajneSlovo.Length} písmen. Máš {zbyvaPokysu} pokusů.\n");

// Hlavní herní smyčka
while (zbyvaPokysu > 0 && !vyhral)
{
    // Výpis aktuálního stavu slova (uhodnuté znaky + podtržítka)
    Console.Write("Slovo: ");
    for (int i = 0; i < uhodnuteZnaky.Length; i++)
    {
        Console.Write(uhodnuteZnaky[i] + " ");
    }
    Console.WriteLine();

    // Výpis zbývajících pokusů a použitých písmen
    Console.WriteLine($"Pokusy: {zbyvaPokysu}");
    Console.WriteLine($"Použitá písmena: {string.Join(", ", hadanaPismena)}");
    Console.WriteLine();

    // Hádání písmene
    Console.Write("Hádat písmeno: ");
    string vstup = Console.ReadLine().ToLower().Trim();

    // Ověření, že uživatel zadal právě jedno písmeno
    if (vstup.Length != 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Zadej prosím právě jedno písmeno!");
        Console.ResetColor();
        continue; // přeskočíme zbytek kola
    }

    // Zkontrolujeme, zda písmeno již nebylo hádáno
    if (hadanaPismena.Contains(vstup))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Písmeno '{vstup}' jsi už hádat.");
        Console.ResetColor();
        continue;
    }

    hadanaPismena.Add(vstup); // přidáme do použitých

    // Zkontrolujeme, zda tajné slovo obsahuje hádané písmeno
    if (tajneSlovo.Contains(vstup))
    {
        // Správný tip — odhalíme všechna výskyty písmene ve slově
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"✓ Výborně! Písmeno '{vstup}' je ve slově!");
        Console.ResetColor();

        for (int i = 0; i < tajneSlovo.Length; i++)
        {
            if (tajneSlovo[i].ToString() == vstup)
            {
                uhodnuteZnaky[i] = tajneSlovo[i]; // odkryjeme písmeno
            }
        }
    }
    else
    {
        // Špatný tip
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"✗ Písmeno '{vstup}' není ve slově.");
        Console.ResetColor();
        zbyvaPokysu--;
    }

    // Zkontrolujeme, zda hráč uhodl celé slovo (žádné _ nezůstalo)
    string aktualni = new string(uhodnuteZnaky);
    if (!aktualni.Contains('_'))
    {
        vyhral = true;
    }

    Console.WriteLine();
}

// Výsledek hry
Console.WriteLine("══════════════════════════");
if (vyhral)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"🎉 Vyhrál/a jsi! Slovo bylo: {tajneSlovo}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"💀 Prohrál/a jsi. Slovo bylo: {tajneSlovo}");
}
Console.ResetColor();
