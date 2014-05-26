
Il seguente articolo descrive un metodo per importare i dati da files ascii con campi a larghezza delimitata in SQL Server utilizzando l'utility bcp

Per eseguire gli esempi presenti in questo articolo, occorre creare una struttura di directory così composta:

    
    c:\esempioBCP 
    c:\esempioBCP\xml_files 
    c:\esempioBCP\dati
    c:\esempioBCP\log
    
    



# 1. Creazione Tabelle in SQL Server

Per prima cosa, occorre creare dentro SQL Server la tabella in cui devono essere messi i dati.
Per comodità ogni campo della tabella lo possiamo definire come tipo VARCHAR.
Esempio:

    
    
    CREATE TABLE BANCHE_EMAIL
    (
      COD_BANCA            VARCHAR(5),
      COD_AGENZIA          VARCHAR(6),
      EMAIL_COD            VARCHAR(4),
      EMAIL_TO_DES         VARCHAR(40),
      EMAIL_TO             VARCHAR(50),
      EMAIL_CC_DES         VARCHAR(40),
      EMAIL_CC             VARCHAR(50),
      EMAIL_NOME_ALLEGATO  VARCHAR(1)
    )
    go
    
    


Una tabella cosi' creata, si aspetta un file ascii che non ha separatori ma che ha una larghezza delimitata in cui:
1. Il primo campo è largo 5 caratteri
2. Il secondo campo è largo 6
e così via.

# 2. Creazione del file di formato

Per poter usare il comando bcp, occorre definire un file xml che contiene la struttura dati che l'utility si aspetta di dover popolare.
In realtà l'utilizzo di un file di formato non è sempre obbligatorio, ma nel caso descritto si.
Per fortuna, il comando bcp ci viene in aiuto.

Per creare un file di formato usare la seguente sintassi.

    
    
    bcp INTPH.dbo.BANCHE_EMAIL format nul -c -x -f .\xml_files\BANCHE_EMAIL.xml -t -U"utente" -P"password"
    
    
    



Se si devono esportare molte tabelle è possibile comporre automaticamente tale linea di comando aiutandosi con uno script sql (valido per SQL Server 2005) come questo:

    
    select 'bcp INTPH.dbo.' + name + ' format nul -c -x -f .\xml_files\' + name + '.xml -t -U"user" -P"password"' from sys.tables where type_desc = 'USER_TABLE'
    
    
    


# 3. Import dati

Per importare i dati è sufficiente utilizzare la seguente sintassi:

    
    
    bcp INTPH.dbo.BANCHE_EMAIL in .\dati\BANCHE_EMAIL_out.sf -e .\log\BANCHE_EMAIL.log -T -f .\xml_files\BANCHE_EMAIL.xml -b 10000 -U"utente" -P"password"
    
    
    @
    
    Come prima, è possibile creare questo script in manieta automatica con una semplice quey:
    
    


select 'bcp INTPH.dbo.' + name + ' in .\dati\' + name + '_out.sf ' + '-e .\log\' + name + '.log -T -f .\xml_files\' +  name  +'.xml -b 10000 -U"user" -P"password"' from sys.tables where type_desc = 'USER_TABLE'

@@

# Risorse
http://sequelserver.blogspot.com/2011/06/script-to-generate-bcp-out-and-bulk.html
