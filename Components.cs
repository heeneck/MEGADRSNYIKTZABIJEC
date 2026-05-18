// ============================================================
//  ZNOVUPOUŽITELNÉ KOMPONENTY — C# konzolové aplikace
//  Zkopíruj si libovolnou metodu přímo do svého programu.
//  Každá sekce je nezávislá — nepotřebuješ všechny.
// ============================================================


// ════════════════════════════════════════════════════════════
//  1. VSTUP OD UŽIVATELE (bezpečné načítání)
// ════════════════════════════════════════════════════════════

// Načte celé číslo — opakuje se, dokud uživatel nezadá platné číslo
int NactiInt(string vyzva)
{
    while (true)
    {
        Console.Write(vyzva);
        string vstup = Console.ReadLine();
        if (int.TryParse(vstup, out int cislo))
            return cislo;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Neplatný vstup. Zadej celé číslo.");
        Console.ResetColor();
    }
}

// Načte celé číslo v daném rozsahu — opakuje se, dokud není v rozsahu
int NactiIntVRozsahu(string vyzva, int min, int max)
{
    while (true)
    {
        int cislo = NactiInt(vyzva);
        if (cislo >= min && cislo <= max)
            return cislo;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Číslo musí být od {min} do {max}.");
        Console.ResetColor();
    }
}

// Načte desetinné číslo — opakuje se, dokud uživatel nezadá platné číslo
double NactiDouble(string vyzva)
{
    while (true)
    {
        Console.Write(vyzva);
        string vstup = Console.ReadLine();
        if (double.TryParse(vstup, out double cislo))
            return cislo;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Neplatný vstup. Zadej desetinné číslo (např. 3,14).");
        Console.ResetColor();
    }
}

// Načte neprázdný text — opakuje se, pokud uživatel zadá prázdný řetězec
string NactiText(string vyzva)
{
    while (true)
    {
        Console.Write(vyzva);
        string vstup = Console.ReadLine().Trim();
        if (vstup.Length > 0)
            return vstup;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Vstup nesmí být prázdný.");
        Console.ResetColor();
    }
}

// Načte odpověď ano/ne — vrátí true pro ano, false pro ne
bool NactiAnoNe(string vyzva)
{
    while (true)
    {
        Console.Write($"{vyzva} (ano/ne): ");
        string vstup = Console.ReadLine().ToLower().Trim();
        if (vstup == "ano" || vstup == "a") return true;
        if (vstup == "ne"  || vstup == "n") return false;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Zadej 'ano' nebo 'ne'.");
        Console.ResetColor();
    }
}

/*  POUŽITÍ:
    int vek    = NactiInt("Zadej věk: ");
    int volba  = NactiIntVRozsahu("Volba (1–4): ", 1, 4);
    double bmi = NactiDouble("Váha v kg: ");
    string jmeno = NactiText("Jméno: ");
    bool pokracovat = NactiAnoNe("Chceš pokračovat?");
*/


// ════════════════════════════════════════════════════════════
//  2. VÝPIS DO KONZOLE (UI pomůcky)
// ════════════════════════════════════════════════════════════

// Vytiskne nadpis v rámečku
void VypisNadpis(string text)
{
    string cara = new string('═', text.Length + 4);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"╔{cara}╗");
    Console.WriteLine($"║  {text}  ║");
    Console.WriteLine($"╚{cara}╝");
    Console.ResetColor();
}

// Vytiskne oddělovací čáru dané délky
void VypisCaru(int delka = 40)
{
    Console.WriteLine(new string('─', delka));
}

// Vytiskne text v barvě
void VypisBarevne(string text, ConsoleColor barva)
{
    Console.ForegroundColor = barva;
    Console.WriteLine(text);
    Console.ResetColor();
}

// Vytiskne pruhový ukazatel (progress bar)  [████░░░░░░] 60%
void VypisProgressBar(string nazev, int hodnota, int maximum)
{
    int bloky = (hodnota * 10) / maximum;
    if (bloky < 0) bloky = 0;
    if (bloky > 10) bloky = 10;

    if (hodnota >= maximum * 0.6)      Console.ForegroundColor = ConsoleColor.Green;
    else if (hodnota >= maximum * 0.3) Console.ForegroundColor = ConsoleColor.Yellow;
    else                               Console.ForegroundColor = ConsoleColor.Red;

    string pruh = "[" + new string('█', bloky) + new string('░', 10 - bloky) + "]";
    Console.Write($"{nazev,-16} {pruh} {hodnota}/{maximum}");
    Console.ResetColor();
    Console.WriteLine();
}

