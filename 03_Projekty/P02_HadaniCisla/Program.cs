// ============================================================
// PROJEKT: Hádání čísla
// POPIS:   Program vygeneruje tajné číslo 1–100.
//          Uživatel hádá a dostává nápovědy "víc" / "míň".
//          Hra skončí, když uhodne správně.
// TÉMATA:  Random, while, podmínky, Convert, počítadlo pokusů
// OBTÍŽNOST: ⭐ Lehká
// ============================================================

Console.Title = "Hádání čísla";
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║     UHODNI TAJNÉ ČÍSLO       ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.WriteLine("Myslím si číslo od 1 do 100. Uhodni ho!");
Console.WriteLine();

// Vygenerujeme tajné číslo
int tajneCislo = Random.Shared.Next(1, 101); // 1 až 100

// Počítadlo pokusů
int pocetPokusu = 0;

// Proměnná pro uhodnuté číslo — začínáme na 0 (zaručeně špatně)
int tipUzivatele = 0;

// Hrajeme, dokud uživatel neuhodne
while (tipUzivatele != tajneCislo)
{
    Console.Write("Tvůj tip: ");
    string vstup = Console.ReadLine();
    tipUzivatele = Convert.ToInt32(vstup); // převod textu na číslo
    pocetPokusu += 1;                      // zvýšíme počet pokusů

    if (tipUzivatele < tajneCislo)
    {
        // Tip je příliš malý
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Moje číslo je VĚTŠÍ. Zkus víc!");
        Console.ResetColor();
    }
    else if (tipUzivatele > tajneCislo)
    {
        // Tip je příliš velký
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Moje číslo je MENŠÍ. Zkus míň!");
        Console.ResetColor();
    }
    // Pokud je tip == tajneCislo, podmínky se nevykonají a cyklus skončí
}

// Uživatel uhodl → gratulácia
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nSprávně! Číslo bylo {tajneCislo}.");
Console.WriteLine($"Uhodl jsi na {pocetPokusu}. pokus!");
Console.ResetColor();

// Malé hodnocení podle počtu pokusů
if (pocetPokusu <= 5)
{
    Console.WriteLine("Neuvěřitelné! Jsi génius!");
}
else if (pocetPokusu <= 10)
{
    Console.WriteLine("Skvělý výkon!");
}
else
{
    Console.WriteLine("Příště to zvládneš rychleji.");
}
