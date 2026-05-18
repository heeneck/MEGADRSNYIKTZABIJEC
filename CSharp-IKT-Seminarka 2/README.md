# 📚 C# — Výukový repozitář (IKT Seminárka)

Tento repozitář slouží jako přehled základů programování v jazyce **C#** pro výuku IKT.
Obsahuje výukové poznámky, miniprogramy z hodin a samostatné projekty různé obtížnosti.

---

## 📁 Struktura repozitáře

```
📦 Repozitář
├── 📂 01_Vysvetlivky/       ← Výukové poznámky ke každému tématu
├── 📂 02_Miniprogramy/      ← Miniprogramy procvičené v hodinách
└── 📂 03_Projekty/          ← 14 samostatných projektů (⭐ až ⭐⭐⭐⭐)
```

---

## 📖 01 — Výukové poznámky

| Soubor | Téma |
|--------|------|
| `01_Datove_typy.md` | Datové typy a proměnné (`int`, `string`, `double`, `bool`) |
| `02_Vypis_textu.md` | Výpis textu do konzole (`Console.WriteLine`, interpolace) |
| `03_Podminky.md` | Podmínky `if`, `else if`, `else`, operátory `&&` a `\|\|` |
| `04_Nahodna_cisla.md` | Generování náhodných čísel (`Random.Shared.Next`) |
| `05_Vstup_uzivatele.md` | Vstup z klávesnice (`Console.ReadLine`) |
| `06_Prevod_vstupu.md` | Převod textu na číslo (`Convert.ToInt32`, `Convert.ToDouble`) |
| `07_Doplnujici_prikazy.md` | Barvy, zvuk, čekání (`ForegroundColor`, `Beep`, `Sleep`) |
| `08_Prace_s_textem.md` | Práce se stringem (`ToUpper`, `Trim`, `Contains`, `Replace` …) |
| `09_Cykly.md` | Cykly `while` a `for` |
| `10_Pole_a_List.md` | Pole (array) a List — ukládání více hodnot |

---

## 🛠️ 02 — Miniprogramy z hodin

| Složka | Program | Témata |
|--------|---------|--------|
| `01_HraSSlovy` | Hra se slovy a náhodnými čísly | vstup, podmínky, Random |
| `02_KontrolaVeku` | Kontrola věku | vstup, Convert, podmínky |
| `03_VypozetVykonu` | Výpočet výkonu (P = U × I) | vstup, Convert, matematika |
| `04_NakupniSeznam` | Nákupní seznam | List, while, foreach |
| `05_GeneratorHesel` | Generátor hesel | pole, while, Random |

---

## 🚀 03 — Samostatné projekty

| Složka | Název | Obtížnost | Témata |
|--------|-------|-----------|--------|
| `P01_Kalkulacka` | Kalkulačka | ⭐ Lehká | vstup, Convert, podmínky, matematika |
| `P02_HadaniCisla` | Hádání čísla | ⭐ Lehká | Random, while, podmínky |
| `P03_PrevodnikTeplot` | Převodník teplot | ⭐ Lehká | vstup, Convert, matematika, podmínky |
| `P04_Kviz` | Kvíz s otázkami | ⭐⭐ Střední | pole, for, podmínky, skóre |
| `P05_TextovyAnalyzator` | Textový analyzátor | ⭐⭐ Střední | string metody, podmínky |
| `P06_SpravceKontaktu` | Správce kontaktů | ⭐⭐ Střední | List, while, foreach |
| `P07_VirtualniMazlicek` | Virtuální mazlíček | ⭐⭐⭐ Těžší | proměnné, while, podmínky, Random |
| `P08_BankovniUcet` | Bankovní účet | ⭐⭐⭐ Těžší | double, while, podmínky, vstup |
| `P09_Obesenec` | Oběšenec (Hangman) | ⭐⭐⭐ Těžší | pole, string, while, for |
| `P10_RPGSouboj` | RPG souboj | ⭐⭐⭐⭐ Nejtěžší | proměnné, Random, while, podmínky |
| `P11_Nasobilka` | Generátor násobilky | ⭐ Lehká | for, matematika, Random, procvičovací režim |
| `P12_BMI_Kalkulator` | BMI Kalkulátor | ⭐ Lehká | double, Convert, podmínky, matematika |
| `P13_Loterie` | Loterie 6/49 | ⭐⭐ Střední | pole, for, foreach, validace vstupu |
| `P14_TextovaAdventura` | Textová adventura | ⭐⭐ Střední | větvené podmínky, while, Thread.Sleep |

---

## 🔧 Jak spustit programy

Každý program je jeden soubor `Program.cs`. Spusť ho ve Visual Studio nebo Visual Studio Code:
1. Otevři složku projektu
2. Otevři `Program.cs`
3. Stiskni `F5` nebo spusť přes terminál: `dotnet run`

---

*Vytvořeno pro seminárku z IKT – C# základy*
