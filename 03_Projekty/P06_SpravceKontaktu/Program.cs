// ============================================================
// PROJEKT: Správce kontaktů
// POPIS:   Jednoduchý správce kontaktů s menu.
//          Uživatel může přidávat, zobrazovat a hledat kontakty.
// TÉMATA:  List, while cyklus, foreach, podmínky, Contains
// OBTÍŽNOST: ⭐⭐ Střední
// ============================================================

Console.Title = "Správce kontaktů";

// Dva Listy — jeden pro jména, druhý pro telefonní čísla
// Indexy odpovídají: jmena[0] patří k cisla[0] atd.
List<string> jmena = new List<string>();
List<string> cisla = new List<string>();

string volba = "";

Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║     SPRÁVCE KONTAKTŮ         ║");
Console.WriteLine("╚══════════════════════════════╝");

// Hlavní menu — opakuje se, dokud uživatel nezvolí "4"
while (volba != "4")
{
    Console.WriteLine();
    Console.WriteLine("--- MENU ---");
    Console.WriteLine("1. Přidat kontakt");
    Console.WriteLine("2. Zobrazit všechny kontakty");
    Console.WriteLine("3. Vyhledat kontakt");
    Console.WriteLine("4. Ukončit");
    Console.Write("Tvoje volba: ");
    volba = Console.ReadLine();

    if (volba == "1")
    {
        // === PŘIDÁNÍ KONTAKTU ===
        Console.Write("Jméno: ");
        string jmeno = Console.ReadLine().Trim();

        Console.Write("Telefon: ");
        string telefon = Console.ReadLine().Trim();

        // Přidáme do obou Listů — vždy na konec (stejný index)
        jmena.Add(jmeno);
        cisla.Add(telefon);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"✓ Kontakt '{jmeno}' přidán.");
        Console.ResetColor();
    }
    else if (volba == "2")
    {
        // === VÝPIS VŠECH KONTAKTŮ ===
        if (jmena.Count == 0)
        {
            Console.WriteLine("Žádné kontakty zatím nejsou uloženy.");
        }
        else
        {
            Console.WriteLine($"\n--- Kontakty ({jmena.Count}) ---");
            // for cyklus — potřebujeme index pro přístup do obou Listů
            for (int i = 0; i < jmena.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {jmena[i]} — {cisla[i]}");
            }
        }
    }
    else if (volba == "3")
    {
        // === VYHLEDÁVÁNÍ KONTAKTU ===
        Console.Write("Hledat jméno: ");
        string hledani = Console.ReadLine().ToLower();

        bool nalezeno = false;

        // Projdeme všechny kontakty a hledáme shodu (nemusí být přesná)
        for (int i = 0; i < jmena.Count; i++)
        {
            if (jmena[i].ToLower().Contains(hledani))
            {
                if (!nalezeno)
                {
                    Console.WriteLine("\n--- Nalezené kontakty ---");
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {jmena[i]} — {cisla[i]}");
                Console.ResetColor();
                nalezeno = true;
            }
        }

        if (!nalezeno)
        {
            Console.WriteLine($"Žádný kontakt s '{hledani}' nebyl nalezen.");
        }
    }
    else if (volba != "4")
    {
        // Uživatel zadal něco jiného než 1-4
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Neplatná volba. Zadej číslo 1–4.");
        Console.ResetColor();
    }
}

Console.WriteLine("\nNashledanou!");