// Vypíše text pomalu — znak po znaku (efekt psacího stroje)
void VypisTypefx(string text, int zpozdeniMs = 20)
{
    foreach (char znak in text)
    {
        Console.Write(znak);
        Thread.Sleep(zpozdeniMs);
    }
    Console.WriteLine();
}

/*  POUŽITÍ:
    VypisNadpis("Moje aplikace");
    VypisCaru();
    VypisBarevne("Operace úspěšná!", ConsoleColor.Green);
    VypisProgressBar("Životy", 65, 100);
    VypisTypefx("Vítej, hrdino...", 30);
*/


// ════════════════════════════════════════════════════════════
//  3. MENU (interaktivní výběr)
// ════════════════════════════════════════════════════════════

// Zobrazí menu z pole položek a vrátí číslo volby (1 až počet položek)
int ZobrazMenu(string nadpis, string[] polozky)
{
    Console.WriteLine();
    VypisNadpis(nadpis);
    for (int i = 0; i < polozky.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"  {i + 1}. ");
        Console.ResetColor();
        Console.WriteLine(polozky[i]);
    }
    Console.WriteLine();
    return NactiIntVRozsahu($"Volba (1–{polozky.Length}): ", 1, polozky.Length);
}

/*  POUŽITÍ:
    int volba = ZobrazMenu("Hlavní menu", new string[] {
        "Nová hra",
        "Nastavení",
        "Konec"
    });
    // volba bude 1, 2, nebo 3
*/


// ════════════════════════════════════════════════════════════
//  4. ČEKÁNÍ A ANIMACE
// ════════════════════════════════════════════════════════════

// Čeká dané sekundy a zobrazí zprávu
void PockejSeZpravou(string zprava, int sekundy)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write(zprava);
    for (int i = 0; i < sekundy; i++)
    {
        Thread.Sleep(1000);
        Console.Write(".");
    }
    Console.ResetColor();
    Console.WriteLine();
}

// Zobrazí rotující spinner po dobu milisekund (vizuální načítání)
void ZobrazSpinner(int trvaниMs = 2000)
{
    char[] spinner = { '|', '/', '─', '\\' };
    int krok = 0;
    long konec = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + trvaниMs;

    Console.CursorVisible = false;
    while (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() < konec)
    {
        Console.Write($"\r  {spinner[krok % 4]} Načítám...");
        Thread.Sleep(100);
        krok++;
    }
    Console.Write("\r                    \r");
    Console.CursorVisible = true;
}

// Odpočítávání od N do 0 s výpisem každé sekundy
void Odpocitej(int sekundy)
{
    for (int i = sekundy; i >= 0; i--)
    {
        Console.Write($"\rZbývá: {i} s   ");
        Thread.Sleep(1000);
    }
    Console.WriteLine("\rHotovo!           ");
}

// Pauza — stiskni Enter pro pokračování
void CekejNaEnter(string zprava = "Stiskni Enter pro pokračování...")
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write(zprava);
    Console.ResetColor();
    Console.ReadLine();
}

/*  POUŽITÍ:
    PockejSeZpravou("Připravuji hru", 3);   // "Připravuji hru..."
    ZobrazSpinner(2000);                     // spinner 2 sekundy
    Odpocitej(5);                            // 5, 4, 3, 2, 1, 0
    CekejNaEnter();
*/


// ════════════════════════════════════════════════════════════
//  5. NÁHODNÁ ČÍSLA A VÝBĚRY
// ════════════════════════════════════════════════════════════

// Vrátí náhodný prvek z pole (string[])
string NahodnyPrvek(string[] pole)
{
    return pole[Random.Shared.Next(0, pole.Length)];
}

// Vrátí náhodný prvek z Listu
string NahodnyPrvekZListu(List<string> list)
{
    return list[Random.Shared.Next(0, list.Count)];
}

// Vrátí true s danou pravděpodobností (0–100 %)
bool NahodnaShoda(int pravdepodobnostProcent)
{
    return Random.Shared.Next(1, 101) <= pravdepodobnostProcent;
}

// Zamíchá pole (Fisher-Yates shuffle)
void ZamichejPole(int[] pole)
{
    for (int i = pole.Length - 1; i > 0; i--)
    {
        int j = Random.Shared.Next(0, i + 1);
        (pole[i], pole[j]) = (pole[j], pole[i]); // swap
    }
}

/*  POUŽITÍ:
    string[] mesta = { "Praha", "Brno", "Ostrava" };
    string nahodne = NahodnyPrvek(mesta);           // např. "Brno"

    bool kriticky = NahodnaShoda(25);               // true ve 25 % případů

    int[] cisla = { 1, 2, 3, 4, 5 };
    ZamichejPole(cisla);                            // zamíchá pořadí
*/


