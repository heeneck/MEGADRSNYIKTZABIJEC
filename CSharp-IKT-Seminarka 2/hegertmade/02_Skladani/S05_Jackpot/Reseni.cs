// ŘEŠENÍ — S05: Jackpot
Console.WriteLine("Vítej v programu");
while (1 + 1 == 2)
{
    int nahodneCislo = Random.Shared.Next(1, 100);
    if (nahodneCislo == 50)
    {
        Console.WriteLine("JACKPOT");
    }
    else
    {
        Console.WriteLine(nahodneCislo);
    }
}
