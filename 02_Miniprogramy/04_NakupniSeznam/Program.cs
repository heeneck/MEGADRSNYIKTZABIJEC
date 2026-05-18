// ============================================================
// PROGRAM: Nákupní seznam
// POPIS:   Uživatel zadává položky nákupního seznamu jednu po druhé.
//          Zadáváním "konec" ukončí seznam a program ho vypíše.
// TÉMATA:  List, while cyklus, foreach cyklus, .Count
// ============================================================

// Vytvoříme prázdný List pro texty — sem budeme přidávat položky
List<string> nakupniSeznam = new List<string>();

// Proměnná pro aktuální vstup — začínáme prázdnou, ne "konec",
// aby se cyklus vůbec spustil
string vstup = "";

Console.WriteLine("=== Nákupní seznam ===");
Console.WriteLine("Zadávej položky. Pro ukončení napiš 'konec'.");
Console.WriteLine();

// Opakujeme tak dlouho, dokud uživatel nezadá "konec"
while (vstup != "konec")
{
    Console.Write("Položka: ");
    vstup = Console.ReadLine(); // načteme co uživatel napsal

    if (vstup != "konec")
    {
        // Pokud to není "konec", přidáme položku do Listu
        nakupniSeznam.Add(vstup);
    }
}

// Výpis výsledného seznamu
Console.WriteLine();
Console.WriteLine("--- Tvůj nákupní seznam ---");
Console.WriteLine($"Celkem {nakupniSeznam.Count} položek:");
Console.WriteLine();

// Proměnná pro číslo před položkou (1., 2., 3., ...)
int cisloPolozky = 1;

// foreach projde všechny položky v Listu jedna po druhé
foreach (string polozka in nakupniSeznam)
{
    Console.WriteLine($"{cisloPolozky}. {polozka}");
    cisloPolozky += 1; // zvýšíme číslo pro příští řádek
}
