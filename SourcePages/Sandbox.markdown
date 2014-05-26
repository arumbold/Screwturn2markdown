




## Import DATI
Tracciati per l'importazione dei dati in AppManager





### IGAMMA_ART.DAT
Tabella anagrafica che contiene tutti i prodotti
<table cellspacing="2" cellpadding="2" border="0">
<tr>
<td>CHIAVE</td>
<td>Chiave univoca del record ereditata dai dati di origine. Questo valore è una stringa che deve identificare in maniera univoca la riga.</td>
<td>Character</td>
<td>200</td>
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>COD ART</td>
<td>Codice dell'articolo</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>DES ART</td>
<td>Descrizione dell'articolo</td>
<td>Text</td>
<td>8000</td>
</tr><tr>
<td>COD FAM</td>
<td>Codice della famiglia degli articoli</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>DES FAM</td>
<td>Descrizione della famiglia</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>COD SFAM</td>
<td>Codice della sottofamiglia degli articoli</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>DES SFAM</td>
<td>Descrizione della sottofamiglia</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>COD GRUPPO1</td>
<td>Codice del Gruppo merceologico dell'articolo (1)</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>DES GRUPPO1</td>
<td>Descrizione del gruppo merceologico dell'articolo (1)</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>COD GRUPPO2</td>
<td>Codice del Gruppo merceologico dell'articolo (2)</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>DES GRUPPO2</td>
<td>Descrizione del gruppo merceologico dell'articolo (2)</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>UM1</td>
<td>Unità di misura 1</td>
<td>Character (fixed length)</td>
<td>3</td>
</tr><tr>
<td>UM2</td>
<td>Seconda unità di misura</td>
<td>Character (fixed length)</td>
<td>3</td>
</tr><tr>
<td>FATTORE CONVERSIONE</td>
<td>Fattore di conversione. Coefficiente che se moltiplicato alla quantità 1 riporta la quantità di una seconda unità di misura. Per passare dalla unità di misura 2 alla unità di misura 1 occorre eseguire una divisione</td>
<td>Decimal</td>
<td>16,10</td>
</tr><tr>
<td>DES GR STAT1</td>
<td>Descrizione del gruppo statico dell'articolo (1)</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>DES GR STAT2</td>
<td>Descrizione del gruppo statico dell'articolo (2)</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>QUANTITA MINIMA VENDITA</td>
<td>Quantità minima di vendita</td>
<td>Decimal</td>
<td>19,8</td>
</tr><tr>
<td>DAT ULT MOD</td>
<td>Data di ultima modifica del record. Attenzione: Questa data deve essere composta nel seguente formato: Giorno (2 caratteri) + Mese (2 caratteri) + Anno (4 caratteri) + Ore (2 caratteri) + Minuti (2 caratteri) + Secondi (2 caratteri).</td>
<td>DateTime</td>
<td>16</td>
</tr>
</table>



### IGAMMA_ART_CONF.DAT
Anagrafica dei codici confezione
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>CHIAVE</td>
<td>Chiave univoca del record ereditata dai dati di origine. Questo valore è una stringa che deve identificare in maniera univoca la riga.</td>
<td>Character</td>
<td>200</td>
</tr><tr>
<td>COD ART</td>
<td>Codice dell'Articolo</td>
<td>Character</td>
<td>25</td>
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>COD CONF</td>
<td>Codice della confezione</td>
<td>Character</td>
<td>4</td>
</tr><tr>
<td>PZ CONFEZ</td>
<td>Pezzi della confezione</td>
<td>Decimal</td>
<td>12,3</td>
</tr><tr>
<td>FLG PREF</td>
<td>Flag per definire il preferenziale</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>DAT ULT MOD</td>
<td>Data di ultima modifica del record. Attenzione: Questa data deve essere composta nel seguente formato: Giorno (2 caratteri) + Mese (2 caratteri) + Anno (4 caratteri) + Ore (2 caratteri) + Minuti (2 caratteri) + Secondi (2 caratteri).</td>
<td>DateTime</td>
<td>16</td>
</tr>
</table>



