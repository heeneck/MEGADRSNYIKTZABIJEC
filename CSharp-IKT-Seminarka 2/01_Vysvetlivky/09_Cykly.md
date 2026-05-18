# 9. Cykly — while a for

Cyklus umožňuje **opakovat blok kódu** dokud platí podmínka.

---

## WHILE cyklus

Cyklus while je jako "opakovaný if" — opakuje se, dokud je podmínka pravdivá.

### Nekonečný cyklus (podmínka je vždy pravdivá)

```csharp
while (1 + 1 == 2) // vždy true → nikdy neskončí
{
    Console.WriteLine("Tralalala");
    Thread.Sleep(500);
}
```

### Konečný cyklus (proměnná se mění)

```csharp
int i = 0;
while (i < 5) // proběhne 5×: pro i = 0, 1, 2, 3, 4
{
    Console.WriteLine("Opakování číslo: " + i);
    i += 1; // bez tohoto by byl cyklus nekonečný!
}
```

### Cyklus s podmínkou na vstup (opakuj dokud uživatel nezadá správné heslo)

```csharp
string heslo = "";
while (heslo != "GYMJS")
{
    Console.WriteLine("Zadej heslo:");
    heslo = Console.ReadLine();
}
Console.WriteLine("Přihlášení úspěšné!");
```

### Odpočítávání

```csharp
int cas = 10;
while (cas >= 0)
{
    Console.WriteLine("Zbývá: " + cas + " s");
    cas--;          // zkrácený zápis pro cas -= 1
    Thread.Sleep(1000);
}
Console.WriteLine("Čas vypršel!");
```

---

## FOR cyklus

Kratší zápis konečného while cyklu. Tři části jsou pohromadě v závorce:
1. **Inicializace** — vytvoří proměnnou (`int krok = 0`)
2. **Podmínka** — dokud platí, cyklus běží (`krok < 5`)
3. **Změna** — co se stane po každém průchodu (`krok++`)

```csharp
for (int krok = 0; krok < 5; krok++)
{
    Console.WriteLine("Krok: " + krok);
}
// Vypíše: 0, 1, 2, 3, 4
```

### Příklady for cyklů

```csharp
// Výpis čísel 1 až 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Výpis sudých čísel 0–10
for (int i = 0; i <= 10; i += 2)
{
    Console.WriteLine(i); // 0, 2, 4, 6, 8, 10
}

// Součet čísel 1 až 5
int soucet = 0;
for (int i = 1; i <= 5; i++)
{
    soucet += i;
}
Console.WriteLine("Součet: " + soucet); // 15

// Generování 3 výherních čísel
for (int i = 1; i <= 3; i++)
{
    int cislo = Random.Shared.Next(1, 100);
    Console.WriteLine($"Výherní číslo č. {i}: {cislo}");
}
```

---

## Porovnání while vs. for

Oba příklady níže dělají **přesně to samé**:

**WHILE:**
```csharp
int krok = 0;
while (krok < 25)
{
    Console.WriteLine("Opakování: " + krok);
    krok += 1;
}
```

**FOR:**
```csharp
for (int krok = 0; krok < 25; krok += 1)
{
    Console.WriteLine("Opakování: " + krok);
}
```

---

## Kdy použít while vs. for?

| Situace | Doporučený cyklus |
|---------|-------------------|
| Předem víš, kolikrát se opakuje | `for` |
| Opakuj, dokud uživatel nezadá správný vstup | `while` |
| Nekonečná smyčka (menu, server…) | `while (true)` |
| Procházení pole s indexem | `for` |

---

## ⚠️ Pozor na nekonečné cykly

Pokud zapomeneš změnit proměnnou v `while`, program se **zasekne**:

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    // CHYBÍ: i += 1;  → cyklus nikdy neskončí!
}
```
