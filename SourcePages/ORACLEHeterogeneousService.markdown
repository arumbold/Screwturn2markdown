Il presente articolo descrive passo per passo un esempio di configurazione utilizzata per l'integrazione di una istanza Oracle con un DB SQL Server attraverso gli heterogeneous services.
Nel seguente esempuio si presuppone che l'istanza oracle sia stata installata su una macchina windows.


## Elenco delle operazioni da effettuare
1. Andare nel Pannello di Controllo di windows, aprire la vece **Data Source (ODBC)** e creare una nuova connessione verso SQLServer chiamata, nel presente esempio, **CRM_DA_ORACLE**
2. Andare nella directory **ORACLE_HOME\hs\admin** e modificare il file **inithsodbc.ora** come segue:

    
    
    # This is a sample agent init file that contains the HS parameters that are
    # needed for an ODBC Agent. 
    
    #
    # HS init parameters
    #
    
    HS_FDS_CONNECT_INFO = CRM_DA_ORACLE
    HS_FDS_TRACE_LEVEL = 0
    # HS_FDS_TRACE_LEVEL = 4
    HS_FDS_TRACE_FILE_NAME = hsodbc_trace_gs.TRC
    
    # Oracle 9.2.x
    HS_FDS_CONNECT_STRING="<navobj><binding><environment><queryProcessor parserDepth='10000' tokenSize='10000'/></environment></binding></navobj>"
    
    # Oracle 8.1.x - 9..0.x
    # HS_FDS_CONNECT_STRING = "TOKEN_SIZE=10000"
    
    #
    # Environment variables required for the non-Oracle system
    #
    #set <envvar>=<value>
    



3. Andare in **ORACLE_HOME/network/admin** e modificare il file **listener.ora** come segue:

    
    
    SID_LIST_LISTENER =
      (SID_LIST =
        (SID_DESC =
          (SID_NAME = PLSExtProc)
          (ORACLE_HOME = E:\oracle\ora92)
          (PROGRAM = extproc)
        )
       (SID_DESC =
          (SID_NAME = hsodbc)
          (ORACLE_HOME = E:\oracle\ora92)
          (PROGRAM = hsodbc)
        )
        (SID_DESC =
          (GLOBAL_DBNAME = o92GS.GS.kion.it)
          (ORACLE_HOME = E:\oracle\ora92)
          (SID_NAME = o92GS)
        )
      )
    
    



La modifica consiste nell'aggiunta, nella sezione SID_LIST_LISTENER della parte relativa al riferimento verso hsodbc, ovvero:


    
       (SID_DESC =
          (SID_NAME = hsodbc)
          (ORACLE_HOME = E:\oracle\ora92)
          (PROGRAM = hsodbc)
        )
    



1. Andare in **ORACLE_HOME/netword/admin** ed editare il file **tnsnames.ora**aggiungendo la seguente entry:


    
    
    HSODBC =
      (DESCRIPTION =
        (ADDRESS_LIST =
          (ADDRESS = (PROTOCOL = TCP)(HOST = 85.18.201.9)(PORT = 1609))
        )
        (CONNECT_DATA =
          (SID = HSODBC)
        )
        (HS = OK)
      )
    
    
    



1. Collegarsi all'utente Oracle con sqlplus e creare un dblink che punta alla riga appena creata nel listener, ovvero:


    
    CREATE DATABASE LINK "KIM.HERMES.KION.IT" CONNECT TO CRM IDENTIFIED BY <PWD> USING 'HSODBC';


Per verificare il funzionamento si può eseguire questa query:

`{
select sysdate from dual@kim;
`}

