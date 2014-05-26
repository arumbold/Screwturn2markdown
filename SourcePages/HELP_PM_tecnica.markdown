
La videata della scheda Tecnica è la videata principale del progetto. In essa viene racchiuso la creazione, la modifica e la eventuale eliminazione delle schede tecniche.<br/><br/>
E' stata suddivisa in tre parti:

* [#Testata](#Testata): dove vengono richieste alcune informazioni generali sulla scheda;
* [#Prodotto](#Prodotto): a seconda della tipologia del prodotto([#shopper](#shopper), [#sacco](#sacco), [#avvolgente](#avvolgente), [#vaschetta](#vaschetta) e [#guanto](#guanto)) vengono visualizzati pannelli differenti con differenti campi;
* [#Imballaggio](#Imballaggio): che può essere di un solo tipo definito di seguito oppure di tutti tre i tipi:
    1. [#Confezione](#Confezione): suddivisibile in rotolo, bauletto, busta, astuccio o cartone;
    2. [#Packaging](#Packaging)
    3. [#Pallet](#Pallet)
* [#Allegati](#Allegati): dove vengono inseriti gli allegati alla scheda tecnica che verranno stampati con la scheda tecnica stessa;
* [#Scheda Prestazionale](#Scheda Prestazionale): inserimento della scheda prestazionale collegata alla scheda tecnica di partenza;



# Scheda Tecnica

La videata si apre in ricerca dei dati, per permettere all'operatore una ricerca immediata tramite codice, nel caso in cui siano già state inserite schede tecniche.<br/>
Se non ci sono ancora presenti nel data base schede tecniche, allora l'operatore dovrà inserirne una nuova, attraverso il pulsante ![](../Upload/PM/new.gif). Elenchiamo di seguito il significato dei campi presenti nella testata.<br/><br/>
* **Codice**: _campo obbligatorio_, codifica della scheda tecnica;
* **Descrizione**: _campo obbligatorio_, campo descrittivo che comparirà nella intestazione della stampa;
* **Stato**: _campo obbligatorio_ ma _non editabile_, gestito dal sistema, che pone direttamente lo stato della scheda tecnica in _BOZZA_;
* **Prodotto**: _campo obbligatorio_, con la possibilità di scelta tra _sacco, rotolo, vaschetta e guanto_, a seconda della scelta dell'operatore, nella [seconda](#prodotto) parte della videata si vedrà il pannello corrispondente al prodotto;
* **Confezione**: _campo opzionale_, con la possibilità di scelta tra _rotolo, bauletto, busta, astuccio e cartone_, a seconda della scelta dell'operatore, nella [terza](#confezione) parte della videata si potranno inserire i campi della confezione;
* **Descrizione Inglese**: _campo opzionale_, campo descrittivo in lingua inglese, che comparirà sotto l'intestazione della stampa;
* **Tipo**: _campo opzionale_, scelta della tipologia della scheda tecnica dai campi configurati precedentemente nella videata [Tipi Scheda Tecnica](HELP_PM_generale.ashx#Tipi_Scheda_Tecnica_5);
* **Fustella**: _campo opzionale_, scelta della fustella della scheda tecnica dai campi configurati precedentemente nella videata [Fustella](HELP_PM_generale.ashx#Fustella_2);
* **Formato**: _campo opzionale_, scelta del formato della scheda tecnica dai campi configurati precedentemente nella videata [Formati Scheda Tecnica](HELP_PM_generale.ashx#Formati_Scheda_Tecnica_1);
* **Materiale**: _campo opzionale_, scelta del materiale della scheda tecnica dai campi configurati precedentemente nella videata [Materiale](HELP_PM_generale.ashx#Materiale_3);
* **Colore**: _campo opzionale_, scelta del materiale della scheda tecnica dai campi configurati precedentemente nella videata [Colori](HELP_PM_generale.ashx#Colori_0);

- - -


<table><tr><td>
![](../Upload/PM/scheda1.png)
</td></tr></table>

Nella figura sopra riportata vi è una scheda tecnica salavata in stato Bozza.<br/>
Vi sono alcuni considerazioni da fare: i campi della testata sono tutti campi editabili, è presente un bottone ![](../Upload/PM/scheda3.jpg), che permette di modificare lo stato della scheda tecnica in stato _CHIUSO_, per consentire il proseguimento dell'iter della scheda.


<table><tr><td>
![](../Upload/PM/scheda2.png)
</td></tr></table>

Sopra viene riportata una testata di scheda tecnica in stato _ANNULLATA_, come si può vedere i campi della scheda sono tutti non modificabili e non cancellabili, la scheda resta solo in visione all'operatore.<br/>
Inoltre sono presenti altri campi e bottoni che ora vediamo in dettaglio.<br/>
* Campo _Revisione_: riporta il numero di revisione a cui è stata sottoposta la scheda tecnica. Campo che viene inserito manualmente dall'operatore nella videata delle [Revisione](HELP_PM_revisione);
* Bottone _Note Revisione_: apre la schermata delle [note di motivazione](HELP_PM_motivo) del tipo Revisione. Viene aperta in pop-up la videata delle [note di motivazione](HELP_PM_motivo), dove vengono elencate le motivazioni che l'operatore ha inserito durante la creazione della [Revisione](HELP_PM_revisione) della scheda tecnica.
* Bottone _Note Annullo_: apre la schermata delle [note di motivazione](HELP_PM_motivo) del tipo Cambio Stato. Anche in questo caso viene aperta in pop-up una videata, dove vengono elencate le motivazioni che l'operatore ha inserito durante il cambiamento di stato privo di [Autorizzazione](HELP_PM_auto).




# Prodotto
A seconda della scelta dell'operatore nella testata della scheda tecnica, il sistema riporta il prodotto corrispondente.
Il campo che determina questa scelta è ![](../Upload/PM/prodotto1.png)


L'operatore per ogni prodotto inserito ha inoltre la possibilità di inserire tre campi descrittivi di annotazione che verranno riportati in fase di stampa:<br/>
![](../Upload/PM/prodotto2.png)
<br/>

Inolte in ogni prodotto esiste un campo descrittivo dove l'operatore può inserire un motivo quando esegue delle modifiche al prodotto in fase di validazione.<br/>
![](../Upload/PM/prodotto3.png)
<br/>


## Shopper

Il prodotto Shopper è qui sotto riportato.

<table><tr><td>
![](../Upload/PM/shopper1.png)
</td></tr></table>

Nella videata i campi presenti sono tutti opzionali in modo da poter far gestire all'operatore la creazione del prodotto.<br/>
La tabella sotto riporta i campi con una breve descrizione, la tipologia del campo, se descrittivo o numerico e in caso di campo numerico l'eventuale unità di misura che verrà riportata nella stampa del prodotto (l'operatore non deve inserirla, verrà gestita in automatico dal sistema).<br/>
**Per avere maggior informazioni direttamente dall'applicativo, l'operatore può restare per qualche secondo con il mouse sopra al campo e comparirà una breve descrizione con l'eventuale unità di misura relativa.**<br/>

<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
<tr>
<td>Dimensione</td>
<td>Testo</td>
<td>dimensione dello shopper</td>
</tr><tr>
<td>Spessore</td>
<td>Numerico</td>
<td>spessore dello shopper</td>
<td>My</td>
</tr><tr>
<td>Peso</td>
<td>Numerico</td>
<td>peso unitario dello shopper</td>
<td>Gr</td>
</tr><tr>
<td>Peso Totale</td>
<td>Numerico</td>
<td>Peso totale dei prodotti</td>
<td>Gr</td>
</tr><tr>
<td>Capacità</td>
<td>Numerico</td>
<td>Capacità dello shopper </td>
<td>Gr</td>
</tr><tr>
<td>Fustella Larghezza</td>
<td>Numerico</td>
<td>Larghezza della fustella dello shopper </td>
<td>Cm</td>
</tr><tr>
<td>Fustella Profondità</td>
<td>Numerico</td>
<td>Profondità della fustella dello shopper </td>
<td>Cm</td>
</tr><tr>
<td>Manico</td>
<td>Selezionabile con menù a tendina </td>
<td>Configurabile dall'utente nell'apposita tabella||  </td>
</tr><tr>
<td>Manico Lunghezza</td>
<td>Numerico</td>
<td>Lunghezza del manico dello shopper </td>
<td>Cm</td>
</tr><tr>
<td>Manico Larghezza</td>
<td>Numerico</td>
<td>Larghezza del manico dello shopper </td>
<td>Cm</td>
</tr><tr>
<td>Saldatura Fondo</td>
<td>Selezionabile con menù a tendina</td>
<td>Colore della maniglia dello shopper </td>
<td> </td>
</tr><tr>
<td>Stampato Codice EAN</td>
<td>Testo</td>
<td>Scelta tra: _stampare sul manico_, _stampare sul fondo_, _stampare sul soffieto_</td>
</tr><tr>
<td>Codice EAN</td>
<td>Testo</td>
<td>Bar code dello shopper </td>
<td> </td>
</tr><tr>
<td>Stampato Colore</td>
<td>Testo</td>
<td>Descrittivo dove inserire il numero dei colori dello shopper </td>
<td> </td>
</tr><tr>
<td>Stampato</td>
<td>Testo</td>
<td>Scelta tra: _stampare sul manico_, _stampare sul fondo_, _stampare sul soffieto_, _stampa in esterno vedi immagine allegata_</td>
</tr>
</table>
<br/><br/><br/>
- - -

Nel riquadro Verde del pannello presente nella figura, l'operatore può inserire gli eventuali colori del prodotto.<br/>
I colori sono stati precedentemente configurati dall'operatore nella videata [Colori](HELP_PM_generale.ashx#Colori_0).
<br/><br/>
L'operatore potrà inserire 12 colori per prodotto, è importante ricordare che i primi sei colori che si trovano nella prima riga dell'elenco saranno quelli che verranno stampati nella prima riga del report del prodotto, mentre il colore dal 7 al 12 sono quelli che verranno stampati nella seconda riga del report.<br/>




## Sacco
Il prodotto Sacco è qui sotto riportato nella figura.

<table><tr><td>
![](../Upload/PM/sacco1.png)
</td></tr></table>

Nella videata i campi presenti sono tutti opzionali in modo da poter far gestire all'operatore la creazione del prodotto.<br/>
La tabella sotto riporta i campi con una breve descrizione, la tipologia del campo, se descrittivo o numerico e in caso di campo numerico l'eventuale unità di misura che verrà riportata nella stampa del prodotto (l'operatore non deve inserirla, verrà gestita in automatico dal sistema).<br/>
**Per avere maggior informazioni direttamente dall'applicativo, l'operatore può restare per qualche secondo con il mouse sopra al campo e comparirà una breve descrizione con l'eventuale unità di misura relativa.**<br/>

<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
</tr><tr>
<td>Dimensione</td>
<td>Testo</td>
<td>dimensione del sacco</td>
</tr><tr>
<td>Spessore</td>
<td>Numerico</td>
<td>spessore del sacco</td>
<td>My</td>
</tr><tr>
<td>Peso</td>
<td>Numerico</td>
<td>peso unitario del sacco</td>
<td>Gr</td>
</tr><tr>
<td>Peso Totale</td>
<td>Numerico</td>
<td>Peso totale dei prodotti</td>
<td>Gr</td>
</tr><tr>
<td>Capacità</td>
<td>Numerico</td>
<td>Capacità del sacco </td>
<td>Gr</td>
</tr><tr>
<td>Fustella Larghezza</td>
<td>Numerico</td>
<td>Larghezza della fustella del sacco</td>
<td>Cm</td>
</tr><tr>
<td>Fustella Profondità</td>
<td>Numerico</td>
<td>Profondità della fustella del sacco</td>
<td>Cm</td>
</tr><tr>
<td>Fascetta Altezza</td>
<td>Numerico</td>
<td>Altezza della fascetta del sacco</td>
<td>Cm</td>
</tr><tr>
<td>Fascetta Stampa</td>
<td>Numerico</td>
<td>Dimensione della fascetta durante la stampa</td>
<td>Cm</td>
</tr><tr>
<td>Maniglia Lunghezza</td>
<td>Numerico</td>
<td>Lunghezza della maniglia del sacco</td>
<td>Cm</td>
</tr><tr>
<td>Maniglia Larghezza</td>
<td>Numerico</td>
<td>Larghezza della maniglia del sacco</td>
<td>Cm</td>
</tr><tr>
<td>Maniglia Colore</td>
<td>Selezionabile con menù a tendina</td>
<td>Colore della maniglia del sacco</td>
<td> </td>
</tr><tr>
<td>Manico</td>
<td>Selezionabile con menù a tendina </td>
<td>Configurabile dall'utente nell'apposita tabella||  </td>
</tr><tr>
<td>Manico Lunghezza</td>
<td>Numerico</td>
<td>Lunghezza del manico del sacco </td>
<td>Cm</td>
</tr><tr>
<td>Manico Larghezza</td>
<td>Numerico</td>
<td>Larghezza del manico del sacco</td>
<td>Cm</td>
</tr><tr>
<td>Saldatura Fondo</td>
<td>Selezionabile con menù a tendina</td>
<td>Colore della maniglia del sacco</td>
<td> </td>
</tr><tr>
<td>Stampato Codice EAN</td>
<td>Testo</td>
<td>Scelta tra: _stampare sul manico_, _stampare sul fondo_, _stampare sul soffieto_</td>
</tr><tr>
<td>Codice EAN</td>
<td>Testo</td>
<td>Bar code del sacco</td>
<td> </td>
</tr><tr>
<td>Stampato Colore</td>
<td>Testo</td>
<td>Descrittivo dove inserire il numero dei colori del sacco</td>
<td> </td>
</tr><tr>
<td>Stampato</td>
<td>Testo</td>
<td>Scelta tra: _stampare sul manico_, _stampare sul fondo_, _stampare sul soffieto_, _stampa in esterno vedi immagine allegata_</td>
</tr>
</table>
<br/><br/><br/>
- - -

Nel riquadro Verde del pannello presente nella figura, l'operatore può inserire gli eventuali colori del prodotto.<br/>
I colori sono stati precedentemente configurati dall'operatore nella videata [Colori](HELP_PM_generale.ashx#Colori_0).
<br/><br/>
L'operatore potrà inserire 12 colori per prodotto, è importante ricordare che i primi sei colori che si trovano nella prima riga dell'elenco saranno quelli che verranno stampati nella prima riga del report del prodotto, mentre il colore dal 7 al 12 sono quelli che verranno stampati nella seconda riga del report.<br/>
Nella figura sottostante un esempio di come inserire i campi per una corretta stampa del prodotto.
<br/>

<table>
<thead><tr>
<td>Inserimento del prodotto</td>
<td>Stampa del prodotto</td>
</tr></thead>
</tr><tr>
<td>![](../Upload/PM/sacco2.png)</td>
<td>![](../Upload/PM/sacco3.png)</td>
</tr>
</table>


## Rotolo

<table><tr><td>
![](../Upload/PM/rotolo1.png)
</td></tr></table>

Nella videata i campi presenti sono tutti opzionali in modo da poter far gestire all'operatore la creazione del prodotto.<br/>
La tabella sotto riporta i campi con una breve descrizione, la tipologia del campo, se descrittivo o numerico e in caso di campo numerico l'eventuale unità di misura che verrà riportata nella stampa del prodotto (l'operatore non deve inserirla, verrà gestita in automatico dal sistema).<br/>
**Per avere maggior informazioni direttamente dall'applicativo, l'operatore può restare per qualche secondo con il mouse sopra al campo e comparirà una breve descrizione con l'eventuale unità di misura relativa.**<br/>

<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
</tr><tr>
<td>Dimensione</td>
<td>Testo</td>
<td>dimensione del rotolo</td>
</tr><tr>
<td>Grammatura</td>
<td>Numerico</td>
<td>grammatura del rotolo</td>
<td>Gr/m</td>
</tr><tr>
<td>Grammatura Tolleranza</td>
<td>Numerico</td>
<td>Tolleranza della grammatura del rotolo</td>
<td>%</td>
</tr><tr>
<td>Peso Anima</td>
<td>Numerico</td>
<td>Peso anima del rotolo</td>
<td>Gr</td>
</tr><tr>
<td>Peso Teorico</td>
<td>Numerico</td>
<td>Peso teorico del rotolo</td>
<td>Gr</td>
</tr><tr>
<td>Peso Teorico Tolleranza</td>
<td>Numerico</td>
<td>Tolleranza del peso teorico del rotolo</td>
<td>%</td>
</tr><tr>
<td>Spessore</td>
<td>Numerico</td>
<td>Spessore del rotolo</td>
<td>My</td>
</tr><tr>
<td>Spessore Tolleranza</td>
<td>Numerico</td>
<td>Tolleranza del spessore del rotolo</td>
<td>%</td>
</tr>
</table>
<br/><br/><br/>



## Vaschetta

<table><tr><td>
![](../Upload/PM/vaschetta1.png)
</td></tr></table>

Nella videata i campi presenti sono tutti opzionali in modo da poter far gestire all'operatore la creazione del prodotto.<br/>
La tabella sotto riporta i campi con una breve descrizione, la tipologia del campo, se descrittivo o numerico e in caso di campo numerico l'eventuale unità di misura che verrà riportata nella stampa del prodotto (l'operatore non deve inserirla, verrà gestita in automatico dal sistema).<br/>
**Per avere maggior informazioni direttamente dall'applicativo, l'operatore può restare per qualche secondo con il mouse sopra al campo e comparirà una breve descrizione con l'eventuale unità di misura relativa.**<br/>

<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
</tr><tr>
<td>Dimensione</td>
<td>Testo</td>
<td>dimensione della vaschetta</td>
</tr><tr>
<td>Peso</td>
<td>Numerico</td>
<td>Peso della vaschetta</td>
<td>Gr</td>
</tr><tr>
<td>Capacità</td>
<td>Numerico</td>
<td>Capacità contenitiva della vascehtta</td>
<td>Lt</td>
</tr><tr>
</tr>
</table>
<br/><br/><br/>



## Guanto

<table><tr><td>
![](../Upload/PM/guanto1.png)
</td></tr></table>

Nella videata i campi presenti sono tutti opzionali in modo da poter far gestire all'operatore la creazione del prodotto.<br/>
La tabella sotto riporta i campi con una breve descrizione, la tipologia del campo, se descrittivo o numerico e in caso di campo numerico l'eventuale unità di misura che verrà riportata nella stampa del prodotto (l'operatore non deve inserirla, verrà gestita in automatico dal sistema).<br/>
**Per avere maggior informazioni direttamente dall'applicativo, l'operatore può restare per qualche secondo con il mouse sopra al campo e comparirà una breve descrizione con l'eventuale unità di misura relativa.**<br/>

<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
</tr><tr>
<td>Dimensione</td>
<td>Testo</td>
<td>dimensione del guanto</td>
</tr><tr>
<td>Spessore</td>
<td>Numerico</td>
<td>Spessore del guanto</td>
<td>My</td>
</tr><tr>
<td>Peso</td>
<td>Numerico</td>
<td>Peso della vaschetta</td>
<td>Gr</td>
</tr>
</table>
<br/><br/><br/>





# Imballaggio
Gli imballaggi a differenza dei prodotti, non sono esclusivi l'uno con l'altro, dato che una scheda tecnica può persistere tutte le varie combinazioni di imballaggio.

L'operatore per ogni tipo di imbalaggio ha la possibilità di inserire tre campi descrittivi di annotazione che verranno riportati in fase di stampa:<br/>
![](../Upload/PM/prodotto2.png)
<br/>

Inolte in ogni imballaggio esiste un campo descrittivo dove l'operatore può inserire un motivo quando esegue delle modifiche al prodotto in fase di validazione.<br/>
![](../Upload/PM/prodotto3.png)
<br/>



## Confezione
L'operatore sceglie nella testata della scheda tecnica la tipologia di confezione che il prodotto dovrà assumere. Tale campo serve per la stampa della scheda tecnica, per definire il tipo di confezione.

Il campo che determina questa scelta è ![](../Upload/PM/confezione1.png)

La videata relativa all'inserimento o modifica della confezione in una scheda tecnica è riportata nella seguente figura:
<table><tr><td>
![](../Upload/PM/confezione2.png)
</td></tr></table>

Nella confezione i campi presenti sono tutti opzionali in modo da poter far gestire all'operatore la creazione.<br/>
La tabella sotto, riporta i campi con una breve descrizione, la tipologia del campo, se descrittivo o numerico e in cao di camp numerico l'eventuale unità di misura che verrà riportata nella stampa del prodotto (l'operatore n deve inserirla, verrà gestita in automatico dal sistema).<br/>
**Per avere maggior informazioni direttamente dall'applicativo, l'operatore può restare per qualche secondo con il mouse sopra al campo e comparirà una breve descrizione con l'eventuale unità di misura relativa.**<br/>

<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
</tr><tr>
<td>Numero</td>
<td>Numerico</td>
<td>Numero dei pezzi della confezione</td>
</tr><tr>
<td>Dimensione</td>
<td>Testo</td>
<td>dimensione del sacco</td>
</tr><tr>
<td>Descrizione</td>
<td>Testo</td>
<td>campo descrittivo della confezione</td>
</tr><tr>
<td>Descrizione Inglese</td>
<td>Testo</td>
<td>campo descrittivo della confezione in lingua inglese</td>
</tr><tr>
<td>Altezza</td>
<td>Numerico</td>
<td>Altezza della confezione</td>
<td>Cm</td>
</tr><tr>
<td>Peso Lordo</td>
<td>Numerico</td>
<td>Peso lordo (peso netto + tara) della confezione</td>
<td>Gr o Kg</td>
</tr><tr>
<td>Peso</td>
<td>Numerico</td>
<td>peso netto della confezione</td>
<td>Gr</td>
</tr><tr>
<td>Tara</td>
<td>Numerico</td>
<td>tara della confezione</td>
<td>Kg</td>
</tr><tr>
<td>Peso Anima</td>
<td>Numerico</td>
<td>peso anima della confezione</td>
<td>Gr</td>
</tr><tr>
<td>Fascetta Lunghezza</td>
<td>Numerico</td>
<td>Fascetta lunghezza della confezione</td>
<td>Cm</td>
</tr><tr>
<td>Fascetta Stampa</td>
<td>Numerico</td>
<td>Dimensione della fascetta durante la stampa</td>
<td>Cm</td>
</tr><tr>
<td>Astuccio Stampa</td>
<td>Numerico</td>
<td>Astuccio stampa della confezione</td>
<td>Cm</td>
</tr><tr>
<td>Astuccio Peso</td>
<td>Numerico</td>
<td>Astuccio peso della confezione</td>
<td>Gr</td>
</tr><tr>
<td>Codice EAN</td>
<td>Testo</td>
<td>Bar code della confezione</td>
</tr><tr>
<td>Stampato Colore</td>
<td>Testo</td>
<td>Descrittivo dove inserire il numero dei colori del sacco</td>
<td> </td>
</tr>
</table>
<br/>
Per la descrizione del riquadro verde dei colori si rimanda a [#Colore](#Colore)


<br/><br/>




## Packaging

La videata relativa all'inserimento o modifica dell'imbalaggio di tipo Packaging in una scheda tecnica è riportata nella seguente figura:
<table><tr><td>
![](../Upload/PM/pack1.png)
</td></tr></table>

Nel packaging i campi presenti sono tutti opzionali in modo da poter far gestire all'operatore la creazione.<br/>
La tabella sotto, riporta i campi con una breve descrizione, la tipologia del campo, se descrittivo o numerico e in cao di camp numerico l'eventuale unità di misura che verrà riportata nella stampa del prodotto (l'operatore n deve inserirla, verrà gestita in automatico dal sistema).<br/>
**Per avere maggior informazioni direttamente dall'applicativo, l'operatore può restare per qualche secondo con il mouse sopra al campo e comparirà una breve descrizione con l'eventuale unità di misura relativa.**<br/>

<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
</tr><tr>
<td>Dimensione</td>
<td>Testo</td>
<td>dimensione del sacco</td>
</tr><tr>
<td>Descrizione</td>
<td>Testo</td>
<td>campo descrittivo del packaging</td>
</tr><tr>
<td>Cartone Dispencer</td>
<td>Numerico</td>
<td>numero dei cartoni dispencer per il packag|| </td>
</tr><tr>
<td>Peso Lordo</td>
<td>Numerico</td>
<td>Peso lordo del packaging</td>
<td>Gr o Kg</td>
</tr><tr>
<td>Tara</td>
<td>Numerico</td>
<td>tara del packaging</td>
<td>Kg</td>
</tr><tr>
<td>Tara 2</td>
<td>Numerico</td>
<td>seconda tara del packaging</td>
<td>Kg</td>
</tr><tr>
<td>Tara 3</td>
<td>Numerico</td>
<td>terza tara dela packaging</td>
<td>Kg</td>
</tr><tr>
<td>Tolleranza</td>
<td>Numerico</td>
<td>tolleranza del packaging</td>
<td>%</td>
</tr><tr>
<td>Codice EAN</td>
<td>Testo</td>
<td>Bar code del packaging</td>
</tr><tr>
<td>Codice ITF</td>
<td>Testo</td>
<td>codice a barre per il riconoscimento del packaging</td>
</tr><tr>
<td>Stampato Colore</td>
<td>Testo</td>
<td>Descrittivo dove inserire il numero dei colori del sacco</td>
<td> </td>
</tr>
</table>
<br/>
Per la descrizione del riquadro verde dei colori si rimanda a [#Colore](#Colore)


<br/><br/>



## Pallet

La videata relativa all'inserimento o modifica dell'imbalaggio di tipo Pallet in una scheda tecnica è riportata nella seguente figura:
<table><tr><td>
![](../Upload/PM/pallet1.png)
</td></tr></table>

Nel pallet i campi presenti sono tutti opzionali in modo da poter far gestire all'operatore la creazione.<br/>
La tabella sotto, riporta i campi con una breve descrizione, la tipologia del campo, se descrittivo o numerico e in cao di camp numerico l'eventuale unità di misura che verrà riportata nella stampa del prodotto (l'operatore n deve inserirla, verrà gestita in automatico dal sistema).<br/>
**Per avere maggior informazioni direttamente dall'applicativo, l'operatore può restare per qualche secondo con il mouse sopra al campo e comparirà una breve descrizione con l'eventuale unità di misura relativa.**<br/>

<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
</tr><tr>
<td>Descrizione Pallet</td>
<td>Testo</td>
<td>campo descrittivo del pallet</td>
</tr><tr>
<td>Codifica Lotto</td>
<td>Testo</td>
<td>Codifica Lotto del pallet</td>
</tr><tr>
<td>Tolleranza</td>
<td>Numerico</td>
<td>tolleranza del packaging</td>
<td>%</td>
</tr><tr>
<td>Codice Cliente</td>
<td>Testo</td>
<td>campo di decodifica del cliente</td>
</tr>
</table>

# Allegati

In queto pannello l'utente può inserire, modificare o cancellare gli allegati che verranno stampati con la Scheda Tecnica.<br/>
Nella figura sotto viene riportata la schermata al momento della sua apertura.<br/>

![](../Upload/PM/allegati1.png)
<br/>
Per poter inserire un allegato è necessario inserire almeno un campo della schermata come la scelta del tipo di Stampa, dove l'utente può scegliere tra tre opzioni rappresentate di seguito:<br/>
![](../Upload/PM/allegati3.png)
<br/>
L'utente può inserire anche il campo descrittivo dell'allegato, che se presente verrà stampato come titolo dell'allegato stesso in stampa.<br/>
Salvando con il pulsante ![](../Upload/PM/update.gif), nella schermata sotto la descrizione dell'immagine compariranno due icone necessarie per il caricamento dell'allegato nel data base dell'applicativo.<br/>
![](../Upload/PM/allegati2.png)
<br/>
<br/>
Una breve descrizione di quali passi l'utente deve eseguire per caricare gli allegati:<br/>
Con il pulsante ![](../Upload/PM/upload.gif) l'utente inizia il caricamento dell'allegato. <br/>
La prima schermata che compare è la seguente:<br/>
![](../Upload/PM/allegati4.png)<br/>
dove l'utente attraverso il pulsante _Sfoglia_ accede ai documenti del proprio computer, con la scelta del file da caricare (schermata successiva)<br/>
![](../Upload/PM/allegati5.png)<br/>
attraverso il pulsante _Apri_ l'applicativo carica il file, chiedendo conferma all'utente del caricamento, attraverso il pulsante ![](../Upload/PM/upload.gif), come di seguito <br/>
![](../Upload/PM/allegati7.png)<br/>
Se l'operazione è andata a buon fine l'utente si trova nel campo dell'allegato il link dell'apertura, o se il file caricato è di piccole dimensioni, l'utente può vedere direttamente l'anteprima dell'immagine allegata.<br/>
![](../Upload/PM/allegati8.png)<br/>
A questo punto compare un terzo pulsante ![](../Upload/PM/zoom.gif), necessario per la visualizzazione dell'allegato.<br/>
<br/>
Il campo _Ordine Stampa_ ![](../Upload/PM/allegati9.png) presente in fondo alla videata, è un campo gestito dal sistema stesso, necessario all'utente per conoscere con quale ordinamento verrà stampato l'allegato caricato al momento della stampa finale della scheda tecnica.<br/>
Ovviamente l'utente può eseguire operazioni agli allegati della scheda tecnica, solo esclusivamente quando la scheda tecnica è in stato _BOZZA_. Nel momento in cui la scheda viene dichiarata in stato _COMPLETATA_, l'utente non èuò più modificare alcun allegato.




# Scheda Prestazionale

<table><tr><td>
I dati della scheda prestazionale si trovano all'interno della scheda tecnica, a cui essa viene legata.<br/>
Sotto viene riportata il pannello della scheda prestazionale, con tutti i campi possibili.<br/>
Di seguito trovate l'elenco dei campi con la relativa descrizione. Dove le relative unità di misura vengono riportate a livello di stampa della scheda.<br/>

![](../Upload/PM/prestazionale1.png)

<br/>
<table border="1">
<thead><tr>
<td>Nome</td>
<td>Tipo Carattere</td>
<td>Descrizione</td>
<td>Unità di misura</td>
</tr></thead>
</tr><tr>
<td>Peso Medio </td>
<td>Numerico</td>
<td>Peso medio</td>
<td>Gr o Kg</td>
</tr><tr>
<td>Peso Medio Tolleranza</td>
<td>Numerico</td>
<td>Peso medio Tolleranza</td>
<td>%</td>
</tr><tr>
<td>Numero</td>
<td>Numerico</td>
<td>campo numerico della scheda</td>
</tr><tr>
<td>Numero Pezzi Tolleranza </td>
<td>Numerico</td>
<td>numero pezzi in tolleranza della scheda</td>
<td>%</td>
</tr><tr>
<td>Pantoni</td>
<td>descrittivo</td>
<td>descrizione dei pantoni della scheda</td>
</tr><tr>
<td>DIMENSIONE</td>
</tr><tr>
<td>Larghezza</td>
<td>Numerico</td>
<td>Valore della larghezza della dimensione della scheda, l'utente può inserire il valore standard e la tolleranza</td>
<td>cm e %</td>
</tr><tr>
<td>Lunghezza</td>
<td>Numerico</td>
<td>Valore della lunghezza della dimensione della scheda, l'utente può inserire il valore standard e la tolleranza</td>
<td>cm e %</td>
</tr><tr>
<td>Profondità Soffietto</td>
<td>Numerico</td>
<td>Valore della profondità del soffietto della dimensione della scheda, l'utente può inserire il valore standard e la tolleranza</td>
<td>cm e %</td>
</tr><tr>
<td>Larghezza Bretella</td>
<td>Numerico</td>
<td>Valore della larghezza della bretella della scheda, l'utente può inserire il valore standard e la tolleranza</td>
<td>cm e %</td>
</tr><tr>
<td>Altezza Bretella</td>
<td>Numerico</td>
<td>Valore dell'altezza della bretella della scheda, l'utente può inserire il valore standard e la tolleranza</td>
<td>cm e %</td>
</tr><tr>
<td>RESISTENZA e ALLUNGAMENTO</td>
</tr><tr>
<td>Campo vuoto</td>
<td>Testo</td>
<td>campo descrittivo che verrà stampato (es. ALLA TRAZIONE BASATA SU ASTM D 882 B v=500 mm/min )</td>
</tr><tr>
<td>Senso Estrusione</td>
<td>Testo e Numerico</td>
<td>Valore del senso estrusione, l'utente può inserire il valore range e il valore tipico</td>
<td> </td>
</tr><tr>
<td>Allungamento</td>
<td>Testo e Numerico</td>
<td>Valore dell'allungamento, l'utente può inserire il valore range e il valore tipico</td>
</tr><tr>
<td>Saldatura Bretelle</td>
<td>Testo e Numerico</td>
<td>L'utente può inserire il valore range e il valore tipico</td>
</tr><tr>
<td>Saldatura Fondo</td>
<td>Testo e Numerico</td>
<td>L'utente può inserire il valore range e il valore tipico</td>
</tr><tr>
<td>RESISTENZA ALL'IMPATTO</td>
</tr><tr>
<td>Campo vuoto</td>
<td>Testo</td>
<td>campo descrittivo che verrà stampato (es. (DART TEST) BASATA SU ASTM D 1709 (A)  W50 (g))</td>
</tr><tr>
<td>Resistenza Impatto</td>
<td>Testo e Numerico</td>
<td>L'utente può inserire il valore range e il valore tipico</td>
<td> </td>
</tr><tr>
<td>RESISTENZA CADUTA</td>
</tr><tr>
<td>Campo vuoto</td>
<td>Testo</td>
<td>campo descrittivo che verrà stampato (es. TENUTA ACQUA BASATA SU UNI 7315)</td>
</tr><tr>
<td>Campo Vuoto Zavorra</td>
<td>Testo</td>
<td>descrizione della zavorra (es. ZAVORRA SABBIA ASCIUTTA)</td>
<td> </td>
</tr><tr>
<td>Resistenza alla Caduta</td>
<td>Testo</td>
<td>L'utente può inserire il valore zavorra, il valore standard ed inserire eventuali [#note](#note) precedentemente configurate</td>
</tr><tr>
<td>Resistenza al Carico</td>
<td>Testo</td>
<td>L'utente può inserire il valore zavorra, il valore standard ed inserire eventuali [#note](#note) precedentemente configurate</td>
</tr><tr>
<td>Opacità</td>
<td>Testo</td>
<td>Valore della opacità</td>
</tr><tr>
<td>Tenuta Acqua|| Testo</td>
<td>Valore della tenuta acqua|| </td>
</tr>
</table>
<br/>
<br/>
Il pulsante ![](../Upload/PM/note2.png) permette all'utente di aprire la finestra delle [Note](HELP_PM_note), per visualizzare il codice e la descrizione della nota scelta per la resistenza alla caduta o la resistenza al carico.
La finestra 

La scheda prestazionale se presente, viene stampata successivamente alla stampa della scheda tecnica ripotando i dati inseriti dall'utente con il layout simile a quello fornitoci.<br/>
