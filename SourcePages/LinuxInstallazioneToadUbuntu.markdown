
E' possibile usare Toad su Ubuntu, con l'ausilio di Wine ([Cos'è wine?](http://it.wikipedia.org/wiki/Wine)). L'idea è quella di simulare la struttura di directory del client di oracle sul file system "windows" creato da wine e quindi installare Toad.  

Ecco i passi da seguire:

## 1. Installazione Wine
Scaricare la versione corrente di wine per la propria distribuzione linux da sito: [Wine download page](http://www.winehq.org/site/download) e installarla.

## 2. Installazione client Oracle
Scaricare dal sito Oracle [Oracle instant client download page](http://www.oracle.com/technology/tech/oci/instantclient/index.html) i seguenti file: 

* Instant Client Package - Basic: <span style="text-decoration:underline">instantclient-basic-win32-10.2.0.3-20061115.zip</span>
* Instant Client Package - SQL*Plus: <span style="text-decoration:underline">instantclient-sqlplus-win32-10.2.0.3-20061115.zip</span>

### 2.1. Creazione directory Oracle
Eseguire `winecfg` in modo da creare in automatico la cartella .wine nella propria home. E' possibile eseguire questa operazione direttamente dal menù di wine: Applicazioni <del>> Wine </del>> Configure Wine. 

Creare le directory per l'instant client:

`{{cd ~/.wine 
cd drive_c  (Corrisponde al disco C classico di Windows)
mkdir ORA 
cd ORA 
mkdir BIN
mkdir -p sqlplus/admin
mkdir -p NETWORK/ADMIN
`}}

Copiare nella cartella ADMIN il tnsnames.ora utilizzato.
      

### 2.2. Copia di files essenziali per il client Oracle
Copiare nella cartella BIN i file decompressi dell'instant client e di sqlplus:

`{{
glogin.sql
oci.dll
ojdbc14.jar 
oraociei10.dll 
Orasqlplusic10.dll 
ocijdbc10.dll 
orannzsbb10.dll 
sqlnet.log 
classes12.jar 
ociw32.dll     
oraocci10.dll 
sqlplus.exe 
`}}

### 2.3. Spostamento e modifica di files

* Fare una copia della dll oci.dll cambiandone il case, ovvero:

`{{
cp oci.dll OCI.dll
`}}

* Spostare il file glogin.sql nella cartella sqlplus/admin

### 2.4. Registrazione delle variabili d'ambiente di ORACLE per wine
Eseguire:

`{{
wine regedit
`}}

Nel "registro di Windows" creare la chiave Oracle per la chiave Oracle le seguenti "stringhe":

`{{
TNS_ADMIN -Passare il percorso della cartella che contiene il tnsname.ora, per esempio: C:\ORACLE\NETWORK\ADMIN
ORACLE_HOME -Passare il percorso della ORACLE_HOME : C:\ORACLE
`}}

### 2.5. Modifica del path di Oracle nel registry di wine

Modificare il path di sistema aggiungendo il percorso della ORACLE_HOME:

Eseguire wine regedit e posizionarsi in:

`{{
HKEY_LOCAL_MACHINE > System > CurrentControlSet > Control > SessionManager > Environment
`}}

## 3. Installazione Toad
Installare Toad (consigliata la versione 8.6, le versioni successive sembrano non funzionare):

Eseguire:

`{{
wine nome_del_file_eseguibile
`}}


NOTE:  

Una volta configurato l'instant client di oracle è possibile installare e usare anche ERWIN.
Dopo aver installato ERWIN con wine nome_del_file_eseguibile è necessario un ulteriore passo: posizionandosi nella  cartella che contiene il file sqlplus.exe ed eseguire:

`{{
cd ~/.wine/drive_c/ORACLE/BIN
wine ~/.wine/drive_c/Program\ Files/CA/AllFusion\ ERwin\ Data\ Modeler/mmopn32.exe
`}}
