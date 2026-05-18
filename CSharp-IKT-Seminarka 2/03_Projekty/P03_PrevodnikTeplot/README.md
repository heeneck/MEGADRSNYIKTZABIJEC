# P03 — Převodník teplot ⭐

## Popis
Uživatel zadá teplotu a jednotku (C / F / K), program ji převede do zbývajících dvou jednotek.

## Vzorce
- **°C → °F:** `(C × 9/5) + 32`
- **°F → °C:** `(F - 32) × 5/9`
- **°C → K:** `C + 273.15`

## Procvičovaná témata
- Vstup a převod na `double`
- Podmínky `if / else if / else`
- Desetinná matematika
- `.ToUpper()` pro toleranci malých/velkých písmen
- Formátování výpisu (`{hodnota:F2}` = 2 desetinná místa)

## Ukázka
```
Teplota: 100
Jednotka (C / F / K): C

100°C =
  212.00 °F (Fahrenheit)
  373.15 K  (Kelvin)
```
