# Dynamický model prípadov použitia
[PDF s textom práce](https://www.overleaf.com/read/sybmxbjsbzyv)
## Cieľ
Analyzujte vybraté metódy modelovania v softvérovom inžinierstve (napríklad
Executable UML a Object Action Language), interaktívnej grafiky v Unity, ako
aj existujúci prototyp animácie dynamiky UML modelu.
Cieľom práce bude obohatiť existujúci prototyp modelovania softvérovej
architektúry a jej funkcionality o dynamický model podľa OAL skriptu alebo
programu v jazyku Python.

## Popis projektu
Pričinok `parser` obsahuje `C#` projekt, ktorý používa `ANTLR`. Program dokáže parsovaním vstupného súboru JSON, ktorý obsahuje prvky jazyka OAL popisujúce animaciu triedneho diagramu v programe `AnimArch`, vytvorit JSON súbor
reprezentujúci zodpovedajúci sekvenčný diagram pre program `SQL Tunder`

## Postup prác

| Dátum | Popis |
|-------|-------|
| október 2022 | Prvé stretnutie k DP |
| november 2022 | Inštalácia, prvotné spustenie a zoznamenie sa s potrebnými prostrediami SQD_Tunder a AnimArch  |
| december 2022| Hľadanie vedeckých článkov pre DP, tvorba sekvenčných diagramov pomocou SQD_Tunder a tvorba animacií v AnimArch|
| január 2023 | Štúdiom tvorby softvéru v Unity a jazyku C#|
|február 2023| Štúdium nástroju ANTLR|
|marec 2023| Śtúdium súborov reprezentujúcich sekvnenčný diagram pre SQD Tunder a súborov reprezentujúcich animaciu v AnimArch, ručne produkovanie OAL kodu popisujúceho animaciu v AnimArch|
|apríl 2023| Vytovrenie prvotného projektu pre ANTLR pre konvertovanie OAL kodu z nastroju AnimArch na súbor so sekvenčným diagramom pre program SQD_Tunder (prvé úspešné parsovanie OAL s ANTLR), hľadanie relevantných vedeckých článkov |
|máj 2023| Pokračovanie v hľadaní a študovaní relevantných článkov, pokračovanie na prácach na projekte s ANTLR, príprava potrebných dokumentov pre projektový seminár|
|september - november 2023| Implementácia možnosti generovať sekvenčý diagram obsahujúci rozne urovne vnorenia ALT, IF fragmentov (rekurzívne), študovanie podobných predošlych DP prác, písanie textu práce |
|december 2023| Písanie textu práce, príprava materiálova na `Projektový seminár 2`, finálne úpravy ALT, IF fragmentov|


## Plán prác

| Dátum | Popis |
|-------|-------|
| január - február 2024 | Dokončenie implementácie, testovanie, písanie práce |
| marec - máj 2024 | Písanie práce, evaluácia |

