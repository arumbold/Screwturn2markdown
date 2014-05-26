
# Import Dati IGM
Tabelle di import
I files devono essere in formato delimitati con pipe separator "|"
## IGAMMA_ART.DAT
Contiene tutti i prodotti



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
<tr>
<td>PRG_ART</td>
<td> Progressivo univoco dell'articolo</td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_FAM</td>
<td> Codice della famiglia degli articoli</td>
</tr><tr>
<td>COD_SFAM</td>
<td> Codice della sottofamiglia degli articoli</td>
</tr><tr>
<td>COD_ART</td>
<td> Codice dell'articolo</td>
</tr><tr>
<td>DES_ART</td>
<td> Descrizione dell'articolo</td>
</tr><tr>
<td>DES_FAM</td>
<td> Descrizione della famiglia</td>
</tr><tr>
<td>DES_SFAM</td>
<td> Descrizione della sottofamiglia</td>
</tr><tr>
<td>COD_GRUPPO1</td>
<td> Codice del Gruppo merceologico dell'articolo (1)</td>
</tr><tr>
<td>COD_GRUPPO2</td>
<td> Codice del Gruppo merceologico dell'articolo (2)</td>
</tr><tr>
<td>DES_GRUPPO1</td>
<td> Descrizione del gruppo merceologico dell'articolo (1)</td>
</tr><tr>
<td>DES_GRUPPO2</td>
<td> Descrizione del gruppo merceologico dell'articolo (2)</td>
</tr><tr>
<td>UM1</td>
<td> Unità di misura 1</td>
</tr><tr>
<td>UM2</td>
<td> Seconda unità di misura</td>
</tr><tr>
<td>FAT_CONV</td>
<td> Fattore di conversione. Coefficiente che se moltiplicato alla quantità 1 riporta la quantità di una seconda unità di misura. Per passare dalla unità di misura 2 alla unità di misura 1 occorre eseguire una divisione</td>
</tr>
</table>



##### 
Tabella delle giacenze dei prodotti



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_GIACENZA</td>
<td> Progressivo univoco</td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_ARTICOLO</td>
<td> Codice dell'articolo</td>
</tr><tr>
<td>COD_DEPOSITO</td>
<td> Codice identificativo del deposito</td>
</tr><tr>
<td>QUANTITA</td>
<td> Quantità disponibile in giacenza</td>
</tr><tr>
<td>UM1</td>
<td> Unità di misura 1</td>
</tr>
</table>




tabella di anagrafica dei listini per prodotto



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_TIPI_LISVEN</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_LISTINO</td>
<td> Codice del listino</td>
</tr><tr>
<td>COD_ART</td>
<td> Codice dell'articolo</td>
</tr><tr>
<td>PREZZO</td>
<td> Prezzo dell'articolo per il listino in corso</td>
</tr><tr>
<td>PREZZO_NETTO</td>
<td> Prezzo netto dell'articolo per il listino in corso</td>
</tr><tr>
<td>UM1</td>
<td> # NON Visibile in IPAD # Unità di misura 1</td>
</tr><tr>
<td>DATA_INIZIO</td>
<td> Data di inizio validità del listino</td>
</tr><tr>
<td>DATA_FINE</td>
<td> Data di fine validità del listino</td>
</tr>
</table>



##### 
Import IGM Tipi Listini Vendite



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_TIPI_LISVEN</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>IND_LISTINO</td>
<td> Indicatore sulla tipologia del listino</td>
</tr><tr>
<td>DES_TIPO_LISTINO</td>
<td> Descrizione tipo listino</td>
</tr><tr>
<td>FLG_TIPOVEN</td>
<td> Flag Tipo Vendita</td>
</tr>
</table>




