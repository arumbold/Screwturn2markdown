
    ( DEV | CLONE(P|T) | DEMO | TEMP_<NOME>[_<DESC>] )_( UNI<CODABBREV> | BASE[_<LANG>] )_( UP | S3 | SIA<COD> )


### La sintassi

<table>
<td>`()`</td>
<td>:</td>
<td>Obbligatorio</td>
<tr>
<td>`[]`</td>
<td>:</td>
<td>Opzionale</td>
</tr><tr>
<td>`<>`</td>
<td>:</td>
<td>Variabile</td>
</tr><tr>
<td>`a|b`</td>
<td>:</td>
<td>a oppure b</td>
</tr>
</table>

## Descrizioni

<table>
<td>`DEV`</td>
<td>:</td>
<td>Sviluppo, quindi aggiornato all'ultima versione non ancora rilasciata</td>
</tr><tr>
<td>`CLONE(P|T)`</td>
<td>:</td>
<td>Clone produzione/test, utile per testare la situazione in cui si trova il cliente e verifica segnalazioni</td>
</tr><tr>
<td>`DEMO`</td>
<td>:</td>
<td>Ambiente demo, aggiornato all'ultima build coerente in sviluppo. Viene esposta all'esterno ai fini di testare/mostrare le nuove implementazioni</td>
</tr><tr>
<td>`TEMP_&lt;NOME&gt;&#0091;_&lt;DESC&gt;&#0093;`</td>
<td>:</td>
<td>Temporanei che appartengono ad uno sviluppatore per un tempo determinato per un particolare task</td>
</tr><tr>
<td>`UNI<CODABBREV>`</td>
<td>:</td>
<td>Codice del cliente</td>
</tr><tr>
<td>`BASE&#0091;_&lt;LANG&gt;&#0093;`</td>
<td>:</td>
<td>Schema "vuoto" per la prima intallazione, puo' essere in una determinata lingua</td>
</tr><tr>
<td>`UP`</td>
<td>:</td>
<td>Appartiene ad applicativo UP</td>
</tr><tr>
<td>`S3`</td>
<td>:</td>
<td>Appartiene ad applicativo ESSE3</td>
</tr><tr>
<td>`SIA&lt;COD&gt;`</td>
<td>:</td>
<td>Appartiene ad un modulo UGOV</td>
</tr>
</table>

### Alcuni esempi

<table style="padding: 10px">
<td>TEMP_ADON_UNIBOCCONI_UP</td>
<td>:</td>
<td>Prova di Ali</td>
</tr><tr>
<td>TEMP_FVAS_DATI_UNIBOCCONI_UP</td>
<td>:</td>
<td>Prova di Fabio per import dei dati</td>
</tr><tr>
<td>DEV_UNIBOCCONI_UP</td>
<td>:</td>
<td>Sviluppo di Bocconi</td>
</tr><tr>
<td>DEV_UNITN_UP</td>
<td>:</td>
<td>Sviluppo di Trento (si sa che e' collegato a DEV_BASE_S3 (vedi sotto))</td>
</tr><tr>
<td>DEMO_UNIBOCCONI_UP</td>
<td>:</td>
<td>Bocconi aggiornato all'ultimo rilascio con i loro dati in produzione</td>
</tr><tr>
<td>DEMO_UNITN_UP</td>
<td>:</td>
<td>Trento aggiornato all'ultimo rilascio con i loro dati in produzione</td>
</tr><tr>
<td>DEV_BASE_IT_UP</td>
<td>:</td>
<td>DB vuoto in Italiano</td>
</tr><tr>
<td>DEV_BASE_TR_UP</td>
<td>:</td>
<td>DB vuoto in Turco</td>
</tr><tr>
<td>DEMO_BASE_EN_UP</td>
<td>:</td>
<td>DB di demo in Inglese, dove i dati possono essere di qualsiasi tipo</td>
</tr><tr>
<td>DEV_BASE_S3</td>
<td>:</td>
<td>ESSE3 vuoto(, per le prove DB Fix stile KION nel caso dei clienti integrati)</td>
</tr>
</table>
