# Z03 — Chatbot

## Zadání

Program obsahuje **2× pole 15 obecných frází**:
- První pole: odpovědi na běžné věty
- Druhé pole: odpovědi na otázky

Na počátku uživatel zadá své jméno.

V **nekonečném cyklu** uživatel zadává větu. Po napsání věty program bude **2 vteřiny čekat**, vyčistí se obrazovka.

Pokud věta **obsahuje otazník**, vybere náhodnou frázi z **pole 2**, pokud ne, vybere náhodnou frázi z **pole 1**.

Program následně vypíše:
```
Jonáš: Dneska jsem si koupil novou hopsakouli.
GJSBOT: To mě upřímně vůbec nepřekvapuje.
```

## Témata
- `string[]` pole s 15 frázemi (2×)
- `while (true)` nekonečný cyklus
- `string.Contains("?")` pro detekci otázky
- `Random.Shared.Next()` pro výběr náhodné fráze
- `Thread.Sleep(2000)` pro čekání
- `Console.Clear()` pro vyčištění obrazovky

## Ukázka frází
**Pole 1 (odpovědi na věty):**
- "To mě upřímně vůbec nepřekvapuje."
- "Zajímavé. Řekni mi víc."
- "Hmm, to si pamatuji."
- ... (celkem 15)

**Pole 2 (odpovědi na otázky):**
- "Na to se ptáš mě?"
- "Dobrá otázka. Sám nevím."
- "Odpověď je 42."
- ... (celkem 15)