tabella di anagrafica clienti/fornitore di un progetto o ditta (azienda) che viene importata in automatico; ogni riga è un cliente della ditta



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI</td>
<td> progressivo univoco interno</td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>RAG_SOC</td>
<td> Ragione sociale</td>
</tr><tr>
<td>INDIRIZZO</td>
<td> Indirizzo</td>
</tr><tr>
<td>CAP</td>
<td> Codice di avviamento postale</td>
</tr><tr>
<td>CITTA</td>
<td> Città</td>
</tr><tr>
<td>PROVINCIA</td>
<td> Provincia</td>
</tr><tr>
<td>RAG_SOC_CORR</td>
<td> Ragione sociale pe rla corrispondenza</td>
</tr><tr>
<td>PARTITA_IVA</td>
<td> Partita iva</td>
</tr><tr>
<td>CODICE_FISCALE</td>
<td> Codice fiscale</td>
</tr><tr>
<td>TELEFONO1</td>
<td> Numero di telefono 1 del cliente/fornitore</td>
</tr><tr>
<td>TELEFONO2</td>
<td> Numero di telefono 2 del cliente/fornitore</td>
</tr><tr>
<td>FAX</td>
<td> Fax</td>
</tr><tr>
<td>CELLULARE</td>
<td> Telefono cellulare</td>
</tr><tr>
<td>E-MAIL</td>
<td> Indirizzo email</td>
</tr><tr>
<td>COGNONOME</td>
<td> Nominativo</td>
</tr><tr>
<td>NOME</td>
<td> Nominativo</td>
</tr><tr>
<td>RAG_SOC_FIS</td>
<td> </td>
</tr><tr>
<td>INDIRIZZO_FIS</td>
<td> </td>
</tr><tr>
<td>CAP_FIS</td>
<td> </td>
</tr><tr>
<td>CITTA_FIS</td>
<td> Citta</td>
</tr><tr>
<td>PROVINCIA_FIS</td>
<td> Provincia</td>
</tr><tr>
<td>INDIRIZZO_CORR</td>
<td> </td>
</tr><tr>
<td>CAP_CORR</td>
<td> </td>
</tr><tr>
<td>CITTA_CORR</td>
<td> Citta</td>
</tr><tr>
<td>PROVINCIA_CORR</td>
<td> Provincia</td>
</tr><tr>
<td>RAG_SOC_EX</td>
<td> </td>
</tr><tr>
<td>RAG_SOC_FIS_EX</td>
<td> </td>
</tr><tr>
<td>INDIRIZZO_EX</td>
<td> </td>
</tr><tr>
<td>INDIRIZZO_FIS_EX</td>
<td> </td>
</tr><tr>
<td>STATO_ESTERO</td>
<td> </td>
</tr><tr>
<td>COD_ISO_STATO_EX</td>
<td> </td>
</tr><tr>
<td>RAG_SOC_CORR_EX</td>
<td> </td>
</tr><tr>
<td>INTERNET</td>
<td> WEB</td>
</tr><tr>
<td>PERSONA_FISICA</td>
<td> </td>
</tr><tr>
<td>ANAGRAFICA_VALIDA</td>
<td> </td>
</tr><tr>
<td>SOSTITUTIVA</td>
<td> </td>
</tr><tr>
<td>DATA_VALIDITA</td>
<td> </td>
</tr><tr>
<td>CAP_CITTA_PR</td>
<td> Descrivi il contenuto del campo</td>
</tr><tr>
<td>CAP_CITTA_PR_FIS</td>
<td> Descrivi il contenuto del campo</td>
</tr>
</table>



##### 
tabella di anagrafica agenti di un cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_AGE</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>COD_AGE</td>
<td> Codice dell'agente</td>
</tr><tr>
<td>RAGSOC_AGE</td>
<td> Ragione sociale dell'agente</td>
</tr><tr>
<td>PREFERENZIALE</td>
<td> Flag agente preferenziale (1 o 0)</td>
</tr>
</table>




tabella di anagrafica contatti di un cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_CONT</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>ID_CONTATTO</td>
<td> Identificativo univoco del contatto</td>
</tr><tr>
<td>TIPO_CONTATTO</td>
<td> Tipologia del contatto (es: uff. acquisti)</td>
</tr><tr>
<td>COGNOME</td>
<td> Cognome del contatto</td>
</tr><tr>
<td>NOME</td>
<td> Nome del contatto</td>
</tr><tr>
<td>PREFERENZIALE</td>
<td> </td>
</tr><tr>
<td>TELEFONO</td>
<td> </td>
</tr><tr>
<td>CELLULARE</td>
<td> </td>
</tr><tr>
<td>COD_CONTATTO</td>
<td> </td>
</tr>
</table>



