

# Rilascio per UP (Client)

...

# Rilascio per UP (Web)

...

# Upgrade di Devexpress per UP (Web)

* Assicurarsi che nessun sviluppatore abbia lock su alcun file della solution!
* Effettuare Check Out sull'intero progetto up_web ed up_didattica dal VSS Explorer a mano, NON da Visual Studio! Questo, perche' alcuni file non sono inclusi nel Visual Studio e/o sono esclusi dal Source Control
* Cancellare i contenuti delle seguenti cartelle:
    * up_web\bin\
    * up_web\obj\
    * up_didattica\bin\
    * up_didattica\obj\
* Fare l'upgrade di Devexpress utilizzando Project Converter con le seguenti opzioni:
    * Project Path: "C:\work\UP\Standard\Sviluppo\up_web" oppure "C:\work\UP\Standard\Sviluppo\up_didattica"
    * Process Subdirectories: Selezionato
    * Create backup files: NON selezionato
    * HintPath behavior: Remove
* Assicurarsi che log della conversione non dia errori
* Svuotare il contenuto dei seguenti file:
    * up_web\Properties\licenses.licx
    * up_didattica\Properties\licenses.licx
* Aprire nella modalita' designer (dal Visual Studio) tutte le form disponibili sia in up_web che in up_didattica. Cosi' facendo Devexpress automaticamente crea i riferimenti giusti alla nuova versione nei file licenses.licx corrispondenti. Uno potrebbe anche provare a cambiare a mano il numero della versione, ma questo non e' il procedimento consigliato da Devexpress!
* Svuotare il contenuto della cartella up_web\App_GlobalResources, prendere i nuovi file resx dal seguente percorso "C:\Program Files\DevExpress <versione>\Components\Sources\DevExpress.Web.ASPxGlobalResources". Ad es.:
    * DevExpress_Web_ASPxEditors_v9_1.resx
    * DevExpress_Web_ASPxGridView_v9_1.resx
    * DevExpress_Web_ASPxScheduler_v9_1.resx
    * DevExpress_Web_v9_1.resx
* Eventualmente avvisare il team di traduzione, perche' quest'ultima modifica molto probabilmente sovrasscrive tutte le traduzioni di questi controlli
* Cancellare la cartella up_web\DevExpress\ASPxSchedulerForms e poi aprire un qualsiasi form che contiene lo scheduler. Cosi' facendo Devexpress automaticamente creat di nuovo la cartella up_web\DevExpress\ASPxSchedulerForms aggiornata
* Effettuare Check In sull'intero progetto up_client dal VSS Explorer

# Allineamento dello sviluppo dopo un upgrade di Devexpress per UP (Web)

## Veloce

Cancellare tutta la cartella di sviluppo in locale e scaricare tutto dal VSS Explorer

## Dettagliato

...

# Upgrade di Devexpress per UP (Client)

* Assicurarsi che nessun sviluppatore abbia lock su alcun file della solution!
* Effettuare Check Out sull'intero progetto up_client dal VSS Explorer a mano, NON da Visual Studio! Questo, perche' alcuni file non sono inclusi nel Visual Studio e/o sono esclusi dal Source Control
* Cancellare i contenuti delle seguenti cartelle:
    * up_client\bin\
    * up_client\obj\
* Fare l'upgrade di Devexpress utilizzando Project Converter con le seguenti opzioni:
    * Project Path: "C:\work\UP\Standard\Sviluppo\up_client"
    * Process Subdirectories: Selezionato
    * Create backup files: NON selezionato
    * HintPath behavior: Remove
* Assicurarsi che log della conversione non dia errori
* Effettuare Check In sull'intero progetto up_client dal VSS Explorer

# Allineamento dello sviluppo dopo un upgrade di Devexpress per UP (Client)

## Veloce

Cancellare tutta la cartella di sviluppo in locale e scaricare tutto dal VSS Explorer

## Dettagliato

* Get Latest Recursive di tutto la solution
* Get Latest dei seguenti file dal VSS Explorer a mano, perche' non sono inclusi in Visual Studio e/o sono esclusi dal Source Control:
    * up_client\Properties\licenses.licx
* Cancellare i contenuti delle seguenti cartelle:
    * up_client\bin\
    * up_client\obj\
* Scaricare dal sito di Devexpress le nuove cartelle di resources.dll per tutte le lingue di interesse e mettere sotto le seguenti cartelle:
    * up_client\bin\Debug
    * up_client\bin\Release
    * up_client\obj\Debug
    * up_client\obj\Release
