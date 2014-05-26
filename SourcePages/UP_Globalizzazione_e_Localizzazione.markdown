
##  Scenario 
* Questa pagina si pone come obbiettivo l'analisi delle attività da fare per la globalizzazione dell'applicativo e la conseguente attività di localizzazione nelle varie culture dell'applicativo UP.
* Per le nozioni generali sulla globalizzazione ed a metodologie specifiche .NET fare riferimento al seguente link: [Globalizzazione e Localizzazione](NET_Globalizzazione_Localizzazione)

##  To Do List  
* UP si compone di alcuni applicativi convolti nei processi di globalizzazione/localizzazione:
    * **UP Client Windows** (ref. global. Vassura) ** Stima: gg. 20**  
*** Culture: gestite tutte le culture nativamente da .NET
*** UICulture:
**** componenti dev express: tutti i componenti sono globalizzati su risorse; localizzazioni, parziali, presenti per un sottoinsieme di culture
**** label/controlli Apex-net: da fare la globalizzazione ed almeno una localizzazione per check
    * **UP WEB** (ref. global. Donmez) ** Stima: gg. 15** (solo logistica, no didattica)
*** Culture: : gestite tutte le culture nativamente da .NET
*** UICulture:
**** componenti dev express: tutti i componenti sono globalizzati su risorse; localizzazione presente per la sola lingua inglese, facciamo check di localizzaione in italiano (eliminare traduzione da codice)
**** label/controlli Apex-net: da fare la globalizzazione ed almeno una localizzazione per check
    * **UP Reports WEB**, utilizzato da entrambi gli applicativi precedenti (ref. global. Calisesi) ** Stima: gg. 5 ** 
*** Culture: : gestite tutte le culture nativamente da .NET / Business Objects
*** UICulture (inizio supporto gestito dalla versione 12 di Crystal Report, attualmente in uso lato sviluppo):
**** Toolbar Viewer Crystal: il componente è globalizzato su risorse; localizzazioni, totali, presenti per un sottoinsieme di culture
**** Reports: la globalizzazione delle label basata su campi formula mutlilingua (soluzione proposta da Business Objects) non sembra essere molto flessibile anche se veloce da implementare; occorre supplemento di indagine
* **Database**  (ref. global. Vassura) ** Stima: gg. 20 ** 
    * Consideriamo, per ora, che il client db sia sempre in inglese (si potrebbe eliminare anche questo vincolo, per semplicità lo teniamo); in ogni caso occorre eliminare le trasformazioni di tipo lato db che coinvolgono date, ore, numeri verso e da stringhe; la modifica più delicata sembra essere la sostituzione della triade di attributi "data inizio" (date), "ora inizio" (string) e "durata" (number) dell'impegno con la corrispondente "data e ora inizio" (date time), "data e ora fine" (datetime); gli attributi sostitutivi sono già presenti (poichè già semplificava le implementazioni in vari contesti), va implementata la bonifica dell'applicativo

##  Problemi noti 
* Alcune lingue, come l'arabo e l'ebraico, vengono tradizionalmente scritte e lette da destra a sinistra invece che da sinistra a destra. Gli utenti di queste lingue non solo si aspettano di leggere il testo delle applicazioni software da destra a sinistra, ma anche che tutti i controlli di un form siano ordinati da destra a sinistra. Nonostante .NET preveda il "mirroring" dei controlli (per questo scopo), non prevediamo, per ora, la risoluzione di questo tipo di problematiche.
* Esistono delle metodologie per creare layout che si adattino in modo proporziale quando si traducono i valori delle stringhe visualizzate in altre lingue; queste metodologie saranno a breve oggetto di una verifica implementativa 

##  Linee guida 
* La cultura neutrale sarà **it** (scelta conservativa)
* Il check di localizzazione verrà eseguito utilizzando la cultura **en**
* Globalizzazione basata su risorse .NET

##  Glossari 
E' stato creato un glossario di termini condivisi tra la lingua Turca e l'italiano:

[Italiano - Turco](UP_Glossary_Italian_to_Turkish)



