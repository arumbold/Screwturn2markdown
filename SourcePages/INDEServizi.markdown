
Nella creazione di servizi con C#, occorre conoscere alcuni procedimenti nella compilazione di un progetto intrinseci di Instant Developer.

## Compilazione
Prima di tutto è importante sapere che la funzione di Rebuild in Visual Studio 2005 elimina la dll IJLIB.dll che il compilatore IN:DE prepara nella cartella in cui viene creato l'eseguibile del servizio.

Se si desidera compilare il progetto da dentro Visual Studio, occorre quindi sapere che bisogna eseguire la **Build** per evitare questo problema.

## Debug
Per poter debuggare il progetto del servizio creato con IN:DE, bisogna :

1. Andare nelle proprietà del servizio (tasto desto sul servizio + properties)
2. Andare nella sezione **Build**
3. Selezionare **DEFINE DEBUG CONSTANTS**
4. Deselezionare **Optimize Code**
5. Alla fine della pagina selezionare **Advanced**
6. Su **debug info** scegliere **full**

Dopo aver fatto questo e aver mandato in esecuzione il programma, occorre eseguire l'attach al processo per potersi _ataccare_ all'esecuzione del programma.

Dopo cio' si possono mettere tutti break point che servono.

**Nota: **  

Per eseguire l'attach occorre selezionare l'opzione **Show process in all sessions**

## Lettura file di configurazione (settings.xml)
Nei servizi creati con IN:DE, non è stata portata come nelle applicazioni web c#, la lettura del web.config in maniera uguale.
Segnalo che l'istruzione GetSetting da usare dentro IN:DE, va usata in maniera leggermente diversa.

Se scrivo

    
    Variabile := GetSetting (Application, Username)


Nella costante Applicazion devo mettere il nome di un file xml. Esempio settings.xml

Nota importante: La documentazione di Progamma dice che il se non viene specificato il parametro, INDE cerca un file chiamato settings.xml. NON E' VERO. Bisogna sempre specificare il nome del file.

Dopodichè, all'interno di questo file, la GetSetting cerchera i valori del primo nodo esistente.

Il file configurazione.xml deve quindi essere formattato in questa maniera.

Ad esempio: 

    
    
    <configurazione 
    	Username="utente" 
    	Password="pwd"
    	Connectionstring="Provider=SQLOLEDB.1;Persist Security Info=False;Data Source=database;"
    	Interval="60"
    	Email="s.teodorani@cineca.com"
    />
    


