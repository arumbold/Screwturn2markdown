Il motivo in realta' e' molto semplice.
Nella 10 il ruolo CONNECT contiene un insieme minore di privilegi rispetto alle versioni precedenti di Oracle.

Fino alla versione 9, il ruolo CONNECT aveva i seguenti diritti:

    
     CREATE SESSION
     ALTER SESSION
     CREATE CLUSTER
     CREATE DATABASE LINK 
     CREATE SEQUENCE
     CREATE SYNONYM
     CREATE TABLE
     CREATE VIEW


Nella 10 invece è stato ridotto cosi':

    
     CREATE SESSION


A qusto punto si puo' operare in due modi:

1. Creare un ruolo APEX che contiene i permessi mancanti in CONNECT e dare in tutti i nostri script il ruolo APEX all'utente che desideriamo creare:

Esempio:

    
    -- Creazione ruolo
    
    CREATE ROLE APEX;
    
    -- Concedo i permessi al ruolo
    GRANT create session, create table, create view, create synonym,
    create database link, create cluster, create sequence,
    alter session TO APEX; 
      
    -- Creazione utente
    CREATE USER MIOUTENTE IDENTIFIED BY ........
     -- Do il grant APEX al MIOUTENTE
    GRANT CONNECT, RESOURCE, APEX TO MIOUTENTE.



2. Ridare a CONNECT i RUOLI presenti nella 9

Esempio:

    
    - Ridefinisco i privilegi di CONNECT
    
      GRANT create session, create table, create view, create synonym,
      create database link, create cluster, create sequence,
      alter session TO CONNECT;



Personalmente, anche se meno elegante in termini di sicurezza, consiglio il metodo 2 per mantenere la compatibilita' con i database della 9 che, almeno per quanto riguarda le migrazioni, sono la maggior parte dei db con cui ci troviamo a che fare.

