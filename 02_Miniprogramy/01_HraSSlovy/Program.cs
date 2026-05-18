// ============================================================
// PROGRAM: Hra se slovy a náhodnými čísly
// POPIS:   Uživatel zadá "small" nebo "big" a program vygeneruje
//          číslo v daném rozsahu.
// TÉMATA:  vstup od uživatele, podmínky if/else, Random
// ============================================================

Console.WriteLine("=== Hra se slovy a čísly ===");
Console.WriteLine("Napiš 'small' nebo 'big':");

// Načteme vstup od uživatele
string volba = Console.ReadLine();

// Porovnáme, co uživatel zadal, a reagujeme
if (volba == "small")
{
    // Vygenerujeme malé číslo (10 až 29)
    int nahodneCislo = Random.Shared.Next(10, 30);
    Console.WriteLine($"Zadal jsi 'small', tady je malé číslo: {nahodneCislo}");
}
else if (volba == "big")
{
    // Vygenerujeme obrovské číslo (100 000 až 899 999)
    int nahodneCislo = Random.Shared.Next(100000, 900000);
    Console.WriteLine($"Zadal jsi 'big', tady je obrovské číslo: {nahodneCislo}");
}
else
{
    // Uživatel zadal něco jiného — informujeme ho
    Console.WriteLine("Neplatný vstup. Zadej prosím 'small' nebo 'big'.");
}
