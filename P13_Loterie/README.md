# P13 — Loterie 6/49 ⭐⭐

## Popis
Simulace klasické loterie. Hráč si vybere 6 čísel (1–49), program vylosuje 6 čísel a porovná shody. Vstup je ošetřen — nelze zadat číslo mimo rozsah ani duplicitu. Výsledek odpovídá kategoriím skutečné loterie.

## Procvičovaná témata
- `int[]` pole pro čísla hráče i losovaná čísla
- `for` + `while` cyklus pro validaci vstupu
- Zanořený `foreach` pro hledání shod
- Kontrola duplicit při losování i zadávání
- `Convert.ToInt32` a ošetření neplatného vstupu
- Podmínky pro výherní kategorie

## Ukázka
```
Číslo 1: 7
Číslo 2: 14
...

🎰 Losuju...

Tvoje čísla:      7 14 22 33 41 48
Losovaná čísla:   3 14 22  9 41 17

Shody:  14✓ 22✓ 41✓
Celkem shod: 3/6

😐 3 shody — malá výhra. Aspoň něco!
```
