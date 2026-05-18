// ŘEŠENÍ — S06: Stavební parcela
Console.Write("Zadejte počet tun dřeva: ");
string vstupDreva = Console.ReadLine();
int tunyDreva = Convert.ToInt32(vstupDreva);
int materialNaDomy = tunyDreva / 10;

Console.Write("Zadejte počet m2 parcely: ");
string vstupParcely = Console.ReadLine();
int m2Parcely = Convert.ToInt32(vstupParcely);
int mistaNaParcele = m2Parcely / 75;

Console.WriteLine($"Počet balíků materiálu na domy: {materialNaDomy}");
Console.WriteLine($"Počet míst na domy: {mistaNaParcele}");

if (materialNaDomy > mistaNaParcele)
{
    int zbyvaDreva = tunyDreva - (10 * mistaNaParcele);
    Console.WriteLine($"Zbyde {zbyvaDreva} tun dřeva, postaví se {mistaNaParcele} domy. Parcely jsou obsazené.");
}
else if (mistaNaParcele >= materialNaDomy)
{
    int zbyvaM2 = m2Parcely - (75 * materialNaDomy);
    Console.WriteLine($"Zbyde {zbyvaM2}m2 parcely, postaví se {materialNaDomy} domy. Došlo dřevo.");
}
