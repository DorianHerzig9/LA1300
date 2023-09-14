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
| 1.   | Kann | Qualität | Als ein User möchte ich einen Score haben, damit ich mich mit mit anderen vergleichen kann. |
| 2.   | Muss | Qualität | Als ein User möchte ich einen Score habe bei welchem ich sehe wie viel züge ich gebraucht habe. |
| 3.   | Muss | Qualität | Als ein User möchte ich einen Multiplayermodus haben, damit ich gegen einen gegner spielen kann. |
| 4.   | Muss | Qualität | Als ein User möchte ich einen Multiplayermodus haben, damit ich sehen kann wer gewonnen hat. |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1 | Das Programm ist im Singleplayer-Modus gestartet und funktionsbereit | ------- | Der Score wird nicht angezeigt, da noch keine Züge gemacht wurden. |
| 1.2 | Der User hat bereits einige Züge gemacht im Singleplayer-Modus | ------- | Der aktuelle Score zeigt die Anzahl der bisherigen Züge im Singleplayer-Modus an. |
| 1.3 | Das Spiel im Singleplayer-Modus wurde beendet | ------- | Der endgültige Score wird angezeigt, und der User kann ihn mit anderen vergleichen. |
| 2.1 | Das Spiel im Singleplayer-Modus läuft, und der User hat noch keinen Zug gemacht | ------- | Der Score zeigt 0 Züge an. |
| 2.2 | Der User hat bereits einige Züge gemacht im Singleplayer-Modus | ------- | Der aktuelle Score zeigt die Anzahl der bisherigen Züge im Singleplayer-Modus an. |
| 2.3 | Das Spiel im Singleplayer-Modus ist beendet, und der User sieht das Endergebnis | ------- | Der endgültige Score zeigt die Gesamtanzahl der Züge an, die der User im gesamten Singleplayer-Spiel gemacht hat. |
| 3.1 | Das Programm wurde gestartet, und der User wählt den Multiplayer-Modus aus | ------- | Das Programm startet den Multiplayer-Modus, in dem zwei Spieler gegeneinander spielen können. |
| 3.2 | Das Programm wurde gestartet, und der User wählt den Einzelspieler-Modus aus | ------- | Das Programm startet den Einzelspieler-Modus, in dem nur ein Spieler spielt. |
| 3.3 | Das Programm wurde gestartet, und der User gibt eine ungültige Eingabe ein (weder Ja noch Nein)	 | Jain | Das Programm erkennt die ungültige Eingabe und fordert den User auf, eine korrekte Eingabe zu machen. |
| 4.1 | Das Multiplayer-Spiel ist beendet, und ein Spieler hat gewonnen | ------- | Das Ergebnis zeigt an, welcher Spieler gewonnen hat. |
| 4.2 | Das Multiplayer-Spiel ist beendet, und es gibt ein Unentschieden | ------- | Das Ergebnis zeigt an, dass das Spiel unentschieden endete. |
| 4.3 | Das Programm wurde im Einzelspieler-Modus gestartet | ------- | Es wird eine Meldung angezeigt, dass der Singleplayer-Modus gestartet wurde. |
| 4.4 | Das Programm wurde im Einzelspieler-Modus gestartet, und der User hat das Spiel beendet | ------- | Es wird eine Meldung angezeigt, dass das Singleplayer-Spiel beendet wurde, und der endgültige Score im Singleplayer-Modus wird angezeigt. |

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
