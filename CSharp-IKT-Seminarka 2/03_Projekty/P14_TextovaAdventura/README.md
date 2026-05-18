# P14 — Textová adventura ⭐⭐

## Popis
Krátká větvená textová hra „Ztracený v lese". Hráč dělá dvě rozhodnutí, každá kombinace vede k jinému konci (3 různé konce celkem). Text se vypisuje pomalu znak po znaku pro atmosféru.

## Herní větve
```
Křižovatka
├── Doleva (voda)
│   ├── Požádej rybáře  → Konec 1 (šťastný)
│   └── Proplíž kolem   → Konec 2 (neutrální)
└── Doprava (světlo)
    ├── Zaklepej na chatu → Konec 3 (záhadný)
    └── Vrať se zpět      → Konec 1 (šťastný)
```

## Procvičovaná témata
- Větvené podmínky `if / else`
- `while` pro validaci vstupu (pouze "1" nebo "2")
- `foreach` přes znaky stringu (efekt psaní)
- `Thread.Sleep` pro dramatické pauzy
- Lokální metody (`void VypisPomaluNovyRadek`, `string ZeptejSe`)
- Barvy konzole pro různé nálady scén

## Ukázka
```
Probouzíš se uprostřed tmavého lesa. Nevíš, jak ses sem dostal/a.
Měsíc osvětluje dvě cesty před tebou.

Která cesta tě láká více?
  [1] Cesta doleva — slyšíš vzdálený zvuk vody
  [2] Cesta doprava — vidíš záblesk světla
```
