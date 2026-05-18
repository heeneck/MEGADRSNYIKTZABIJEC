using System;

class TeplotyVTydnu
{
    static void Main()
    {
        double[] teploty = new double[7];
        string[] dny = { "Pondeli", "Utery", "Streda", "Ctvrtek", "Patek", "Sobota", "Nedele" };

        for (int i = 0; i < 7; i++)
        {
            Console.Write(dny[i] + ": ");
            teploty[i] = double.Parse(Console.ReadLine());
        }

        double soucet = 0;
        double max = teploty[0];
        double min = teploty[0];

        for (int i = 0; i < 7; i++)
        {
            soucet += teploty[i];
            if (teploty[i] > max) max = teploty[i];
            if (teploty[i] < min) min = teploty[i];
        }

        Console.WriteLine("Prumer: " + soucet / 7);
        Console.WriteLine("Nejvyssi: " + max);
        Console.WriteLine("Nejnizsi: " + min);
    }
}
