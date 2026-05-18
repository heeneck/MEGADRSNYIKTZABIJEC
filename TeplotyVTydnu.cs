using System;
using System.Collections.Generic;

class TeplotyVTydnu
{
    static void Main()
    {
        string[] dny = { "Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Neděle" };
        List<double> teploty = new List<double>();

        Console.WriteLine("=== Teploty v týdnu ===\n");

        foreach (string den in dny)
        {
            Console.Write($"{den}: ");
            string vstup = Console.ReadLine();
            double teplota = double.Parse(vstup.Replace(',', '.'),
                System.Globalization.CultureInfo.InvariantCulture);
            teploty.Add(teplota);
        }

        double prumer = 0;
        double max = teploty[0];
        double min = teploty[0];
        int indexMax = 0;
        int indexMin = 0;

        for (int i = 0; i < teploty.Count; i++)
        {
            prumer += teploty[i];
            if (teploty[i] > max) { max = teploty[i]; indexMax = i; }
            if (teploty[i] < min) { min = teploty[i]; indexMin = i; }
        }

        prumer /= teploty.Count;

        Console.WriteLine("\n=== Výsledky ===");
        Console.WriteLine($"Průměrná teplota: {prumer:F1} °C");
        Console.WriteLine($"Nejvyšší teplota: {max:F1} °C ({dny[indexMax]})");
        Console.WriteLine($"Nejnižší teplota: {min:F1} °C ({dny[indexMin]})");
    }
}
