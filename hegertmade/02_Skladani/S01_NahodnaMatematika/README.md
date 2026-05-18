# S01 — Náhodná matematika 🔀

## Popis programu

Program má vygenerovat 3 náhodná čísla.
Všechna 3 čísla se vypíšou po uvítacím textu.
První dvě se sečtou a součet se uloží do proměnné.
Poté se vynásobí třetím číslem a toto se uloží do proměnné **vysledek**.
Vypíše se proměnná **vysledek** s textem `'Výsledek: '`.

## Jak by vypadal výpis programu po spuštění:
```
Vítej v programu
První číslo: 7
Druhé číslo: 3
Třetí číslo: 4
Výsledek: 40
```
*(7 + 3 = 10, pak 10 × 4 = 40)*

---

## 🔀 Přeházené řádky — seřaď je správně:

```
Console.WriteLine("Výsledek: " + vysledek);
int vysledek = soucet * cislo3;
Console.WriteLine("Vítej v programu");
Console.WriteLine("Druhé číslo: " + cislo2);
int soucet = cislo1 + cislo2;
Console.WriteLine("První číslo: " + cislo1);
Console.WriteLine("Třetí číslo: " + cislo3);
int cislo1 = Random.Shared.Next(1, 15);
int cislo2 = Random.Shared.Next(1, 15);
int cislo3 = Random.Shared.Next(1, 15);
```

---

*Řešení je v souboru `Reseni.cs`*
