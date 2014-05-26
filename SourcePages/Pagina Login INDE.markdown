
## Anomalia nella Form di login
Anomalia riscontrata utilizzando pagina di login di default di INDE.
Il Problema si verifica quando si utilizzono delle lettere accentate nell'user e/o nella password.
Se vengono utilizzate le lettere accentate nella pagina di login di INDE esse vengono eliminate e questo compromette la possibilità di loggarsi all'applicativo se vengono fatte delle verifiche sulle credenziali immesse.


## Risoluzione al problema
Per risolvere il problema è necessario modificare il file login1.htm che utilizza INDE per creare la pagina di login.
Nel file si possono effettuare due tipi di modifiche per risolvere l'anomalia:

`{{
1. Modificare il charset definito utilizzando UTF-8
oppure
2. Eliminare charset dal file e a quel punto verrà utilizzato quello definito nel web.config
`}}

PS: Se l'applicativo è stato rilasciato creando le dll è necessario ricompilare le nuove dll con il nuovo file modificato.

