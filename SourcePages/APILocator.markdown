
## Introduzione
APILocator è un webservice restfull che ha la funzione di concentrare in un unico punto alcuni dati di configurazione.
Possiamo immaginarlo come un file di configurazione centralizzato a cui tutte le applicazioni si collegano la prima volta che vengono avviate.
Se per qualunque motivo l'APPLocator non è raggiungibile, l'applicazione client utilizza i parametri letti la volta precedente.

## Reference

Per chiamare il servizio bisogna comporre una query string simile a questa:
    
    http://applocate.apexnet.it/ApiLocator.aspx?CMD=url&appkey=IUNIVERSITY&version=1

in cui:

* http://applocate.apexnet.it è l'indirizzo internet in cui è installato il servizio.
* ApiLocator.aspx?CMD= 

## Parametri

* appkey
Identifica la chiave univoca dell'applicazione

* version
Identifica la versione dell'API di cui sto richiedendo l'url

* api
Identifica la versione dell'api dell'applocator

## Valore di ritorno
Ritorna una stringa JSON composta in questo modo
    
    {
      apiVersion: "1.0"
      data: [
        "url 1"
      ]
      result: "OK"
    }
    

## Esempio
http://applocate.apexnet.it/ApiLocator.aspx?CMD=url&appkey=IUNIVERSITY&version=1&api=1



