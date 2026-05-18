using System;
using System.Collections.Generic;

class BrainrotCounter
{
    static void Main()
    {
        string[] brainrotSlova = {
            "skibidi", "rizz", "sigma", "ohio", "gyatt", "fanum", "mewing",
            "bussin", "slay", "based", "no cap", "fr fr", "lowkey", "highkey",
            "delulu", "sus", "goated", "mid", "npc", "ratio", "L", "W", "touch grass"
        };

        List<string> brainrotVety = new List<string>();

        Console.WriteLine("=== Brainrot Counter ===");
        Console.WriteLine("Zadávejte věty (pro ukončení napište STOP):\n");

        while (true)
        {
            Console.Write("> ");
            string veta = Console.ReadLine();

            if (veta.Trim().ToUpper() == "STOP")
                break;

            string vetaLower = veta.ToLower();
            bool obsahujeBrainrot = false;

            foreach (string slovo in brainrotSlova)
            {
                if (vetaLower.Contains(slovo))
                {
                    obsahujeBrainrot = true;
                    break;
                }
            }

            if (obsahujeBrainrot)
                brainrotVety.Add(veta);
        }

        Console.WriteLine("\n=== Výsledky ===");

        if (brainrotVety.Count == 0)
        {
            Console.WriteLine("Žádné brainrot věty nebyly detekovány.");
        }
        else
        {
            Console.WriteLine("Brainrot věty:");
            foreach (string v in brainrotVety)
                Console.WriteLine($"  - {v}");

            Console.WriteLine($"\nBrainrot detekován v {brainrotVety.Count} větách.");
        }
    }
}
