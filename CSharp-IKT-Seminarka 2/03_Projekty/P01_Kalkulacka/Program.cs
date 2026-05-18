// ============================================================
// PROJEKT: Kalkulačka
// POPIS:   Jednoduchá kalkulačka pro dvě čísla.
//          Uživatel zadá dvě čísla a operaci (+, -, *, /).
// TÉMATA:  vstup, Convert, podmínky, matematika
// OBTÍŽNOST: ⭐ Lehká
// ============================================================

Console.Title = "Kalkulačka";
Console.WriteLine("╔══════════════════════════╗");
Console.WriteLine("║      KALKULAČKA          ║");
Console.WriteLine("╚══════════════════════════╝");
Console.WriteLine();

// Načtení prvního čísla
Console.Write("Zadej první číslo: ");
double cislo1 = Convert.ToDouble(Console.ReadLine());

// Výběr operace
Console.WriteLine("Vyber operaci: + - * /");
Console.Write("Operace: ");
string operace = Console.ReadLine();

// Načtení druhého čísla
Console.Write("Zadej druhé číslo: ");
double cislo2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

// Výpočet podle zvolené operace
if (operace == "+")
{
    double vysledek = cislo1 + cislo2;
    Console.WriteLine($"{cislo1} + {cislo2} = {vysledek}");
}
else if (operace == "-")
{
    double vysledek = cislo1 - cislo2;
    Console.WriteLine($"{cislo1} - {cislo2} = {vysledek}");
}
else if (operace == "*")
{
    double vysledek = cislo1 * cislo2;
    Console.WriteLine($"{cislo1} * {cislo2} = {vysledek}");
}
else if (operace == "/")
{
    // Dělení nulou je matematicky nedefinované — musíme to ošetřit
    if (cislo2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Chyba: Nelze dělit nulou!");
        Console.ResetColor();
    }
    else
    {
        double vysledek = cislo1 / cislo2;
        Console.WriteLine($"{cislo1} / {cislo2} = {vysledek}");
    }
}
else
{
    // Uživatel zadal neplatnou operaci
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Neznámá operace: '{operace}'");
    Console.ResetColor();
}
