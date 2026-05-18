// ŘEŠENÍ — S02: Heslo
// Správné pořadí řádků:

Console.WriteLine("Zadejte heslo a potvrďte stiskem ENTER");
string heslo = Console.ReadLine();
if (heslo == "XOXOXO")
{
    Console.WriteLine("Dveře otevřené");
}
else if (heslo.Length == 6)
{
    Console.WriteLine("Správná délka hesla, ale zkuste to znovu.");
}
else
{
    Console.WriteLine("NESPRÁVNÉ HESLO");
}
