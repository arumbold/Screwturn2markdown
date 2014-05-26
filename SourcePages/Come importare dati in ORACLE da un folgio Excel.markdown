##  Scenario 
Vi sono diversi approcci, vediamone alcuni.
##  INDE (Instant Developer) 
Vediamo i principali passi:
* Creare un ODBC di sistema di tipo Microsoft Excel Driver che punti al file .xls
* In Instant Developer creare un nuovo oggetto Database di tipo ODBC e col pulsante Build creare la stringa di connessione  usando un provider Ole DB for ODBC driver e scegliendo l'ODBC creato precedentemente. Il risultato dovrebbe essere simile a: "Provider=MSDASQL.1;Persist Security Info=False;Data Source=ODBS_XLS"
* Aprire il file .xls
* Selezionare tutte le righe e colonne di dati che si vogliono importare
* Dare un nome ai dati selezionati digitandolo nella "Casella Nome" in alto a sinistra(sarà quello della tabella in Oracle)
* ATTENZIONE: i nomi di colonna nel foglio excel sono quelli che verranno dati alle colonne di Oracle, quindi attenzione a non superare i 30 caratteri o ad usare spazi, trattini ecc., meglio rinominarli nel dubbio.
* In Instant fare **Import Schema** sul database di prima.
* Dovrebbe comparirvi sotto l'oggetto "tables" il nome digitato prima in Excel (potete farne anche più di uno) Selezionarlo e proseguire
* Ora che avete la tabella importata potete trascinarla (col Ctrl la copiate) in un Database Oracle, prenderne l'ownership e crearla sul DB
* Per quanto riguarda i dati ci dovrebbe essere un metodo per copiarli con un Drag&Drop tra Database in Instant; esiste comunque la possibilità di usare l**'Import Table Data** wizard di TOAD 
##  SSIS (Sql Server Integration Services) 
Vediamo i principali passi:
* Aprire Visual Studio 2005 o Sql Server Business Intelligence Developer
* Creare un Integration Services Project
* Lanciare l' **SSIS Import ed Export Wizard** (si può creare e modificare il package anche manualmente)
* Seguire tutti i passi, alla fine avrò un package che realizza l'export che posso debuggare dal IDE, posso schedularlo da sqlserver, posso invocarlo da codice .NET
* Unico prerequisito: devo avere una versione di sqlserver 2005 (SSIS è un add-on) installata in una macchina che possa vedere la macchina con Oracle 
* Vedi screenshot: [Test SSIS Package Excel To Oracle](../Upload/CaptureExcelToOracle.JPG)
##  Oracle Tools 
* Per importare semplici fogli excel su tabelle oracle si può utilizzare **Oracle Sqldeveloper** ([SqlDeveloper Import Data](../Upload/SqlDeveloperImportData.JPG)); tasto destro su tabelle, selezionare la voce import e parte il wizard (1 file - 1 tabella).
* E' possibile inoltre importare prima i files in Microsoft Access e poi utilizzare utilizzare **Oracle Developer Tools** (add-in visual studio 2005/2008) per importare i dati dal Db Access verso Oracle

##  Riferimenti 
* [SSIS Overview](http://www.microsoft.com/technet/prodtechnol/sql/2005/intro2is.mspx)
* [SSIS Tutorials](http://blogs.msdn.com/mattm/archive/2007/06/12/ssis-tutorials-on-jumpstarttv.aspx)
* [Oracle Sqldeveloper](http://www.oracle.com/technology/products/database/sql_developer/index.html)
