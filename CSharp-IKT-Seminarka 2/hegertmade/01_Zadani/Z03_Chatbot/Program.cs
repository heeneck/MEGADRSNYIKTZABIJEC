// ============================================================
// PROJEKT: Chatbot (GJSBOT)
// Odpovídá na věty i otázky pomocí náhodných frází.
// Pokud věta obsahuje "?", vybere frázi z pole pro otázky.
// TÉMATA: string[], while(true), Contains, Random, Thread.Sleep
// ============================================================

// Pole 1 — odpovědi na běžné věty
string[] odpovediNaVety = {
    "To mě upřímně vůbec nepřekvapuje.",
    "Zajímavé. Řekni mi víc.",
    "Hmm, to si pamatuji.",
    "To zní jako typický problém.",
    "Máš úplnou pravdu.",
    "Nějak jsem to nečekal/a.",
    "To se mi líbí.",
    "Opravdu? To je fascinující.",
    "Chápu tě.",
    "Mohl/a bys to rozvést?",
    "To je zajímavý pohled.",
    "S tím úplně souhlasím.",
    "Někdy se to stává.",
    "To je docela běžná situace.",
    "Díky, že mi to říkáš."
};

// Pole 2 — odpovědi na otázky
string[] odpovediNaOtazky = {
    "Na to se ptáš mě?",
    "Dobrá otázka. Sám nevím.",
    "Odpověď je 42.",
    "Proč se mě na to ptáš?",
    "To záleží na úhlu pohledu.",
    "Nad tím jsem nikdy nepřemýšlel/a.",
    "Možná ano, možná ne.",
    "Zkus se zeptat někoho jiného.",
    "Na to odpovídám jen v pátek.",
    "Zajímavá otázka. Nechám tě přemýšlet.",
    "Nevím, ale google by mohl vědět.",
    "Správná odpověď je: záleží.",
    "Možná ti na to odpovím příště.",
    "To by chtělo hlubší analýzu.",
    "Ano. Nebo ne. Nebo obojí."
};

// Načtení jména
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║         GJSBOT v1.0          ║");
Console.WriteLine("╚══════════════════════════════╝");
Console.ResetColor();
Console.WriteLine();
Console.Write("Zadej své jméno: ");
string jmeno = Console.ReadLine().Trim();
if (jmeno.Length == 0) jmeno = "Anonymní";

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Vítej, {jmeno}! Piš cokoliv. GJSBOT ti odpoví.");
Console.WriteLine(new string('─', 40));
Console.ResetColor();
Console.WriteLine();

// Nekonečný chat cyklus
while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"{jmeno}: ");
    Console.ResetColor();
    string veta = Console.ReadLine();

    if (veta.Trim().Length == 0)
        continue;

    // Počkej 2 sekundy (chatbot "přemýšlí")
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("GJSBOT píše");
    for (int i = 0; i < 3; i++)
    {
        Thread.Sleep(600);
        Console.Write(".");
    }
    Console.ResetColor();
    Thread.Sleep(400);

    // Vyber odpověď podle typu věty
    string odpoved;
    if (veta.Contains("?"))
    {
        int index = Random.Shared.Next(0, odpovediNaOtazky.Length);
        odpoved = odpovediNaOtazky[index];
    }
    else
    {
        int index = Random.Shared.Next(0, odpovediNaVety.Length);
        odpoved = odpovediNaVety[index];
    }

    // Vyčisti a vypiš konverzaci
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Vítej, {jmeno}! Piš cokoliv. GJSBOT ti odpoví.");
    Console.WriteLine(new string('─', 40));
    Console.ResetColor();
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"{jmeno}: {veta}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"GJSBOT: {odpoved}");
    Console.ResetColor();
    Console.WriteLine();
}
