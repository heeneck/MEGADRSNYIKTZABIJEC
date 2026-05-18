# P08 — Bankovní účet ⭐⭐⭐

## Popis
Simulace bankovního účtu s menu. Hráč může vkládat, vybírat peníze a zobrazit historii transakcí. Program ošetřuje chybové stavy (záporná částka, nedostatek prostředků).

## Procvičovaná témata
- `double` pro práci s penězi
- `List<string>` pro historii transakcí
- `while` cyklus jako hlavní menu
- Ošetření vstupů (záporné hodnoty, výběr více než je na účtu)
- Formátování čísel (`{castka:F2}` = 2 desetinná místa)
- `foreach` pro výpis historie

## Ukázka
```
══════════════════════
Zůstatek: 1350.00 Kč
══════════════════════
1. Vložit peníze
2. Vybrat peníze
3. Zobrazit historii
4. Odhlásit se
Volba: 2
Kolik chceš vybrat (Kč): 2000
Chyba: Nedostatek prostředků! Máš jen 1350.00 Kč.
```
