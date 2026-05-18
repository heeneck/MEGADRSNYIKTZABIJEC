// ŘEŠENÍ — S03: Počet měsíců
Console.WriteLine("Vítejte v programu. Zadejte počet let");
string rokyText = Console.ReadLine();
int roky = Convert.ToInt32(rokyText);
if (roky > 0)
{
    Console.WriteLine("Úspěšný výpočet");
    int pocetMesicu = roky * 12;
    Console.WriteLine(roky + " let je " + pocetMesicu);
}
else
{
    Console.WriteLine("CHYBA");
}
