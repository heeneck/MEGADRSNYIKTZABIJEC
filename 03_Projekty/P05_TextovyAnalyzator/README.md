# P05 — Textový analyzátor ⭐⭐

## Popis
Uživatel napíše libovolnou větu a program ji "rozebere": spočítá znaky a slova, vypíše různé verze textu a zkontroluje, zda obsahuje konkrétní slova nebo jakým typem věta je.

## Procvičovaná témata
- `.Length` — počet znaků
- `.Split(' ')` — rozdělení textu na slova (vrátí pole)
- `.Trim()` — oříznutí mezer
- `.ToUpper()` / `.ToLower()` — změna velikosti
- `.Contains()` — hledání v textu
- `.EndsWith()` — detekce konce věty
- `foreach` cyklus přes pole slov

## Ukázka
```
Napiš libovolnou větu:
> Ahoj světe, jak se máš?

══════ ANALÝZA TEXTU ══════
Počet znaků (včetně mezer): 25
Přibližný počet slov:       4
Velká písmena:   AHOJ SVĚTE, JAK SE MÁŠ?
Malá písmena:    ahoj světe, jak se máš?

══════ HLEDÁNÍ SLOV ══════
(žádný pozdrav nenalezen)

Věta je otázka (končí '?').
```