// ════════════════════════════════════════════════════════════
//  6. PRÁCE S TEXTEM (string pomůcky)
// ════════════════════════════════════════════════════════════

// Zarovná text na střed do dané šířky mezerami
string ZarovnejNaStred(string text, int sirka)
{
    int mezery = (sirka - text.Length) / 2;
    if (mezery < 0) mezery = 0;
    return new string(' ', mezery) + text;
}

// Opakuje string N-krát (např. "=-" → "=-=-=-=-=-=-")
string OpakovanyText(string vzor, int pocet)
{
    string result = "";
    for (int i = 0; i < pocet; i++)
        result += vzor;
    return result;
}

// Zkontroluje, zda je string číslo (bez try-catch)
bool JeCislo(string text)
{
    return int.TryParse(text, out _);
}

// Vrátí počet výskytů daného znaku v textu
int PocetVyskytu(string text, char znak)
{
    int pocet = 0;
    foreach (char c in text)
        if (c == znak) pocet++;
    return pocet;
}

/*  POUŽITÍ:
    Console.WriteLine(ZarovnejNaStred("Výsledky", 40));
    Console.WriteLine(OpakovanyText("=-", 20));   // "=-=-...-="
    bool platne = JeCislo("42");                  // true
    int tecky = PocetVyskytu("www.github.com", '.'); // 2
*/


// ════════════════════════════════════════════════════════════
//  7. SKÓRE A STATISTIKY (herní pomůcky)
// ════════════════════════════════════════════════════════════

// Vrátí textové hodnocení podle procentuálního skóre
string OhodnotSkore(int dosazene, int maximum)
{
    int procenta = (dosazene * 100) / maximum;
    if (procenta == 100) return "Perfektní! 🏆";
    if (procenta >= 80)  return "Skvělé! ⭐";
    if (procenta >= 60)  return "Dobré 👍";
    if (procenta >= 40)  return "Ujde 😐";
    return "Příště lépe 💪";
}

// Vypíše tabulku výsledků (jméno + hodnota)
void VypisTabulkuVysledku(string[] jmena, int[] hodnoty)
{
    VypisCaru(30);
    Console.WriteLine($"{"Pořadí",-8} {"Jméno",-15} {"Body",6}");
    VypisCaru(30);
    for (int i = 0; i < jmena.Length; i++)
    {
        Console.WriteLine($"{i + 1,-8} {jmena[i],-15} {hodnoty[i],6}");
    }
    VypisCaru(30);
}

/*  POUŽITÍ:
    Console.WriteLine(OhodnotSkore(8, 10));        // "Skvělé! ⭐"

    string[] hrace = { "Alice", "Bob", "Charlie" };
    int[] body     = { 1500, 800, 1200 };
    VypisTabulkuVysledku(hrace, body);
*/


// ════════════════════════════════════════════════════════════
//  RYCHLÝ PŘEHLED — všechny metody na jednom místě
// ════════════════════════════════════════════════════════════
//
//  VSTUP
//    NactiInt(vyzva)                       → int
//    NactiIntVRozsahu(vyzva, min, max)     → int
//    NactiDouble(vyzva)                    → double
//    NactiText(vyzva)                      → string
//    NactiAnoNe(vyzva)                     → bool
//
//  VÝPIS
//    VypisNadpis(text)
//    VypisCaru(delka)
//    VypisBarevne(text, barva)
//    VypisProgressBar(nazev, hodnota, max)
//    VypisTypefx(text, zpozdeniMs)
//
//  MENU
//    ZobrazMenu(nadpis, polozky[])         → int (číslo volby)
//
//  ČEKÁNÍ
//    PockejSeZpravou(zprava, sekundy)
//    ZobrazSpinner(ms)
//    Odpocitej(sekundy)
//    CekejNaEnter(zprava)
//
//  NÁHODA
//    NahodnyPrvek(pole[])                  → string
//    NahodnyPrvekZListu(list)              → string
//    NahodnaShoda(procenta)                → bool
//    ZamichejPole(pole[])
//
//  TEXT
//    ZarovnejNaStred(text, sirka)          → string
//    OpakovanyText(vzor, pocet)            → string
//    JeCislo(text)                         → bool
//    PocetVyskytu(text, znak)              → int
//
//  SKÓRE
//    OhodnotSkore(dosazene, maximum)       → string
//    VypisTabulkuVysledku(jmena[], body[])
//
// ============================================================
