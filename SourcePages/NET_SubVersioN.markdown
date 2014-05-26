
## Scenario
* **Subversion** (noto anche come **SVN**, che è il nome del suo client a riga di comando) è un sistema di controllo versione progettato da CollabNet Inc. con lo scopo di essere il naturale successore di CVS
* Il progetto è **open source**, l'architettura è client-server, multipiattaforma (linux, windows, mac os x), i protocolli di comunicazione sono vari (anche se i più utilizzati sono http e ssl)
* Esistono poi una miriade di tools gratuiti e commerciali per facilitare l'amministrazione dei server e l'utilizzo lato client (per es. **TortoiseSVN** è un client free che si integra in windows explorer)
* Vari add-in o plug-in ai principali IDE sono stati sviluppati per integrare il client all'interno dell'ambiente di sviluppo; gli add-in di SVN per Visual Studio più utilizzati sono:
    * Ankhsvn (open-source)
    * **VisualSVN** (commerciale)

## Tecnologie, Strumenti
* Al fine di avere rapidamente on-line un sistema di Source Control basato su Subversion utilizziamo i setup di **installazione** di VisualSVN.
    * Server: esiste un installer di SVN completamente gratuito (**VisualSVN Server**) che consente di installare e gestire un server Subversion su Windows (XP, Vista, Win Server 2003 e Win Server 2008), con un server apache e una managemente console per la gestione del repository; fa tutto l'installer; la management console (che è un plugin MMC) è semplice da usare per la maggior parte delle attività
    * Client Windows: per gestire Subversion da Explorer basta installare (anch'esso gratis) **TortoiseSVN** per avere a disposizione tutti i comandi SVN come menù contestuali, con anche le icon overlays che mostrano lo stato dei file e delle cartelle 
    * Add-in Visual Studio: per gestire Subversion da Visual Studio occorre installare **VisualSVN** (il cui costo è qualche decina di dollari)
* Per **utilizzare** Subversion, almeno per la semplice routine di lavoro, si può leggere la mini documentazione fornita da VisualSVN (vedi riferimenti) 
* Comandi principali lato client
    * **Import**: Importing Data Into A Repository
    * **Checking Out** : Checking Out A Working Copy
    * **Update**: Update Your Working Copy With Changes From Others	
    * **Commit**: Committing Your Changes To The Repository
    * **Show Log**: Examining History
    * **Branch/Tag**: creating copies from 'main branch' (trunk); branchs are dynamic copies of 'trunk';  tags are static copies of 'trunk' and aren't modifing by convention 
    * **Merge**: merge types
*** Merge a range of revisions
*** Reintegrate a branch
*** Merge two different trees

## Hooks

Hooks (ing. gancio) sono delle azioni che uno puo' definire per una repository in modo che questi vengano eseguiti ogni volta che viene eseguito la relativa operazione SVN. Un uso molto utile e comune e' quello di inviare messaggi di posta ogni volta che viene effettuato un commit (Post-commit) dagli sviluppatori.

### Post-commit Hook

I passi da seguire per realizzare Post-commit Hook sono:

1. Connettersi VisualSVN Server (via Remote Desktop @ sandiego)
2. Click destro sul nome della repository
3. Selezionare "Properties"
4. Visualizzare la scheda "Hooks" nel finestrino "Properties for <nome-repository>"
5. Doppio click sul "Post-commit hook"
6. Nel campo di testo inserire `C:\Program Files\VisualSVN Server\bin\VisualSVNServerHooks.exe commit-notification "%1" -r %2 --no-diffs -smtp-server pop.apex-net.it --from "svn@apex-net.it" --to "foo@apex-net.it,bar@apex-net.it"`

Nell'esempio di sopra volendo il parametro `--no-diffs` si puo' togliere se si desidera di mandare nel corpo del messaggio anche la diff. delle modifiche fatte sui file, oltre la descrizone del commit e l'elenco dei file modificati.

### Post-revprop-change Hook

Una cosa molto utile per questo hook, potrebbe essere abilitare la possibilita' di modificare il messagio dei commit. A tal fine si puo' usare [pre-revprop-change](../Attachments/NET_SubVersioN/pre-revprop-change.txt), quindi si puo' procedere facendo copia&incolla del contenuto come visto nel hook precendente, od altrimenti basta copiare il file sotto la directory `\\sandiego\c$\Repositories\&lt;Nome Repository del Progetto&gt;\hooks\` cambiando l'estension in "cmd" anziche' "txt".

## Riferimenti
* [SVN Sito ufficiale](http://subversion.tigris.org/)
* [TortoiseSVN](http://tortoisesvn.net/)
* [Ankhsvn](http://ankhsvn.open.collab.net/)
* [VisualSVN](http://www.visualsvn.com/visualsvn/)
* [VisualSVN - Introduction](http://www.visualsvn.com/visualsvn/doc/introduction/)
* [CVS versus SVN (pdf)](../Upload/CVS-SVN_slides.pdf)

## Allegati
[attachment:TortoiseSVN.jpg](attachment:TortoiseSVN.jpg)
[attachment:VisualSVN.jpg](attachment:VisualSVN.jpg)
