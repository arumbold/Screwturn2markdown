
## Introduzione
Questo articolo ha lo scopo di spiegare il funzionamento generale dell'interfaccia dell'applicazione web.

I dati desiderati dall'utente sono disponibili per la visualizzazione o per la modifica grazie al supporto di una serie di videate; ognuna di queste è legata ad un insieme di funzioni e di dati differente.

Per aprire le videate dell'applicazione occorre utilizzare il menu posizionato alla sinistra del browser; aprendo le videate saranno disponibili ulteriori  comandi per gestire i dati che esse contengono.

Ogni videata ha al suo interno uno o più pannelli, i contenitori dei dati di interesse. Tramite i comandi di pannello è possibile agire direttamente su tali dati. 

### Applicabilità
Le informazioni di questo documento si applicano ai seguenti prodotti sviluppati da [Apex-net](htp://www.apex-net.it).

* Cim - Company Internal Management
* SDS - Schema Documentation System
* ADA - Apen-net Data Analyzer
* CORO - Gestione Punti
* KIMProject - Integrazione KIM con Project Server
* CPR -
* Placement - Gestione Placement Università
* CARCLI - Gestione Cartella Clinica

## Menu
![Esempio di menu](../Upload/menu.gif)
Il menu dell'applicazione è composto da un elenco di gruppi di comandi. Inizialmente ogni gruppo è chiuso e non mostra i comandi che sono presenti al suo interno.

Sarà sufficiente cliccare sul nome del gruppo desiderato per far si che il gruppo si apra, ovvero che vengano mostrati i comandi che contiene.

Subito dopo l'apertura dell'applicazione il sistema non presenta videate aperte. Per poter aprire una videata (Form) ed agire così sui dati bisogna usare i comandi del menu.

Nell'immagine che riportiamo sulla destra, il menu presenta un solo gruppo di comandi (Tabelle) che contiene diversi comandi, i quali aprono ciascuno una videata; cliccando, ad esempio, sulla voce Prodotti si aprirà la videata che mostra l'elenco dei prodotti.

Per nascondere i comandi del gruppo è sufficiente cliccare ancora una volta sul suo nome. 



## Videate
![Esempio di lista videate aperte](../Upload/vidlist.gif)
Abbiamo visto che è possibile accedere alle varie videate dell'applicazione utilizzando i comandi del menù.

E' possibile aprire contemporaneamente più videate, ed in questo caso l**'elenco delle videate aperte** viene visualizzato subito sotto al menu di applicazione con un menu a linguette, come si vede nell'immagine qui a fianco. 

Nell'esempio ci sono due videata aperte: ordini e prodotti. Il nome della **videata attiva** viene evidenziato dalla linguetta di colore bianco. Inoltre il nome della videata attiva appare nella barra del titolo della videata, come si vede dal secondo esempio sulla destra.

Nella barra del titolo, inoltre, è presente il **pulsante di chiusura** della videata: ![closex](../Upload/closex.gif). Cliccando su questo pulsante, la videata corrente viene chiusa e ne viene mostrata un'altra tra quelle attualmente aperte.

Sotto all'elenco delle videate aperte possiamo invece vedere il pulsante ![closex](../Upload/clall.gif), che chiude tutte le videate aperte e mostra la pagina di benvenuto.

All'estremità superiore destra del browser notiamo la presenza di un pulsante uguale a quello per la chiusura di una singola finestra. Quest'ultimo chiude l'intera sessione di lavoro eseguendo il **logout** (scollegamento) dell'utente e riportando l'applicazione alla schermata di login. 

![Esempio di titolo della videata](../Upload/vidcap.gif)
Notiamo infine che nella barra di stato del browser, ovvero l'area grigia posta nella parte inferiore del browser, vengono visualizzati dei **messaggi informativi** rispetto al campo della videata in cui è posizionato il cursore (per posizionare il cursore su un campo è sufficiente cliccarci sopra una volta).

### Comandi delle videate
Riportiamo ora un elenco dei comandi disponibili per la visualizzazione e la gestione delle videate.

<table cellpadding="2">
<td>![hidemenu](../Upload/hidemenu.gif)</td>
<td>Questo pulsante è situato in alto a sinistra, a fianco del nome dell'applicazione e nasconde il menu aumentando l'area disponibile per la visualizzazione e la gestione dei dati.</td>
<tr>
<td>![hidemenu](../Upload/showmenu.gif) </td>
<td>Questo pulsante diventa visibile solo a menu nascosto e compie invece l'operazione inversa e mostra il menu appena nascosto.</td>
</tr><tr>
<td>![collapse](../Upload/collapse.gif) </td>
<td>Questo pulsante riduce una parte della videata riducendola ad una semplice riga</td>
</tr><tr>
<td>![expand](../Upload/expand.gif) </td>
<td>Questo pulsante compie l'operazione inversa ed espande la videata ridotta.  </td>
</tr><tr>
<td>![lock](../Upload/lock.gif) </td>
<td>Questo pulsante (lucchetto chiuso) indica che i dati del pannello sono bloccati, e pertanto finché la videata resta in questo stato non è possibile modificare tali dati. Cliccandolo la videata si sblocca, permettendo la modifica.</td>
</tr><tr>
<td>![unlk](../Upload/unlk.gif)</td>
<td>Questo pulsante  (lucchetto aperto) compie l'operazione inversa a quella appena descritta, ovvero blocca la possibilità di modificare i dati del pannello.</td>
</tr>
</table>


## Pannelli
![Esempio di pannello in lista](../Upload/panel.gif)
Solitamente all'apertura di una videata il pannello si predispone per l'inserimento dei **criteri di ricerca**. In questo modo potrete selezionare i dati che vi interessano inserendo degli "esempi" nei campi.

Per **eseguire la ricerca** dovrete  cliccare sul pulsante ![find_sm](../Upload/find_sm.gif). Se non inserite alcun esempio, verranno trovati tutti i dati. E' possibile capire se il pannello si trova in questo stato dalla scritta nella riga del titolo, come mostrato dall'immagine a sinistra.

Per effettuare ricerche speciali è possibile utilizzare i caratteri speciali indicati nel riquadro seguente.

Dopo aver premuto il tasto "esegui ricerca", verranno mostrati i dati a video. A questo punto potrete **scorrerli o modificarli**. Se li modificate il pannello lo segnala nella riga del titolo, come si vede nelle immagini a sinistra. 

Dopo aver completato la modifica dovete premere il tasto ![update_sm](../Upload/update_sm.gif) per **salvare le modifiche** oppure potete premere il tasto ![cancel_sm](../Upload/cancel_sm.gif) per **annullarle**.

Gli altri tasti presenti nella barra del titolo del pannello sono illustrati nei riquadri che seguono.

E' possibile che la videata contenga altri comandi che attivano funzioni specifiche; in questo caso riferitevi alla documentazione specifica della videata per avere ulteriori informazioni.

![Pannello in stato Criteri di ricerca (QBE)](../Upload/panqbe.gif)
![Pannello in stato Visualizzazione Dati](../Upload/panqbe.gif)
![Pannello in stato Dati Modificati](../Upload/panupd.gif)











### Filtri di ricerca
Elenco dei filtri di ricerca disponibili

<table cellpadding="2">
<td>**> valore**</td>
<td>Trova i dati che in quel campo hanno un valore maggiore o uguale a quello inserito  </td>
</tr><tr>
<td>**< valore **</td>
<td>Trova i dati che in quel campo hanno un valore minore o uguale a quello inserito</td>
</tr><tr>
<td>**% o * è un carattere "jolly"**</td>
<td>Indica che può esserci un valore qualsiasi al suo posto (per esempio %como trova tutti i record il cui campo del criterio finisce con "como", mentre scrivere %co% fa ricercare tutti i dati che in quel campo hanno un valore che ha al suo interno la parola "co", in questo caso la parola giaCOmo verrebbe trovata).</td>
</tr><tr>
<td>**=** </td>
<td>Trova i record che in quel campo hanno un valore uguale a quello indicato</td>
</tr><tr>
<td>**#**</td>
<td>Trova i record che in quel campo hanno un valore diverso da quello indicato</td>
</tr><tr>
<td>**.**</td>
<td>Trova tutti i record per cui in quel campo è stato introdotto un valore </td>
</tr><tr>
<td>**!**</td>
<td>Trova tutti i record per cui quel campo è stato lasciato vuoto </td>
</tr><tr>
<td>**valore1:valore2**</td>
<td>Trova tutti i record il cui valore del campo selezionato è compreso tra value1 e value2</td>
</tr><tr>
<td>**combinazioni**</td>
<td>E' possibile combinare gli effetti dei vari operatori mediante l'uso del punto e virgola. (es. <10; 20:30 - trova tutti i valori minori o uguali a 10 oppure quelli compresi tra 20 e 30). </td>
</tr>
</table>

### Comandi di Pannello
<table cellpadding="2">
<td>![next](../Upload/next.gif)</td>
<td>Vai alla prossima riga</td>
</tr><tr>
<td>![prev](../Upload/prev.gif)</td>
<td>Vai alla riga precedente</td>
</tr><tr>
<td>![top](../Upload/top.gif)</td>
<td>Vai all'ultima riga</td>
</tr><tr>
<td>![bottom](../Upload/bottom.gif)</td>
<td>Vai alla prima riga</td>
</tr><tr>
<td>![search](../Upload/search.gif)</td>
<td>Mette il pannello il modalità di ricerca</td>
</tr><tr>
<td>![list](../Upload/list.gif)</td>
<td>Permette di cambiare la modalità di visualizzazione corrente</td>
</tr><tr>
<td>![list](../Upload/list.gif)</td>
<td>Permette di cambiare la modalità di visualizzazione corrente. In modalità "dettaglio"  la finestra presenta i dati trovati una riga per volta, con una grafica solitamente più comoda per l'inserimento e la modifica dei dati. In modalità "lista" invece vengono presentati più risultati contemporaneamente, in una tabella. In questa modalità è possibile avere alcuni campi al di fuori della tabella, per permettere una visualizzazione migliore dei dati più importanti relativi alla riga correntemente selezionata</td>
</tr><tr>
<td>![cancel](../Upload/cancel.gif)</td>
<td>Annulla le modifiche fatte ai dati</td>
</tr><tr>
<td>![refresh](../Upload/refresh.gif)</td>
<td>Aggiorna il pannello eseguendo una nuova ricerca</td>
</tr><tr>
<td>![new](../Upload/new.gif)</td>
<td>Si posiziona ad una nuova riga e si prepara per l'inserimento </td>
</tr><tr>
<td>![dupl](../Upload/dupl.gif)</td>
<td>Duplica la riga attuale</td>
</tr><tr>
<td>![delete](../Upload/delete.gif)</td>
<td>Cancella la riga attuale</td>
</tr><tr>
<td>![update](../Upload/update.gif)</td>
<td>Salva le modifiche fatte ai dati del pannello     </td>
</tr><tr>
<td>![print](../Upload/print.gif)</td>
<td>Attiva la funzione di stampa, se attiva per questo pannello</td>
</tr>
</table>
