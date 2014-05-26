
## Mai piu' update su join
In ADO.net non è piu' possibile eseguire update su query composte da join.
Non era consigliato neanche prima ma in VB era possibile farlo.

Se proprio non si puo' fare a meno si puo' fare una vista (con la join) e poi fare il pannello direttamente sulla vista.
In questo modo funziona.


## Cambiamento comportamento su resync sui pannelli ID
Nell'utilizzo di ado.net da parte di ID non esiste la possibilità di chiamare il metodo resync che consentiva qual'ora un trigger modificasse un valore su un record, di vedere il valore cambiato sul pannello.
Per risolvere questo problema in .net si agire in due modi:
1. Fare un reresh dopo un update di un pannello
2. spostare la logica del trigger lato client.

## Errata visualizzazione link download blob (Risolto)
In un progetto compilato con c# si ottiene il seguente malfunzionamento:
Se in form visualizzato in modalita' FORM contenente un campo blob, viene effettuata la cancellazione di un record N, il pannello visualizza i dati del record N+1 ma scompare il link per il download.
Occorre eseguire un refresh per farlo riapparire.
Questa cosa e' stata segnalata in progamma. E' un comportamente che conoscono e che devono risolvere.


## Sempre PK con C#
Abbiamo convertito il progetto RTC in C#.
Modificando l'initial status di un pannello da DATA a NEW ROW, viene mostrato il seguente errore non presente in Web IIS:

    
    Dynamic SQL generation for the Updatecommand is not supported against a Selectcommand that does not return any key column information.


Il problema sembra legato al drive ado.net che vuole assolutamente che sia presente una primary key in una tabella.
Per risolvere il problema bisogna rispettare questa regola

**Nota del 4 aprile 2007**

Si è scoperto che il problema è dovuto alla mancanza delle primary key sulle tabelle dell'RTC.

## Gestione di parametri di tipo ref
Instant developer utilizza al suo interno tipi personalizzati chiamati IDVariant.
Quando si rimappa dentro ID la chiamata ad una funzione rimappata internamente, occorre in alcuni casi creare una funzione di interfaccia per in cui effettuare una conversione dei dati da IDVariant a string e viceversa.
Il file codi' creato deve essere aggiunto alla custom.

