
## Novità
#### **Funzioni utilità Codice fiscale** - (rif: ID3730)
*Calcolo codice fiscale italiano, secondo l'algoritmo  ufficiale riportato sul sito Agenzia delle Entrate (http://www.agenziaentrate.it)
*Controllo codice fiscale: la funzione effettua la validità formale del codice fiscale considerando anche i casi di omocodia.

#### **Funzioni di supporto esportazione appuntamenti in formato iCalendar** - (rif: ID3731)
Gli appuntamenti vengono esportati su file secondo lo standard iCalendar (estensione del formato vCalendar) 

#### **Gestito Clean-up reports allo scadere della sessione** - (rif: ID3733) ![Warning](../Upload/LogError.png)
E' possibile parametrizzare se deve esssere fatto il clean-up di tutti i reports gestiti allo scadere della sessione applicativa web; questo permette di ridurre il numero delle connessioni DB e il numero di job contemporanei dell'engine .NET di Crystal Report.

#### **Integrazione Appuntamenti Exchange 2007** - (rif: ID3734) ![Warning](../Upload/LogError.png)
Implementati Web services Wrapper per integrazioni server Exchange 2007.
Il colloquio avviene sempre per mezzo di Web Services.
Realizzate funzioni Crea, Cancella, Cerca "Appuntamenti" su server Exchange.
 possibile anche creare nuovi utenti e mailboxes sul server  Exchange attraverso il modulo OnExchange.

#### **Web services Configurazione Remota server Exchange 2007** - (rif: ID3735)
Realizzata funzione di creazione nuovi utenti e mailboxes sul server Exchange 2007.
Il web service deve essere installato sul server Exchange e permette di eseguire comandi in spazio di esecuzione virtuale della Powershell estesa di Exchange.


#### **AME (Asynchronous Message Engine)** - (rif: ID3736)
L'applicativo si occupa di inviare messaggi e-mail o sms in modalità diretta o posticipata.
E' costituito da 3 moduli applicativi.
* WSMessageEngine: contiene l'interfaccia e le librerie del message engine, se installato singolarmente è in grado di gestire gli invii diretti dei messaggi
* Message scheduler: il servizio permette di inviare le e-mail e gli sms presenti nella coda dei messaggi. 
* Message Management: il modulo permette di modificare i parametri di configurazione di AME presenti sul database. Permette inoltre di controllare le tabelle di spooler e di storico dei messaggi e gli eventuali errori segnalati nella tabella dei log



