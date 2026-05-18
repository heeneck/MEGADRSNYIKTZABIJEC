// ============================================================
// PROGRAM: Kontrola věku
// POPIS:   Uživatel zadá věk a program ho zařadí do kategorie:
//          nezletilý, zletilý, nebo neuvěřitelně starý.
// TÉMATA:  vstup, Convert.ToInt32, podmínky if/else if
// ============================================================

Console.WriteLine("=== Kontrola věku ===");
Console.WriteLine("Zadejte věk:");

// Console.ReadLine() vrací string → musíme převést na int
string vekVstup = Console.ReadLine();
int zadanyVek = Convert.ToInt32(vekVstup);

// Podmínky vyhodnocujeme shora dolů — první platná se vykoná
if (zadanyVek > 110)
{
    // Zvláštní případ — věk přes 110 je podezřelý
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Opravdu Vám je více než 110 let???");
}
else if (zadanyVek >= 18)
{
    // Standardní dospělý (18–110 let)
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Zletilý");
}
else if (zadanyVek >= 0)
{
    // 0 až 17 let — nezletilý
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Nezletilý");
}
else
{
    // Záporné číslo — nesplní žádnou předchozí podmínku → else
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ještě jsi se nenarodil...");
}

// Vrátíme barvy na výchozí
Console.ResetColor();
