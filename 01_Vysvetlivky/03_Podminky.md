# 3. Podmínky if – else if – else

## Co je podmínka?
Podmínka umožňuje programu **rozhodovat se** — provést různý kód podle toho, co je zrovna pravda.

---

## Operátory porovnání

| Operátor | Význam | Příklad |
|----------|--------|---------|
| `==` | rovná se | `vek == 18` |
| `!=` | nerovná se | `barva != "red"` |
| `>` | větší než | `skore > 50` |
| `<` | menší než | `skore < 50` |
| `>=` | větší nebo rovno | `vek >= 18` |
| `<=` | menší nebo rovno | `vek <= 65` |

---

## if – else

Nastane vždy jen **jedna** ze dvou větví.

```csharp
int skore = 75;

if (skore >= 50)
{
    Console.WriteLine("Prošel jsi!");
}
else
{
    Console.WriteLine("Neprošel jsi.");
}
```

---

## if – else if – else

Nastane vždy jen **jedna** větev — ta první, jejíž podmínka platí.

```csharp
int vysledek = 60;

if (vysledek >= 90)
{
    Console.WriteLine("Výborně");
}
else if (vysledek >= 75)
{
    Console.WriteLine("Chvalitebně");
}
else if (vysledek >= 60)
{
    Console.WriteLine("Dobře");
}
else
{
    Console.WriteLine("Nedostatečně");
}
```

> `else` je **nepovinný** — program skončí podmínky bez akce, pokud žádná nepasuje.

---

## Více if za sebou (může platit více větví)

Pokud použijeme samostatné `if`, mohou se vykonat **všechny** platné větve najednou.

```csharp
int utok = 20;

if (utok > 15)
{
    Console.WriteLine("Kritický zásah!");
}
if (utok >= 5)
{
    Console.WriteLine("Zásah nepřítele");
}
if (utok < 5)
{
    Console.WriteLine("Nepřítel se ubránil");
}
// Vypíše obě první podmínky, protože 20 > 15 i 20 >= 5
```

---

## Spojování podmínek

### `&&` — A ZÁROVEŇ (obě musí platit)

```csharp
int vek = 30;

if (vek >= 18 && vek < 120)
{
    Console.WriteLine("Zletilá osoba");
}
```

### `||` — NEBO (stačí, aby platila jedna)

```csharp
string zkratka = "CZ";

if (zkratka == "CZ" || zkratka == "SK")
{
    Console.WriteLine("Čechoslováci, vítejte!");
}
```

---

## Příklad: pozdrav podle jazyka

```csharp
Console.WriteLine("Zadejte zkratku: CZ / SK / EN / DE / FR / ES");
string zkratkaStatu = Console.ReadLine();

if (zkratkaStatu == "CZ")
{
    Console.WriteLine("Ahoj");
}
else if (zkratkaStatu == "SK")
{
    Console.WriteLine("Dobrý deň");
}
else if (zkratkaStatu == "EN")
{
    Console.WriteLine("Hello");
}
else if (zkratkaStatu == "DE")
{
    Console.WriteLine("Guten Tag");
}
else if (zkratkaStatu == "FR")
{
    Console.WriteLine("Bonjour");
}
else if (zkratkaStatu == "ES")
{
    Console.WriteLine("Hola");
}
else
{
    Console.WriteLine("Zkratku neznám.");
}
```

---

## ⚠️ Důležité poznámky
- Podmínka se píše do **kulatých závorek**: `if (podminka)`
- Kód uvnitř podmínky do **složených závorek**: `{ ... }`
- `=` je přiřazení, `==` je porovnání — pozor na záměnu!
- Pořadí `else if` je důležité — vykoná se první platná větev
