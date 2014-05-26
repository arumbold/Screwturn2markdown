
## Premessa
Chiunque abbia dovuto sviluppare procedure PL/SQL, prima o poi si sarà trovato nella situazione di dover tracciare l'esecuzione di una procedura per capire a che punto sia arrivata.
Normalmente è abitubine risolvere questa problematica in due modi:

1. Stampare nello standard output lo stato dell'esecuzione usando il package Oracle dbms_output
2. Creare una tabella di log in cui inserire righe e creare così un tracing sullo stato dell'esecuzione in corso.

In alcuni contesti però, queste due soluzioni però possono avere delle fastidiose controindicazioni.

Ad esempio, nel primo caso, esiste un limite fisico alla quantità di dati che possono essere messi nel buffer di memoria, inoltre il risultato viene esposto all'utente alla fine dell'esecuzione della procedura.

L'inconveniente della seconda soluzione invece è quello di dover per forza effettuare commit intermedi per poter vdere da un'altra sessione lo righe di log scritte nella relativa tabella.

## Il package dbms_application_info
A queste due soluzioni, ne esiste una terza che prevede l'utilizzo del package Oracle **dbms_application_info**.
Questo package, consente di scrivere in alcuni campi della tabella v$session le informazioni che si desidera monitorare.

### DBMS_APPLICATION_INFO.SET_MODULE
Consente di scrivere nei campi MODULE e ACTION della v$session

Esempio 1:

    
    
    SQL> exec DBMS_APPLICATION_INFO.SET_MODULE('TASSE', 'Inizio: ' || to_char(sysdate, 'dd-mon-yyyy hh24:mi:ss'));
    
    SQL> select module, action from v$session where module = 'TASSE';
    
    MODULE   ACTION
    -------- -------------
    TASSE    Inizio: 22-gen-2008 16:27:14
    


Esempio 2:

    
    
    BEGIN 
    
       DBMS_APPLICATION_INFO.SET_MODULE('TASSE', 'Inizio'); 
       INSERT INTO TABELLA_TASSE (c1, c2, c3) VALUES ('A', 'B', 'C')
       DBMS_APPLICATION_INFO.SET_MODULE('TASSE', 'Fine Passo 1');            
    
       INSERT INTO TABELLA_TASSE (c1, c2, c3) VALUES ('D', 'E', 'F')
       DBMS_APPLICATION_INFO.SET_MODULE('TASSE', 'Fine');
    END; 
    /
    


### DBMS_APPLICATION_INFO.SET_ACTION
Consente di scrivere nel campo ACTION della v$session

Esempio 3:

    
    
    BEGIN 
    
       DBMS_APPLICATION_INFO.SET_MODULE('TASSE', ''); 
       DBMS_APPLICATION_INFO.SET_ACTION('Inizio'); 
    
       INSERT INTO TABELLA_TASSE (c1, c2, c3) VALUES ('A', 'B', 'C')
       DBMS_APPLICATION_INFO.SET_ACTION('Fine Passo 1');            
    
       INSERT INTO TABELLA_TASSE (c1, c2, c3) VALUES ('D', 'E', 'F')
       DBMS_APPLICATION_INFO.SET_MODULE('TASSE', 'Fine');
    END; 
    /
    


## Riferimenti
Il suddetto package contiene altri metodi che possono essere usati, per esempio, per leggere le informazioni.
Per i dettagli sul loro utilizzo vi rimando a questo link:

* http://lbd.epfl.ch/f/teaching/courses/oracle8i/server.815/a68001/dbms_app.htm
