// ============================================================
// PROGRAM: Výpočet elektrického výkonu
// POPIS:   Uživatel zadá napětí (V) a proud (A),
//          program vypočítá výkon podle vzorce P = U × I
// TÉMATA:  vstup, Convert.ToInt32, matematika, barvy konzole
// ============================================================

Console.WriteLine("=== Výpočet elektrického výkonu ===");
Console.WriteLine("Vzorec: P = U × I (výkon = napětí × proud)");
Console.WriteLine();

// Načtení napětí
Console.WriteLine("Zadejte napětí (V):");
string vstupNapeti = Console.ReadLine();
int zadaneNapeti = Convert.ToInt32(vstupNapeti); // převod textu na číslo

// Načtení proudu
Console.WriteLine("Zadejte proud (A):");
string vstupProud = Console.ReadLine();
int zadanyProud = Convert.ToInt32(vstupProud); // převod textu na číslo

// Výpočet výkonu (násobení)
int vykon = zadaneNapeti * zadanyProud;

// Výpis výsledku modrou barvou pro zvýraznění
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Výkon = {zadaneNapeti} V × {zadanyProud} A = {vykon} Wattů");
Console.ResetColor();
