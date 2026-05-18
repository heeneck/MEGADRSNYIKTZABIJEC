# S06 — Stavební parcela 🔀

## Popis
Tuny dřeva ÷ 10 = balíky materiálu. m² parcely ÷ 75 = místa na domy.
Porovnej co je méně — to určuje počet domů a co zbyde.

```
Zadejte počet tun dřeva: 20
Zadejte počet m2 parcely: 750
Počet balíků materiálu na domy: 2
Počet míst na domy: 10
Zbyde 600m2 parcely, postaví se 2 domy. Došlo dřevo.
```

## 🔀 Přeházené řádky:
```
string vstupParcely = Console.ReadLine();
int materialNaDomy = tunyDreva / 10;
Console.Write("Zadejte počet m2 parcely: ");
int mistaNaParcele = m2Parcely / 75;
Console.WriteLine($"Počet balíků materiálu na domy: {materialNaDomy}");
if (materialNaDomy > mistaNaParcele)
{ int zbyvaDreva = ...; Console.WriteLine($"Zbyde {zbyvaDreva} tun dřeva..."); }
int tunyDreva = Convert.ToInt32(vstupDreva);
Console.WriteLine($"Počet míst na domy: {mistaNaParcele}");
string vstupDreva = Console.ReadLine();
else if (mistaNaParcele >= materialNaDomy)
{ int zbyvaM2 = ...; Console.WriteLine($"Zbyde {zbyvaM2}m2 parcely..."); }
int m2Parcely = Convert.ToInt32(vstupParcely);
Console.Write("Zadejte počet tun dřeva: ");
int zbyvaM2 = m2Parcely - (75 * materialNaDomy);
```
*Tip: nejdřív vstupy → výpočty → výpisy → podmínky. Řešení → `Reseni.cs`*