##### 
tabella di anagrafica dei dettagli contatto di un cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_CONT_DATI</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>ID_CONTATTO</td>
<td> Identificativo univoco del contatto</td>
</tr><tr>
<td>TIPO_CONTATTO</td>
<td> Tipologia del contatto (es: uff. acquisti)</td>
</tr><tr>
<td>PREF</td>
<td> Preferenziale (1 o 0)</td>
</tr><tr>
<td>COGNOME</td>
<td> Cognome del contatto</td>
</tr><tr>
<td>NOME</td>
<td> Nome del contatto</td>
</tr><tr>
<td>INDIRIZZO</td>
<td> Indirizzo</td>
</tr><tr>
<td>CAP</td>
<td> Codice di avviamento postale</td>
</tr><tr>
<td>CITTA</td>
<td> Città</td>
</tr><tr>
<td>PROVINCIA</td>
<td> Provincia</td>
</tr><tr>
<td>ORARIO_LAVORO</td>
<td> Orario di lavoro</td>
</tr><tr>
<td>TELEFONO1</td>
<td> Numero di telefono 1</td>
</tr><tr>
<td>TELEFONO2</td>
<td> Numero di telefono 2</td>
</tr><tr>
<td>CELLULARE1</td>
<td> Numero di cellulare 1</td>
</tr><tr>
<td>CELLULARE2</td>
<td> Numero di cellulare 2</td>
</tr><tr>
<td>TELEF_CASA</td>
<td> Numero di telefono di casa</td>
</tr><tr>
<td>FAX</td>
<td> Numero di fax</td>
</tr><tr>
<td>EMAIL1</td>
<td> Indirizzo email del contatto 1</td>
</tr><tr>
<td>EMAIL2</td>
<td> Indirizzo email del contatto 2</td>
</tr><tr>
<td>ALTRO_INDIRIZZO1</td>
<td> Altro indirizzo 1</td>
</tr><tr>
<td>ALTRO_INDIRIZZO2</td>
<td> Altro indirizzo 2</td>
</tr><tr>
<td>DES_NOTE</td>
<td> Note libere</td>
</tr>
</table>




tabella di anagrafica delle informazioni di un cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_INFO</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>MACROAREA</td>
<td> Macroarea di riferimento dell'azienda</td>
</tr><tr>
<td>DATA_CREAZIONE</td>
<td> Data di creazione del record</td>
</tr><tr>
<td>AREA</td>
<td> Area di appartenenza dell'azienda</td>
</tr><tr>
<td>MACROCATEGORIA</td>
<td> Macrocategoria di appartenenza dell'azienda</td>
</tr><tr>
<td>DATA_ULT_DOC_NO_FT</td>
<td> Data dell'ultimo documento non fatturato</td>
</tr><tr>
<td>CATEGORIA</td>
<td> Categoria di appartenenza dell'azienda</td>
</tr><tr>
<td>DATA_ULT_DOC_FT</td>
<td> Data ultimo documento fatturato</td>
</tr><tr>
<td>DATA_ULT_ORDINE</td>
<td> Data dell'ultimo ordine</td>
</tr><tr>
<td>ASPETTO_DEI_BENI</td>
<td> Aspetto dei beni</td>
</tr><tr>
<td>DATA_VARIAZIONE</td>
<td> </td>
</tr><tr>
<td>ZONA</td>
<td> </td>
</tr><tr>
<td>DATA_DISMISSIONE</td>
<td> </td>
</tr><tr>
<td>SOTTOCATEGORIA</td>
<td> </td>
</tr><tr>
<td>RAGGR1</td>
<td> </td>
</tr><tr>
<td>FIDO_AZIENDALE</td>
<td> </td>
</tr><tr>
<td>RAGGR2</td>
<td> </td>
</tr><tr>
<td>FIDO_ASS_CREDITO</td>
<td> </td>
</tr><tr>
<td>RAGGR3</td>
<td> </td>
</tr><tr>
<td>BLOCCO_ANAGRAFICO</td>
<td> </td>
</tr><tr>
<td>PORTO</td>
<td> </td>
</tr><tr>
<td>LIVELLO_BLOCCO</td>
<td> </td>
</tr><tr>
<td>TIPO_SPEDIZIONE</td>
<td> </td>
</tr><tr>
<td>DATA_BLOCCO</td>
<td> </td>
</tr><tr>
<td>IMBALLO</td>
<td> </td>
</tr><tr>
<td>NOTE_BLOCCO</td>
<td> </td>
</tr><tr>
<td>BLOCCO_DOCUMENTI</td>
<td> </td>
</tr><tr>
<td>VETTORE1</td>
<td> </td>
</tr><tr>
<td>VETTORE2</td>
<td> </td>
</tr><tr>
<td>SPEDIZIONIERE</td>
<td> </td>
</tr>
</table>



##### 
tabella delle note di un cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_NOTE</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>PROGRESSIVO</td>
<td> Progressivo di nota</td>
</tr><tr>
<td>TIPO_NOTA</td>
<td> Tipologia di nota (es: resp acquisti)</td>
</tr><tr>
<td>DES_NOTE</td>
<td> Note libere</td>
</tr>
</table>




