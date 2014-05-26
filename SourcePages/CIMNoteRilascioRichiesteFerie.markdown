
### 06.00.12.0
#### ![](../Upload/bug.gif) BUG: **Non si riesce a rifiutare le ferie** - (ID: 6626)
Corretto mal funzionamento che non permetteva di rifiutare le ferie.


#### ![](../Upload/bug.gif) BUG: **Risolta anomalia Rifiuto Ferie** - (ID: 6515)
Risolta l'anomalia che impediva di rifiutare le ferie di un operatore con grado dell'organigramma superiore a quello dell'autorizzatore.


### 06.00.10.0
#### ![](../Upload/nuovo.gif) NEW: **Aggiunta gestione Permesso legge 104 in tipologie di ferie** - (ID: 6436)
E' possibile ora inserire manualmente le nuove attività(tipi di permessi ferie ecc).<br>
Per aggiungere un nuovo permesso/ferie è sufficiente andare in tabelle di base <del>> ProprietàRapportini e nel tab TipologiediLavoro inserire una riga compilando i campi desiderati. Nel campo Indicatore sarà necessario specificare se si tratta di Ferie, lavoro malattia ecc.Successivamente occorrerà selezionare il tab Attività e inserire una riga collegata alla tipologia lavoro appena inserita(compilare il campo Tipologia lavoro con la tipologia appena inserita).<br>
Infine, se questa attività inserita ha il campo Scollegata impostato a SI, sarà necessario specificare(in basso nello stesso tab) se nei rapportini deve comparire in automatico con il codice cliente, la commessa, la sottocomessa oppure se deve comparire da sola.<br>
Se si sceglie di far comparire anche la commessa, è necessario andare nel menu del CIM e selezionare Commesse </del>> commesse di tutti, selezionare la commessa desiderata e nel sottotab "AttivitaCommesse" inserire la riga per collegare la commessa all attività.


### 06.00.9.0
#### ![](../Upload/nuovo.gif) NEW: **Aggiunta tipologia "Permessi non retribuiti" in richieste ferie** - (ID: 6333)
Ora è possibile effettuare delle richieste ferie con tipologia Permessi NON retribuiti.


#### ![](../Upload/bug.gif) BUG: **Inibita visualizzazione richieste ferie cancellate da form autorizzatori** - (ID: 6336)
Corretto visualizzazione della form degli autorizzatori. Ora le richieste cancellate non vengono più visualizzate.


### 06.00.7.0
#### ![](../Upload/bug.gif) BUG: **Messaggio Form richiesta Ferie senza a newline** - (ID: 6062)
Adesso il messaggio di riepilogo della form Richiesta ferie viene visualizzato correttamente andando a capo quando necessario.


### 06.00.6.0
#### ![](../Upload/modifica.gif) CHA: **Modifica calcolo ore ferie** - (ID: 4917)
Adesso il calcolo delle ore ferie è basato sulle ore lavorative dell'utente che le richiede.<br>
Quindi anche se le ore richieste sono superiori alle 8 ore standard, comunque ne vengono segnate 8.<br>
Inoltre, grazie al fatto che che il conteggio delle ore si basa su quelle lavorate dall'utente, a seconda della tipologia di quest'ultimo (part-time , full-time)vengono impostate a max 6 oppure max 8.


#### ![](../Upload/bug.gif) BUG: **Controlli da aggiungere ad Autorizzazione Ferie** - (ID: 5918)
Sono stati aggiunti alcuni controlli per evitare incongruenze nei dati delle richieste ferie, ovvero:<br>
- In richiesta ferie non vengono mai eliminate le righe. Le ferie non fatte ora settano un flag di cancellazione logica.<br>
- Il tipo ferie è stato reso obbligatorio.<br>
- Se si inserisce una richiesta ferie per un periodo precedente alla data in cui si è, ora l'operatore viene avvisato con un messaggio informativo.<br>
- Le ferie inserite in rapportino da richiesta ferie non sono più modificabili dalla maschera dei rapportini. L'utente le può eliminare ma viene avvisato e, se in caso di conferma, viene mandata una mail<br>
- In Consultazione Rapportini tali rapportini non sono modificabili (loccati) ma, se eliminati, inviano una mail (vedi rapportino).<br>
- Durante processo stampa presente mensili, bloccare e avvisare se esistono richieste autorizzate senza rapportini. Il messaggio deve essere informativo ma consentire di proseguire con l'elaborazione.<br>
- Schedulazione di una procedura di controllo che ogni giorno ci avvisa in caso di dati incongruenti.


#### ![](../Upload/bug.gif) BUG: **Non invia mail su richieste permessi retribuiti** - (ID: 5704)
Anomalia Risolta. Inserita nella nuova richiesta ferie la possibiltà di distinguere fra "ferie" e "permesso retribuito".<br>
Una volta effettuata la richiesta viene inviata una mail che specifica il tipo di ferie richiesto.<br>
Quando l'autorizzatore accetta o rifiuta una richiesta, viene inviata una notifica che ne specifica l'esito.