Ecco un esempio:

    
    using System;
    using com.progamma;
    
    /*
      IN:DE non usa ref per passare i parametri ma usa il Boxing (come in Java). Pertanto ciò che occorre fare
      è cambiare il valore della classe IDVariant e non restituire un nuovo IDVariant.
    */
    
    public class GSn_gs_00_25_progetti_sService_EXT : GSn_gs_00_25_progetti_sService 
    {
        // Per ogni parametro preceduto da "ref" uso IDVariant come tipo dato. Dentro IN:DE non scrivo .stringValue() o .intValue() ma solo il numero di parametro
        public int fn_insert_requisito_ext(string as_user, string as_password, int al_prg_progetto, string as_titolo_req, string as_des_req, string as_data_richiesta, string as_data_fabb, string as_cda_stato, string as_cda_area, string as_cda_processo, int al_cdn_priorita, int al_sol_id, IDVariant as_des_err)
        {
            // Estraggo il valore dall'IDVariant
            String str = as_des_err.stringValue();
            //
            // Chiamo il WS, passando i parametri ref per riferimento
            int ret = fn_insert_requisito(as_user, as_password, al_prg_progetto, as_titolo_req, as_des_req, as_data_richiesta, as_data_fabb, as_cda_stato, as_cda_area, as_cda_processo, al_cdn_priorita, al_sol_id, ref str);
            //
            // Aggiorno l'IDVariant fornito indicandone il nuovo valore
            as_des_err.set(new IDVariant(str));
            //
            // Ritorno ciò che ho ottenuto dalla chiamata al WS
            return ret;
        }


## Localizzazione della configurazione applicazione (Web.Config)
Per isolare una parte della configurazione in un web.config si può utilizzare l'attributo location. 
Poichè ID utilizza un httphandler questo componente può interferire con un'eventuale applicazione .NET in posizione gerarchica sottostante 
all'applicazione principale realizzata con ID.
Di seguito viene riportato un esempio per isolare l'httphandler utilizzato da un'applicazione "ASp_NET_App_annidate" realizzata con ID:

    
    <?xml version="1.0"?>
    <configuration>
    
    <location path="ASp_NET_App_annidate" allowOverride="true" inheritInChildApplications="false">
      <system.web>
       <httpHandlers>
          <add verb="*" path="Webapp.aspx" type="IDHttpHandler"/>
        </httpHandlers>
     </system.web>
    </location>
    
    </configuration>  


questo è tutto

## Parametro PanelsLikeSearch
Questo parametro non viene piu' gestito da INDE nella versione di c#, riporto nuovo comportamento descritto da programma:
Il parametro non viene utilizzato in Java e in C#. Il criterio e' che l'operatore like viene utilizzato nei campi di tipo character, altrimenti il codice SQL viene generato con l'operatore =. Per risolvere il problema e' necessario utilizzare l'evento di BeforeFind per mettere nel QBEfilter l'operatore = prima del valore cercato dall'utente.

## Save Blob File
Diversita' di comportamento da VB nella gestione del parametro path nel caso in cui si valorizza con empty string o non valorizzandolo. 
Non specificandolo viene chiesto al sistema operativo l'url della directory temporanea per l'utente corrente, in VB6 e' la stessa dove gira l'applicazione, in Java e' c:\windows\system32 e in C# e' c:\document & settings... Per risolvere il problema ed ottenere un'applicazione portabile e' sufficiente valorizzare il parametro path ad esempio utilizzando la funzione path().

## Load Blob File
Se in vb veniva utilizzata la procedura 'Load Blob FileVB' migrando l'applicativo in c# e' necessario sostituirla con la funzione 'Load Blob file'

## Body e BodyHTML nell'invio delle email
il componente di VB (Dundas Mailer) e' in grado di inviare email con entrambi i body (sia plain che HTML), mentre il comportamento di Java e C# e' differente a causa del supporto dei componenti forniti dai linguaggi.
Se si specificano entrambe le proprieta' il messaggio viene mandato considerando solamente il plain body, per mandare mail in HTML occorre specificare solamente la proprietà HTMLBody. In VB specificando entrambe le proprietà la mail viene mandata con entrambe le proprietà impostate, e normalmente viene visualizzato il body HTML per le impostazioni del client.
E' disponibile un articolo di documentazione sull'argomento.

<[http://www.progamma.com:8080/IDES/ID_DOC/1C08EFA7-78D5-4E79-8717-257A643D84ED.htm>]

Per risolvere rapidamente il problema e' sufficiente creare un folder di codice da usare solamente in VB, e valorizzare li' dentro la proprietà Body, mentre si valorizza al di fuori la proprietà HTMLBody.


## Utilizzo di alcuni parametri nell'url dell'applicativi
Mi hanno fatto notare che se ci si collega con il seguente url http://crm.apex-net.it/CRM.aspx?WCI=IWForm&WCE= si perde rtc e non funziona nulla

R) Utilizzando la URL senza i parametri il problema scompare. Problemi analoghi si possono manifestare se si utilizza il comando "aggiungi ai preferiti" di IE per memorizzare l'url. Questo perche' IE può arbitrariamente decidere di memorizzare url e ordine di caricamento dei frames, ma non e' detto che imposti correttamente l'ordine di caricamento del frame di visualizzazione e di quello di rendering differenziale (normalmente nascosto ma presente). Il metodo corretto per aggiungere un collegamento ai preferiti e' di crearlo manualmente con l'url senza parametri.

## Comportamento diverso nelle espressioni con interi
Nel cim c'era un espressione che conteneva la divisione di due interi e il risultato in vb restituiva valore con decimali
mentre con c# viene arrotondato alla parte intera.
Per risolvere il problema è necessario convertire una delle variabili come decimal e a quel punto viene utilizzato come tipo di ritorno dell'espressione un decimal.


## Comportamento diverso nelle master query di pannello senza PK
All'interno del cim esisteva una master query di un pannello senza PK:

    
    select
      A.CDA_MATRICOLA as MATRICPARTEC,
      A.IND_VALUTAZ_PERS as IND_VALUTAZ_PERS,
      A.IND_EFFICACIA as IND_EFFICACIA,
      A.CDA_UTENTE_CREAZ as UTE_CREAZ,
      A.DTM_CREAZ as DAT_CREAZ,
      A.CDA_UTENTE_MOD as UTE_MODIF,
      A.DTM_MOD as DAT_MODIF,
      A.DES_NOTE_EFFICACIA as DES_NOTE_EFFICACIA,
      A.DTM_EFFICACIA as DTM_EFFICACIA
    from
      PARTECIPANTI A
    where (A.PRG_SESSIONE = ~~PQRY_CORSI.ID~~)


che in vb funzionava, ora utilizzando c#, al momento del salvataggio viene restituito il seguente errore:
DB error while updating records (Error = Dynamic SQL generation for the UpdateCommand is not supported against a SelectCommand that does not return any key column information.)

Per risolvere il problema è necessario inserire la PK della tabella nella master query.


 
