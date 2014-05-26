
In questa pagina sono riportati alcuni esempi di script per la gestione di log basati su tabelle partizionate

## Partizionamento log con rotazione dati

### Creazione tabella di log

     SQL
    
    
    
    DROP TABLE ES_LOG_CONTROLLO_VERBALI_P;
    
    create table ES_LOG_CONTROLLO_VERBALI_P
    ( DT_ERRORE       DATE,
      PINCODE         NUMBER(9),
      CARRIERA        NUMBER(2),
      ID_PROVA        NUMBER,
      MATRICOLA       VARCHAR2(10),
      NUM_CONFIG      NUMBER,
      SUPERATO        VARCHAR2(1),
      NOTE            VARCHAR2(1000),
      FLG_TIPO        VARCHAR2(1),
      NOTIFICA_WEB    NUMBER,
      NOTIFICA_EMAIL  NUMBER,
      PARAMETRI_INPUT VARCHAR2(2000),
      ERRORE          VARCHAR2(2000)
    )
    TABLESPACE APPO_LOG_DAT
    partition by range (DT_ERRORE) INTERVAL(numtodsinterval(1,'day')) 
    (
      partition P0 values less than (TO_DATE(' 2009-12-01 00:00:00', 'SYYYY-MM-DD HH24:MI:SS', 'NLS_CALENDAR=GREGORIAN'))
        tablespace APPO_LOG_DAT
        pctfree 0
        initrans 1
        maxtrans 255
        storage
        (
          initial 64K
          next 1M
          minextents 1
          maxextents unlimited
        )
    );
    


### Creazione Trigger per popolare dati partizione 

     SQL
    create or replace trigger trg_es_log_verbali_g_bi01
      before insert on es_log_controllo_verbali
      for each row
    begin
      -- Data Errore --
      IF :NEW.DT_ERRORE IS NULL THEN
        :NEW.DT_ERRORE := SYSDATE;
      END IF;
    
    end trg_es_log_verbali_g_bi01;
    /
    


### Creazione Procedura per droppare partizione vecchie

     SQL
    CREATE OR REPLACE PROCEDURE ALMAESAMI.DROP_PARTITION (giorni  date)
    IS
    data_partizione  date;
    BEGIN
    
    declare cursor c1 
    is
    select 
    partition_name NOME_PARTIZIONE, 
    high_value  VALORE
    from user_tab_partitions 
    where 1=1 --table_owner = 'DIDATTICA' 
    and table_name = 'ES_LOG_CONTROLLO_VERBALI'
    and partition_name != 'P0';
    
    begin
    
    --open(c1);
    --de
    
    FOR TAB1 IN c1 LOOP
        execute immediate ('select '|| TAB1.VALORE || ' from dual') into data_partizione;
        --if to_date(TAB1.VALORE, '')
            --dbms_output.put_line(data_partizione);
            --dbms_output.put_line(giorni);
        if trunc(data_partizione) < trunc(giorni) then
           execute immediate ('alter table ES_LOG_CONTROLLO_VERBALI drop partition ' || TAB1.NOME_PARTIZIONE || ' UPDATE GLOBAL INDEXES'); 
          --dbms_output.put_line(TAB1.NOME_PARTIZIONE);
          dbms_output.put_line('Droppata partizione '|| TAB1.NOME_PARTIZIONE);
       
        end if;
       
       null;
    END LOOP;
    
    null;
    end;
    
    END;
    /
    
    


### Job per la schedulazione
Ogni sera alle 11

     SQL
    
    BEGIN 
      SYS.DBMS_JOB.REMOVE(329);
    COMMIT;
    END;
    /
    
    DECLARE
      X NUMBER;
    BEGIN
      SYS.DBMS_JOB.SUBMIT
      ( job       => X 
       ,what      => 'ALMAESAMI.DROP_PARTITION (sysdate -14);'
       ,next_date => to_date('04/02/2010 23.00.00','dd/mm/yyyy hh24:mi:ss')
       ,interval  => 'TRUNC(SYSDATE+1)+23/24'
       ,no_parse  => FALSE
      );
      SYS.DBMS_OUTPUT.PUT_LINE('Job Number is: ' || to_char(x));
    COMMIT;
    END;
    /
    

