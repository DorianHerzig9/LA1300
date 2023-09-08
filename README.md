# Projekt-Dokumentation zu LA1300

## NumberGesserSpiel 2.0 

Dorian Herzig

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|18.08.2023| 0.1 | Heute habe ich mich über die Sound fünktion in C# informiert. |
|25.08.2023| 0.2 | Heute habe ich mich dafür entschieden, das ich nur eine Score und Multiplaymodus mache. |
|01.09.2023| 0.3 | Heute habe ich an meinem Projekt gearbeitet und rumprobiert. |
|08.09.2023| 0.4 | Heute habe ich wieder an meinem Projekt gearbeitet aber ich werde noch Zuhause arbeiten müssen. |
|  |  |  |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt will ich mein ehemaliges NumberGesserSpiel mit mehr funktionen verbessern und ausstatten. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
###| 1.   | Muss | Qualität | Als ein User möchte ich Sounds hören, damit man weiss, wann man Gewonnen hat. |###
| 2.   | Muss | Qualität | Als ein User möchte ich einen Score habe bei welchem ich sehe wie viel züge ich gebraucht habe. |
| 3.   | Muss | Qualität | Als ein User möchte ich einen Multiplayermodus haben, damit ich gegen einen gegner spielen kann. |
| 4.   | Muss | Qualität | Als ein User möchte ich einen Multiplayermodus haben, damit ich sehen kann wer mit weniger Zügen die Zahl gefunden hat. |

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm ist gestartet und funktionsbereit | Spieler giebt eine korekte Zahl ein | Das Programm gibt einen Sound aus |
| 2.1  | Das Programm ist gestartet und funktionsbereit | Spieler giebt eine eine falsche Zahl ein | Das Programm gibt einen Sound aus |
| 3.1  | Das Programm ist gestartet und funktionsbereit | Spieler giebt eine eine nicht gültige Zahl ein | Das Programm gibt einen Sound aus |
| 4.1  | Das Programm wurde gestartet und es wird gefragt ob man den Multiplayermodus wählen will| Ja | Das Programm führt einen Spielmodus aus in welchem zwei User spielen können |
| 4.2  | Das Programm wurde gestartet und es wird gefragt ob man den Multiplayermodus wählen will | Nein | Das Programm führt einen Spielmodus aus in welchem nur ein User spielen kann|
| 4.3  | Das Programm wurde gestartet und es wird gefragt ob man den Multiplayermodus wählen will | Jain | Das Programm bemerkt die falsche eingabe und bittet den User auf eine korekte eingabe zu machen|

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

<img width="356" alt="image" src="https://github.com/DorianHerzig9/LA1300/assets/110893245/5311463d-6f32-4f50-8251-72bbf35b7c98">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A |08.09.20323|Dorian| Code Kosmetik | 90-120 min |
| 2.B |08.09.20323|Dorian| Classen erstellen | 120-165 min|
| 3.C |08.09.20323|Dorian| Multiplayer implementieren | 120-165 min |
| 4.D |08.09.20323|Dorian| Score implementieren | 120-165 min |
| 5.E |08.09.20323|Dorian| Portfolioeintrag | 90-120 min|

Total: 18 Arbeitsparkete 
1 = 45 min

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
