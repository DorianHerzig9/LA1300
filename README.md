# Projekt-Dokumentation zu LA1300

## NumberGesserSpiel 2.0 

Dorian Herzig

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|18.08.2023| 0.1 | Heute habe ich mich über die Soundfunktion in C# informiert. |
|25.08.2023| 0.2 | Heute habe ich mich dafür entschieden, dass ich nur einen Score und Multiplaymodus mache. |
|01.09.2023| 0.3 | Heute habe ich an meinem Projekt gearbeitet und herumprobiert. |
|08.09.2023| 0.4 | Heute habe ich wieder an meinem Projekt gearbeitet, aber ich werde noch Zuhause arbeiten müssen. |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt will ich mein ehemaliges NumberGesserSpiel mit mehr Funktionen verbessern und ausstatten. 

### 1.2 User Storys

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1.   | Kann | Qualität | Als ein User möchte ich einen Score haben, damit ich mich mit anderen vergleichen kann. |
| 2.   | Muss | Qualität | Als ein User möchte ich einen Score habe, bei welchem ich sehe, wie viel Züge ich gebraucht habe. |
| 3.   | Muss | Qualität | Als ein User möchte ich einen Multiplayer-Modus haben, damit ich gegen einen Gegner spielen kann. |
| 4.   | Muss | Qualität | Als ein User möchte ich einen Multiplayer-Modus haben, damit ich sehen kann, wer gewonnen hat. |

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

### 1.4 Diagramme

<img width="356" alt="image" src="https://github.com/DorianHerzig9/LA1300/assets/110893245/5311463d-6f32-4f50-8251-72bbf35b7c98">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A |08.09.2023|Dorian| Code Kosmetik | 90-120 min |
| 2.B |08.09.2023|Dorian| Classen erstellen | 120-165 min|
| 3.C |08.09.2023|Dorian| Multiplayer implementieren | 120-165 min |
| 4.D |08.09.2023|Dorian| Score implementieren | 120-165 min |
| 5.E |08.09.2023|Dorian| Portfolioeintrag | 90-120 min|

Total: 18 Arbeitspakete 
1 = 45 min

## 3 Entscheiden

Ich habe ein gutes Gefühl, dass ich die Funktionen schaffe. Doch ich fühle mich noch nicht so sicher beim Programmieren von Klassen und wie sich sie richtig einsetzen muss.
Ich tendiere dazu, dass ich Probleme mit den Klassen bekommen werde.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A	 | 08.09.2023 | Dorian | 90-120 min	 | ~ 90 min  |
| 2.B	 | 08.09.2023 | Dorian | 120-165 min | ~ 105 min |
| 3.C	 | 08.09.2023 | Dorian | 120-165 min | ~ 145 min |
| 4.D	 | 08.09.2023	| Dorian | 120-165 min | ~ 150 min |
| 5.E	 | 08.09.2023 | Dorian | 90-120 min	 | ~ 60 min  |

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 15.09.2023 | OK | Dorian |
| 1.2  | 15.09.2023 | NOK | Dorian |
| 1.3  | 15.09.2023 | OK | Dorian |
| 2.1  | 15.09.2023 | NOK | Dorian |
| 2.2  | 15.09.2023 | NOK | Dorian |
| 2.3  | 15.09.2023 | OK | Dorian |
| 3.1  | 15.09.2023 | OK | Dorian |
| 3.2  | 15.09.2023 | OK | Dorian |
| 3.3  | 15.09.2023 | NOK | Dorian |
| 4.1  | 15.09.2023 | OK | Dorian |
| 4.2  | 15.09.2023 | NOK | Dorian |
| 4.3  | 15.09.2023 | OK | Dorian |
| 4.4  | 15.09.2023 | OK | Dorian |

# NOK
| TC-№ | Grund |
| ---- | ----- |
| 1.2  | Der Score wird nicht während dem Spiel angezeigt. |
| 2.1  | Der Score wird nicht während dem Spiel angezeigt. |
| 2.2  | Der Score wird nicht während dem Spiel angezeigt. |
| 3.3  | Das Programm schaltet sich ab. |
| 4.2  | Es gibt kein Unentschieden. |

## 6 Auswerten

Ich glaube, dass ich das Projekt erfüllen konnte. Doch das, mit Hilfe von ChatGPT und Mitschülern. Am meisten Probleme hatte ich bei den Klassen.
Um im Programmieren von Klassen besser zu werden, werde ich mich in naher Zukunft mich weiter mit Klassen vertiefen.

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
