
# Regolamento Subversion

Suggerimenti qui elencati non sono obbligatori, ma sono consigliati in modo da facilitare il nostro sviluppo.

## Messaggi commit

Qui alcuni suggerimenti per come scrivere un buon messaggio di commit:

### Commit tag

* Nel messaggio di commit tutti tag vengono messi per primo
* I tag vengono messi fra parentesi quadrate (ad. es `[tag]`)
* Se un commit rientra nell'ambito di piu' di un tag allora tag vengono concatenati come `[tag1] [tag2] [tag3]` ...

<table border="1" style="text-align: center; margin: 10px;">
<thead><tr>
<td>Nome tag</td>
<td>Descrizione</td>
<td>Esempio</td>
</tr></thead>
<tr>
<td>i18n</td>
<td>Il termine inglese internationalization viene spesso abbreviato come i18n, dove il numero 18 fa riferimento al numero di lettere omesse ("nternationalizatio"); quindi questo tag si utilizza quando la modifica richiede nuove o modifiche nelle traduzioni dell'applicativo</td>
<td>`[i18n] Aggiunte colonne su frmFiltroEntita e uscGestioneEventi per import UGOV`</td>
</tr>
</table>
