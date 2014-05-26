
##  Web Report Preview 
* E' un applicativo basato su architettura ASP.NET che permette di fruire sul WEB di reports realizzati con la tecnologia 
Crystal Report 
* Altre applicazioni (WEB o meno) possono comunicare con questa applicazione dedicata attraverso get e/o post http
* E' stato realizzato da Apex-net utilizzando il Microsoft .NET framework e il Crystal Reports .NET sdk

##  ApexNetPreview.aspx (entry point di Web Report Preview)

E' possibile "comandare" l'applicativo attraverso la pagina ApexNetPreview.aspx (entry point dell'applicativo).

Tale possibilità viene fornita attraverso la query string dell'url della pagina stessa e/o eventuali valori passati con post http. 

La pagina ApexNetPreview "carica" le variabili presenti nella query string e del post direttamente nella session.
I parametri non specificati nella modalità standard vengono letti dal Web.config, alcuni dal nodo-sezione
specificato da "AplicationName", altri dal nodo "appSettings", secondo lo schema della tabella sottostante.
L'ordine in cui vengono caricati i parametri è: "appSettings", sezione, query string, post http; ciò significa che i
parametri contenuti in "appSettings" rappresentano il default, i parametri della sezione specializzano il
default per ogni applicativo, attraverso la query string e/o il post è possibile personalizzare l'apertura di ogni
singolo report.

Es: 
    
    http://localhost/WRP/ApexNetPreview.aspx?ReportPath=ReportTest/TestOperatCRM.rpt&PreviewType=EXP
    &ExportFormatType=pdf&sf={ST_OPERATORI.MATR_OP}>'000001'&p1=Intestazione&v1=SI


Per tutti i parametri previsti il meccamismo è del tipo chiave e valore.

Per ulteriori dettagli (configurazione, parametri, pre-requisiti, ...) fare riferimento al Readme.txt (v. 3.5): 
**[WRP ReadMe](../Upload/ReadMe.txt)**.
Tale doc. è comunque sempre installato con l'applicazione WRP.

##  Soluzioni a problemi noti 

* Nel caso di export nei formati excel e word dalla toolbar della "Modalità RichPreview" 
potrebbe verificarsi il seguente errore **Errore: DLL export o formato export non valido**; 
é un errore lato server;
fare riferimento al seguente link:
[Invalid export DLL or export format" with Crystal Reports 2008](http://forums.sdn.sap.com/thread.jspa?tstart=0&threadID=1065075)

* Per problemi riguardanti l'installazione del **Print Control(ActiveX)** di Crystal Reports 2008  
fare riferimento al seguente link: 
[Problems installing Crystal Reports 2008 Print Control(ActiveX)](http://www.sdn.sap.com/irj/scn/weblogs;jsessionid=(J2EE3417500)ID1617741650DB11112347389125823727End?blog=/pub/wlg/14395)

* Errore: **maximum report processing jobs limit**
Incrementare il "Print Job Limit", il default è 75; 
é un errore lato server;
fare riferimento al seguente link: 
[Crystal Reports Maximum Report Processing Jobs Limit](http://www.sdn.sap.com/irj/boc/index?rid=/library/uuid/f053713e-3e3d-2c10-2a81-f79259e54023&overridelayout=true)

* Nel caso di **Selection Formula** con valori alfanumerici occorre prestare attenzione al caso dei **caratteri speciali** (come a esempio gli apici); per evitare di utilizzare tecniche differenti a seconda del carattere speciale basta racchiudere tutto il valore con doppi apici, e non con apici singoli
per esempio:
    
    {codice} = "SD'A"


* Esiste una incompatibilità tra un'applicazione **inde 8.5 rd3** (che utilizza il metodo App.OpenDocument) e WRP con browser IE8 su macchine client con windows superiore a 6.0, ci possono essere errori javascript di questo tipo
**Messaggio: 'bobj.crv.stateManager' è nullo o non è un oggetto**
per evitare questo problema occorre utilizzare una delle seguenti modalità:
    * passare i parametri in **post** (metodo preferenziale) e non in query string 
oppure
    * utilizzare un **work-around** interno a WRP; chiamare la pagina "IndeRd3Trasfert.aspx" invece di "ApexNetPreview.aspx" come entry-point dell'applicazione nel caso di chiamata get http con paramentri in query string, verrà in questo caso eseguito un post http interno a WRP e verrà quindi by-passato l'errore 
