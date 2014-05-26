
## Passo 1)
Scaricare la versione corrente di wine per la propria distribuzione linux da sito: [Wine download page](http://www.winehq.org/site/download) e installarla.

## Passo 2)
Scaricare dal sito Oracle [Oracle instant client download page](http://www.oracle.com/technology/tech/oci/instantclient/index.html) i seguenti file: 
Instant Client Package - Basic: <span style="text-decoration:underline">instantclient-basic-win32-10.2.0.3-20061115.zip</span>
Instant Client Package - SQL*Plus: <span style="text-decoration:underline">instantclient-sqlplus-win32-10.2.0.3-20061115.zip</span>

## Passo 3)
Eseguire `winecfg` in modo da creare in automatico la cartella .wine nella propria home. E' possibile eseguire questa operazione direttamente dal menù di wine: Applicazioni <del>> Wine </del>> Configure Wine. 

Creare le directory per l'instant client:
`{{cd ~/.wine 
cd drive_c  (Corrisponde al disco C classico di Windows)
mkdir ORA 
cd ORA 
mkdir BIN
mkdir -p sqlplus/admin
mkdir -p NETWORK/ADMIN
Copiare nella cartella ADMIN il tnsnames.ora utilizzato.`}}
      

## Passo 4)
Copiare nella cartella BIN i file decompressi dell'instant client e di sqlplus:

glogin.sql {BR}
oci.dll {BR} 
ojdbc14.jar {BR}      
oraociei10.dll {BR}
Orasqlplusic10.dll {BR}  
ocijdbc10.dll {BR} 
orannzsbb10.dll {BR} 
sqlnet.log {BR}
classes12.jar {BR}     
ociw32.dll {BR}    
oraocci10.dll {BR}   
sqlplus.exe {BR}

## Passo 5)
Fare una copia della dll oci.dll cambiando il case:
cp oci.dll OCI.dll

##  Passo 6)
Spostare il file glogin.sql nella cartella sqlplus/admin

## Passo 7)
Eseguire:
`wine regedit`
Nel "registro di Windows" creare la chiave Oracle per la chiave Oracle le seguenti "stringhe":
> TNS_ADMIN -Passare il percorso della cartella che contiene il tnsname.ora, per esempio: C:\ORACLE\NETWORK\ADMIN
> ORACLE_HOME -Passare il percorso della ORACLE_HOME : C:\ORACLE

## Passo 8)
Modificare il path di sistema aggiungendo il percorso della ORACLE_HOME:

Eseguire wine regedit e posizionarsi in:
> HKEY_LOCAL_MACHINE > System > CurrentControlSet > Control > SessionManager > Environment

# Passo 9)
Installare Toad (consigliata la versione 8.6, le versioni successive sembrano non funzionare):
`wine nome_del_file_eseguibile`


NOTE:
Una volta configurato l'instant client di oracle è possibile installare e usare anche ERWIN.
Dopo aver installato ERWIN con wine nome_del_file_eseguibile è necessario un ulteriore passo: posizionandosi nella  cartella che contiene il file sqlplus.exe:

cd ~/.wine/drive_c/ORACLE/BIN
wine ~/.wine/drive_c/Program\ Files/CA/AllFusion\ ERwin\ Data\ Modeler/mmopn32.exe