tabella anagrafica delle testate dei documenti di cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_DOC_TEST</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>COD_TIPODOC</td>
<td> Codice tipo documento</td>
</tr><tr>
<td>COD_STIPODOC</td>
<td> Codice sottotipo documento</td>
</tr><tr>
<td>FLG_DA_EVADERE</td>
<td> Flag da evadere</td>
</tr><tr>
<td>TIPOSTATO_DOC</td>
<td> Tipo stato documento</td>
</tr><tr>
<td>DATA_DOC</td>
<td> Data del documento</td>
</tr><tr>
<td>NUM_REG</td>
<td> Numero di registrazione del documento utilizzato come collegamento tra la testata e le righe</td>
</tr><tr>
<td>NUM_DOC</td>
<td> # NON Visibile in IPAD # Numero del documento</td>
</tr><tr>
<td>TIPO_DOC</td>
<td> Tipo documento gestionale (CLS-DDT; CLS-ORDINE; CLP-ORDINE)</td>
</tr><tr>
<td>TIPO</td>
<td> Tipo (es:DdT; Ordine Cl.)</td>
</tr><tr>
<td>SOTTOTIPO</td>
<td> Sottotipo (es: Ven/Acq; Normale)</td>
</tr><tr>
<td>VALUTA</td>
<td> Valuta</td>
</tr><tr>
<td>TOTALE_DOC</td>
<td> Totale del documento</td>
</tr><tr>
<td>DATA_REG</td>
<td> </td>
</tr><tr>
<td>SEZIONALE</td>
<td> </td>
</tr><tr>
<td>DOC_ORIG</td>
<td> </td>
</tr><tr>
<td>DEPOSITO</td>
<td> </td>
</tr><tr>
<td>DATA_CONS</td>
<td> </td>
</tr><tr>
<td>SCADENZE</td>
<td> </td>
</tr><tr>
<td>ESTCONT</td>
<td> </td>
</tr>
</table>



##### 
Tabella di anagrafica per le righe documento di un cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_DOC_RIG</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>NUM_REG</td>
<td> Numero di registrazione del documento</td>
</tr><tr>
<td>PRG_RIGA</td>
<td> Progressivo di riga</td>
</tr><tr>
<td>COD_RIGA</td>
<td> Codice riga (es. R3IRB; 02661; F94PA13150; F7CSTP; F6SC10510)</td>
</tr><tr>
<td>DES_RIGA</td>
<td> Descrizione riga</td>
</tr><tr>
<td>COD_UM</td>
<td> Codice unità di misura (es: KG, PZ, CT)</td>
</tr><tr>
<td>QTA</td>
<td> Quantità</td>
</tr><tr>
<td>PRZ_NETTO</td>
<td> Prezzo Netto del prodotto (non visibile in IPAD)</td>
</tr><tr>
<td>PRZ_LORDO</td>
<td> Prezzo lordo, comprensivo di IVA del prodotto (non visibile in IPAD)</td>
</tr><tr>
<td>IMPORTO</td>
<td> Importo della riga del documento</td>
</tr><tr>
<td>QTA_TRESF</td>
<td> </td>
</tr><tr>
<td>SC_1</td>
<td> </td>
</tr><tr>
<td>SC_2</td>
<td> </td>
</tr><tr>
<td>SC_3</td>
<td> </td>
</tr><tr>
<td>SC_4</td>
<td> </td>
</tr><tr>
<td>SC_5</td>
<td> </td>
</tr><tr>
<td>SC_6</td>
<td> </td>
</tr><tr>
<td>SC_IMP</td>
<td> </td>
</tr><tr>
<td>MAG_1</td>
<td> </td>
</tr><tr>
<td>MAG_2</td>
<td> </td>
</tr><tr>
<td>MAG_IMP</td>
<td> </td>
</tr>
</table>




tabella delle scadenze dei documenti del cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_DOC_SCAD</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>CHIAVE</td>
<td> Descrivi il contenuto del campo</td>
</tr><tr>
<td>NUM_REG</td>
<td> Numero di registrazione del documento (numero di collegamento alla testata del documento)</td>
</tr><tr>
<td>COD_RATA</td>
<td> # NON Visibile in IPAD # Codice della rata</td>
</tr><tr>
<td>DAT_SCAD</td>
<td> Data di scadenza</td>
</tr><tr>
<td>IMPORTO</td>
<td> Importo della scadenza</td>
</tr><tr>
<td>DES_TIPO</td>
<td> Descrizione del tipo (es: Rim.diretta; Ric. banc.; Bonifico)</td>
</tr><tr>
<td>DES_STATO</td>
<td> # NON Visibile in IPAD # Descrizione dello stato (es: Chiuso, aperto)</td>
</tr><tr>
<td>DES_OPERAZIONE</td>
<td> # NON Visibile in IPAD # Descrizione dell'operazione (es: Pag/Risc; Chiusura; Creazione; Insoluto)</td>
</tr><tr>
<td>DES_BANCA_AGENZIA</td>
<td> # NON Visibile in IPAD #  Descrizione banca / agenzia</td>
</tr><tr>
<td>NETTO_PREV</td>
<td> </td>
</tr><tr>
<td>DES_TIPO_PRES</td>
<td> </td>
</tr><tr>
<td>FLG_DA_LIB</td>
<td> </td>
</tr><tr>
<td>FLG_SOSP</td>
<td> </td>
</tr>
</table>



