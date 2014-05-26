
##  Scenario 
* Nell'installazione predefinita di ASP.NET le applicazioni Web vengono eseguite in un processo di lavoro (**work-process**). Per **impostazione predefinita** in IIS, l'identità di questo processo utilizza un account locale:
    * in IIS 5 è l'account ASPNET
    * in IIS 6 e 7 è l'account **NetworkService**
* Vi sono delle **autorizzazioni** di default concesse all'utente predefinito, vedi riferimenti; tuttavia può accadere che vi siano dei casi in cui l'accesso o la modalità di accesso ad una risorsa (accesso a file-system,  DB, ...) non sia sempre possibile
* Vi sono anche delle impostazioni come le **Opzioni Internazionali** che sui sistemi windows vengono configurate per utente e che quindi vanno settate opportunamente per gli utenti con cui corrono i work-process Asp.NET

##  Soluzioni 
* È possibile cambiare e configurare l'identità del processo nella sezione <processModel> del file Machine.config nella sottodirectory Config della directory principale di installazione del Framework .NET.
* E' possbile agire a livello di configurazione di IIS: in IIS 6/7 è possibile cambiare l'identità dell'utente del work-process collegato ad un determinato application pool, ad esempio utilizzando IIS manager (proprietà dell'application pool)
* In un **web server di produzione** è consigliabile non modificare l'identità con cui corre un work-process ASP.NET, ma **autorizzare il singolo accesso ad una risorsa da parte dell'utente predefinito ** (per es. autorizzare alla scrittura di una ben determinata directory di File- System) 
* Per una corretto utilizzo delle **opzioni internazionali**, da parte delle applicazioni ASP.NET(dalla versione 2.0) devono essere verificati i seguenti punti:
    * L'applicazione deve gestire la specifica "culture" programmaticamente  o in modo dichiarativo (web.config); vedi [Globalizzazione e Localizzazione](NET_Globalizzazione_Localizzazione)
    * Una volta determinata la "culture" verranno appplicate le **opzioni internazionali specificate per l'utente** con cui viene eseguito il "work-process"; nel caso si voglia cambiare le impostazioni di default per la culture occorre quindi fare questi cambiamenti per gli utenti ASPNET (IIS 5) e per **NetworkService** (IIS 6 e 7) 
*** Per i sistemi Windows Vista e Windows Server 2008 è possibile copiare determinate impostazioni tramite il pannello di controllo (opzioni internazionali - opzioni di amministrazione - copia in account riservati)
*** E' comunque sempre possibile agire sul registro di sistema; per esempio nel caso di NetworkService (SID: S-1-5-20), possiamo ad esempio agire sulle apposite chiavi di registro
    
    HKEY_USERS\S-1-5-20\Control Panel\International


##  Riferimenti 
* [Support Microsoft: Process and request identity in ASP.NET](http://support.microsoft.com/kb/317012)
* [Well-known security identifiers in Windows operating systems](http://support.microsoft.com/kb/243330/en-us)
* [Finding Current User's SID in Windows 2000 Server & Windows XP](http://www.pcreview.co.uk/forums/thread-1581056.php)

##  Esempi 
* Vedi immagine su cambio opzioni internazionali per orario di un'applicazione ASP.NET, nel caso di "culture" italiana
[attachment:AspNetInternationalOptions.JPG](attachment:AspNetInternationalOptions.JPG)

