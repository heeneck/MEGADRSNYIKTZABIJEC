# P07 — Virtuální mazlíček (Tamagotchi) ⭐⭐⭐

## Popis
Hráč pojmenuje mazlíčka a pečuje o něj: krmí ho, hraje si s ním a nechává ho spát. Každá akce mění stavové ukazatele (hlad, štěstí, energie). Po každém kole se hodnoty přirozeně snižují — hra skončí, když mazlíček "umře".

## Procvičovaná témata
- Více proměnných reprezentujících "stav" hry
- `while` cyklus s více podmínkami (`hlad > 0 && stesti > 0`)
- `Random.Shared.Next` pro variabilitu akcí
- Podmínky a varování při nízkých hodnotách
- Grafické ukazatele v konzoli (pruhový graf znakem `█`)
- Lokální metoda (`void VypisUkazatel(...)`)

## Ukázka
```
╔══════════════════════════════════╗
║  Mazlíček: Flíček                ║
║  Kolo: 3                         ║
╚══════════════════════════════════╝

Hlad (sytost): [ 45/100] [████░░░░░░]
Štěstí       : [ 62/100] [██████░░░░]
Energie      : [ 30/100] [███░░░░░░░]
```