##### 
tabella di anagrafica del fatturato mensile di un cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_DOC_TOT</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>ANNO</td>
<td> Anno</td>
</tr><tr>
<td>MESE</td>
<td> Mese</td>
</tr><tr>
<td>FATTURATO</td>
<td> Fatturato totale</td>
</tr>
</table>




Tabella di anagrafica del blocco di un cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_BLOCCO</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>COD_BLOCCO</td>
<td> # NON Visibile in IPAD # Codice blocco </td>
</tr><tr>
<td>TIPO_BLOCCO</td>
<td> # NON Visibile in IPAD # Tipologia del blocco </td>
</tr><tr>
<td>NOTA_BLOCCO</td>
<td> Descrizione del blocco del cliente/fornitore</td>
</tr><tr>
<td>DATA_BLOCCO</td>
<td> # NON Visibile in IPAD # Data blocco </td>
</tr>
</table>



##### 
tabella di anagrafica delle condizioni di vendita del cliente/fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_COND_VEND</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>PAGAMENTO</td>
<td> Pagamento (es: Rimessa diretta a vista fattura; R.D. 60 GG. DATA FATTURA)</td>
</tr><tr>
<td>BANCA</td>
<td> Banca</td>
</tr><tr>
<td>AGENZIA</td>
<td> Agenzia</td>
</tr><tr>
<td>LISTINO_ANAGRAFICO</td>
<td> Listino anagrafico</td>
</tr><tr>
<td>VALUTA</td>
<td> Valuta</td>
</tr><tr>
<td>SCONTI_ANAG_PERC</td>
<td> Sconti anagrafici in percentuale</td>
</tr><tr>
<td>MAGGIORAZIONE_ANAG_PERC</td>
<td> Maggiorazione anagrafica percentuale</td>
</tr><tr>
<td>SCONTI_ANAG_IMP</td>
<td> Sconti anagrafica imponibile</td>
</tr><tr>
<td>SCONTO_PIEDE</td>
<td> Sconto piede</td>
</tr><tr>
<td>C_C</td>
<td> </td>
</tr><tr>
<td>BANCA1</td>
<td> </td>
</tr><tr>
<td>AGENZIA1</td>
<td> </td>
</tr><tr>
<td>SPESE_BOLLI</td>
<td> </td>
</tr><tr>
<td>BBAN</td>
<td> </td>
</tr><tr>
<td>SPESE_INCASSO</td>
<td> </td>
</tr><tr>
<td>IBAN</td>
<td> </td>
</tr><tr>
<td>GIORNI_SLITTAMENTO</td>
<td> </td>
</tr><tr>
<td>SCAGLIONI_PAGAMENTO</td>
<td> </td>
</tr><tr>
<td>LISTINO_ARTICOLI</td>
<td> </td>
</tr><tr>
<td>GG_SCAD_FISSO</td>
<td> </td>
</tr><tr>
<td>LISTINO_99_PREZZI</td>
<td> </td>
</tr><tr>
<td>SEDE</td>
<td> </td>
</tr><tr>
<td>SEDE1</td>
<td> </td>
</tr><tr>
<td>TRATTAMENTO_IVA</td>
<td> </td>
</tr><tr>
<td>MAGGIORAZIONE_ANAG_IMP</td>
<td> </td>
</tr><tr>
<td>CLIENTE_PER_FATT</td>
<td> </td>
</tr><tr>
<td>SPESE_FISSE1</td>
<td> </td>
</tr><tr>
<td>TESTO_FISSO1</td>
<td> </td>
</tr><tr>
<td>SPESE_FISSE2</td>
<td> </td>
</tr><tr>
<td>TESTO_FISSO2</td>
<td> </td>
</tr>
</table>