### IGAMMA_ART_ULTACQ.DAT
Tabella di anagrafica del prodotto ultimo acquisto del fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>CHIAVE</td>
<td>Chiave univoca del record ereditata dai dati di origine. Questo valore è una stringa che deve identificare in maniera univoca la riga.</td>
<td>Character</td>
<td>200</td>
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>COD ART</td>
<td>Codice dell'articolo</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>PROG</td>
<td># NON Visibile in IPAD # Progressivo</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>VALUTA</td>
<td>Valuta</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>PRZ</td>
<td>Prezzo</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>DATA DOC</td>
<td># NON Visibile in IPAD # Data del documento</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>NUM DOC</td>
<td># NON Visibile in IPAD # Numero del documento</td>
<td>Integer</td>
<td>7</td>
</tr><tr>
<td>COD CLFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>TIPO DOC</td>
<td>Indicatore sulla tipologia di documento</td>
<td>Character</td>
<td>50</td>
</tr><tr>
<td>DAT ULT MOD</td>
<td>Data di ultima modifica del record. Attenzione: Questa data deve essere composta nel seguente formato: Giorno (2 caratteri) + Mese (2 caratteri) + Anno (4 caratteri) + Ore (2 caratteri) + Minuti (2 caratteri) + Secondi (2 caratteri).</td>
<td>DateTime</td>
<td>16</td>
</tr>
</table>



### IGAMMA_ART_ULTVEN.DAT
Tabella di anagrafica del prodotto ultima vendita del cliente
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>CHIAVE</td>
<td>Chiave univoca del record ereditata dai dati di origine. Questo valore è una stringa che deve identificare in maniera univoca la riga.</td>
<td>Character</td>
<td>200</td>
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>COD ART</td>
<td>Codice dell'articolo</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>PROG</td>
<td># NON Visibile in IPAD # Progressivo</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>VALUTA</td>
<td>Valuta</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>PRZ</td>
<td>Prezzo</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>DATA DOC</td>
<td># NON Visibile in IPAD #Data del documento di riferimento</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>NUM DOC</td>
<td># NON Visibile in IPAD #Numero del documento di riferimento</td>
<td>Integer</td>
<td>7</td>
</tr><tr>
<td>COD CLFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>RAG SOC</td>
<td># NON Visibile in IPAD # Ragione sociale</td>
<td>Character</td>
<td>40</td>
</tr>
</table>



### IGAMMA_CITTA.DAT
Lista anagrafica delle città
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>CODICE</td>
<td>Codice della citta</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>DESCRIZIONE</td>
<td>descrizione della citta</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>CAP</td>
<td>Codice Avviamento Postale</td>
<td>Character (fixed length)</td>
<td>8</td>
</tr><tr>
<td>PROVINCIA</td>
<td>provincia</td>
<td>Character (fixed length)</td>
<td>2</td>
</tr>
</table>



