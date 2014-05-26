
## Elencare le prime 15 più grandi tabelle di uno schema

Per capire quali sono, in uno schema SQLServer, le tabelle più grandi di uno schema, copiare e incollare il seguente script in query analyzer.

`{{
set nocount on
create table #spaceused (
  name nvarchar(120),
  rows char(11),
  reserved varchar(18),
  data varchar(18),
  index_size varchar(18),
  unused varchar(18)
)

declare Tables cursor for
  select name
  from sysobjects where type='U'
  order by name asc

OPEN Tables
DECLARE @table varchar(128)

FETCH NEXT FROM Tables INTO @table

WHILE @@FETCH_STATUS = 0
BEGIN
  insert into #spaceused exec sp_spaceused @table
  FETCH NEXT FROM Tables INTO @table
END

CLOSE Tables
DEALLOCATE Tables 

select top 15
name, 
rows, 
cast(rtrim(ltrim(replace(reserved,'KB',_))) as numeric) reserved_bytes,
cast(rtrim(ltrim(replace(data,'KB',_))) as numeric) data_bytes,
index_size,
unused
from #spaceused 
order by reserved_bytes desc

`}}


## Calcolare la dimensione di una colonna blob
Un sistema analogo che puo' essere usato per calcolare la dimensione di una colonna blob e' il seguente:

`{{
select SUM(datalength(blb_allegato)) from documenti
`}}
