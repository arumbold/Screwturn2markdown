
##  Scenario 
ADO.NET in collaborazione con IIS permette di utilizzare una tecnica di accesso al DB chiamata Connetion Pooling.

##  Come funziona 
Alla prima richiesta al db il connection pool serve la richiesta (apre la connessione). Una volta che la client application richiede di chiudere la connessione, **ADO.NET non distrugge completamente la connessione** ma viene creato un **connection pool** dove viene
messo l'oggetto "connessione rilasciata" mantenendo il riferimento a quest'ultimo. Alla prossima richiesta di eseguire una query o stored procedure viene utilizzata una connessione libera del pool. Questo comporta un **aumento delle performance** rispetto ad una gestione senza connection pool.
Per maggiori dettagli (configurazione, esempi, ecc.) fare riferimento ai link riportati di seguito.

##  Riferimenti 
* [Codeproject: uno sguardo su ADO.NET Connection Pooling](http://www.codeproject.com/useritems/ADONET_ConnectionPooling.asp )
* [GotDotNet: esempi](http://samples.gotdotnet.com/QuickStart/howto/doc/adoplus/connectionpooling.aspx )
* [MSDN: .NET Connection Pooling Lifeguard](http://msdn2.microsoft.com/en-us/library/aa175863(SQL.80).aspx )

