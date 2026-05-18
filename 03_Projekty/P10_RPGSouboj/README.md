# P10 — RPG Souboj ⭐⭐⭐⭐

## Popis
Tahový RPG souboj hráče (jméno dle výběru) proti bossovi „Drak Karthus". Hráč vybírá ze 4 akcí (útok, silný útok, obrana, léčení), každá pracuje s manou. Nepřítel se každé 3 kola posiluje. Hra skončí, když jeden z bojovníků padne.

## Herní mechaniky
| Akce | Efekt | Cena many |
|------|-------|-----------|
| Útok | 10–20 zranění | zdarma |
| Silný útok | 25–40 zranění | 15 many |
| Obrana | blokuje příští útok | 10 many |
| Léčení | +20–35 HP | 20 many |

- Mana se automaticky regeneruje (+5 za kolo)
- Nepřítel má 25% šanci na silný útok ("ohnivý dech")
- Nepřítel se každé 3 kola posiluje

## Procvičovaná témata
- Více propojených proměnných (HP, mana, útok)
- `while` cyklus s podmínkou na životy obou bojovníků
- `Random.Shared.Next` pro variabilitu bojů
- Složitější podmínky a herní logika
- Barvy konzole pro přehledné zobrazení
- Lokální metoda (`void VypisHP(...)`)
- Operátor modulo `%` pro periodické efekty (kolo % 3 == 0)

## Ukázka
```
══ KO L O  4 ══

           Hrdina: [100/100] [██████████]
   Mana: 45/50

      Drak Karthus: [ 68/120] [█████░░░░░]

⚔ Hrdina zaútočil za 17 zranění!
🔥 Drak Karthus použil OHNIVÝ DECH za 31 zranění! → ZABLOKOVÁNO štítem!
⬆ Drak Karthus zesílil! (+2 útok)
```
