// ============================================================
// PROGRAM: Generátor hesel
// POPIS:   Program vygeneruje náhodné 8znakové heslo
//          ze sady písmen a číslic.
// TÉMATA:  pole (array), while cyklus, Random, .Length
// ============================================================

// Pole dostupných znaků — 10 písmen + 10 číslic
string[] pismenaCislice = {
    "a", "b", "c", "d", "e",
    "f", "g", "h", "i", "j",
    "0", "1", "2", "3", "4",
    "5", "6", "7", "8", "9"
};

// Sem budeme skládat výsledné heslo — začínáme prázdným stringem
string heslo = "";

// Počítadlo průchodů cyklu
int krok = 0;

Console.WriteLine("=== Generátor hesel ===");
Console.WriteLine("Generuji 8znakové heslo...");

// Cyklus proběhne přesně 8× (krok = 0, 1, 2, ..., 7)
while (krok < 8)
{
    // Vygenerujeme náhodný index od 0 do délky pole - 1 (0 až 19)
    // pismenaCislice.Length vrací 20, ale Next(0, 20) dá 0–19 ✓
    int nahodnyIndex = Random.Shared.Next(0, pismenaCislice.Length);

    // Přidáme znak na daném indexu na konec hesla
    heslo = heslo + pismenaCislice[nahodnyIndex];

    krok += 1; // posuneme počítadlo
}

// Výpis výsledného hesla
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Vygenerované heslo: {heslo}");
Console.ResetColor();
