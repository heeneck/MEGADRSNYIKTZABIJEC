# Z02 — Brainrot counter

## Zadání

V programu uživatel zadává věty, dokud nenapíše `"STOP"`.

Pokud text obsahuje nějaké brainrot slovíčko, vloží se text do pole stringů (využít můžeš i `List<string>`).

Jakmile cyklus skončí zadáním `"STOP"`, vypíše se obsah pole stringů + kolik vět to bylo:

```
Brainrot detekován v 8 větách
```

## Témata
- `List<string>` pro ukládání brainrot vět
- `while` cyklus s podmínkou na `"STOP"`
- `string.Contains()` pro detekci slovíček
- výpis celého listu pomocí `foreach`

## Brainrot slovíčka (příklady)
Vyber si aspoň 5, např.: `"skibidi"`, `"rizz"`, `"sigma"`, `"gyatt"`, `"fanum"`, `"mewing"`, `"ohio"`, `"aura"`

## Ukázka výstupu
```
Zadej větu (nebo STOP pro ukončení): Dneska byl sigma výlet
Zadej větu (nebo STOP pro ukončení): Šli jsme do kina
Zadej větu (nebo STOP pro ukončení): Ten film byl fanum tax
Zadej větu (nebo STOP pro ukončení): STOP

Brainrot věty:
- Dneska byl sigma výlet
- Ten film byl fanum tax

Brainrot detekován v 2 větách
```
