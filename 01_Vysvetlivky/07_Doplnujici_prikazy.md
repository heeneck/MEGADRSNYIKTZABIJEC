# 7. Doplňující příkazy konzole

## Barvy textu a pozadí

```csharp
// Změna barvy textu
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Tento text bude zelený");

// Změna barvy pozadí
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Tento text bude mít červené pozadí");

// Reset na výchozí barvy
Console.ResetColor();
Console.WriteLine("Zpět na normální barvy");
```

### Dostupné barvy ConsoleColor

`Black`, `DarkBlue`, `DarkGreen`, `DarkCyan`, `DarkRed`, `DarkMagenta`, `DarkYellow`,
`Gray`, `DarkGray`, `Blue`, `Green`, `Cyan`, `Red`, `Magenta`, `Yellow`, `White`

---

## Nastavení okna (pro samostatnou aplikaci)

Tyto příkazy se dávají na **první řádky programu** a platí pouze při spuštění jako exe soubor:

```csharp
Console.Title = "Moje aplikace";  // název okna v záhlaví
Console.WindowWidth = 80;         // šířka okna ve znacích
Console.WindowHeight = 30;        // výška okna v řádcích
```

---

## Vymazání konzole

```csharp
Console.Clear(); // vymaže veškerý text z konzole (okna)
```

---

## Čekání — Thread.Sleep

Program se na daném místě **zastaví** na zadaný počet milisekund (1000 ms = 1 sekunda).

```csharp
Console.WriteLine("Čekám 2 sekundy...");
Thread.Sleep(2000); // čeká 2 sekundy
Console.WriteLine("Hotovo!");
```

```csharp
// Odpočítávání
for (int i = 5; i >= 0; i--)
{
    Console.WriteLine("Zbývá: " + i + " sekund");
    Thread.Sleep(1000);
}
Console.WriteLine("Start!");
```

---

## Zvuk — Console.Beep

> ⚠️ **Nefunguje na macOS!** Pouze Windows.

```csharp
// Console.Beep(frekvence_Hz, délka_ms)
Console.Beep(440, 500);   // tón A, půl sekundy
Console.Beep(880, 300);   // tón o oktávu výš, 0.3 sekundy
```

```csharp
// Ukázka: dvě různé frekvence uložené v proměnných
int frekvence1 = 4000;
int frekvence2 = 800;
int delka1 = 500;
int delka2 = 2000;

Console.Beep(frekvence1, delka1);
Console.Beep(frekvence2, delka2);
```

---

## Praktický příklad — animovaný loader

```csharp
Console.WriteLine("Načítám data...");
Thread.Sleep(1000);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("✓ Data načtena!");
Console.ResetColor();
```