Tabella di anagrafica del prodotto ultima vendita del cliente



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_ART_ULT_VEN</td>
<td> </td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_ART</td>
<td> Codice dell'articolo</td>
</tr><tr>
<td>VALUTA</td>
<td> Valuta</td>
</tr><tr>
<td>VAL_PREZZO</td>
<td> Prezzo</td>
</tr><tr>
<td>DATA_DOC</td>
<td> # NON Visibile in IPAD #Data del documento di riferimento</td>
</tr><tr>
<td>NUM_DOC</td>
<td> # NON Visibile in IPAD #Numero del documento di riferimento</td>
</tr><tr>
<td>PROG</td>
<td> # NON Visibile in IPAD # Progressivo</td>
</tr><tr>
<td>RAG_SOC</td>
<td> Ragione sociale</td>
</tr>
</table>



##### 
Tabella di anagrafica del prodotto ultimo acquisto del fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_ART_ULT_AQ</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_ART</td>
<td> Codice dell'articolo</td>
</tr><tr>
<td>VALUTA</td>
<td> Valuta</td>
</tr><tr>
<td>VAL_PREZZO</td>
<td> Prezzo</td>
</tr><tr>
<td>DATA_DOC</td>
<td> # NON Visibile in IPAD # Data del documento</td>
</tr><tr>
<td>NUM_DOC</td>
<td> # NON Visibile in IPAD # Numero del documento</td>
</tr><tr>
<td>PROG</td>
<td> # NON Visibile in IPAD # Progressivo</td>
</tr><tr>
<td>RAG_SOC</td>
<td> Ragione sociale</td>
</tr>
</table>




TABELLA NON UTILIZZATA MAAAAA



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_TIPI_LISVEN</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>ARTICOLO</td>
<td> ARTICOLO</td>
</tr><tr>
<td>VARIANTE</td>
<td> VARIANTE</td>
</tr><tr>
<td>VALUTA</td>
<td> Valuta</td>
</tr><tr>
<td>DATA_INIZIO</td>
<td> Data di inizio del listino</td>
</tr><tr>
<td>DATA_FINE</td>
<td> Data di fine del listino</td>
</tr><tr>
<td>PREZZO</td>
<td> Prezzo</td>
</tr><tr>
<td>SC_1</td>
<td> Sconto 1</td>
</tr><tr>
<td>SC_2</td>
<td> Sconto 2</td>
</tr><tr>
<td>SC_3</td>
<td> Sconto 3</td>
</tr><tr>
<td>SC_4</td>
<td> Sconto 4</td>
</tr><tr>
<td>SC_5</td>
<td> Sconto 5</td>
</tr><tr>
<td>SC_6</td>
<td> Sconto 6</td>
</tr><tr>
<td>SC_IMP</td>
<td> Sconto Importo</td>
</tr><tr>
<td>MAG_1</td>
<td> Maggiorazione 1</td>
</tr><tr>
<td>MAG_2</td>
<td> Maggiorazione 2</td>
</tr><tr>
<td>MAG_IMP</td>
<td> Maggiorazione a importo</td>
</tr>
</table>



##### 
TABELLA NON UTILIZZATA MAAAAA



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI</td>
<td> progressivo univoco interno</td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>COD_LIST</td>
<td> Codice Listino</td>
</tr>
</table>








<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_FATT</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_ORDINE</td>
<td> </td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>RAG_SOC</td>
<td> Ragione sociale</td>
</tr><tr>
<td>COD_CF</td>
<td> Codice fiscale</td>
</tr><tr>
<td>NUM_RIGA</td>
<td> Numero di riga</td>
</tr><tr>
<td>CPD_PARTE</td>
<td> </td>
</tr><tr>
<td>DESCR</td>
<td> Descrizione</td>
</tr><tr>
<td>QTA_ORDINATA</td>
<td> Quantità ordinata</td>
</tr><tr>
<td>QTA_EVASA</td>
<td> Quantità evasa</td>
</tr><tr>
<td>VAL_PREZZO</td>
<td> Prezzo</td>
</tr><tr>
<td>VAL_PREZZO_IVA</td>
<td> Prezzo con iva</td>
</tr><tr>
<td>VAL_PERC_IVA</td>
<td> Iva in percentuale</td>
</tr><tr>
<td>VAL_SCONTO</td>
<td> Sconto</td>
</tr><tr>
<td>VAL_IMPONIBILE</td>
<td> Imponibile</td>
</tr><tr>
<td>VAL_IMPON_IVA</td>
<td> Imponibile iva</td>
</tr><tr>
<td>VAL_ANNO</td>
<td> Anno</td>
</tr><tr>
<td>DTM_CONFERMATA</td>
<td> Data confermata</td>
</tr><tr>
<td>TIPO_DOC</td>
<td> Tipo documento</td>
</tr><tr>
<td>DES_TIPO_DOC</td>
<td> Descrizione tipo documento</td>
</tr><tr>
<td>VAL_CAUSALE</td>
<td> Causale</td>
</tr><tr>
<td>VAL_CAUS_MAG</td>
<td> Causale magazzino</td>
</tr><tr>
<td>CDA_UNITA_MIS</td>
<td> Unitò di misura</td>
</tr>
</table>