### IGAMMA_CLIFOR.DAT
Anagrafica clienti/fornitore di un progetto o ditta (azienda) che viene importata in automatico; ogni riga è un cliente della ditta
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>RAG SOC</td>
<td>Ragione sociale</td>
<td>Text</td>
<td>8000</td>
</tr><tr>
<td>INDIRIZZO</td>
<td>Indirizzo</td>
<td>Text</td>
<td>8000</td>
</tr><tr>
<td>PARTITA IVA</td>
<td>Partita IVA</td>
<td>Character (fixed length)</td>
<td>12</td>
</tr><tr>
<td>CODICE FISCALE</td>
<td>Codice Fiscale</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>TELEFONO1</td>
<td>Numero di telefono 1 del cliente/fornitore</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>TELEFONO2</td>
<td>Numero di telefono 2 del cleinte/fornitore</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>FAX</td>
<td>Fax</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>CELLULARE</td>
<td>Telefono cellulare</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>E MAIL</td>
<td>indirizzo email</td>
<td>Character</td>
<td>100</td>
</tr><tr>
<td>INTERNET</td>
<td>Indirizzo internet del cliente (es http://www.apexnet.it)</td>
<td>Character</td>
<td>100</td>
</tr><tr>
<td>CAP</td>
<td>CAP</td>
<td>Character (fixed length)</td>
<td>8</td>
</tr><tr>
<td>CITTA</td>
<td>Citta</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>PROV</td>
<td>Provincia</td>
<td>Character (fixed length)</td>
<td>2</td>
</tr><tr>
<td>DAT ULT MOD</td>
<td>Data di ultima modifica del record nel formato ddmmyyyy (es: per il 2 marzo 2012, inserire 02032012)</td>
<td>Character</td>
<td>8</td>
</tr>
</table>



### IGAMMA_CLIFOR_AGE.DAT.
tabella di anagrafica agenti di un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>COD AGE</td>
<td>Codice dell'agente</td>
<td>Character (fixed length)</td>
<td>2</td>
</tr><tr>
<td>RAGSOC AGE</td>
<td>Ragione sociale dell'agente</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>PREFERENZIALE</td>
<td>Flag agente preferenziale (1 o 0)</td>
<td>Integer</td>
<td>1</td>
</tr>
</table>



### IGAMMA_CLIFOR_BLO.DAT
Tabella di anagrafica del blocco di un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>COD BLOCCO</td>
<td># NON Visibile in IPAD # Codice blocco </td>
<td>Integer</td>
<td>2</td>
</tr><tr>
<td>TIPO BLOCCO</td>
<td># NON Visibile in IPAD # Tipologia del blocco </td>
<td>Character</td>
<td>15</td>
</tr><tr>
<td>NOTA BLOCCO</td>
<td>Descrizione del blocco del cliente/fornitore</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>DATA BLOCCO</td>
<td># NON Visibile in IPAD # Data blocco </td>
<td>Date</td>
<td>10</td>
</tr>
</table>



### IGAMMA_CLIFOR_CON.DAT
tabella di anagrafica contatti di un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>ID CONTATTO</td>
<td>Identificativo univoco del contatto</td>
<td>Integer</td>
<td>8</td>
</tr><tr>
<td>COD CONTATTO</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character</td>
<td>10</td>
</tr><tr>
<td>TIPOCONTATTO</td>
<td>Tipologia del contatto (es: uff. acquisti)</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>PREFERENZIALE</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COGNOMENOME</td>
<td>Cognome Nome del Contatto</td>
<td>Character</td>
<td>50</td>
</tr><tr>
<td>TELEFONO</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>CELLULARE</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character</td>
<td>20</td>
</tr>
</table>



### IGAMMA_CLIFOR_DEST.DAT
Tabella di anagrafica della destinazione dei prodotti acquistati da un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1= Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente/Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>PREFERENZIALE</td>
<td>Flag di destinazione Preferenziale</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>COD DEST</td>
<td>Codice della Destinazione dei prodotti</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>RAGSOC DEST</td>
<td>Ragione Sociale della Destinazione dei pordotti</td>
<td>Text</td>
<td>8000</td>
</tr><tr>
<td>INDIRIZZO</td>
<td>Indirizzo di destinazione</td>
<td>Text</td>
<td>8000</td>
</tr><tr>
<td>CAP</td>
<td>Codice Avviamento Postale della destinazione</td>
<td>Character (fixed length)</td>
<td>8</td>
</tr><tr>
<td>CITTA</td>
<td>Citta di destinazione dei prodotti</td>
<td>Text</td>
<td>8000</td>
</tr><tr>
<td>PROVINCIA</td>
<td>Provincia di destinazione</td>
<td>Character (fixed length)</td>
<td>2</td>
</tr><tr>
<td>STAMPA PREF DOC</td>
<td>Descrizione del tipo di stampa preferito per li documento</td>
<td>Character</td>
<td>6</td>
</tr><tr>
<td>TELEFONO</td>
<td>Recapito telefonico della destinazione dei prodotti</td>
<td>Character (fixed length)</td>
<td>20</td>
</tr><tr>
<td>CELLULARE</td>
<td>Recapito telefonico della destinazione dei prodotti</td>
<td>Character (fixed length)</td>
<td>20</td>
</tr><tr>
<td>MAIL</td>
<td>Recapito posta elettronica della destinazione dei prodotti</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>FAX</td>
<td>Recapito fax della destinazione dei prodotti</td>
<td>Character (fixed length)</td>
<td>20</td>
</tr><tr>
<td>NOTE DEST</td>
<td>Campo descrittivo libero per la destinazione dei prodotti</td>
<td>Text</td>
<td>512</td>
</tr>
</table>



### IGAMMA_CLIFOR_DETCON.DAT
tabella di anagrafica dei dettagli contatto di un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>ID CONTATTO</td>
<td>Identificativo univoco del contatto</td>
<td>Integer</td>
<td>8</td>
</tr><tr>
<td>TIPO CONTATTO</td>
<td>Tipologia del contatto (es: uff. acquisti)</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>PREF</td>
<td>Preferenziale (1 o 0)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COGNOME NOME</td>
<td>Cognome Nome del contatto</td>
<td>Character</td>
<td>50</td>
</tr><tr>
<td>INDIRIZZO</td>
<td>indirizzo</td>
<td>Character</td>
<td>50</td>
</tr><tr>
<td>CAP</td>
<td>Codice Avviamento Postale</td>
<td>Character</td>
<td>8</td>
</tr><tr>
<td>CITTA</td>
<td>Città</td>
<td>Character</td>
<td>50</td>
</tr><tr>
<td>PR</td>
<td>Provincia</td>
<td>Character (fixed length)</td>
<td>2</td>
</tr><tr>
<td>ORARIO LAVORO</td>
<td>Orario di Lavoro</td>
<td>Character</td>
<td>100</td>
</tr><tr>
<td>TELEFONO1</td>
<td>Numero di telefono 1</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>TELEFONO2</td>
<td>Numero di telefono 2</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>CELLULARE1</td>
<td>Numero di telefono cellulare 1</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>CELLULARE2</td>
<td>Numero di telefono cellulare 2</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>TELEF CASA</td>
<td>Numero di telefono casa</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>FAX</td>
<td>Numero di FAX</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>EMAIL1</td>
<td>Indirizzo e-mail del contatto 1</td>
<td>Character</td>
<td>100</td>
</tr><tr>
<td>EMAIL2</td>
<td>Indirizzo e-mail del contatto 2</td>
<td>Character</td>
<td>100</td>
</tr><tr>
<td>ALTRO INDIRIZZO1</td>
<td>Altro indirizzo 1</td>
<td>Character</td>
<td>50</td>
</tr><tr>
<td>ALTRO INDIRIZZO2</td>
<td>Altro indirizzo 2</td>
<td>Character</td>
<td>50</td>
</tr><tr>
<td>NOTE</td>
<td>Campo Note Libero</td>
<td>Text</td>
<td>9999</td>
</tr>
</table>



### IGAMMA_CLIFOR_FATT.DAT
tabella di anagrafica del fatturato mensile di un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>ANNO</td>
<td>Anno</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>MESE</td>
<td>Mese</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>FATTURATO</td>
<td>Fatturato Totale</td>
<td>Decimal</td>
<td>28,8</td>
</tr>
</table>



### IGAMMA_CLIFOR_INFO.DAT
tabella di anagrafica delle informazioni di un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>MACROAREA</td>
<td>Macroarea di riferimento dell'azienda</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>DATA CREAZIONE</td>
<td>Data di creazione del record</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>AREA</td>
<td>Area di appartenenza dell'azienda</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>ZONA</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>MACROCATEGORIA</td>
<td>Macrocategoria di appartenenza dell'azienda</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>DATA ULT DOC NO FT</td>
<td>Data dell'ultimo documento non fatturato</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>CATEGORIA</td>
<td>Categoria di appartenenza dell'azienda</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>DATA ULT DOC FT</td>
<td>Data ultimo documento fatturato</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>DATA ULT ORDINE</td>
<td>Data dell'ultimo ordine</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>RAGGR1</td>
<td>Primo livello di raggruppamento del cliente</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>FIDO AZIENDALE</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Decimal</td>
<td>15,2</td>
</tr><tr>
<td>RAGGR2</td>
<td>Secondo livello di raggruppamento del cliente</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>RAGGR3</td>
<td>Terzo livello di raggruppamento del cliente</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>DATA BLOCCO</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>ASPETTO DEI BENI</td>
<td>Aspetto dei beni</td>
<td>Character</td>
<td>40</td>
</tr>
</table>



### IGAMMA_CLIFOR_LISTVEN.DAT
Tabella di anagrafica dei listini di vendita del cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>ARTICOLO</td>
<td>Codice Articolo</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>VARIANTE</td>
<td>Variante</td>
<td>Character (fixed length)</td>
<td>20</td>
</tr><tr>
<td>DESCRIZIONE</td>
<td>Descrizione articolo</td>
<td>Character</td>
<td>72</td>
</tr><tr>
<td>VALUTA</td>
<td>Valuta</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>DATAINIZIO</td>
<td>Data inizio del listino</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>DATAFINE</td>
<td>Data di fine del listino</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>PREZZO</td>
<td>Prezzo</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>SC1</td>
<td>Sconto 1</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC2</td>
<td>Sconto 2</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC3</td>
<td>Sconto 3</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC4</td>
<td>Sconto 4</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC5</td>
<td>Sconto 5</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC6</td>
<td>Sconto 6</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SCIMP</td>
<td>Sconto Importo</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>MAGG1</td>
<td>Maggioranzione 1</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>MAGG2</td>
<td>Maggiorazione 2</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>MAGGIMP</td>
<td>Maggiornazione a importo</td>
<td>Decimal</td>
<td>28,8</td>
</tr>
</table>



### IGAMMA_CLIFOR_NOTE.DAT
tabella delle note di un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>PROGRESSIVO</td>
<td>Progressivo di nota</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>TIPO NOTA</td>
<td>Tipologia di nota (es: resp acquisti)</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>NOTA</td>
<td>Note libere</td>
<td>Text</td>
<td>9999</td>
</tr>
</table>



### IGAMMA_CLIFOR_RIGHDOC.DAT
Tabella di anagrafica per le righe documento di un cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>CHIAVE</td>
<td>Chiave univoca del record ereditata dai dati di origine</td>
<td>Character</td>
<td>200</td>
</tr><tr>
<td>NUM REG</td>
<td>Numero di registrazione del documento</td>
<td>Character (fixed length)</td>
<td>12</td>
</tr><tr>
<td>PRG RIGA</td>
<td>Progressivo di riga</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>COD RIGA</td>
<td>Codice riga (es. R3IRB; 02661; F94PA13150; F7CSTP; F6SC10510)</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>DES RIGA</td>
<td>Descrizione riga</td>
<td>Text</td>
<td>1600</td>
</tr><tr>
<td>COD UM</td>
<td>Codice unità di misura (es: KG, PZ, CT)</td>
<td>Character (fixed length)</td>
<td>3</td>
</tr><tr>
<td>QTA</td>
<td>Quantità</td>
<td>Decimal</td>
<td>19,8</td>
</tr><tr>
<td>PRZ LORDO</td>
<td>Prezzo lordo, comprensivo di IVA del prodotto </td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>PRZ NETTO</td>
<td>Prezzo Netto del prodotto </td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>IMPORTO</td>
<td>Importo della riga del documento</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>QTA TRESF</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>19,8</td>
</tr><tr>
<td>SC 1</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC 2</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC 3</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC 4</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC 5</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC 6</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SC IMP</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>MAG 1</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>MAG 2</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>MAG IMP</td>
<td>#NON UTILIZZATO # Inserire stringa vuota</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>DATA CONFERMA</td>
<td>Data del documento</td>
<td>Date</td>
<td>10</td>
</tr>
</table>



### IGAMMA_CLIFOR_SCADOC.DAT
tabella delle scadenze dei documenti del cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>CHIAVE</td>
<td>Campo Chiave della tabella (deve essere univoco)</td>
<td>Character</td>
<td>154</td>
</tr><tr>
<td>NUM REG</td>
<td>Numero di registrazione del documento (numero di collegamento alla testata del documento)</td>
<td>Character (fixed length)</td>
<td>12</td>
</tr><tr>
<td>COD RATA</td>
<td>#NON Visibile in IPAD # Codice della rata</td>
<td>Character</td>
<td>7</td>
</tr><tr>
<td>DAT SCAD</td>
<td>Data di scadenza</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>IMPORTO</td>
<td>Importo della scadenza</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>NETTO PREV</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>DES TIPO</td>
<td>Descrizione del tipo (es: Rim.diretta; Ric. banc.; Bonifico)</td>
<td>Character</td>
<td>12</td>
</tr><tr>
<td>DES STATO</td>
<td>Descrizione dello stato (es: Chiuso, aperto)</td>
<td>Character</td>
<td>6</td>
</tr><tr>
<td>DES TIPO PRES</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character</td>
<td>14</td>
</tr><tr>
<td>DES OPERAZIONE</td>
<td>#NON Visibile in IPAD # Descrizione dell'operazione (es: Pag/Risc; Chiusura; Creazione; Insoluto)</td>
<td>Character</td>
<td>10</td>
</tr><tr>
<td>FLG DA LIB</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>FLG SOSP</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>DES BANCA AGENZIA</td>
<td>#NON Visibile in IPAD #  Descrizione banca / agenzia</td>
<td>Character</td>
<td>81</td>
</tr>
</table>



### IGAMMA_CLIFOR_TESTDOC.DAT
tabella anagrafica delle testate dei documenti di cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>TIPOSTATO DOC</td>
<td>Tipo stato documento</td>
<td>Integer</td>
<td>2</td>
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>COD TIPODOC</td>
<td>Codice tipo documento</td>
<td>Integer</td>
<td>2</td>
</tr><tr>
<td>COD STIPODOC</td>
<td>Codice sottotipo documento</td>
<td>Integer</td>
<td>2</td>
</tr><tr>
<td>FLGDAEVADERE</td>
<td>Flag da evadere</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>DATADOC</td>
<td>Data del documento</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>NUMREG</td>
<td>Numero di registrazione del documento utilizzato come collegamento tra la testata e le righe</td>
<td>Character (fixed length)</td>
<td>12</td>
</tr><tr>
<td>TIPODOC</td>
<td>Tipo documento gestionale (CLS-DDT; CLS-ORDINE; CLP-ORDINE)</td>
<td>Character (fixed length)</td>
<td>14</td>
</tr><tr>
<td>TIPO</td>
<td>Tipo (es:DdT; Ordine Cl.)</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>SOTTOTIPO</td>
<td>Sottotipo (es: Ven/Acq; Normale)</td>
<td>Character</td>
<td>20</td>
</tr><tr>
<td>DATAREG</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>SEZIONALE</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character (fixed length)</td>
<td>2</td>
</tr><tr>
<td>NUMDOC</td>
<td>#NON Visibile in IPAD # Numero del documento</td>
<td>Integer</td>
<td>7</td>
</tr><tr>
<td>DOCORIG</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character</td>
<td>10</td>
</tr><tr>
<td>DEPOSITO</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character (fixed length)</td>
<td>2</td>
</tr><tr>
<td>VALUTA</td>
<td>Valuta</td>
<td>Character (fixed length)</td>
<td>4</td>
</tr><tr>
<td>TOTALEDOC</td>
<td>Totale del documento</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>DATACONS</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>SCADENZE</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>ESTCONT</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>DATA FATTURA</td>
<td>Data della fattura</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>NUM FATTURA</td>
<td>Numero di fattura</td>
<td>Character</td>
<td>20</td>
</tr>
</table>



### IGAMMA_CLIFOR_TIPI_LISTVEN.DAT
Tabella di anagrafica della tipologia dei listini vendite dei clienti/fornitori
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>IND LISTINO</td>
<td>Indicatore sulla tipologia del listino</td>
<td>Integer</td>
<td>2</td>
</tr><tr>
<td>DES TIPO LISTINO</td>
<td>Descrizione tipo listino</td>
<td>Character</td>
<td>50</td>
</tr><tr>
<td>FLGVENACQ</td>
<td>Flag Tipo Vendita</td>
<td>Integer</td>
<td>1</td>
</tr>
</table>



### IGAMMA_CLIFOR_VEN.DAT
Anagrafica delle condizioni di vendita del cliente/fornitore
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>PAGAMENTO</td>
<td>Pagamento (es: Rimessa diretta a vista fattura; R.D. 60 GG. DATA FATTURA)</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>BANCA</td>
<td>Banca</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>AGENZIA</td>
<td>Agenzia</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>LISTINO ANAGRAFICO</td>
<td>Listino anagrafico</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>LISTINO ARTICOLI</td>
<td>#NON UTILIZZATO # Inserire Null</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>VALUTA</td>
<td>Valuta</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>SCONTI ANAG PERC</td>
<td>Sconti anagrafici in percentuale</td>
<td>Character</td>
<td>115</td>
</tr><tr>
<td>SCONTI ANAG IMP</td>
<td>Sconti anagrafica imponibile</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>MAGGIORAZIONE ANAG PERC</td>
<td>Maggiorazione anagrafica percentuale</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>SCONTO PIEDE</td>
<td>Sconto piede</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>COD CONDPAG</td>
<td>Codice del listino anagrafico</td>
<td>Character</td>
<td>50</td>
</tr>
</table>



### IGAMMA_CONDPAG.DAT
Condizioni di pagamento
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>CODICE</td>
<td>Codice condizioni di pagamento</td>
<td>Character (fixed length)</td>
<td>6</td>
</tr><tr>
<td>DESCRIZIONE</td>
<td>descrizione condizioni di pagamento</td>
<td>Character</td>
<td>40</td>
</tr>
</table>



### IGAMMA_GIACENZE.DAT
Tabella delle giacenze dei prodotti
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD ARTICOLO</td>
<td>Codice dell'articolo</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>COD DEPOSITO</td>
<td>Codice identificativo del deposito</td>
<td>Character (fixed length)</td>
<td>2</td>
</tr><tr>
<td>QUANTITA</td>
<td>Quantità disponibile in giacenza</td>
<td>Decimal</td>
<td>19,8</td>
</tr><tr>
<td>UM1</td>
<td>Unità di misura 1</td>
<td>Character (fixed length)</td>
<td>3</td>
</tr>
</table>



### IGAMMA_LISTINI.DAT
Tabella di anagrafica dei listini per prodotto
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD LIST</td>
<td>Codice del listino</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>COD ART</td>
<td>Codice dell'articolo</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>PREZZO</td>
<td>Prezzo dell'articolo per il listino in corso</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>PREZZO NETTO</td>
<td>Prezzo netto dell'articolo per il listino in corso</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>UM1</td>
<td>#NON Visibile in IPAD # Unità di misura 1</td>
<td>Character (fixed length)</td>
<td>3</td>
</tr><tr>
<td>DATA INIZIO</td>
<td>Data di inizio validità del listino</td>
<td>Date</td>
<td>10</td>
</tr><tr>
<td>DATA FINE</td>
<td>Data di fine validità del listino</td>
<td>Date</td>
<td>10</td>
</tr>
</table>



### IGAMMA_STOART.DAT
Dati storici degli articoli
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>COD ART</td>
<td>Codice Articolo</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>NUM RIGHE</td>
<td>Numero identificativo di riga</td>
<td>Integer</td>
<td>10</td>
</tr><tr>
<td>ULT NUM REG</td>
<td>Ultimo Numero registro</td>
<td>Character (fixed length)</td>
<td>12</td>
</tr><tr>
<td>ULT PROG RIGA</td>
<td>Ultimo Progressivo riga</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>DESC ARTICOLO</td>
<td>Descrizione Articolo</td>
<td>Text</td>
<td>1600</td>
</tr><tr>
<td>ULT QTA</td>
<td>Ultimo valore di quantità</td>
<td>Decimal</td>
<td>19,8</td>
</tr><tr>
<td>ULT PRZ</td>
<td>Ultimo prezzo</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>ULT SC PER1</td>
<td>Ultimo sconto percentuale 1</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>ULT SC PER2</td>
<td>Ultimo sconto percentuale 2</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>ULT SC PER3</td>
<td>Ultimo sconto percentuale 3</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>ULT SC PER4</td>
<td>Ultimo sconto percentuale 4</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>ULT SC PER5</td>
<td>Ultimo sconto percentuale 5</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>ULT SC PER6</td>
<td>Ultimo sconto percentuale 6</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>ULT SC IMPORTO</td>
<td>Ultimo sconto importo</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>ULT MAG PER1</td>
<td>Ultimo sconto maggiorazione percentuale 1</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>ULT MAG PER2</td>
<td>Ultimo sconto maggiorazione percentuale 2</td>
<td>Decimal</td>
<td>6,3</td>
</tr><tr>
<td>ULT MAG IMPORTO</td>
<td>Ultimo sconto maggiorazione importo</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>ULT DATA</td>
<td>Date</td>
<td>10</td>
</tr>
</table>



## Import Catalogo
Tracciati per l'importazione dei dati multimediali in AppManager





### IGAMMA_CATALOGO.DAT
Tracciato per l'importazione di dati multimediali.</br>
All'interno dell'iPad, nella sezione catalogo, è possibile mostrare le fotografie degli articoli in una gerarchia di cartelle che rappresentano la struttura merceologica ( famiglia, gruppo, ecc).</br>
Questo tracciato descrive tale gerarchia.
La cartella con le immagini da importare deve rispcchiare questo criterio:
1. Deve contenere tutte le fotografie da importare.
2. Le fotografie devono essere tutte nella cartella principale
3. Le fotografie devono contenere, nel nome, il codice dell'articolo.
4. La cartella deve contenere il file di testo delimitato IGAMMA_CATALOGO.DAT che descrive la struttura merceologica degli articoli
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>NOMEFILE</td>
<td>Nome del file da importare. Deve contenere il codice dell'articolo (13243.jpg)</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>TITOLO</td>
<td>Nome descrittivo del file (es: Piatto in porcellana)</td>
<td>Text</td>
<td>8000</td>
</tr><tr>
<td>COD ART</td>
<td>Codice dell'articolo</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>L1</td>
<td>Livello 1 (es: Piatti)</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>L2</td>
<td>Livello 2 (es: Porcellane)</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>L3</td>
<td>Livello 3</td>
<td>Character</td>
<td>30</td>
</tr><tr>
<td>L4</td>
<td>Livello 4</td>
<td>Character</td>
<td>30</td>
</tr>
</table>



## Export
Tracciati per l'esportazione dei dati da AppManager a gestionale





### IGAMMA_AM_ORDxx.DAT (Ordini)
Tracciato per l'esportazione dei dati da appManager al gestionale

Nome del file:"IGAMMA_AM_ORD_yyyyMMdd_HHmmss_prg.DAT, dove:

* yyyy Anno
* MM Mese
* HH Ore
* mm Minuti
* ss Secondi
* prg progressivo 
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>COD EXT ORD</td>
<td>Codice dell'ordine</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>T DAT ORDINE</td>
<td>Data dell'ordine</td>
<td>Character (fixed length)</td>
<td>25</td>
</tr><tr>
<td>NR ORD ORIG</td>
<td>Numero dell'ordine di origine</td>
<td>Decimal</td>
<td>17,6</td>
</tr><tr>
<td>T COD CLIFOR</td>
<td>Tipo cliente o Fornitore (0=cliente, 1=fornitore)</td>
<td>Decimal</td>
<td>38,6</td>
</tr><tr>
<td>T COD AGENTE</td>
<td>Codice agente</td>
<td>Character (fixed length)</td>
<td>3</td>
</tr><tr>
<td>T DAT CONS TES</td>
<td>Data di consegna della merce</td>
<td>Character (fixed length)</td>
<td>3</td>
</tr><tr>
<td>R DES NOTE</td>
<td>Nota di riga</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>R IND TIPO RIGA</td>
<td>Indicatore di riga</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>R COD ART</td>
<td>Codice articolo</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>R DES RIGA ORD</td>
<td>Descrizione riga ordine</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>R CDA UM1</td>
<td>Unità di misura 1</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>R CDA UM2</td>
<td>Unità di misura 2</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>R QTA1</td>
<td>Quantità 1 (decimal 15,3)</td>
<td>Decimal</td>
<td>19,8</td>
</tr><tr>
<td>R QTA2</td>
<td>Quantità 2 (decimal 15,3)</td>
<td>Decimal</td>
<td>19,8</td>
</tr><tr>
<td>R PREZZO1</td>
<td>Prezzo 1 (decimal 15,2)</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>R PREZZO2</td>
<td>Prezzo 2 (decimal 15,2)</td>
<td>Decimal</td>
<td>28,8</td>
</tr><tr>
<td>R IND TIPO OM</td>
<td>Indicatore tipo omaggio</td>
<td>Character</td>
<td>3</td>
</tr><tr>
<td>R SCONTO 1</td>
<td>Sconto 1</td>
<td>Character</td>
<td>3</td>
</tr><tr>
<td>R SCONTO2</td>
<td>Sconto 2</td>
<td>Character</td>
<td>3</td>
</tr>
</table>



### IGAMMA_AM_CFxx.DAT - (Clienti)
Tracciato per l'esportazione dei dati relativi alla modifica dati cliente dall' appManager al gestionale

Nome del file:"IGAMMA_AM_CF_yyyyMMdd_HHmmss.DAT, dove:

* yyyy Anno
* MM Mese
* HH Ore
* mm Minuti
* ss Secondi

<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>TELEFONO1</td>
<td>Numero di telefono</td>
<td>Character</td>
<td>3</td>
</tr><tr>
<td>TELEFONO2</td>
<td>Numero di telefono</td>
<td>Character</td>
<td>3</td>
</tr><tr>
<td>FAX</td>
<td>Numero di telefono fax</td>
<td>Character</td>
<td>3</td>
</tr><tr>
<td>CELLLULARE</td>
<td>Numero di telefono cellulare</td>
<td>Character</td>
<td>3</td>
</tr><tr>
<td>MAIL</td>
<td>Numero di telefono cellulare</td>
<td>Character</td>
<td>3</td>
</tr>
</table>



### IGAMMA_AM_CF_NOTE_xx.DAT - (Note cliente)
Note del cliente
<table cellspacing="2" cellpadding="2" border="0">
</tr><tr>
<td>COD DITTA</td>
<td>Codice della ditta</td>
<td>Integer</td>
<td>5</td>
</tr><tr>
<td>COD CLIFOR</td>
<td>Codice Cliente / Fornitore</td>
<td>Integer</td>
<td>6</td>
</tr><tr>
<td>TIPO CLIFOR</td>
<td>Tipologia (0=Cliente, 1=Fornitore)</td>
<td>Integer</td>
<td>1</td>
</tr><tr>
<td>PROGRESSIVO</td>
<td>Progressivo di nota</td>
<td>Integer</td>
<td>3</td>
</tr><tr>
<td>TIPO NOTA</td>
<td>Tipologia di nota (es: resp acquisti)</td>
<td>Character</td>
<td>40</td>
</tr><tr>
<td>NOTE</td>
<td>Note libere</td>
<td>Character</td>
<td>4000</td>
</tr>
</table>
