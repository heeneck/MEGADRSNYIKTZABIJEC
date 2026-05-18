# 1. Datové typy a proměnné

## Co je proměnná?
Proměnná je "krabička" v paměti počítače, do které ukládáme hodnotu. Má **název** a **datový typ**.

---

## Základní datové typy

| Datový typ | Popis | Příklad hodnoty |
|------------|-------|-----------------|
| `int` | Celé číslo (kladné i záporné) | `25`, `-10` |
| `string` | Text (vždy v uvozovkách) | `"Karel"`, `"Ahoj světe"` |
| `double` | Desetinné číslo (tečka, ne čárka!) | `199.50`, `3.14` |
| `bool` | Pravda / nepravda | `true`, `false` |

---

## Vytvoření proměnných

```csharp
int vek = 25;
string jmeno = "Karel";
double cena = 199.50;
bool jeAktivni = true;
```

Proměnnou lze vytvořit i bez počáteční hodnoty a přiřadit ji později:

```csharp
// Vytvoření bez hodnoty
int pocetSkladem;
string adresaBydliste;

// Přiřazení hodnoty
pocetSkladem = 17;
adresaBydliste = "Vysočanské náměstí 500";
```

---

## Matematické operace s proměnnými

```csharp
int cislo = 5;
cislo = 300;             // přiřazení nové hodnoty → 300

int number = 20;
int result = number * 3; // výsledek je 60

int teplota = 20;
teplota = teplota - 5;   // nová hodnota: 15
```

### Sčítání, odčítání, násobení, dělení

```csharp
int cislo = 5;
cislo = cislo + 300; // → 305

cislo = cislo - 3;   // odčítání
cislo = cislo * 5;   // násobení
cislo = cislo / 4;   // dělení
```

### Zkrácené zápisy (fungují identicky)

```csharp
cislo += 300;  // stejné jako cislo = cislo + 300
cislo -= 3;    // stejné jako cislo = cislo - 3
cislo *= 5;    // stejné jako cislo = cislo * 5
cislo /= 4;    // stejné jako cislo = cislo / 4
```

---

## Přiřazení hodnoty z jiné proměnné

```csharp
int utok1 = 20;
int utok2 = 30;

int utok3 = utok1;       // utok3 = 20
int utok4 = utok2 - utok1; // utok4 = 10
```

---

## ⚠️ Důležité poznámky
- Název proměnné **nesmí začínat číslicí** (např. `1cislo` je špatně, `cislo1` je správně)
- Název **nesmí obsahovat mezery** (používej `camelCase`: `pocetSkladem`)
- Typ `double` používá **tečku**, ne čárku: `3.14` ✅, `3,14` ❌
- Typ `string` musí být vždy v **uvozovkách**: `"text"` ✅, `text` ❌
