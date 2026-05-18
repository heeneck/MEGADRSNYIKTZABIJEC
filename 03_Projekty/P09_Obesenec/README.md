# P09 — Oběšenec (Hangman) ⭐⭐⭐

## Popis
Klasická slovní hra. Program náhodně vybere tajné slovo z pole. Hráč hádá písmena — za každé špatné přijde o jeden ze 6 pokusů. Postupně se odhaluje slovo, dokud ho hráč neuhodne nebo nevyčerpá pokusy.

## Procvičovaná témata
- `char[]` pole pro sledování odhalených písmen
- `string.Contains()` pro ověření, zda je písmeno ve slově
- `for` cyklus pro odkrývání písmen na správných pozicích
- `List<string>` pro zapamatování použitých písmen
- `while` cyklus s více podmínkami ukončení
- `continue` pro přeskočení kola při špatném vstupu

## Ukázka
```
Slovo má 12 písmen. Máš 6 pokusů.

Slovo: _ _ _ _ _ _ _ _ _ _ _ _
Pokusy: 6
Použitá písmena:

Hádat písmeno: a
✓ Výborně! Písmeno 'a' je ve slově!

Slovo: _ _ _ _ _ a _ _ _ a _ _
```
