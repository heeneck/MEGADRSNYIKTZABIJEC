// ============================================================
// PROJEKT: Převodník teplot
// POPIS:   Převádí teploty mezi Celsia, Fahrenheit a Kelvin.
//          Uživatel zadá teplotu a jednotku, dostane ostatní dvě.
// TÉMATA:  vstup, Convert.ToDouble, matematika, podmínky
// OBTÍŽNOST: ⭐ Lehká
// ============================================================

Console.Title = "Převodník teplot";
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║     PŘEVODNÍK TEPLOT         ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.WriteLine("Zadej teplotu a jednotku: C (Celsius), F (Fahrenheit), K (Kelvin)");
Console.WriteLine();

// Načtení teploty
Console.Write("Teplota: ");
double teplota = Convert.ToDouble(Console.ReadLine());

// Načtení jednotky a převod na velká písmena (aby fungovalo "c" i "C")
Console.Write("Jednotka (C / F / K): ");
string jednotka = Console.ReadLine().ToUpper();

Console.WriteLine();

// Výpočet a výpis podle zadané jednotky
if (jednotka == "C")
{
    // Ze Celsius počítáme Fahrenheit a Kelvin
    double fahrenheit = (teplota * 9.0 / 5.0) + 32;
    double kelvin = teplota + 273.15;

    Console.WriteLine($"{teplota}°C =");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"  {fahrenheit:F2} °F (Fahrenheit)");
    Console.WriteLine($"  {kelvin:F2} K  (Kelvin)");
    Console.ResetColor();
}
else if (jednotka == "F")
{
    // Z Fahrenheit počítáme Celsius a Kelvin
    double celsius = (teplota - 32) * 5.0 / 9.0;
    double kelvin = celsius + 273.15;

    Console.WriteLine($"{teplota}°F =");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"  {celsius:F2} °C (Celsius)");
    Console.WriteLine($"  {kelvin:F2} K  (Kelvin)");
    Console.ResetColor();
}
else if (jednotka == "K")
{
    // Z Kelvinu počítáme Celsius a Fahrenheit
    double celsius = teplota - 273.15;
    double fahrenheit = (celsius * 9.0 / 5.0) + 32;

    Console.WriteLine($"{teplota} K =");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"  {celsius:F2} °C (Celsius)");
    Console.WriteLine($"  {fahrenheit:F2} °F (Fahrenheit)");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Neznámá jednotka '{jednotka}'. Zadej C, F, nebo K.");
    Console.ResetColor();
}