##### 
NON UTILIZZATA



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_SCA_CRUSC</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>DITTA</td>
<td> </td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>CDN_ANNO</td>
<td> </td>
</tr><tr>
<td>CDN_MESE</td>
<td> Mese</td>
</tr><tr>
<td>DES_ANNO</td>
<td> Descrizione dll'Anno</td>
</tr><tr>
<td>DES_MESE</td>
<td> Descrizione del mese</td>
</tr><tr>
<td>TOT_SCA_IMP</td>
<td> Totale importo scadenza</td>
</tr><tr>
<td>PRG_SCA_IMP</td>
<td> Progressivo importo scadenza</td>
</tr><tr>
<td>TOT_EFF_IMP</td>
<td> Totale importo effettivo</td>
</tr><tr>
<td>PRG_EFF_IMP</td>
<td> Progressivo importo effettivo</td>
</tr><tr>
<td>TOT_EFFPRE_IMP</td>
<td> Totale importo</td>
</tr><tr>
<td>PRG_EFFPRE_IMP</td>
<td> </td>
</tr><tr>
<td>TOT_NOEFF_IMP</td>
<td> </td>
</tr><tr>
<td>PRG_NOEFF_IMP</td>
<td> </td>
</tr><tr>
<td>TOT_INSOL_IMP</td>
<td> </td>
</tr><tr>
<td>PRG_INSOL_IMP</td>
<td> </td>
</tr>
</table>




NON UTILIZZATA



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>PRG_CLI_SCAD</td>
<td> </td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>CHIAVE</td>
<td> Descrivi il contenuto del campo</td>
</tr><tr>
<td>NUM_REG</td>
<td> Numero di registrazione del documento</td>
</tr><tr>
<td>TIPO</td>
<td> Tipo (es: Contanti; Rim.diretta; Ric. banc.; Bonifico)</td>
</tr><tr>
<td>STATO</td>
<td> Stato della scadenza (es: Aperto)</td>
</tr><tr>
<td>DALIBERALIZZARE</td>
<td> </td>
</tr><tr>
<td>INSOLUTI</td>
<td> FLag insoluto (es. 1 o 0)</td>
</tr><tr>
<td>SOSPESI</td>
<td> Sospesi</td>
</tr><tr>
<td>VALUTA</td>
<td> Valuta</td>
</tr><tr>
<td>IMPORTO</td>
<td> Importo della scadenza</td>
</tr><tr>
<td>IMP_NETTO</td>
<td> iMPORTO NETTO DELLA SCADENZA</td>
</tr><tr>
<td>NUM_DOC</td>
<td> Numero del documento</td>
</tr><tr>
<td>SEZIONALE</td>
<td> Sezionale</td>
</tr><tr>
<td>DATA_DOC</td>
<td> Data del documento</td>
</tr><tr>
<td>BANCA_AGENZIA</td>
<td> Banca / Agenzia</td>
</tr><tr>
<td>TIPO_PRESENTAZIONE</td>
<td> Tipo di presentazione (es: Non soggetto; Sconto fatture; In portafoglio)</td>
</tr><tr>
<td>MOVIMENTI</td>
<td> Movimenti</td>
</tr><tr>
<td>SOLLECITI</td>
<td> Solleciti</td>
</tr><tr>
<td>DES_NOTE</td>
<td> Note libere </td>
</tr><tr>
<td>DA_RAGGRUP</td>
<td> </td>
</tr><tr>
<td>RATA</td>
<td> </td>
</tr><tr>
<td>GG_DILAZ_DITTA</td>
<td> </td>
</tr><tr>
<td>GG_DILAZ_EFF</td>
<td> </td>
</tr><tr>
<td>GG_RITARDO</td>
<td> </td>
</tr><tr>
<td>DITTA</td>
<td> </td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>RIGACONT</td>
<td> </td>
</tr><tr>
<td>PROG_EC</td>
<td> </td>
</tr><tr>
<td>PROG_EFF</td>
<td> </td>
</tr><tr>
<td>SCADENZA</td>
<td> </td>
</tr>
</table>



