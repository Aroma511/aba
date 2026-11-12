# Dashboard

## Forschungsfrage
![[Forschungsfrage & Ziel]]

## Offene Aufgaben
```tasks
not done
group by filename
limit 30
```

## Letzte Devlog-Einträge
```dataview
TABLE autor, dauerH AS "Stunden"
FROM "06_Entwicklung/Devlog"
WHERE typ = "devlog"
SORT datum DESC
LIMIT 5
```

## Mechaniken nach Status
```dataview
TABLE status, verantwortlich
FROM "03_Game-Design/Mechaniken"
WHERE typ = "mechanik"
SORT status ASC
```

## Kapitel-Status
```dataview
TABLE status, verantwortlich
FROM "08_Schreiben/Kapitel"
SORT file.name ASC
```

## Ungelesene Quellen
```dataview
TABLE autor, jahr, relevanz
FROM "02_Quellen"
WHERE typ = "quelle" AND status = "ungelesen"
SORT relevanz DESC
```

## Offene Probleme
```dataview
LIST
FROM "04_Technik/Probleme & Lösungen"
WHERE typ = "problem" AND status = "offen"
```

## Gesamte Arbeitszeit
```dataviewjs
const pages = dv.pages('"06_Entwicklung/Devlog"').where(p => p.typ == "devlog");
const h = pages.map(p => Number(p.dauerH) || 0).reduce((a,b) => a+b, 0);
dv.paragraph("Gesamt: " + h + " Stunden");
```
