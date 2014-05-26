* [Sviluppo](https://sandiego.apex-net.it/svn/ApexNetProjects/AIT/Sviluppo/IDT/trunk/)


# File di configurazione

## userSettings
Le configurazioni che ogni utente od il team di sviluppo puo' modificare in modo da soddisfare le proprie esigenze.

### ExportSQL.Settings._{Trigger|View|Function|Procedure}_

#### CreateSearch
Nel caso si vuole sostituire l'istruzione di create, verra' ricercata questa stringa per sostituirla

* Se CreateSearch e' vuota la sostituzione non verra' applicata

#### CreateReplace
La stringa che verra' sostituita al posto di quella trovata in CreateSearch

* Se CreateSearch e' vuota CreateReplace non verra' presa in considerazione
* Se CreateReplace e' vuota CreateSearch sara' cancellato a causa della sostituzione con la stringa vuota

#### CreateEnding
La stringa che si vuole appendere alla fine dell'istruzione create

* Per la sintassi di Oracle, spesso questa stringa ha il valore "/", oppure ";" per le viste

#### DropEnding
La stringa che si vuole appendere alla fine dell'istruzione drop

* Per la sintassi di Oracle, spesso questa stringa ha il valore ";"

### ExportSQL.Settings.Output

#### DirectoryName<span style="text-decoration:underline">{Functions|Procedures|Triggers|Views}_
Il nome della cartella che verra' creato per ogni tipo di oggetto, quando l'output desiderato e' del tipo "un file per ogni oggetto"

#### FileName</span>{Functions|Procedures|Triggers|Views}_Type
Il nome del file che verra' creato per ogni tipo di oggetto, quando l'output desiderato e' del tipo "un file per ogni tipo oggetto"

#### FileName_SingleFilePerObject
Il nome del file che verra' creato, quando l'output desiderato e' del tipo "un file unico per tutti gli oggetti di tutti i tipi"

### ExportSQL.Settings.General

#### ExportDrops
* Se e' True, allora le istruzioni di drop verranno create globalmente
* Se e' False, allora nessun istruzione drop verra' creato

#### DefaultInputFile
Il percorso predefinito del file ddl creato da INDE. Se nel flusso di lavoro dell'utente non esiste un percorso usato spesso, allora puo' essere lasciato vuoto; altrimenti se si utilizza in maggiore parte dei casi sempre uno stesso percorso, questa configurazione tornera' ad essere molto comodo.

#### DefaultOutputPath
Come in DefaultInputFile. Questa volta il percorso e' per l'output che verra' generato dal programma.

## applicationSettings
Queste configurazioni non devono essere toccate dall'utente finale. Se vengono modificate, il programma non potra' generare l'output desiderato o potrebbe generare degli errori a run-time.

# Manuale d'uso

![La schermata d'ingresso](../Attachments/AIT-INDE-Export-SQL/00.jpg)
![Selezionare il tipo di input](../Attachments/AIT-INDE-Export-SQL/01.jpg)
![Se e' selezionato "Build INDE", allora bisogna ora scegliere il file dll generato da INDE](../Attachments/AIT-INDE-Export-SQL/02.jpg)
![Altrimenti si puo' incollare qualsiasi testo liberamente. Ricordarsi che deve avere la sintassi INDE valida!](../Attachments/AIT-INDE-Export-SQL/03.jpg)
![Selezionare quali tipi di oggetti si vogliono esportare. La scelta predefinita e' "Tutti"](../Attachments/AIT-INDE-Export-SQL/04.jpg)
![Deselezionando "Tutti", l'utente potra' scegliere soltanto i tipi di oggetti d'interesse](../Attachments/AIT-INDE-Export-SQL/05.jpg)
![Selezionare la modalita' di salvataggo](../Attachments/AIT-INDE-Export-SQL/06.jpg)
![Specificare il percorso di output](../Attachments/AIT-INDE-Export-SQL/07.jpg)
![Dopo una schermata intermedia che visualizza il procedimento del programma, apparira' questa, indicando che l'operazione e' conclusa con successo](../Attachments/AIT-INDE-Export-SQL/08.jpg)