# Export Dati IGM
Tabelle di Export
I files devono essere in formato delimitati con pipe separator "|"
##### 
Export IGM Testate Ordini



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>ID_TES_ORD</td>
<td> Identificativo Tabella</td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_EXT_ORD</td>
<td> Ordine o preventivo nostro ext_code</td>
</tr><tr>
<td>NOME_FILE</td>
<td> Descrivi il contenuto del campo</td>
</tr><tr>
<td>DAT_ORDINE</td>
<td> Formato: AAAAMMGG (Data di quando ho creato l'ordine)</td>
</tr><tr>
<td>ID_TES_ORIG</td>
<td> ID Testata Origine</td>
</tr><tr>
<td>NR_ORD_ORIG</td>
<td> GUID generato dal dispositivo e identifica la testata ordine generata</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>COD_AGENTE</td>
<td> Codifica Agente</td>
</tr><tr>
<td>DAT_CONS_TES</td>
<td> </td>
</tr><tr>
<td>DES_NOTE</td>
<td> Note Documento Ordine</td>
</tr><tr>
<td>DAT_EXPORT</td>
<td> </td>
</tr>
</table>




Tabella Export per le righe ordine



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>ID_RIG_ORD</td>
<td> Identificativo Tabella</td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>ID_TES_ORIG</td>
<td> ID Testata Origine</td>
</tr><tr>
<td>NR_ORD_ORIG</td>
<td> GUID generato dal dispositivo e identifica la testata ordine generata</td>
</tr><tr>
<td>IND_TIP_RIGA</td>
<td> Indicatore Tipo Riga  (0= articolo, 2=descrittivo) </td>
</tr><tr>
<td>COD_ART_ORD</td>
<td> Codice Articolo Ordine</td>
</tr><tr>
<td>DES_RIGA_ORD</td>
<td> Descrizione Riga Ordine</td>
</tr><tr>
<td>CDA_UM_1</td>
<td> </td>
</tr><tr>
<td>CDA_UM_2</td>
<td> </td>
</tr><tr>
<td>QTA_1</td>
<td> </td>
</tr><tr>
<td>QTA_2</td>
<td> </td>
</tr><tr>
<td>PREZZO_1</td>
<td> </td>
</tr><tr>
<td>PREZZO_2</td>
<td> </td>
</tr><tr>
<td>IND_TIPO_OM</td>
<td> Indicatore tipo omaggio (0=no, 1=omaggio con rivalsa, 2=omaggio senza rivalsa, 3=omaggio con sconto in merce) </td>
</tr><tr>
<td>SCONTO_1</td>
<td> se non c'è sconto devo mettere 0, altrimenti gamma recupero lo sconto e c'è il rischio che lo applichi 2 volte</td>
</tr><tr>
<td>SCONTO_2</td>
<td> se non c'è sconto devo mettere 0, altrimenti gamma recupero lo sconto e c'è il rischio che lo applichi 2 volte</td>
</tr><tr>
<td>DAT_EXPORT</td>
<td> </td>
</tr><tr>
<td>DES_NOTE</td>
<td> Note della riga Ordine</td>
</tr>
</table>



# ==
tabelle valorizzata dai dispositivi che chiamano i WS per aggiornare l'anagrafica cliente fornitore



<table cellspacing="2" cellpadding="2" border="0">
<thead><tr>
<td>Variabile</td>
</tr></thead>
<thead><tr>
<td>Descrizione</td>
</tr></thead>
</tr><tr>
<td>ID_IGM_EXP_CLI_FOR</td>
<td> Identificativo Cliente composto da:</td>
</tr><tr>
<td>ID_PROGETTO</td>
<td> Identificativo univoco del progetto</td>
</tr><tr>
<td>COD_DITTA</td>
<td> Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende</td>
</tr><tr>
<td>COD_CLIFOR</td>
<td> Codice Cliente / Fornitore</td>
</tr><tr>
<td>TIPO_CLIFOR</td>
<td> Tipologia (0=Cliente, 1=Fornitore)</td>
</tr><tr>
<td>TELEFONO1</td>
<td> </td>
</tr><tr>
<td>TELEFONO2</td>
<td> </td>
</tr><tr>
<td>FAX</td>
<td> </td>
</tr><tr>
<td>CELLULARE</td>
<td> </td>
</tr><tr>
<td>E-MAIL</td>
<td> </td>
</tr><tr>
<td>DAT_EXPORT</td>
<td> </td>
</tr>
</table>



# Procedure Da IGM A MOB
Procedure di import da tabelle IGM a tabelle MOB
# Procedure Da MOB A IGM
Cosa raggruppa questa cartella?
