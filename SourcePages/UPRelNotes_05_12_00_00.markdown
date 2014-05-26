
## Nuove Implementazioni
#### **Gestione Impegni: Sospensione Impegni** - (rif: ID6118) 
Nel caso di sospensione di impegni dalla Finestra "Gestione impegni" aggiunta la form che chiede se Liberare<br>
le Risorse, Pubblicare una Nota, ed il testo del Motivo della Sospensione. Nel caso vengano selezionati più impegni la form compare una sola volta e vale per tutti.


#### **(GS: 58440) Orario di fine evento nel modulo di rilevazione presenze - Ticket Nr. 37948** - (rif: ID6231) 
Aggiunta la colonna "Durata" nel modulo di rilevazione presenze per determinare l'orario di fine dell'impegno


#### **(GS: 59001) Visualizzazione di tutte le risorse del calendario - Ticket Nr: 37177** - (rif: ID6301) 
Inserito il campo per gestire il numero di risorse visibili nella vista corrente del calendario Web. Aggiunto anche un pulsante per incrementare tale numero fino al totale delle risorse del filtro corrente.


#### **(GS: 59003) Salvataggio l'ultima modalità di visualizzazione del calendario** - (rif: ID6302) 
Implementato il salvataggio su DB per utente, di tutte le proprietà del calendario Web tramite pulsante di "Salva Layout Calenario".<br>
Per ripristinare le proprietà di default è necessario andare in: Opzioni personali -> Ripristina Layout.<br>
Il dettaglio delle proprietà salvate è il seguente:<br>
<br>
- ultima visualizzazione utilizzata<br>
- flag "Mostra solo orario lavorativo " <br>
- flag "Mostra minuti " <br>
- flag " Mostra ora inizio "   <br>
- flag "  Mostra ora fine "   <br>
- flag "  Altezza automatica "   <br>
- Altezza Appuntamenti      <br>
- flag "  Adatta a cella "  <br>
- flag "  Mostra Weekend "   <br>
- flag "  Comprimi Weekend "   <br>
- Numero Giorni della vista giornaliera   <br>
- Larghezza Calendario    <br>
- Numero Intervalli Temporali   (solo per la vista Cronologica)<br>
- Numero di Risorse Per Pagina  per Vista<br>
- Tipologia di raggruppamento risorsa (solo per filtro Eventi)


## Modifiche
## Anomalie
#### **(GS: 58696) Form proprietà evento** - (rif: ID6281) 
Riprisitinata la possibilità di editare nella form evento  il numero posti.


#### **Errore nell'export in DOC della stampa** - (rif: ID6329) 
Risolto installando il service pack1 di Crystal Report.



