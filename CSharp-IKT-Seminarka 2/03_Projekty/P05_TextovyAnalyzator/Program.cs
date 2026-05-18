// ============================================================
// PROJEKT: Textový analyzátor
// POPIS:   Uživatel napíše větu a program o ní řekne:
//          - počet znaků, počet slov
//          - zda obsahuje konkrétní slova
//          - upravenou verzi textu (bez mezer na okrajích, velká písmena)
// TÉMATA:  string metody (Length, Contains, Replace, ToUpper, Trim, Split)
// OBTÍŽNOST: ⭐⭐ Střední
// ============================================================

Console.Title = "Textový analyzátor";
Console.WriteLine("╔══════════════════════════════════╗");
Console.WriteLine("║       TEXTOVÝ ANALYZÁTOR         ║");
Console.WriteLine("╚══════════════════════════════════╝");
Console.WriteLine();

// Načtení textu od uživatele
Console.WriteLine("Napiš libovolnou větu:");
Console.Write("> ");
string text = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("══════ ANALÝZA TEXTU ══════");

// 1. Délka textu
Console.WriteLine($"Počet znaků (včetně mezer): {text.Length}");

// 2. Počet slov — rozdělíme text mezerami a spočítáme části
// Split(' ') rozdělí string na pole stringů podle oddělovače
string[] slova = text.Split(' ');
Console.WriteLine($"Přibližný počet slov:       {slova.Length}");

// 3. Verze bez mezer na okrajích
string oriznuty = text.Trim();
Console.WriteLine($"Text bez okrajových mezer:  \"{oriznuty}\"");

// 4. Velká a malá písmena
Console.WriteLine($"Velká písmena:   {text.ToUpper()}");
Console.WriteLine($"Malá písmena:    {text.ToLower()}");

Console.WriteLine();
Console.WriteLine("══════ HLEDÁNÍ SLOV ══════");

// 5. Zda text obsahuje konkrétní slova
string[] hledanaSlova = { "ahoj", "hello", "čau", "dobrý", "hey" };
bool nalezen = false;

foreach (string slovo in hledanaSlova)
{
    if (text.ToLower().Contains(slovo))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"✓ Text obsahuje pozdrav: \"{slovo}\"");
        Console.ResetColor();
        nalezen = true;
    }
}

if (!nalezen) // ! znamená "NE" — nalezen == false
{
    Console.WriteLine("Text neobsahuje žádný ze sledovaných pozdravů.");
}

// 6. Začíná nebo končí určitým způsobem?
Console.WriteLine();
if (text.EndsWith("?"))
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Věta je otázka (končí '?').");
    Console.ResetColor();
}
else if (text.EndsWith("!"))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Věta je zvolání (končí '!').");
    Console.ResetColor();
}
else
{
    Console.WriteLine("Věta je oznamovací.");
}
