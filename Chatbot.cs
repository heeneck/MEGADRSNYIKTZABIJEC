using System;

class Chatbot
{
    static void Main()
    {
        // První pole – klíčová slova / témata vstupu
        string[] klicovaSlov = {
            "ahoj", "čau", "jak se máš", "co děláš", "odkud jsi",
            "kolik ti je", "jaké máš hobby", "oblíbené jídlo", "oblíbená barva", "oblíbený film",
            "počasí", "sport", "hudba", "škola", "práce",
        };

        // Druhé pole – odpovědi chatbota (odpovídají indexem klíčovým slovům)
        string[] odpovedi = {
            "Ahoj! Jak ti můžu pomoct?",
            "Čau čau! Co tě přivádí?",
            "Mám se skvěle, díky! A ty?",
            "Jen tak si povídám s tebou!",
            "Jsem digitální bytost, takže odkudkoli!",
            "Věk je jen číslo – já se nepočítám.",
            "Moje hobby je odpovídat na otázky. Překvapení!",
            "Mám rád/a data a algoritmy. Chutné!",
            "Moje oblíbená barva je #0078D7 – taková pěkná modrá.",
            "Klasika: Matrix. Nebo možná Inception? Obojí!",
            "Dnes je ideální počasí na programování.",
            "Sport? Já závodím v rychlosti psaní odpovědí.",
            "Poslouchám hlavně binární kód. Zní skvěle.",
            "Škola je základ – nezanedbávej ji!",
            "Moje práce je bavit tě. A daří se mi to?",
        };

        Random rng = new Random();

        Console.WriteLine("=== Chatbot ===");
        Console.WriteLine("Napiš cokoliv (nebo 'konec' pro ukončení):\n");

        while (true)
        {
            Console.Write("Ty: ");
            string vstup = Console.ReadLine();

            if (vstup.Trim().ToLower() == "konec")
            {
                Console.WriteLine("Chatbot: Nashle! Byl jsem rád, že jsem si s tebou popovídal.");
                break;
            }

            string vstupLower = vstup.ToLower();
            int nalezenyIndex = -1;

            for (int i = 0; i < klicovaSlov.Length; i++)
            {
                if (vstupLower.Contains(klicovaSlov[i]))
                {
                    nalezenyIndex = i;
                    break;
                }
            }

            string odpoved;
            if (nalezenyIndex >= 0)
            {
                odpoved = odpovedi[nalezenyIndex];
            }
            else
            {
                // Žádné klíčové slovo nebylo nalezeno – náhodná obecná odpověď
                string[] obecneOdpovedi = {
                    "To je zajímavé, řekni mi víc!",
                    "Hmm, o tom přemýšlím...",
                    "Opravdu? To jsem nevěděl/a!",
                    "Super téma! Co tě na tom zajímá?",
                    "Nemám na to jasnou odpověď, ale rád/a si popovídám dál."
                };
                odpoved = obecneOdpovedi[rng.Next(obecneOdpovedi.Length)];
            }

            Console.WriteLine($"Chatbot: {odpoved}\n");
        }
    }
}
