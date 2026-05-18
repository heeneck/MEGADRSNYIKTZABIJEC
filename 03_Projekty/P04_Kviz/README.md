# P04 — Kvíz s otázkami ⭐⭐

## Popis
Program provede hráče 5 otázkami z různých oblastí. Za každou správnou odpověď dostane bod. Na konci se zobrazí celkové skóre a hodnocení.

## Procvičovaná témata
- Pole `string[]` pro otázky i odpovědi
- `for` cyklus s indexem (`i`)
- Porovnání pole otázek a odpovědí (stejný index)
- `.ToLower().Trim()` pro tolerantní porovnání
- Počítadlo skóre

## Ukázka
```
Otázka 1/5: Jaká je hlavní město Francie?
Tvoje odpověď: paris
✓ Správně!

Otázka 2/5: Kolik planet je ve sluneční soustavě?
Tvoje odpověď: 9
✗ Špatně. Správná odpověď: 8

══════════════════════════
Výsledek: 4 / 5 bodů
Dobrá práce! Skoro jsi to dal/a.
```

## Jak přidat vlastní otázky?
Jednoduše přidej text do pole `otazky[]` a správnou odpověď (malými písmeny) na stejný index do pole `spravneOdpovedi[]`.
