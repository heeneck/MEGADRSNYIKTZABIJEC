// ============================================================
// PROJEKT: Teploty v týdnu
// Načte teplotu pro každý den, vypíše průměr, max a min.
// TÉMATA: double[], for, Convert.ToDouble, podmínky
// ============================================================

string[] dny = { "Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Neděle" };
double[] teploty = new double[7];

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== Teploty v týdnu ===");
Console.ResetColor();
Console.WriteLine();

// Načtení teplot pro každý den
for (int i = 0; i < 7; i++)
{
    while (true)
    {
        Console.Write($"{dny[i]}: ");
        string vstup = Console.ReadLine();
        if (double.TryParse(vstup, out double teplota))
        {
            teploty[i] = teplota;
            break;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Neplatný vstup. Zadej desetinné číslo (např. 21.5).");
        Console.ResetColor();
    }
}

// Výpočet průměru, maxima a minima
double soucet = 0;
double maximum = teploty[0];
double minimum = teploty[0];
string nejteplejiDen = dny[0];
string nejchladnejiDen = dny[0];

for (int i = 0; i < 7; i++)
{
    soucet += teploty[i];
    if (teploty[i] > maximum)
    {
        maximum = teploty[i];
        nejteplejiDen = dny[i];
    }
    if (teploty[i] < minimum)
    {
        minimum = teploty[i];
        nejchladnejiDen = dny[i];
    }
}

double prumer = soucet / 7;

// Výpis výsledků
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== Výsledky ===");
Console.ResetColor();

Console.Write("Průměrná teplota: ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"{prumer:F1} °C");
Console.ResetColor();

Console.Write($"Nejvyšší teplota: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{maximum} °C ({nejteplejiDen})");
Console.ResetColor();

Console.Write($"Nejnižší teplota:  ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"{minimum} °C ({nejchladnejiDen})");
Console.ResetColor();
