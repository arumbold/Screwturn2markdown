
##  Scenario 
In una master query di un pannello vengono utilizzati due campi che puntano ad uno stesso campo di db. 
I due campi venivano utilizzati uno nella parte qbe per poter fare selezioni con loock up e altro nella parte di visualizzazione e inserimento.
Al momento dell'inserimento di un nuovo record veniva restituito il seguente errore:
Column name 'PRG_VERS_PIAN' appears more than once in the result column list.
Infatti la query di insert ripete due volte il campo riportato nell'errore.


##  Come risolvere 
Di seguito il soluzione proposta da progamma.
Il problema è dovuto al connector .NET verso SqlServer che "analizza" l'espressione della query di Select e cerca di capire quali siano le colonne da utilizzare per gli inserimenti, gli aggiornamenti e le cancellazioni.

Comunque la soluzione è cercare di "obbligare" il driver a fare ciò che vogliamo che è quello di spingerlo a non considerare la colonna "Versione" utilizzata per il QBE. Per fare questo occorre modificare il riferimento alla colonna con un'espressione il cui risultato sia il valore del campo ma che il driver faccia fatica ad analizzare e ricondurre ad un riferimento alla colonna. Avevamo già provato con ToInteger(campo) che viene tradotta in CONVERT(campo, int) ma abbiamo visto che il driver è in grado di capire che il campo è già intero e la CONVERT viene eliminata istantaneamente. Provando con 'campo + 0' abbiamo ottenuto il risultato desiderato... La somma è troppo "difficile" per il driver che in questo caso non considera la colonna negli statement di insert e update, come da te desiderato. 
