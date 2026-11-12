# Quellenübersicht

```dataview
TABLE autor, jahr, art, status, relevanz
FROM "02_Quellen"
WHERE typ = "quelle"
SORT relevanz DESC
```
