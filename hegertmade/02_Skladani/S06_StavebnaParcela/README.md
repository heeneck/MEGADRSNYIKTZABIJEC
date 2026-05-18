# S06 — Stavební parcela 🔀

## Popis programu

V programu uživatel zadá počet tun dřeva a počet m² stavební parcely.

- Počet tun dřeva ÷ 10 = počet balíků materiálu na domy
- Velikost parcely ÷ 75 = počet domů, které se na parcelu vejdou

**Pokud je materiál na domy vyšší než místa na parcele:**
- vynásobí počet tun na 1 dům (10) × počtem míst na parcele
- odečte od celkového počtu tun → zjistí, kolik tun dřeva zbyde
- vypíše kolik tun dřeva zbyde + počet míst na parcele (= počet domů)

**Pokud je počet míst na parcele vyšší než materiál:**
- vynásobí počet m² na 1 dům (75) × počtem balíků materiálu
- odečte od celkového m² → zjistí, kolik m² zbyde
- vypíše kolik m² zbyde + kolik máme materiálu (= počet domů)

## Jak by vypadalo spuštění programu:
```
Zadejte počet tun dřeva: 20
Zadejte počet m2 parcely: 750
Počet balíků materiálu na domy: 2
Počet míst na domy: 10
Zbyde 600m2 parcely, postaví se 2 domy. Došlo dřevo.

Zadejte počet tun dřeva: 200
Zadejte počet m2 parcely: 300
Počet balíků materiálu na domy: 20
Počet míst na domy: 4
Zbyde 160 tun dřeva, postaví se 4 domy. Parcely jsou obsazené.
```

---

## 🔀 Přeházené řádky — seřaď je správně:

```
string vstupParcely = Console.ReadLine();
int materialNaDomy = tunyDreva / 10;
Console.Write("Zadejte počet m2 parcely: ");
int mistaNaParcele = m2Parcely / 75;
Console.WriteLine($"Počet balíků materiálu na domy: {materialNaDomy}");
if (materialNaDomy > mistaNaParcele)
{
    [ZDE BUDE 1 PŘÍKAZ]
    Console.WriteLine($"Zbyde {zbyvaDreva} tun dřeva, postaví se {mistaNaParcele} domy. Parcely jsou obsazené.");
}
int tunyDreva = Convert.ToInt32(vstupDreva);
int zbyvaDreva = tunyDreva - (10 * mistaNaParcele);
Console.WriteLine($"Počet míst na domy: {mistaNaParcele}");
string vstupDreva = Console.ReadLine();
else if (mistaNaParcele >= materialNaDomy)
{
    [ZDE BUDE 1 PŘÍKAZ]
    Console.WriteLine($"Zbyde {zbyvaM2}m2 parcely, postaví se {materialNaDomy} domy. Došlo dřevo.");
}
int m2Parcely = Convert.ToInt32(vstupParcely);
Console.Write("Zadejte počet tun dřeva: ");
int zbyvaM2 = m2Parcely - (75 * materialNaDomy);
```

*Tip: Nejdřív přečti vstupy, pak proveď výpočty, pak vypiš výsledky, pak podmínky.*

---

*Řešení je v souboru `Reseni.cs`*
