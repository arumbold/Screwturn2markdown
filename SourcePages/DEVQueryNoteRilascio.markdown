
La seguente query può essere utilizzata per estrarre le note di rilascio.

## Introduzione
In questa pagina sono riportate le query necessarie per produrre le pagine per le note di rilascio da pubblicare sul wiki.
Per ottenere l'output desiderato, occorre utilizzare il query analyzer e procedere in questo modo:

1. Aprire il query analyzer
2. Andare nel menu **Query**
3. Scegliere la voce **Opzioni query**
4. Andare nel tab Testo
5. Mettere 8192 nella voce **Numero massimo di caratteri visualizzati** (attenzione che non venga troncato l'output)
6. Confermare
7. Premere Control-T (Attiva la visualizzazione dell'output in modalita' test e non piu' griglia)
8. Eseuire la query

## Estrazione note di rilascio per Versione

**Con questa query si estrae il prodotto interessato**

La prima parte della query riporta:
1. Il nome del file da creare nel wiki
2. Il nome della pagina da produrre

Rimuovere quindi questa parte dal contenuto generato.

    
    select * from prodotti


**Con questa invece si estrae la versione del prodotto interessato**

    
    SELECT * FROM VERSIONI WHERE PRG_PRODOTTO = 3 ORDER BY ID DESC


**Con questa query invece si estraggono le note di rilascio vere e proprie**

    
    select 'Nome file: CIMRelNotes_' + replace(cda_versione,'.','_') 
      from versioni where id = 248
    union all
    select 'Nome pagina: CIM: Release notes ' + cda_versione + ' del ' + cast(day(dat_rilascio) as varchar) + '/' + cast(month(dat_rilascio) as varchar) + '/' + cast(year(dat_rilascio) as varchar) 
      from versioni where id = 248
    union all
    select '<Inserire qui un messaggio di introduzione alla versione>' 
    union all
    select char(13) + '{TOC}' + char(13)
    union all
    select '===Novità===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+ ' - (rif: ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
      from segnalazioni 
    where prg_vers_ril = 248
    and prg_tipo = 2
    and flg_riservato = 'N'
    union all
    select '===Modifiche===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+ ' - (rif: ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
      from segnalazioni 
    where prg_vers_ril = 248
    and prg_tipo = 3
    and flg_riservato = 'N'
    union all
    select '===Correzioni===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+ ' - (rif: ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
      from segnalazioni 
    where prg_vers_ril = 248
    and prg_tipo = 1
    and flg_riservato = 'N'



## Estrazione note di rilascio per Fascicolo
Query Note di rilascio per fascicoli'''{BR}
Query da utilizzare per la pagina personalizzata delle note di rilascio.
Da utilizzare solo se esistono fascicoli interessati alle note di rilascio

    
    select '===Novità===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+' - (rif: '+ (select cda_versione from versioni 
    where id = segnalazioni.prg_vers_ril )+' - ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
    from segnalazioni 
    where dbo.CHECK_IN_FASCICOLO(id,19) = -1
    and prg_tipo = 2
    and flg_riservato = 'N'
    union all
    select '===Modifiche===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+ ' - (rif: ' + (select cda_versione from versioni 
    where id = segnalazioni.prg_vers_ril )+ ' - ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
    from segnalazioni 
    where dbo.CHECK_IN_FASCICOLO(id,19) = -1
    and prg_tipo = 3
    and flg_riservato = 'N'
    union all
    select '===Correzioni===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+ ' - (rif: ' + (select cda_versione from versioni 
    where id = segnalazioni.prg_vers_ril )+ ' - ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
    from segnalazioni 
    where dbo.CHECK_IN_FASCICOLO(id,19) = -1
    and prg_tipo = 1
    and flg_riservato = 'N'



## Estrazione note di rilascio per Cliente

Con questa query si estraggono le versioni interessate e si mette il risultato nella IN della query

    
    select * from versioni where prg_prodotto = 3 order by id desc


    
    select '===Novità===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+' - (rif: '+ (select cda_versione from versioni 
    where id = segnalazioni.prg_vers_ril )+' - ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
    from segnalazioni 
    where 1=1
    and cda_cliente = 'C00007'
    and prg_tipo = 2
    and flg_riservato = 'N'
    and prg_vers_ril in (248,255,260,261)
    union all
    select '===Modifiche===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+ ' - (rif: ' + (select cda_versione from versioni 
    where id = segnalazioni.prg_vers_ril )+ ' - ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
    from segnalazioni 
    where 1=1
    and cda_cliente = 'C00007'
    and prg_tipo = 3
    and flg_riservato = 'N'
    and prg_vers_ril in (248,255,260,261)
    union all
    select '===Correzioni===' 
    union all
    select '=====''''''' + ltrim(rtrim(des_titolo_note)) + ''''''''+ ' - (rif: ' + (select cda_versione from versioni 
    where id = segnalazioni.prg_vers_ril )+ ' - ID' + cast(ID as varchar) + ')' +  case flg_importanza WHEN 10 THEN ' [image|Warning|{UP}LogError.png]' ELSE '' END  + '=====' +char(13) + replace(des_note_rilas,'NULL','') + char(13)
    from segnalazioni 
    where 1=1
    and cda_cliente = 'C00007'
    and prg_tipo = 1
    and flg_riservato = 'N'
    and prg_vers_ril in (248,255,260,261)

