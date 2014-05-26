## DB di origine e mappatura
### Lista della tabelle
### UNIVAQ Aquila Origine 01/10/2006
**IOL** (righe n. 1163){BR}
_Descriscione Tabella: _Tabella dei percorsi. Da migrare nella P06_PDSORD. Nel caso dei dottorati, contiene i cicli da inserire nalla P06_CDSORD.{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* IOL_CODCDL
(Codice del corso Chiave Corso Di Laurea Chiave Indirizzo = (Ind+Orie+Ling). )
* IOL_CODORIE
(Codice orientamento.)
* IOL_CODLING
(Codice della lingua)
* IOL_DESCRORIE
(Descrizione dell'orientamento)
* IOL_DESCRLING
(Descrizione della lingua)
* IOL_FLGDIPL
(Stampa sul diploma)
* IOL_DESCR_EN
(Descrizione in inglese)
* IOL_DESCRIND
(Descrizione dell'indirizzo  Contiente anche a livello descrittivo la classe)
* IOL_TIPOIND
(Tipo Indirizzo non c'è relazione)
* IOL_FLGSTAT
(Flg Indir. Da Stampare sui certificati. )
* IOL_RID
(Questo campo contiene l'identificativo della tabella)
* IOL_CODIND
(Corso Di Laurea Chiave Indirizzo = (Ind+Orie+Ling): )
* IOL_CLASSE
(Classe del curricum.  La calsse indicata nell'indirizzo otrebbe essere differente da quella del CDL)
{BR}
**MDL** (righe n. 7000){BR}
_Descriscione Tabella: _Tabella dei Moduli. Va migrata sulla P09_AD_RAG MDL_CODINS è l'insegnamento padre, MDL_CODMOD indica i figli{BR}
_Aree di interesse: _
J12 - Offerta Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* MDL_RID
(Questo campo contiene l'identificativo della tabella)
* MDL_CODCDL
(Codice corso di laurea dove le attività didattiche sono raggruppate)
* MDL_CODINS
(Codice insegnamento padre del gruppo)
* MDL_MODULO
(Sequenza modulo. Sempre 0 o Null <del> Non considerare.)
* MDL_CODMOD
(Codice insegnamento modulo (Figlio))
{BR}
**PDO** (righe n. 3623){BR}
_Descriscione Tabella: _Tabella associativa tra l'insegnamento e il docente{BR}
_Aree di interesse: _
J12 - Offerta Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* PDO_RID
(non rilevante)
* PDO_CODCDL
(Codice del corso)
* PDO_CODIND
(Codice dell'indirizzo)
* PDO_AAVALID
(Anno accademico di riferimento)
* PDO_CODINS
(Codice insegnamento)
* PDO_DOCENTE
(Codice docente)
* PDO_DTUPDATE
(non rilevante)
* PDO_CODORIE
(Codice dell'ordinamento)
* PDO_CODLING
(Codice della lingua)
{BR}
**PES** (righe n. 57){BR}
_Descriscione Tabella: _Anagrafica prove del concorso{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* PES_RID
(Questo campo contiene l'identificativo della tabella)
* PES_CODEST
(Codice Esame di Stato)
* PES_CODPRV
(Codice prova esame di stato.)
* PES_DESCR
(Descrizione Prova Esame)
* PES_SEZIONE
(sezione)
* PES_SETTORE
(settore)
* PES_DNVT
(base del voto)
* PES_MINV
(voto minimo per considerare la prova superata)
* PES_CODINT
(codice prova che ingloba le singole prove.)
* PES_TIPO
(Tipo Prova)
* PES_FLGESOB
(Flag prova esonerabile se lo studente è già in possesso dell'abilitazione sezione B)
* PES_FLGTUTOR
(Flag tutor presente (in genere per i tirocini))
{BR}
**PNO** (righe n. 200){BR}
_Descriscione Tabella: _Tabella di relazione tra i corsi Ante-riforma e i post-riforma. Migrare sulla P06_CDSORD_AR_PR.  Usata solamente per quali sono le equivalenze fra i corsi di laurea{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* PNO_RID
(Questo campo contiene l'identificativo della tabella)
* PNO_CDLNEW
(Codice CDS post-Riforma.)
* PNO_ANNOACC
(Anno di inizio validazione associazione)
* PNO_BLOCCOESAMI
(non utilizzato)
* PNO_CAMBIOESAMI
(non utilizzato)
* PNO_DTUPDATE
(Data aggiornamento)
* PNO_CODCDL
(Codice CDS Ante-Riforma.)
* PNO_NUMANNI
(Anno di attivazione del Post-Riforma)
{BR}
**PRP** (righe n. 7193){BR}
_Descriscione Tabella: _Tabella delle propedeuticità tra insegnamenti. {BR}
_Aree di interesse: _
J12 - Offerta Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* PRP_CODCDL
(Codice Corso)
* PRP_CODINS
(Codice insegnamento)
* PRP_PROG
(Progressivo propedeuticità e sequenza.)
* PRP_ESAME
(Codice Esame propedeutico)
* PRP_FINE_PAR
(Fine parentesi. Non considerare.)
* PRP_ANNO
(Anno Di Corso di Validita' (non utilizzato))
* PRP_IMM_AI
(Anno Immatricolazione inizio Validita'  Se 0 per tutti)
* PRP_AAC_AI
(Anno Iscrizione inizio Validita'  Se 0 per tutti)
* PRP_RID
(Questo campo contiene l'identificativo della tabella)
* PRP_ESFR
(Propedeuticità di Esame o Frequenza.)
* PRP_INIZ_PAR
(Inizio parentesi. </del> Ignorare.)
* PRP_AND_OR
(AND o OR con propedeuticità seguente.  )
* PRP_CDL
(Corso Di Laurea di Validita'  Può succedere di dover indicare un esame vecchi di un altro corso di laurea, perchè gli studenti potrebbero aver sostenuto quello.)
* PRP_IMM_AF
(Anno Immatricolazione fine Validita'  Se 0 per tutti)
* PRP_AAC_AF
(Anno Iscrizione fine Validita'  Se 0 per tutti)
{BR}
**RDL** (righe n. 288749){BR}
_Descriscione Tabella: _Righe delle delibere. Raggruppare e concatenare nel campo testo della P04_ATTI_AMMIN   FIGLIA di DEL{BR}
_Aree di interesse: _
J05 - Gestione Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* RDL_CDL
(Corso Di Laurea)
* RDL_NUMDEL
(Num.progressivo delibera Studente. Per il collegamento alla testata (DEL).)
* RDL_RIGA
(Testo riga.)
* RDL_RID
(Questo campo contiene l'identificativo della tabella)
* RDL_MATR
(Matricola. Per il collegamento alla testata (DEL).)
* RDL_NUM
(Progressivo di riga. Per l'ordinamento delle righe.)
{BR}
**SEC** (righe n. 372){BR}
_Descriscione Tabella: _Tabella Settori. Mappare con P07_SETT.{BR}
_Aree di interesse: _
J09 - Classi e Settori
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* SEC_RID
(Questo campo contiene l'identificativo della tabella)
* SEC_SETTORE
(Codice settore)
* SEC_AREA
(Codice Area scientifico-disciplinare.  Vedi ARD)
* SEC_DESCR
(Descrizione settore)
* SEC_DECLAR
(Dichiarazione del settore.)
* SEC_DTUPDATE
(Data aggiornamento)
* SEC_DESCR_EN
(Descrizione settore in inglese)
{BR}
**SEM** (righe n. 4196){BR}
_Descriscione Tabella: _Tabella delle attività seminariali{BR}
_Aree di interesse: _
J15 - Libretto Studente
J12 - Offerta Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* SEM_RID
(non rilevante)
* SEM_CODINS
(Codice dell'insegnameto dell'esame)
* SEM_DESCR
(Descrizione del seminario)
* SEM_CREDITO
(Crediti del seminario)
* SEM_DTUPDATE
(non rilevante)
* SEM_PROGR
(Progressivo del seminario)
{BR}
**SSE** (righe n. 63){BR}
_Descriscione Tabella: _Sessioni degli esami di stato.  Dovrebbero essere tutte codificate{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* SSE_RID
(Questo campo contiene l'identificativo della tabella)
* SSE_ANNO
(Anno della sessione.)
* SSE_SESSIONE
(Sessione esame)
* SSE_PERIODO
(Periodo sessione vecchio ordinamento oppure sezione A)
* SSE_DTORD
(Data Ordinanza vecchio ordinamento oppure sezione A)
* SSE_DTUPDATE
(Data Aggiornamento)
* SSE_DTINIZB
(Data inizio sezione B)
* SSE_PERIODOB
(Periodo sessione sezione B)
* SSE_DTORDB
(data ordinanza sezione B)
* SSE_PERIODOM
(Periodo sessione per Medicina)
* SSE_DTORDM
(Data ordinanza per Medicina)
* SSE_DTINIZM
(Data inizio esami per Medicina)
* SSE_DTINIZ
(Data Inizio Sessione vecchio ordinamento oppure sezione A)
{BR}
**STDTIT** (righe n. 72640){BR}
_Descriscione Tabella: _Codici maturità ed anno integrativo (eventuale)  Dovrebbe essere un doppione della STD{BR}
_Aree di interesse: _
J01 - Anagrafiche Persone
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* STD_CODTIT
(codice titolo)
* STD_CODINT
(codice titolo integrativo)
* STD_MATR
(matricola)
{BR}
**STN** (righe n. 27528){BR}
_Descriscione Tabella: _dati inviati all'ANS relativi agli studenti{BR}
_Aree di interesse: _
J20 - Anagrafe nazionale studenti
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* STN_RID
(Questo campo contiene l'identificativo della tabella)
* STN_MATR
(matricola)
* STN_CFISC
(codice fiscale)
* STN_SK_INVIO
(scheda inviata)
* STN_COD_MIUR
(codice miur del corso)
* STN_IMM_MIUR
(codice miur del corso di immatricolazione)
* STN_STATO
(stato dell'invio)
* STN_DTUPDATE
(ultimo aggiornamento)
* STN_ANNOACC
(anno accademico di invio)
* STN_ANNOMIUR
(anno accademico)
{BR}
**T04** (righe n. 149){BR}
_Descriscione Tabella: _Tabella Nazioni e Cittadinanze. Da mappare con P01_NAZI e P01_CITTAD. {BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T04_CODNAZ
(Codice nazione/cittadinanza)
* T04_DTUPDATE
(Data aggiornamento)
* T04_DESCRICITTADINO
(Descrizione cittadinanza)
* T04_CODISTAT
(Codice ISTAT)
* T04_CEE
(Indica se Paese/cittadino comunitario o extracomunitario)
* T04_RID
(Questo campo contiene l'identificativo della tabella.)
* T04_DESCRISTATO
(Descrizione nazione)
* T04_CODFISC
(Codice stato da inserire nel calcolo del codice Fiscale per i cittadini stranieri.)
* T04_COD_MIUR
(Codice MIUR)
{BR}
**T05** (righe n. 107){BR}
_Descriscione Tabella: _Tabella provincie. Da Mappare con P01_PROV.{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T05_RID
(Questo campo contiene l'identificativo della tabella.)
* T05_DTUPDATE
(Data aggiornamento)
* T05_DESCR
(Descrizione)
* T05_PRVISTAT
(Codice ISTAT della provincia)
* T05_CODPROV
(Codice Provincia)
* T05_REGIONE
(Descrizione Regione)
{BR}
**T09** (righe n. 1980){BR}
_Aree di interesse: _
J07 - Configurazione Tasse
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T09_RID
(Questo campo contiene l'identificativo della tabella)
* T09_TIPOS
(Codice del tipo corso di studio  Vedi TCL)
* T09_CODCAUSALE
(Codice Causale. (Voce)  Vedi nella T10)
* T09_DTUPDATE
(Data Aggiornamento)
* T09_RATA
(Rata. (1,2,L))
* T09_FLGIMPVAR
(Flag variabilita' (S/N) non usato)
* T09_TIPO_ISCR
(non significativo valori vecchi)
* T09_CODCONT
(Causale contabile <del> Non migrare.)
* T09_ANNOACC
(Anno accademico)
* T09_IMPORTO
(Importo fisso tassa, importo puo essere in Euro e in Lire)
* T09_INDIRIZZO
(Tipo indirizzo. Sempre vuoto. NON migrare.)
* T09_CODCDL
(Il campo identifica dove vale la riga.   Se non è valorizzato vale per tutti Se è valorizzato con il codice facoltà vale per la facoltà Se è valorizzato con il codice corso vale per la corso )
{BR}
**T10** (righe n. 127){BR}
_Descriscione Tabella: _Tabella anagrafica delle causali{BR}
_Aree di interesse: _
J06 - Anagrafica Tasse
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T10_CODCAUSALE
(Codice Causale..)
* T10_DTUPDATE
(Data aggiornamento.)
* T10_DESCRIZIONE
(Descrizione Causale.)
* T10_RID
(Questo campo contiene l'identificativo della tabella)
{BR}
**T16** (righe n. 40){BR}
_Descriscione Tabella: _Ambasciate{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T16_RID
(Questo campo contiene l'identificativo della tabella)
* T16_CODAMB
(Codice Ambasciata)
* T16_DTUPDATE
(data aggiornamento)
* T16_DESCRIZIONE
(descrizione dell'ambasciata)
* T16_CODNAZ
(codice dello stato (fk verso T04))
{BR}
**T25** (righe n. 12){BR}
_Descriscione Tabella: _Numero massimo di certificati emettibili dai totem per studente{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T25_ANNOACC
(Anno accademico)
* T25_NRMAXCERT
(Numero massimo di certificati)
* T25_DTUPDATE
(Data Aggiornamento)
* T25_RID
(Questo campo contiene l'identificativo della tabella)
{BR}
**T29** (righe n. 270){BR}
_Descriscione Tabella: _Tabella delle tasse per gli esami di stato{BR}
_Aree di interesse: _
J07 - Configurazione Tasse
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T29_ANNO
(Anno Accademico)
* T29_CODCAUSALE
(Codice Causale (Voce))
* T29_DTUPDATE
(Data Aggiornamento)
* T29_CODCONT
(Causale contabile.)
* T29_RID
(Questo campo contiene l'identificativo della tabella)
* T29_RATA
(Codice Rata (O/E))
* T29_IMPORTO
(Importo sia in euro che in lire)
{BR}
**T31** (righe n. 24){BR}
_Descriscione Tabella: _Enti erogatori di borse{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T31_ENTE_BORSA
(Codice dell'ente)
* T31_ENTE_DESCR
(descrizione dell'ente)
* T31_DTUPDATE
(ultimo aggiornamento)
* T31_RID
(Questo campo contiene l'identificativo della tabella)
{BR}
**T32** (righe n. 8){BR}
_Descriscione Tabella: _Tasse dei dottorati{BR}
_Aree di interesse: _
J08 - Tassazione studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T32_TIPOCDL
(tipo corso del dottorato)
* T32_CODCDL
(corso del dottorato)
* T32_ANNOACC
(anno accademico di tassazione)
* T32_RATA
(rata)
* T32_IMPORTOD
((fascia massima) contributo)
* T32_IMPORTOP
((fascia massima) contributo con esonero)
* T32_DATASCAD
(data scadenza)
* T32_DTUPDATE
(ultimo aggiornamento)
* T32_IMPORTOT1
((fascia 2) importo per iscrizione)
* T32_IMPORTOP1
((fascia 2) contributo con esonero)
* T32_IMPORTOT2
((fascia 1) importo per iscrizione)
* T32_IMPORTOD2
((fascia 1) contributo)
* T32_IMPORTOP2
((fascia 1) contributo con esonero)
* T32_IMPORTOE
((fascia massima) importo iscrizione con esonero)
* T32_RID
(identificativo tabella)
* T32_IMPORTOT
((fascia massima) importo per iscrizione)
* T32_IMPORTOE1
((fascia 2) importo iscrizione con esonero)
* T32_IMPORTOD1
((fascia 2) contributo)
* T32_IMPORTOE2
((fascia 1) importo iscrizione con esonero)
{BR}
**T33** (righe n. 48){BR}
_Descriscione Tabella: _Tasse dei master{BR}
_Aree di interesse: _
J08 - Tassazione studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T33_RID
(identificativo tabella)
* T33_ANNOACC
(anno accademico)
* T33_RATA
(rata)
* T33_IMPORTOT
(importo)
* T33_IMPORTOE
(importo con esonero)
* T33_DATASCAD
(data scadenza)
* T33_TIPOCDL
(tipo corso)
* T33_CODCDL
(codice corso)
* T33_DTUPDATE
(data ultimo aggiornamento)
{BR}
**T50** (righe n. 21){BR}
_Descriscione Tabella: _Tabella regioni.   Da Mappare con la P01_REGIO{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T50_RID
(Identificatore di record)
* T50_DESCR
(Descrizione regione)
* T50_REGISTAT
(Codice ISTAT regione)
{BR}
**TAM** (righe n. 18400){BR}
_Descriscione Tabella: _Tabella delle prove di ammissione per le lingue Per i corsi della facoltà di lettere. Tutti gli studenti sono obbligati a sostenere il test per stabilire il livello di conoscenza{BR}
_Aree di interesse: _
J04 - Test di Ingresso e Ammissione
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TAM_RID
(identificativo tabella)
* TAM_MATR
(matricola)
* TAM_DTUPDATE
(ultimo aggiornamento)
* TAM_VOTO_ING
(voto inglese)
* TAM_VOTO_TED
(voto tedesco)
* TAM_VOTO_FRA
(voto francese)
* TAM_VOTO_SPA
(voto spagnolo)
{BR}
**TES** (righe n. 23931){BR}
_Descriscione Tabella: _Tabella delle Tesi di laurea.  Per ogni TES dovrebbe esistere una LAU.  TES e LAU vengono caricati assieme, contemporaneamente.  Da migrare sulla P12_DOM_CT insieme alla LAU.{BR}
_Aree di interesse: _
J18 - Conseguimento Titolo
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TES_MATR
(Matricola)
* TES_CORRELATORI
(Nome Eventuali Correlatori.  Campo Libero)
* TES_CODCONTRELAT
(Codice controrelatore. Quando manca considerare TES_CONTRRELATORE  FK nella T18)
* TES_CONTRELATORE
(nome del controrelatore  campo libero)
* TES_DIPARTIMENTO
(Cod.Dipartimento.   Vedi tabella DIP.  E' sempre vuoto)
* TES_TIT1_TESI
(Titolo tesi.)
* TES_TIT2_TESI
(Titolo tesi.)
* TES_TIT3_TESI
(Titolo tesi.)
* TES_TIT4_TESI
(Titolo tesi.)
* TES_TIT5_TESI
(Titolo tesi.)
* TES_TESINA2
(Titolo della tesina.)
* TES_RID
(Questo campo contiene l'identificativo della tabella)
* TES_NUMTESILAU
(Nr. Di Tesi (progressivo tesi))
* TES_CODCORRELAT
(Codice Correlatore.  Ignorare se 0 e considerare invece TES_CORRELATORI.   FK nella T18)
* TES_DESCRDIP
(Descr.Dipartimento. Un solo caso la tabella DIP è vuota).)
* TES_CDL
(Codice del corso dove si laurea lo studente  Se non dovesse coincidere con il corso presente nella AAC, fa fede quello della AAC.)
* TES_CODRELATORE
(Codice Relatore  FK nella T18)
* TES_RELATORE
(Nome Relatore preso dalla T18. Questo campo non è modificabile dall'applicativo, quindi dovrebbe coincidere con il contenuto della T18.)
* TES_TESINA3
(Titolo della tesina.)
* TES_DESCR_EN
(titolo in inglese per il diploma supplement)
* TES_TESINA1
(Titolo della tesina. Capita che lo studente presenti una tesina in aggiunta alla tesi (oppure in sua sostituzione).)
{BR}
**TST** (righe n. 318){BR}
_Descriscione Tabella: _Testi schema delle certificazioni{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TST_TIPOS
(tipo di certificato)
* TST_TIPOT
(?)
* TST_CODICE
(codice)
* TST_PRG
(progressivo (quando il testo è maggiore di 2000 caratteri))
* TST_TESTO
(testo del certificato)
* TST_RID
(Questo campo contiene l'identificativo della tabella)
{BR}
**EST** (righe n. 18){BR}
_Descriscione Tabella: _Tabella degli esami di stato. Insieme alla DOM va migrata nella P03_CONCORSI. Deve essere utilizzata anche per il mapping (manuale) con la MAP_07_AB_PROF.{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* EST_RID
(Questo campo contiene l'identificativo della tabella)
* EST_DESCR
(Descrizione Esame di stato.)
* EST_DESCRRID
(Descrizione ridotta. </del> Non usare. Usiamo la EST_DESCR. )
* EST_PROFESSIONE
(Descrizione Professione abilitata)
* EST_PRESIDENTE
(codice presidente  )
* EST_DOCENTE1
(codice docente)
* EST_DOCENTE2
(codice docente)
* EST_DOCENTE3
(codice docente)
* EST_DOCENTE4
(codice docente)
* EST_DOCENTE5
(codice docente)
* EST_DOCENTE6
(codice docente)
* EST_DOCENTE7
(codice docente)
* EST_DOCENTE8
(codice docente)
* EST_DOCENTE9
(codice docente)
* EST_SEZIONE
(Sezione.  E' un'ulteriore dettaglio del codice concorso EST_CODEST.)
* EST_SETTORE
(Settore. E' un'ulteriore dettaglio del codice concorso EST_CODEST.  Usato per ingegneria)
* EST_DESCSETT
(Descrizione Settore.)
* EST_ANNO_FINE
(anno solare di fine validità.  Ancora non è stato utilizzato)
* EST_CODEST
{BR}
(Codice Concorso per esame di stato.  DD medicina vecchio ordinamento 2M medicina nuovo DO odontoiatria FF biologia vecchio FJ biologo junior FS biologo senior MC commercialista II ingegneria vecchio IJ ingegnere junior I2 ingegnere senior EE farmacia DX servizi sociali vecchio DA servizi sociali senior DB servizi sociali junior)
* EST_SESS_FINE
(sessione di fine validità.  Ancora non è stato utilizzato)
* EST_FLG_MEDICINA
(Flag Esame di stato di Medicina (solo per i nuovi ordinamenti))
**FAC** (righe n. 12){BR}
_Descriscione Tabella: _Facoltà. Migrare sulla P06_FAC.{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* FAC_RID
(Questo campo contiene l'identificativo della tabella)
* FAC_CODFAC
(Codice Facolta')
* FAC_DESCR
(Descrizione ridotta. NON considerare. Usiamo quella estesa.)
* FAC_DESCRE
(Descrizione Estesa)
* FAC_ISTAT
(Codice Istat Facolta')
* FAC_ALMA
(Codice per Almalaurea)
* FAC_SEDE
(Codice Sede di Almalaurea)
{BR}
**FAN** (righe n. 443){BR}
_Descriscione Tabella: _Tabella dei coefficiente per la riduzione tasse.{BR}
_Aree di interesse: _
J07 - Configurazione Tasse
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* FAN_RID
(Questo campo contiene l'identificativo della tabella)
* FAN_TIPOS
(Codice del tipo corso di studio  Vedi TCL)
* FAN_ANNOACC
(Anno Accademico)
* FAN_COEFF
(Coefficente di riferimento per la RIDUZIONE TASSE)
* FAN_DTUPDATE
(Data Aggiornamento)
* FAN_CODFAC
(Chiave Facolta'.  Sempre valorizzato e vale per tutti i corsi se non è dettagliato diversamente nel campo FAN_CODFAC)
* FAN_CODCDL
(Codice C.d.L.  Se è valorizzato significa che per il corso presente è differente per quello sche è stato definito per la facoltà)
{BR}
**T28** (righe n. 3602){BR}
_Descriscione Tabella: _Appelli d'esame.  A livello di corso. Quando manca l'insegnamento allora vale per tutto il corso, altrimenti solo per quell'insegnamento.{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
J15 - Libretto Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T28_RID
(Questo campo contiene l'identificativo della tabella)
* T28_ANNOACC
(Anno accademico)
* T28_SESSIONE
(codice sessione)
* T28_CODCDL
(Codice del corso)
* T28_CODINS
(codice insegmanento)
* T28_DTINIZ
(data inizio dell'appello)
* T28_DTFINE
(data fine)
* T28_SEMESTRE
(codice del semestre/quadrimestre/bimestre)
* T28_DTUPDATE
(ultimo aggiornamento)
* T28_FLG_FC
(Appello valido per fuori corso (S) altrimenti (N))
* T28_LAUREANDI
(Appello valido per laureandi (S) altrimenti (N) Sono laureandi gli studenti con domanda caricata nella LAU)
{BR}
**T01** (righe n. 8){BR}
_Descriscione Tabella: _Descrizioni TAF.  In aggiunta ai TAF ministeriali (A..F) sono stati utilizzati anche i TAF G (di sede) e T (transitati in affine){BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T01_TIPOAF
(Codice TAF.)
* T01_DESCR
(Descrizione TAF)
* T01_DTUPDATE
(Data Aggiornamento)
* T01_DESCR_EN
(Descrizione dell'attività formativa in inglese. Sempre vuota.)
* T01_RID
(Questo campo contiene l'identificativo della tabella.)
{BR}
**CRD** (righe n. 0){BR}
_Descriscione Tabella: _Tabella dei coordinatori e referenti per i dottorati   Per il momento non è utilizzata Verificare l'effettivo utilizzo in sede di migrazione effettiva{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CRD_RID
(identificativo tabella)
* CRD_CODCDL
(codice corso dottorato)
* CRD_CICLO
(ciclo)
* CRD_NOME
(nome)
* CRD_COGN
(cognome)
* CRD_SEDE
(sede)
* CRD_E_MAIL
(e-mail)
* CRD_NUMTEL
(numero di telefono)
* CRD_NUMCEL
(numero cellulare)
* CRD_NUMFAX
(numero fax)
* CRD_CODFAC
(codice facolta)
* CRD_INDREC
(indirizzo recapito)
* CRD_CAPREC
(CAP recapito)
* CRD_LOCREC
(Località di recapito)
* CRD_DECORRENZA
(data decorrenza)
* CRD_DTUPDATE
(ultimo aggiornamento)
* CRD_CODDOC
(codice docente)
* CRD_FLAG_CR
(Flag Coordinatore o Referente)
{BR}
**DEL** (righe n. 30175){BR}
_Descriscione Tabella: _Testata delibere. Migrare nella P04_ATTI_AMMIN.{BR}
_Aree di interesse: _
J05 - Gestione Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* DEL_CDL
(Corso di Studi)
* DEL_MATR
(Matricola)
* DEL_NUMDEL
(Numero progressivo delibera dello studente)
* DEL_NUMRIG
(Numero totale di righe della delibera. Non usare. Esse3 usa i campi testo.)
* DEL_AA
(Anno Acc. Emiss. Delibera)
* DEL_DTCF
(Data Delibera)
* DEL_DTDR
(Data Decreto Rettorale)
* DEL_NRDR
(Nr. Decreto Rettorale (ev. nella P04_DELIBERE, si inserisce sulla prima riga del testo.))
* DEL_DTSA
(Data Senato Accademico. E' ripetuta all'interno del testo. Non migrare.)
* DEL_DTDF
(Data Consiglio Facolta'.)
* DEL_TIPO
(Tipo Di Delibera . Tr=Trasferimento . La=Laurea . Ri=Riconosc. Laurea . Pd=Provvedim.Discip. . Tp=Tirocinio Pratico . Va=Varie Lp Pi   DB DV LP PI ST TR  VA)
* DEL_FLGVALIDA
(Flg Delibera Valida (S/N)  Non si sa il significato )
* DEL_TITOLO
(Titolo Della Delibera)
* DEL_STAMPA
(Flag Delibera Stampata  Stampa sul congedo e sul statino di laurea)
* DEL_RID
(Questo campo contiene l'identificativo della tabella)
{BR}
**DOM** (righe n. 10172){BR}
_Descriscione Tabella: _Domande di ammissione all'esame di stato.   Si deve utilizzare questa tabella anche per risalire alle associazioni esami di stato - sessioni  Sembra che manchi almeno una sessione nella SSE: la 3 del 2001 per biologia. Possiamo inserirla manualmente.  A parità di PERS_ID (matricole riunificate), DOM_CODESR, DOM_ANNO e DOM_SESSIONE prendo il record con DOM_MATR maggiore.{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* DOM_RID
(Questo campo contiene l'identificativo della tabella)
* DOM_CDL
(Corso di Laurea. <del> Il dato non e' rilevante.)
* DOM_MATR
(Matricola.)
* DOM_CODEST
(Codice esame di stato)
* DOM_ANNO
(Anno del concorso)
* DOM_SESSIONE
(Sessione del concorso)
* DOM_PERIODO
(Periodo esame.  come nella SSE)
* DOM_DTORD
(Data ordinanza di istituzione concorso.   come nella SSE)
* DOM_DTDOM
(Data presentazione domanda.)
* DOM_DTINIZ
(Data inizio.  come nella SSE)
* DOM_SEZIONE
(sezione)
* DOM_SETTORE
(codice settore)
* DOM_FLG_ABIL_B
(Flag abilitazione settore B già conseguita)
{BR}
**E2S** (righe n. 318){BR}
_Descriscione Tabella: _Esami sostenuti con esito negativo dell'ultimo libretto Ante-riforma per gli studenti che hanno esercitato l'opzione per il passaggio al post-riforma.  Sta alla ESA come la P2S sta alla PDS, e come la ESA, va migrata nella P11_REG_SCE.  Le colonne sono identiche a quelle della ESA, pertanto si rimanda a tale tabella per la spiegazione di tali campi.{BR}
_Aree di interesse: _
J15 - Libretto Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* E2S_RID
(Questo campo contiene l'identificativo della tabella)
* E2S_CDL
(Corso Di Laurea)
* E2S_MATR
(Matricola)
* E2S_CODINS
(Codice Insegnamento)
* E2S_DTSOST
(Data Sostenimento Esame)
* E2S_UNIV
(Universita' Sost. Esame)
* E2S_AACSOSTESA
(Anno Acc. Sostenimento Esame)
* E2S_SESSIONE
(Sessione Sostenimento Esame)
* E2S_VOTO
(Voto Esame nn = Numero da 1 a 17 Re=Respinto Rt=Ritirato)
* E2S_FLGCONVESA
(Flg Esame Convalidato (S/ ))
* E2S_INTEGRATIVO
(Esame integrativo (I/P/..))
* E2S_DOCENTE
(Docente esame)
{BR}
**ESP** (righe n. 23602){BR}
_Descriscione Tabella: _Esiti delle prove degli studenti. Da migrare in P03_CLASSIF_DETT   Contiene anche le bocciature presso altri atenei (con ESP_SEDEUNV != 12). Generalmente queste righe NON hanno il codice della prova. Queste sono da migrare nella P03_BOCC_ESA_STA  A parità di PERS_ID (matricole riunificate), ESP_CODEST, ESP_ANNO e ESP_SESSIONE prendo il record con ESP_MATR maggiore.{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ESP_CODTUTOR
(codice del tutor  FK verso la TUT)
* ESP_DINIZ
(data inizio della prova)
* ESP_DFINE
(data fine della prova)
* ESP_RID
(Questo campo contiene l'identificativo della tabella)
* ESP_CDL
(Corso di studi.)
* ESP_MATR
(Matricola.)
* ESP_ANNO
(Anno Solare esame)
* ESP_SESSIONE
(Sessione esame)
* ESP_CODEST
(Codice Esame di Stato (professione))
* ESP_CODPRV
(Codice Prova Esame)
* ESP_SEDEUNV
(Codice Sede Universita')
* ESP_ESITO
(Esito della prova. )
* ESP_VOTO
(Voto prova)
* ESP_DNVT
(Denominatore Voto (100,110,etc)
* ESP_LODE
(Lode)
* ESP_SEZIONE
(sezione)
* ESP_SETTORE
(settore)
* ESP_CODINT
(codice prova padre)
{BR}
**PDF** (righe n. 157905){BR}
_Descriscione Tabella: _Piano di studi di Facoltà. Da migrare nelle tabelle P09_OD, P09_AD_PDSORD, P09_UD_PDSORD, P09_SEG_PDSORD.  La presenza dell'insegnamento in questa tabella determina che si deve inserire in P09_AD_GEN ecc., se manca in P09_AD_LIB.  La presenza dell'insegnamento in questa tabella determina anche che l'attività del libretto è da considerarsi "in piano", la mancanza come attività libera fuori piano. {BR}
_Aree di interesse: _
J12 - Offerta Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* PDF_RID
(Questo campo contiene l'identificativo della tabella)
* PDF_CODCDL
(Codice Corso di Laurea di Offerta Didattica )
* PDF_CODIND
(Codice Indirizzo)
{BR}
* PDF_CODORIE
(Codice orientamento. (Vedi IOL))
* PDF_CODLING
(Codice lingua (vedi IOL))
* PDF_AAVALID
(Anno Accademico di validità.)
* PDF_CODINS
(Codice insegnamento)
* PDF_TIPOINS
(Insengamento Obbligatorio Nel Piano di Studi (S/N))
* PDF_ANNO
(Anno di corso)
* PDF_PROP_CDL
(Data da visualizzare nel piano)
* PDF_CREDITO_MAX
(Obsoleto)
* PDF_DTUPDATE
(Data aggiornamento)
* PDF_TIPOAF
(Tipo attivitò formativa)
* PDF_AMBITO
(Codice dell'ambito  Vedi ACL)
* PDF_CREDITO
(Crediti dell'insegnamento)
* PDF_DOCENTE
(Codice del docente Titolare)
* PDF_SEMESTRE
(Definizione del periodo didattico di svolgimento)
* PDF_INSTIPO
(Tipologia dell'insegnamnto ( normale... integrato... moduli...))
* PDF_TIPOVOTO
(Tipologia del voto (..30 ..ID))
* PDF_COMPOSTO
(Definizione di esame composto o non conposto)
* PDF_TIPOCOMP
(non rilevante)
* PDF_CODINT
(Sugli insegnamenti modulo è caricato l'insegnamento padre)
* PDF_DURATA
(Durata dell'insegnamento)
* PDF_ORE
(Ore dell'insegnamento)
* PDF_TIPOESAME
(Tipologia dell'esame dell'insegnamento)
* PDF_FLGFREQ
(Definizione dell'obbligatorietà della frequenza)
* PDF_NOMEDIA
(Definizione se l'esame deve essere considerato per la media)
* PDF_CODPROVA
(Codice insegnamento per la definizione della esame priciso rispetto a un codice esame predefinito (vedi prova di conoscenza della lingua)  Codice dell'esame generico)
* PDF_FLGCNV
(Per una specifica convenzione certi esami erano da piano caricati già superati con convalida)
* PDF_FLGPIANO
(Identifica il fatto che non deve essere ricaricato il piano negli anni successivi allo studente.  Il dato è comune per corso e anno accademico (quindi deve essere uguale su tutte le attività).  Da verificare)
**PDS** (righe n. 3035634){BR}
_Descriscione Tabella: _Piano di studi e libretto dello studente. Migrare sulla P11_AD_PIANI, P11_AD_SCE, P11_SEG_SCE, P11_AD_REG, P11_AD_REG_DOC.  Tutti gli insegnamenti presenti nella PDF vanno migrati sia nella P11_AD_PIANI che nella P11_AD_SCE, quelli non presenti SOLO sulla P11_AD_SCE e NON sulla P11_AD_PIANI.  La PDS contiene solo gli insegnamenti fino all'anno di ultima iscrizione e non il piano completo.  Puo' capitare che una riga di PDS abbia dei dettagli nella AAF. Non esiste un particolare criterio per sapere se i dettagli esistono o meno. Generalmente i dettagli esistono per le attività di tipo ALTRE ATTIVITA' FORMATIVE.{BR}
_Aree di interesse: _
J15 - Libretto Studente
J13 - Piani di Studio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* PDS_RID
(Questo campo contiene l'identificativo della tabella)
* PDS_CDL
(Codice Corso di laurea. Non sempre coincide con il corso di iscrizione. E' il corso a cui afferisce l'insegnamento.)
* PDS_MATR
(Matricola)
* PDS_CODINS
(Codice Insegnamento)
* PDS_ANNO
(Anno Frequenza Dell'esame È l'anno di corso)
* PDS_TIPOINS
(Tipo Insegnamento. L = Monodisciplinare I = Integrato (è il padre)  M = Modulo (sono i figli) W= Workshop B= Laboratorio  P = Prova di idoneità   Vengono gestiti i gruppi: gli I sono i padri, gli M sono i figli )
* PDS_ANNU
(Annualita' Insegnamento)
* PDS_COMPOSTO
(Insegnamento composto (S/N)   L'informazione serve per gestire i gruppi e quindi se =S identifica l'insegnamento composto, padre del raggruppamento  Non utilizzato in quanto il padre è identificato da PDS_TIPOINS = I)
* PDS_MODULO
(Chiave Modulo può valere 0 o null (Spazio) a seconda che sia o no un modulo.  Non utilizzato)
* PDS_CODINT
(Codice insegnamento Integrato (Padre). Vengono gestiti i gruppi. Identifica il padre del raggruppamento.  E' significativo solo quando PDS_TIPOINS = M)
* PDS_CREDITO
(Crediti)
* PDS_ORE
(Ore di durata.)
* PDS_TOTCREDITI
(Totale Crediti didattici superati (convalidati). NON CONSIDERARE  Il credito dell'esame e' dato dal campo PDS_CREDITO, l'unico importante      )
* PDS_NOMEDIA
(Insegnamento che non partecipa al calcolo della Media esami)
* PDS_NUMFRQ
(Numero Di Frequenze.  Nel caso di esame bi-semestrale le frequenze che lo studente deve ottenere sono 2!)
* PDS_UNIVESA
(Universita' Sost. Esame)
* PDS_AACSOSTESA
(Anno Accademico Sostenimento Esame)
* PDS_DTSOSTESA
(Data Sostenimento Esame.)
* PDS_LODEESA
(Lode (L=Lode).)
* PDS_CODCATTEDRA
(Docente dell'esame.)
* PDS_TIPOESAME
(Tipologia di esame)
* PDS_FLGFREQ
(Frequenza obbligatoria)
* PDS_SEDEAF
(non usato)
* PDS_TIPOAF
(T.A.F.)
* PDS_AMBITO
(ambito ministeriale)
* PDS_TIPOCORSO
(tipo corso)
* PDS_AMBOLD
(vecchi ambiti interni.)
* PDS_UNIVFRQ
(Universita' Di Frequenza)
* PDS_AACFRQ
(Anno Accademico Frequenza.  Serve anche per capire a quale anno di offerta collegare gli insegnamenti. )
* PDS_TIPOFRQ
(Flg Tipo Frequenza =In Attesa Di Assegnaz. S=Con Statino A=Assegnaz. Automatica N=Non Richiesta (Convalida) U= frequenza d'ufficio O=frequenza convalidata per opzione C=Convalida)
* PDS_SESSIONEESA
(Sessione Sost. Esame Riferimento tabella T08.T08_N3)
* PDS_VOTOESA
(Voto Esame  Numeri= VOTO  AP = approvato (giudizio positivo) BN = buono CV= convalidato con giudizio positivo DI = discreto ID = Idoneo LO = Lodevole NO = errore NR = errore OT= Ottimo PO = positivo RE = respinto SF = sufficiente)
* PDS_FLGCONVESA
(Flg Esame Convalidato (S/ ) (S/O/N/F)   S=Convalidato  O=Convalida di attività in seguito a opzione/pass.ordinamento N=No convalida.   E' prioritario anche rispetto a AAC_UNIVESA.)
* PDS_CRDOPZ
(Crediti opzionali   Generalmente questo campo viene valorizzato quando PDS_CREDITO = 0 in occasione di convalide per opzione. Capita pero' che entrambi i campi siano valorizzati, in questo caso i due valori devono essere sommati.)
* PDS_FLGINPIANO
(Flag In Piano (S/N).   Quando il flag è N, gli esami non concorrono alla media (corrispondono agli esami sovrannumerari di Esse3)  Questo flag vale N quando uno studente toglie dal piano un esame che ha frequentato (a casusa di una variazione al piano oppure un passaggio) o superato (a causa di un passaggio). Eventualmente, nel caso di esame fuori piano e superato, ci puo' essere una convalida. )
* PDS_DURATA
(Durata.   Valori: 0 - annuali 0,2 - bimestrale 0,4 - quadrimestrale 0,5 - semestrale 1 - annuale 1,5 - bisemestrale)
* PDS_SUPINT
(Flg Esame Integrato superato (../S)  Non considerare. L'esame integrato è da considerare superato quando ha il voto.)
* PDS_SEMESTRE
(Semestre Di Insegnam.  Vedi INS.INS_SEMESTRE)
* PDS_AAVALID
(anno accademico di validità non considerare)
{BR}
**SCL** (righe n. 511){BR}
_Descriscione Tabella: _Tabella delle regole di sbarramento. Migrare in P08_REGSBA, P08_SBA e le relative tabelle di filtro.{BR}
_Aree di interesse: _
J10 - Regolamenti Didattici
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* SCL_RID
(Questo campo contiene l'identificativo della tabella)
* SCL_CODCDL
(Corso Di Laurea)
* SCL_TIPO
(Tipo sbarramento)
* SCL_ANNO
(Anno di corso su cui effettuar lo sbarramento)
* SCL_PROG
(Progressivo sbarramento)
* SCL_TOTALE
(Sbarramento totale (S/N) su tutti)
* SCL_TIPO_SCL
(Tipo Numero (E=Esame,A=Annualita',O=Ore))
* SCL_ANNO_SCL
(Anno di corso di Controllo)
* SCL_NUMERO
(Valore per il controllo da effettuare)
* SCL_CODINS
(Codice esame da superare)
* SCL_TIPOISCR
(Con F sono le regole per andare al fuori corso)
* SCL_TIPO_INS
(Tipo Insegnamento su cui effettuare il controllo per lo sbarramento)
* SCL_AND_OR
(Definizione della successione delle regole,  A sono tutte da soddisfare O sono altrenativa)
{BR}
**STD** (righe n. 87270){BR}
_Descriscione Tabella: _Anagrafica persone e studente. I dati confluiranno sulla tabella P01_ANAPER (anagrafica persone) P01_STU (carriere studente), P01_MATUR (maturità), P01_TIT_IT (Titoli di studio), P04_MAT (Matricole){BR}
_Aree di interesse: _
J01 - Anagrafiche Persone
J05 - Gestione Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* STD_PROVNAS
(Provincia di nascita.)
* STD_CITTADNAS
(Cittadinanza-rif. Tabella T04-)
* STD_ISTATNAS
(Codice Istat del comune di nascita)
* STD_INDREC
(Indirizzo recapito)
* STD_LUOGOREC
(Comune recapito)
* STD_FRAZREC
(Frazione recapito (campo libero))
* STD_PROVREC
(Provincia recapito)
* STD_TELREC
(Telefono recapito)
* STD_ISTATREC
(Codice Istat del comune di Recapito)
* STD_CAPRES
(C.A.P. residenza)
* STD_LUOGORES
(Comune residenza)
* STD_PROVRES
(Provincia residenza)
* STD_NAZRES
(Nazione residenza)
* STD_TELRES
(Telefono residenza)
* STD_FLGTIT
(Flag titolodi studio straniero (S/N))
* STD_AATIT
(Anno conseguimento tit studio—è l'anno solare non detrarre 1</del>)
* STD_NAZTIT
(Nazione conseguim. tit studio)
* STD_LODETIT
(Eventuale lode titolo di studio (../L))
* STD_VOTO_3SUP
(Votazione media 3' anno in decimi Utilizzato per calcolo tasse)
* STD_DTDIPLTIT
(Data presentazione diploma)
* STD_FLGDIPLTIT
(Flag diploma ritirato (S/N))
* STD_RICHTIT
(Titolo di studio confermato (S/N))
* STD_FLGDIPLINT
(Flag Diploma Integrativo)
* STD_MESICORSO
(Nr. Mesi Corso Studi <del>non utilizzato-)
* STD_DTCOLLOQUIO
(Data colloquio italiano</del>non utilizzato-)
* STD_CODINT
(Codice Titolo Di Studio Integrativo)
* STD_ISTINT
(Istituto conseguimento titolo integrativo)
* STD_RICHINT
(Inviata conferma titolo integrativo (S/N))
* STD_DTCONFINT
(Data conferma titolo integrativo)
* STD_DTLAU
(Data laurea precedente)
* STD_NAZLAU
(Nazione conseguimento laurea)
* STD_RICHLAU
(Richiesta conferma laurea (S/N))
* STD_DTCONFLAU
(Data conferma laurea)
* STD_NRTELEXP
(Nr. Teleespresso equipollenze<del>non utilizzato-)
* STD_NRDECRRT
(Nr. Decreto Rettorale Ammissione</del>non utilizzato-)
* STD_DTTRA
(Data domanda di trasferimento in uscita)
* STD_UNIVTRA
(Università di trasferimento in uscita (se univtra = 12 sono passaggi interni))
* STD_DTTRAEFF
(Data effettiva di trasferimento)
* STD_CDLTRADA
(CDL di provenienza.)
* STD_CDLULT
(Corso di laurea ultimo. Non considerare. Usiamo il dato di AAC.)
* STD_ANNOCORSOULT
* STD_FLGLAVULT
* STD_CDLPENULT
{BR}
(Anno di corso ultimo.Non considerare. Usiamo il dato di AAC.)
(Flg Lavoratore (S/N). Non considerare. Usiamo il dato di AAC.)
(Corso Di Laurea Penultimo. Non considerare. Usiamo il dato di AAC.)
* STD_DTCESSULT
(Data Ultima Cessazione della carriera)
* STD_IP_ANNOCORSO
(Anno In Corso Studente Sotto Ipotesi)
* STD_IP_NFCTOT
(Nr. Totale Di Fuoricorso Sotto Ipotesi)
* STD_FLG_IP_COND
(Flag Ipot. Sotto Condizione)
* STD_NESAPOSTOT
(N.Tot.Di Esami Positivi)
* STD_NESANEGTOT
(N.Tot.Di Esami Negativi)
* STD_NINSERTITOT
(N.Tot. Inserti<del>non utilizzato-)
* STD_FLGLAUPRIMA
(Flg Laureato Precedentemente (S/N)  Per questi studenti deve essere STD_TIPOIMM = 'L')
* STD_FLGDELIB
(Flg Delibere (S/N). )
* STD_FLGPDSLIB
(Flg Pds Personalizzato (S/N)  Utilizzare STD_FLGTIPOPDS)
* STD_FLGFOTO
(Flg Present. Foto Autentica (S/N))
* STD_FLGIMM
(Flg Dati Imm.Da Compl/Correg. (S/N) )
* STD_FLGDADECADERE
(Flg Proposto Da Decadere)
* STD_FLGLIBR
(Flg Libretto Emesso (S/N))
* STD_FLGBLOCCO2
(Flg Blocco Per Prestito Libri (S/N) )
* STD_FLGANOM01
(Consegnato Certif.-Deve Dipl. (S/N))
* STD_FLGANOM02
(Ritirato Attest.-Deve Dipl. (S/N))
* STD_FLGANOM04
(Manca Foto Autentica (S/N))
* STD_FLGANOM06
(Tit.Studio Da Legalizzare (S/N))
* STD_BANCA_ABI
(Codice ABI Banca )
* STD_BANCA_CAB
(Codice CAB Banca)
* STD_BANCA_SC
(Codice Sottoconto C.C. Bancario)
* STD_FLGTBC
(Vaccinazione TBC (S/N)  Vale solo per i corsi di Medicina. All'atto dell'iscrizione viene impostata su S e poi viene messa a N quando la porta.)
* STD_FLGVARI
(Blocco generico)
* STD_FLGTIPOPDS
(Flag tipo Piano di Studio)
* STD_VOTODEN
(Denominatore del voto del titolo di maturità)
* STD_LIMDECADENZA
(non usato)
* STD_TELCEL
(Num.Tel.cellulare)
* STD_E_MAIL
(Indirizzo E-mail dello studente.)
* STD_TIPODOTT
(Tipo Dottorato)
* STD_LAU_TIPOCDL
(Tipo CDL nel quale lo studente ha conseguito la laurea presentata)
* STD_DTRICHTIT
(data elaborazione conferme da inviare - titolo di maturità)
* STD_DTRICHINT
(data elaborazione conferme da inviare - titolo di maturità integrativo)
* STD_DTRICHLAU
(data elaborazione conferme da inviare - titolo di laurea)
* STD_VOTOLAU
(Voto laurea precedente)
* STD_LODELAU
(Lode lurea precedente)
* STD_TIPO_DOTT
(Tipo Dottorato. )
* STD_FLGPOL
(Convenzione con Polizia di Stato )
* STD_FLGAAINTAPP
(Hanno titoli di servizio e non anno integrativo.)
* STD_RID
(Questo campo contiene l'identificativo della tabella)
* STD_CFISC
(Codice Fiscale.)
* STD_PROGR_BADGE
(Progressivo Badge</del>non utilizzato<del>)
* STD_PASSW_BADGE
(Password dello studente.)
* STD_CODSTATO
(Codice Stato Dello Studente A=Attivo L=Laureato T=Trasferito (in uscita) R=Rinunciatario D=Decaduto M=Deceduto S=In Sospeso C=Congelamento posizione (è sempre una sospensione) P=Equipollente E=Esame di Stato)
* STD_DTIMM
(Data immatricolazione/ingresso a L'Aquila)
* STD_DTPRIMM
(Data prima immatricolazione della carriera)
* STD_AAC_PRIMM
(A. Acc. Pr. Immatricolazione)
* STD_CDL_PRIMM
(C.D.L. Prima Immatricolazione (se trasferito in ingresso -> viene presa da CDE, altrimenti dalla CDL))
* STD_DTCONCORSO
(Data concorso ammissione</del>non utilizzato<del>)
* STD_VOTO_TEST
(Voto Test Ammissione</del>non utilizzato<del>)
* STD_COGN
(Cognome Studente)
* STD_DTNAS
(Data di nascita)
* STD_SESSO
(Sesso)
* STD_VOTO_4SUP
(Votazione media 4' anno in decimi Utilizzato per calcolo tasse)
* STD_VOTO_RIF
(Votazione media corretta in 60')
* STD_DOCUMTIT
(Tipo documento presentato.   Vedere Mappatura su tabella TIPI_DEPOSITO.)
* STD_DTCONFTIT
(Data conferma titolo di studio)
* STD_DTAMMISS
(Data prova ammissione</del>non utilizzato-)
* STD_AAINT
(Anno conseguimento titolo integrativo)
* STD_NAZINT
(Nazione conseguimento titolo integrativo)
* STD_CDLLAU
(Codice corso precedente laurea (se univlau<>12 va sulle CDE altrimenti CDL)  Capita che univlau=12 ma il corso non si trova nella VDL. In questo caso (e solo se lo studente ha una sola carriera precedente chiusa per titolo, allora si puo' risalire al corso di laurea tramite la LAU.  )
* STD_UNIVLAU
(Università laurea precedente-rif. Tabella T03-su questa tabella va fatto il mapping)
* STD_RICONLAU
(Riconoscimento laurea  Non esistono casi di Equipollenza.)
* STD_DTTELEXP
(Data Teleespresso equipollenze<del>non utilizzato-)
* STD_RIF_LEGGE
(Rif. di legge per riconoscimenti e equipollenze.)
* STD_DTDECRRT
(Data Decreto Rettorale Ammissione</del>non utilizzato-)
* STD_CDLTRA
(CDL di trasferimento in uscita)
* STD_UNIVTRADA
(Università di provenienza (se univ=12 sono passaggi interni))
* STD_ANNOACCULT
(Anno accademico ultimo. Non considerare. Usiamo il dato di AAC.)
* STD_INDIRULT
(Indirizzo/orient./lingua ultimo. Non considerare. Usiamo il dato di AAC.)
* STD_TIPOISCRULT
(Tipo di iscrizione ultimo. Non considerare. Usiamo il dato di AAC.)
* STD_NFCTOT
(Numero totale di fuoricorso. Non considerare. Usiamo il dato di AAC.)
* STD_MODISCRULT
(Modalita' Iscr. Ultima. Non considerare. Usiamo il dato di AAC.)
* STD_FLG_COND
(Flag Iscr. Sotto Condizione (S/N).  Si riferisce solamente all'ultima iscrizione)
* STD_IP_TIPOISCR
(Tipo Iscrizione Sotto Ipotesi)
* STD_FLG_IPOT
(Flag Ipotesi Iscrizione 0 = Senza Ipotesi 1 = Studente Con Ipotesi 2 = Iscriz. Come Da Ipotesi 3 = Ipotesi Annullata)
* STD_NPDSLIBTOT
(N.Tot.Di Pds Liberalizzati (dovrebbe tenere traccia ogni volta che si cambia qualcosa sul PDS)  )
* STD_NDELTOT
(N.Tot. Di Delibere .)
* STD_AAPDSLIB
(Anno Acc Ult.Pds Personalizz.)
* STD_FLGSTRANIERO
(Flg Nazionalita' Straniera (S/N) Non Usare. Vale il dato di Nazionalità.)
* STD_FLGCERTNA
(Flg Presentaz. Cert. Nasc. (S/N))
* STD_FLGCARDID
(Flg Carriera Did.Da Caricare (gestiti in caso di trasferimenti in ingresso)   Gestito a mano ed aggiornato ogni volta che si completa la carriera dello studente (ricostruzione iscrizioni e piano + convalide)  S=Si(Anni+Insegnamenti)  A=Si(Solo Insegnamenti)  N=No)
* STD_FLGCARASS
(Flg Carriera Did. Assestata (S/N) )
* STD_FLGBLOCCO1
(Flg Blocco Per Provv. Discip. (S/N) )
* STD_FLGBLOCCO3
(Flg Blocco Per Tasse (S/N) )
* STD_FLGANOM03
(Manca Conferma Tit.Studio (S/N))
* STD_FLGANOM05
(Cert.Nasc. Mancante/Irreg. (S/N))
* STD_BANCA_CC
(Codice C.C. Bancario)
* STD_BANCA_TIT
(Titolare C.C. Bancario)
* STD_FLG_PRIVACY
(Trattamento dati personali(S/N))
* STD_DNVTLAU
(Denominatore Voto laurea prec.)
* STD_ENTEBORSA
(codice Ente borsa  FK verso T31)
* STD_TIPOCDL
(Tipo corso studi (Da CDL-TIPO2) verificare la coerenza di questo dato con la tabella TCL, questa è stata creata successivamente per i certificati<del> U=diploma universitario N=triennale F=scuola diretta fini speciale S=scuole di specializzazione L=ante riforma H=specialistica ciclo unico P=laurea specialistica  E' una denormalizzazione per velocizzare alcuni calcoli. Questo campo non partecipa alla migrazione.)
* STD_UNI_PRIMM
(Univ. Pr. Immatricolazione)
* STD_TIPOIMM
(Tipo di immatricolazione)
* STD_NOME
(Nome studente)
* STD_LUOGONAS
(Luogo di nascita-rif. Tabella T40 (assieme a STD_PROVNAS))
* STD_NAZNAS
(Nazione di nascita-rif. Tabella T04 (nazione del luogo di nascita)-)
* STD_CAPREC
(C.A.P. recapito)
* STD_NAZREC
(Nazione recapito)
* STD_INDRES
(Indirizzo residenza)
* STD_FRAZRES
(Frazione residenza (inserimento libero))
* STD_ISTATRES
(Codice Istat comune di Residenza Recapito tasse su residenza per tutti. Questo campo è ininfluente visto che i bollettini vengono stampati on-line.)
* STD_CODTIT
(Codice titolo di studio-rif.Tabella T06-)
* STD_ISTTIT
(Istituto conseguim. titolo di studio (FK verso T02))
* STD_VOTOTIT
(Votazione titolo di studio. Se STD_AATIT <= 1998 allora base in 60esimi altrimenti base in 100esimi)
* STD_SEDEFORM
(Codice sede formativa della didattica  Utilizzato per i corsi sanitari  FK in SFO)
* STD_DTTAR
(Sostituisce la data di immatricolazione a seguito di ricorso al TAR)
* STD_LAU_CLASSE
(Classe di appartenenza della laurea presentata)
* STD_FLGCONFTIR
(Conferma tirocinio (per esami di stato))
* STD_FLGBLOCCOAAT
(Flag blocco per autocertificazioni per tasse.  Lo studente con questo blocco paga l'intera rata fino alla laurea. )
* STD_FLG_NPDS
(Flag mancanza piano da frequentare, cioè quello relativo agli anni di corso uguali o maggiori di quello di iscrizione)
* STD_VOTO_3DEN
(denominatore voto di 3 superiore)
* STD_VOTO_4DEN
(denominatore voto di 4 superiore)
* STD_FLG_DEBITO
(Flag di immatricolazione alla specialitica con debito formativi.  Non può sostenere esami della specialistica finchè esitono debito formativi)
* STD_RIF_POL
(Rifugiato Politico (S/N))
* STD_CODCDL
(Codice Corso di Laurea di immatricolazione a L'Aquila.  Quando uno studente si immatricola fuori e poi entra a L'Aquila, questo campo contiene il codice del corso di ingresso in ateneo.)
* STD_MATR
(Matricola.  Deve avere un rapporto 1:1 con lo STU_ID. Attenzione ai rientri in quanto possono generare una nuova riga nella STD. Le matricole che iniziano per 'E' sono relative agli esami di stato e vanno escluse dalla carriera (hanno solo la posizione).  Le matricole normali sono numeriche con 6 caratteri. Gli esami di stato hanno come primo carattere 'E', se per sono interni allora mantengono la stessa STD. )
**T02** (righe n. 4960){BR}
_Descriscione Tabella: _Tabella degli istituti superiori.  Migrare nella P01_SCUOLA.  Gli istituti con il codice MIUR valorizzato verranno mappati/collegati, gli altri verranno inseriti.{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T02_RID
(Questo campo contiene l'identificativo della tabella.)
* T02_CODIST
(Codice Scuola Superiore. )
* T02_DTUPDATE
(Data Aggiornamento)
* T02_DESCRIZIONE
(Descrizione del tipo scuola)
* T02_NOME
(Nome istituto)
* T02_TIPO
(Flag Statale)
* T02_INDIR
* T02_CAP
(Indirizzo scuola)
(Cap)
* T02_LOCALITA
(Località.)
* T02_STATO
(Nazione)
* T02_FLG_CONFERMA
(Flag Conferma Campo non gestito)
* T02_COD_MIUR
(Codice Miur Codice MIUR, è possibile utilizzarlo per il mapping con gli istituti presenti in Esse3.)
{BR}
**T03** (righe n. 763){BR}
_Descriscione Tabella: _Tabella Università.  Atenei italiani ed esteri e istituti ASL (per conferme di lauree triennali sanitarie).  Mappare con la P06_ATENEI e P01_ATESTRA.  vanno nella P01_ATESTRA i record con T03_STATO != 1 gli altri vanno in P06_ATENEI{BR}
_Aree di interesse: _
J02 - Struttura Didattica
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T03_DTUPDATE
(Data Aggiornamento)
* T03_DESCRIZIONE
(Descrizione. Usare per Mapping. )
* T03_INDIR
(Indirizzo)
* T03_CAP
(CAP)
* T03_LOCALITA
(Localita'.)
* T03_COD_MIUR
(Codice MIUR)
* T03_RID
(Questo campo contiene l'identificativo della tabella)
* T03_CODUNIV
(Codice Universita')
* T03_STATO
(Stato/Nazione. In base a questo campo si suddivide tra P01_ATENEI e P01_ATESTRA.  1 - italia altri - estero (decodificata in T04)  FK verso T04)
{BR}
**T06** (righe n. 101){BR}
_Descriscione Tabella: _Tabella Titoli di studio. Da Mappare con la TIPI_TITOLO_SUP.  Eventualmente aggiungere i mancanti.  Il mapping verrà effetuato principalmente tramite il codice ALMA/Laurea (T06_ALMA){BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T06_RID
(Questo campo contiene l'identificativo della tabella.)
* T06_CODTIT
(Codice interno)
* T06_DESCRIZIONE
(Descrizione)
* T06_FLG_ANNOINT
(Anno Integrativo (S/N) </del> Non esiste un campo corrispondente in Esse3.)
* T06_FLG_TITSTRA
(Flag titolo straniero (a livello di istituto superiore).)
* T06_TIPO
(Non si conosce il significato)
* T06_COD_MIUR
(Codice MIUR)
* T06_ALMA
(Codice ALMA Laurea)
* T06_DTUPDATE
(Data aggiornamento )
{BR}
**T07** (righe n. 190){BR}
_Descriscione Tabella: _Date inizio e fine iscrizioni, scadenze rate tasse ecc. per anno/corso.  VERIFICARE l'effettiva utilità/necessità di migrare questi dati, trattandosi di scadenze relative al passato.  Dovrebbero popolare le tabelle P06_AA_SCAD_CDS, P06_AA_SOSP_CDS, P06_AA_SCAD_AT e P06_AA_SOSP_AT.   NB. L'AA 2006/2007 viene codificato come 2007{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T07_ANNOACC
(Codice AA (Anno finale))
* T07_DTUPDATE
(data di aggiornamento)
* T07_DATAINIZIOAA
(data inizio AA)
* T07_DATAFINEAA
(data fine AA)
* T07_DATAINIZIOISCRIZ
(data inizio iscrizioni)
* T07_DATASCAD1RATA
(data scadenza prima rata (corrisponde alla data di chiusura delle iscrizioni))
* T07_DATASCAD2RATA
(data scadenza secdonda rata)
* T07_DATAINIZIOAACA
(data inizio corsi annuali)
* T07_DATAFINEAACA
(data fine corsi annuali)
* T07_DATAINIZIOAACS1
(Inizio corsi 1' semestre)
* T07_DATAFINEAACS1
(Fine corsi 1' semestre)
* T07_DATAINIZIOAACS2
(Inizio corsi 2' semestre)
* T07_DATAFINEAACS2
(Fine corsi 2' semestre)
* T07_REDDITOEQC
(Limite max di reddito equiv. corretto)
* T07_TIPOCDL
(Tipo di corso (decodificato in TCL))
* T07_DATASCAD3RATA
(Data scadenza terza rata)
* T07_VALUTA
(Valuta utilizzata (Lire / Euro))
* T07_DATASCAD1RATANC
(Data scadenza prima rata per i corsi a numero chiuso. (Corrisponde alla data di fine iscrizione per i corsi a numero chiuso))
* T07_RID
(Questo campo contiene l'identificativo della tabella)
{BR}
**T11** (righe n. 4580){BR}
_Descriscione Tabella: _Tabella dei CAP.  Da verificare/mappare con quella definita in Esse3. Inoltre si possono inserire le località nella tabella P01_località.{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T11_CAP
(CAP NUMERICO)
* T11_DTUPDATE
(Data aggiornamento)
* T11_PREFTEL
(prefisso telefonico)
* T11_FLAG_DUP
(Cap con piu' localita' (0/1))
* T11_RID
(Questo campo contiene l'identificativo della tabella.)
* T11_DESCRIZIONE
(Localita' (Se Flag-dup=0))
* T11_PROVINCIA
(Provincia di appartenenza. Considerare per il mapping nei casi di CAP duplicato)
{BR}
**T18** (righe n. 2166){BR}
_Descriscione Tabella: _Tabella docenti.  Da migrare nella tabella DOCENTI di Esse3. Utilizzata principalmente per caricare i relatori.{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
J18 - Conseguimento Titolo
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T18_DOCENTE
(Codice Docente)
* T18_DTUPDATE
(Data Aggiornamento)
* T18_NOMEDOCENTE
(Cognome e Nome)
* T18_PASSWD
(Password Badge)
* T18_PROVENIENZA
(Codice tipologia (1 = Interno, 2 = Esterno))
* T18_DTNASCITA
(Data Nascita)
* T18_INDIRIZZO
(centiIndirizzo)
* T18_CAP
(CAP)
* T18_LOCALITA
(Localita')
* T18_PROGR_BADGE
(Progr. Badge)
* T18_RID
(Questo campo contiene l'identificativo della tabella)
* T18_TIPODOCENTE
(Tipo Titolo (1 Dottore, 2 Ch.Prof.))
* T18_DTRUOLO
(Data entrata Ruolo)
{BR}
**T19** (righe n. 85){BR}
_Descriscione Tabella: _Tabella delle facoltà esterne.   Sarebbe opportuno NON inserire in migrazione i dati su queste tabelle e utilizzare invece le descrizioni libere presenti sia nelle iscrizioni che nei libretti. In caso contrario migrare nella P01_FAC_ATENEI_ITA aggiungendo ai dati forniti da esse3.{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T19_FACEST
(Codice Facolta' Esterna)
* T19_DTUPDATE
(Data aggiornamento)
* T19_DESCR_FACEST
(Descrizione facoltà.)
* T19_RID
(Questo campo contiene l'identificativo della tabella)
* T19_TIPO_FACEST
(Tipo FAcoltà.  Non abbiamo decodifica.)
{BR}
**T40** (righe n. 10245){BR}
_Descriscione Tabella: _Tabella comuni.   Da mappare con P01_COMU.  Qualora ci fossero comuni non presenti in P01_COMU, molto probabilmente si tratta di località o frazioni che quindi vanno inserite nella P01_LOCALITA associandole al comune di riferimento.  Solo nei casi di comuni effettivi (Es. nuovi) si procederà all'inserimento nella P01_COMU. {BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T40_RID
(Questo campo contiene l'identificativo della tabella)
* T40_CODCOM
(Codice Comune)
* T40_DTUPDATE
(Data aggiornamento)
* T40_DESCRCOM
(Descrizione)
* T40_DESCRRID
(Descrizione ridotta<del> non considerare)
* T40_PROV
(sigla provincia)
* T40_CAP
(CAP)
* T40_COMISTAT
(Codice ISTAT)
{BR}
**TCL** (righe n. 20){BR}
_Descriscione Tabella: _Tipi e livelli di Cordi di laurea. Da mappare con la TIPI_CORSI.{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TCL_RID
(Questo campo contiene l'identificativo della tabella)
* TCL_TIPOCDL
(Codice Tipo corso.)
* TCL_ATTIVO
(Attivo (S/N). Ignorare. In Esse3 questo concetto è a livello di corso. )
* TCL_DESCR
(Descrizione.)
* TCL_DTUPDATE
(Data aggiornamento.)
* TCL_CORSOSCUOLA
(Serve per la stampa dei certificati.)
* TCL_DESDIPLOMA
(Tipo di titolo rilasciato (descrittivo))
* TCL_DOTTORE
(Appellativo di dottore (S/N) Serve per la stampa dei certificati)
* TCL_LIVELLOMIN
(Livello del corso ministeriale)
* TCL_MATR_CAR
(Il primo carattere per la definizione della matricola)
* TCL_COD_MIUR
(Codice MIUR)
* TCL_DESCR_EN
(Descrizione in lingua (Inglese))
* TCL_NUOVOREG
(Indicatore Ante-Post riforma. N=Ante-Riforma S=Post-Riforma.)
* TCL_TIPOSCUOLA
(Tipo di corso (descrittivo))
* TCL_DELLASCUOLA
(Serve per la stampa dei certificati.)
* TCL_PROCLAMAZIONE
(Serve per la stampa dei certificati)
* TCL_DURATALEG
(Durata legale prevista (S/N))
* TCL_LIVELLO
(Livello del Corso di Studio.  Tipologia di accesso 1 - diploma 2 - laurea 3 - dottorati)
* TCL_TIPOMATR
(Definizione della Matricola  U - matricola assegnata in automatico a livello di ateneo A - matricola assegnata in automatico a livello di tipo di corso C - matricola asseganta in manuale ??? )
{BR}
**TSD** (righe n. 27594){BR}
_Descriscione Tabella: _tasse esami di stato{BR}
_Aree di interesse: _
J08 - Tassazione studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TSD_MATR
(Matricola.)
* TSD_ANNO
(Anno solare.)
* TSD_SESSIONE
(Sessione della prova d'esame.)
* TSD_COD
(Codice Tassa (decodifica nella tabella T10).)
* TSD_IMPDOV
(Importo dovuto (uguale all'importo pagato).)
* TSD_DTPAG
(Data di pagamento.)
* TSD_ENTE
(Ente Pagamento )
* TSD_RID
(Questo campo contiene l'identificativo della tabella)
* TSD_CDL
(Corso di studio di appartenenza della persona relativamente all'addebito in oggetto.)
* TSD_FLGRATA
(Flg Rata Di Appartenenza O= abilitazione E=iscrizione)
* TSD_IMPPAG
(Importo effettivamente pagato (uguale all'importo dovuto).)
{BR}
**T08** (righe n. 5888){BR}
_Descriscione Tabella: _Tabella sessioni d'esame. Migrare nella P10_SES.   Quando il CODINS è vuoto allora il record si riferisce all'intero corso. Quando gli insegnamenti hanno un comportamento differente, vengono dettagliati inserendo il CODINS.{BR}
_Aree di interesse: _
J15 - Libretto Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T08_RID
(Questo campo contiene l'identificativo della tabella)
* T08_ANNO
(Anno solare. NON DECREMENTARE di 1)
* T08_CODCDL
(Codice corso di laurea.)
* T08_CODINS
(Codice insegnamento. )
* T08_DTUPDATE
(data aggiornamento)
* T08_AAC3
(Anno accademico di riferimento della 3 sessione)
* T08_DTFINE3
(Data fine 3 sessione.)
* T08_AAC1
(Anno accademico di riferimento della 1 sessione)
* T08_DTFINE1
* T08_AAC2
(Data fine 1 sessione.)
(Anno accademico di riferimento della 2 sessione)
* T08_DTINIZ2
(Data inizio 2 sessione.)
* T08_DTINIZP1
(Data di inizio della sessione preappello)
* T08_DTFINEP1
(Data di fine della sessione preappello)
* T08_DTINIZF1
(Data inizio 1 sessione per fuori corso.)
* T08_DTFINEF1
(Data fine 1 sessione per fuori corso.)
* T08_DTINIZF2
(Data inizio 2 sessione per fuori corso)
* T08_DTFINEF2
(Data fine 2 sessione per fuori corso)
* T08_P1
(Sessione preappello. Insieme al codice corso compone il codice sessione.)
* T08_AACP1
(Anno accademico di riferimento della sessione preappello)
* T08_F1
(Prima sessione per Fuori Corso. Insieme al codice corso compone il codice sessione.)
* T08_AACF1
(Anno accademico di riferimento della 1 sessione per fuori corso)
* T08_F2
(Seconda sessione per fuori corso. Insieme al codice corso compone il codice sessione.)
* T08_AACF2
(Anno accademico di riferimento della 2 sessione per fuori corso)
* T08_SEMESTRE
(Codice Semestre)
* T08_N3
(Codice parlante della sessione (prima, seconda, ...))
* T08_DTINIZ3
(Data inizio 3 sessione.)
* T08_N1
(Prima sessione. Insieme al codice corso compone il codice sessione.)
* T08_DTINIZ1
(Data inizio 1 sessione.)
* T08_N2
(Seconda sessione. Insieme al codice corso compone il codice sessione.)
* T08_DTFINE2
(Data fine 2 sessione.)
{BR}
**T13** (righe n. 13){BR}
_Descriscione Tabella: _Elenco delle cariche istituzionale e responsabili di segreteria. Utilizzata per le firme autografe per i certificati stampati dai totem.{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T13_CARICA
(Codice interno di carica)
* T13_DTUPDATE
(data di modifica)
* T13_DESCRIZIONE
(descrizione della carica)
* T13_NOMINATIVO
(Nome della persona)
* T13_RID
(Questo campo contiene l'identificativo della tabella)
{BR}
**AAC** (righe n. 338806){BR}
_Descriscione Tabella: _Iscrizioni annuali degli studenti per anno accademico. Da migrare nella P04_ISCR_ANN.  Sono presenti anche gli anni effettuati in altri atenei.{BR}
_Aree di interesse: _
J05 - Gestione Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* AAC_RID
(Questo campo contiene l'identificativo della tabella)
* AAC_CDL
(Corso di Laurea di iscrizione.  Sono presenti i codici dei corsi anche esterni che vengono presi dalla tabella CDE)
* AAC_MATR
(Matricola studente)
* AAC_ANNOACC
(Anno accademico di iscrizione.)
* AAC_DTISCRIZIONE
(Data Di Iscrizione)
* AAC_MODISCR
(Modalita' Di Iscrizione N=Normale, R=Rientro, I=Passaggio Interno, O=Passaggio di ordinamento (e/o opzione 509) quindi passaggio di corso, M=immatricolazione  )
* AAC_INDIR
(Codice indirizzo. Definito nella tabella IOL. E' la concatenazione di IOL_CODIND,IOL_CODORIE,IOL_CODLING (indirizzo,orientamento,lingua). )
* AAC_TIPOIND
(Tipo Indirizzo Laurea (ignorare))
* AAC_UNIV
(Università di iscrizione.  L'Aquila = 12)
* AAC_ANNOCORSO
(Anno di corso.)
* AAC_TIPOISCR
(Tipo Iscrizione C = In Corso F = Fuori Corso R = Ripetente I = Interruzione  )
* AAC_NFCTOT
(Numero Totale Di Fuoricorso.)
* AAC_DTRATATASSE
(Data 1^ rata Tasse  Risulta come dato sisignificativo, ma è presente anche sulla TAS)
* AAC_IMPDOVTOT
(Totale importi dovuti.   Verificare se coincide con la somma degli importi d TAS.)
* AAC_IMPPAGTOT
(Totale Importi pagati.  Verificare se coincide con la somma degli importi d TAS.)
* AAC_IMPDAPAGTOT
(Tot. Importi Da Pagare   Verificare se coincide con la somma degli importi d TAS.)
* AAC_IMP2RATA
(Tot. Importi Emessi 2Rata </del> Non considerare. valgono quelli di TAS.)
* AAC_FLG2RATA
(Flg 2a Rata (non considerare) = Non Ancora Emesso E = Emesso R = Ricevuto)
* AAC_IMPRIMBORSI
(Tot. Importi Rimborsati <del> Non considerare. valgono quelli di TAS.)
* AAC_FLGLAV
(Flg Lavoratore (S/N)  Vedificare il campo sulla AAT)
* AAC_FLGCSOU
(Flg Pagam. ESU (S/N))
* AAC_FLGMICL
(Flg Pagam. Micl (S/N))
* AAC_FLGREDDITO
(Flag Reddito(non utilizzato))
* AAC_PRESTITO
(Flag Prestito D'onore (S/N) (non utilizzato))
* AAC_DICH_REDD
(Autodichiarazione presentata (S/N) presente in AAT   (non utilizzato, anzi utilizzato solo per poter attribuire l'esonero meglio se non gestito))
* AAC_NRCERTL_S
(Nr.Cert. Liberi Stampati emessi dallo sportello automatico)
* AAC_PIANOSIFA
(Piano Studi da Sifa (S/.)(non utilizzato))
* AAC_FLGANOM
(Flag di blocco amministrativo.)
* AAC_FLGESOTOT
(Flg Esonero Totale . N=Non Richiesto . R=Richiesto . O=Ottenuto . X=Non Ottenuto)
* AAC_TIPO4
(Tipo Di Flag-Esonero4 (non utilizzato) M=Merito R=Reddito)
* AAC_NUMVIN
(Numero di concorsi vinti (non utilizzato) )
* AAC_1FASCIAMERT
(Fascia di Merito 1)
* AAC_1NR_ESA_STD
(Numero esami studente 1.)
* AAC_1NR_ESA_RIF
(Nr. Esami Di Riferimento)
* AAC_1MEDIA_ESA_RIF
(Media Esami Di Riferimento)
* AAC_2FASCIAMERT
(Fascia di Merito)
* AAC_2NR_ESA_RIF
(Nr. Esami Di Riferimento)
* AAC_2MEDIA_ESA_STD
(Media Esami Studente)
* AAC_FLGESOPARZ
(Flg Esonero Parziale (non utilizzato) . N=Non Richiesto . R=Richiesto . O=Ottenuto . X=Non Ottenuto   Valorizzati per gli studenti molto vecchi, non sono significativi)
* AAC_FLGASSEGNO
(Flg Assegno Di Studio.   Influisce sul tipo esonero ottenuto e sul tipo_borsa.)
* AAC_FLGESO4
(Flag Esonero Parz. Legge 41   N=Non Richiesto R=Richiesto O=Ottenuto   Verificare come gestire esonero per handicap X=Non Ottenuto)
* AAC_FLGRIMBORSO
(Flg Rimborso =Valore Iniziale C = Conguaglio delle tasse R = Rimborso In Corso E = Rimborso Effettuato)
* AAC_1MEDIA_ESA_STD
(Media Esami Studente)
* AAC_2NR_ESA_STD
(Nr. Esami Studente)
* AAC_2MEDIA_ESA_RIF
( Media Esami Di Riferimento)
* AAC_FLGRM
(Flg Rimborso Miniprestito =Valore Iniziale E = Rimborso Effettuato)
* AAC_FAC
(Facoltà di Iscrizione.   Codice ISTAT delle facolta, è un dato molto vecchi, deve essere verificato e forse non considerato)
* AAC_FLGRA
(Flg Rimborso Assegno. =Valore Iniziale E = Rimborso Effettuato)
* AAC_TIPO_HCAP
(Handicap dichiarato non ha rilavanza dal punto di vista delle tasse.  Sulla AAT c'è il dato relativo all'Handicap per l'esonero S/N)
{BR}
**AAT** (righe n. 133843){BR}
_Descriscione Tabella: _Tabella delle autodichiarazioni di reddito annuale per le tasse. Da migrare sulla P05_AUTOCERTIFICAZIONI.{BR}
_Aree di interesse: _
J08 - Tassazione studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* AAT_CDL
(Codice corso.)
* AAT_MATR
(Matricola.)
* AAT_ANNOACC
(Anno Accademico)
* AAT_FUORISEDE
(Flag Stud. Fuori Sede (S/N))
* AAT_PARENTELA
(Relazione di parentela nello stato di famiglia)
* AAT_REDDITOTOT_STD
(Reddito totale IRPEF)
* AAT_IMMOBILI_STD
(reddito da immobili dello studente)
* AAT_TERRENI_STD
(reddito da terreni dello studente)
* AAT_TITOLI_STD
(Titoli di stato studente)
* AAT_OBBLIG_STD
(Azioni, obbligazioni studente)
* AAT_NUMDIP_STD
(Numero Dipendenti Studente)
* AAT_SCAMBICULT
(Flag Scambi Culturali (S/N))
* AAT_TIPOHCAP
(Tipo handicap studente)
* AAT_INVALIDPERC
(Percentuale di invalidita')
* AAT_DTLAVDIP
(Data inizio attivita' lavorativa)
* AAT_DTLAVAUT
(Data inizio attivita lavorativa autonomo)
* AAT_DTINILEVA
(Data inizio Leva)
* AAT_DTFINLEVA
(Data fine Leva)
* AAT_DIPUNI
(Dipendente universita')
* AAT_LAUREA
(Laureato/Diplomato)
* AAT_NUCLEOFAM
(Componenti Nucleo Fam.)
* AAT_NUMPERC
(Percettori Nucleo Fam.)
* AAT_NUMCOMPHCAP
(Componenti fam. portatori di handicap)
* AAT_REDDITOTOT_FAM
(Reddito totale IRPEF famiglia)
* AAT_IMMOBILI_FAM
(Immobili dello famiglia)
* AAT_TERRENI_FAM
(Terreni dello famiglia)
* AAT_DEPOSITI_FAM
(Depositi bancari famiglia)
* AAT_OBBLIG_FAM
(Azioni, obbligazioni famiglia)
* AAT_1NUCLEOFAMC
(Nr.Componenti Nucleo Fam. Corretto)
* AAT_1REDDITOEQC
(Reddito Equivalente Corretto in milioni)
* AAT_2REDDITOEQC
(Reddito Equivalente Corretto in milioni)
* AAT_AAC_PRIMM
(anno accademico di prima immatricolazione)
* AAT_LAVAUT
(Studente lavoratore autonomo (S/N).  Impiegato per determinare la tipologia di reddito "Lavoratore Autonomo alla data".)
* AAT_FIGLI
(Studentessa con figli. Impiegato per determinare la tipologia di reddito "Data nascita figli (studentessa con figli)" (Se vale 'S' viene inserita una data fittizia).)
* AAT_LEVAMILT
(Leva mil. civile dopo l' immatr. (S/N).)
* AAT_NUMCOMPUNI
(Numero Altri familiari studenti)
* AAT_REDDITODIP_FAM
(Reddito IRPEF da attivita dipendente)
* AAT_TITOLI_FAM
(Titoli di stato famiglia)
* AAT_AZIENDE_FAM
(Aziende famiglia con piu' di 2 dip (S/N))
* AAT_2NUCLEOFAMC
(Nr.Componenti Nucleo Fam. Corretto)
* AAT_RID
(Questo campo contiene l'identificativo della tabella)
* AAT_DATA_DICH
(Data Autodichiarazione redditi di presentazione)
* AAT_REDDITODIP_STD
(Reddito IRPEF da attivita dipendente)
* AAT_DEPOSITI_STD
(Depositi bancari studente)
* AAT_AZIENDE_STD
(Aziende studente con piu' di 2 dip (S/N))
* AAT_PORTHCAP
(Studente portatore di handicap (S/N))
* AAT_INVALID
(Studente con invalidita' (S/N). Sempre N.)
* AAT_LAVDIP
(Studente lavoratore dipendente (S/N). Impiegato per determinare la tipologia di reddito "Lavoratore Dipendente alla data".)
* AAT_NUMVIV_FAM
(Numero genitori viventi)
* AAT_NUCLEO_IND
(Nucleo indipendente)
{BR}
**ABL** (righe n. 9771){BR}
_Descriscione Tabella: _Abilitazioni Esami di Stato (solo esiti positivi).  {BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ABL_MATR
(Matricola. )
* ABL_ANNO
(Anno dell'esame di stato. Per determinare il concorso e la sessione.)
* ABL_SESSIONE
(Sessione)
* ABL_DTDOM
(Data Domanda Esame Di Stato)
* ABL_CODEST
(Codice esame di stato)
* ABL_DNVT
(Denominatore Voto (50,60,100,110,etc))
* ABL_NREG_ATT
(N. Attestato Esame di Stato)
* ABL_DTRIL_ATT
(Data rilascio attestato)
* ABL_DTCOMPDIPL
(Data compilazione diploma)
* ABL_DTRITRDIPL
(Data Ritiro Diploma)
* ABL_SEZIONE
(sezione)
* ABL_SETTORE
(settore)
* ABL_RID
(Questo campo contiene l'identificativo della tabella)
* ABL_CDL
(Corso di laurea. )
* ABL_UNIV
(Univ. Esame Di Stato Se =12 L'Aquila Altrimenti si tratta di un'altra università quindi migriamo solo il titolo )
* ABL_VOTO
(Voto esame.)
* ABL_LODE
(Lode. (L/spazio))
* ABL_NUMREGDIPL
(Num. Registrazione diploma)
* ABL_FLDISPDIPL
(Flg Diploma Disponibile (S/N))
{BR}
**ANCTIT** (righe n. 25478){BR}
_Descriscione Tabella: _Titoli presentati dai preiscritti  Dovrebbe essere un doppione delle informazioni presenti in ANC{BR}
_Aree di interesse: _
J04 - Test di Ingresso e Ammissione
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ANC_CODCDL
(codice corso)
* ANC_ANNOACC
(anno accademico)
* ANC_ANNO
(anno di corso)
* ANC_PROGRISCR
(prematricola)
* ANC_CODTIT
(codice del titolo)
{BR}
**ARC** (righe n. 48572){BR}
_Descriscione Tabella: _Tabella delle Archiviazioni. Attenzione!!!   I numeri di archivio non sono veritieri. {BR}
_Aree di interesse: _
J05 - Gestione Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ARC_DTFINESOSP
(Data fine sospensione)
* ARC_RID
(Questo campo contiene l'identificativo della tabella)
* ARC_CDL
(Corso di Studio)
* ARC_MATR
(Matricola)
* ARC_TPINSERTO
(Codice Archivio .   C = decaduti / ritirati / trasferiti; . E = esami di stato . L = laureati / equipollenze.)
* ARC_NRINSERTO
(Numero Di Inserto. ATTENZIONE! I numeri inseriti non sono veritieri. NON MIGRARE.)
* ARC_CODFINERAPP
(Codice Fine Rapporto: .   L=Laurea . T=Trasfer. Ad Altra Univ.  R=Rinuncia . D=Decadimento .  M=Morte .  I=Congedo Interno . S=Sospensione Provv. .   )
* ARC_DTFINERAPP
(Data Di Fine Rapporto/Chiusura. Se sospensione=Data inizio sospensione.)
* ARC_NOTE
(Note di fine rapporto.)
* ARC_ALLEGATI
(Allegati di congedo. )
* ARC_DTARCH
(non usato)
* ARC_FL_DIPL
(non usato)
* ARC_DT_DIPL
(non usato)
* ARC_TP_PROT
(non usato)
* ARC_NR_PROT
(non usato)
{BR}
**ARD** (righe n. 14){BR}
_Descriscione Tabella: _Aree Disciplinari. Mappare con P07_AREE.{BR}
_Aree di interesse: _
J09 - Classi e Settori
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ARD_RID
(Questo campo contiene l'identificativo della tabella)
* ARD_AREA
(Codice area)
* ARD_DESCR
(Descrizione)
* ARD_DTUPDATE
(data aggiornamento)
{BR}
**CCA** (righe n. 262){BR}
_Descriscione Tabella: _Associazione matricola / codice abilitazione per le SISS{BR}
_Aree di interesse: _
J05 - Gestione Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CCA_CODCDL
(Codice del corso)
* CCA_MATR
(Codice della matricola)
* CCA_CODABL
(Codice abilitazione  Vedi CCZ)
* CCA_RID
(non usare)
* CCA_DTUPDATE
(non usare)
* CCA_UNVABL
(Codcie dell'universita di abilitazione  è sempre 12 Aquila)
{BR}
**CDE** (righe n. 737){BR}
_Descriscione Tabella: _Corsi esterni.  Sarebbe opportuno NON inserire in migrazione i dati su queste tabelle e utilizzare invece le descrizioni libere presenti sia nelle iscrizioni che nei libretti. In caso contrario migrare sulla P01_CDS_ATENEI_ITA e P01_FAC_ATENEI_ITA aggiungendo ai dati forniti da esse3.{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CDE_CODCDE
(Chiave Corso Di Studi.)
* CDE_DESCR
(Descrizione ridotta. Usare quella estesa.)
* CDE_DESCRE
(Descrizione Estesa)
* CDE_TIPO2
(Tipo Corso.)
* CDE_FLGTIR
(Flag Tirocinio (S/N)</del> Non gestito sui CDS Esterni di Esse3.)
* CDE_ESA_STATO
(Flag Esame di stato (S/N). <del> Non gestito sui CDS esterni di Esse3.)
* CDE_RID
(Questo campo contiene l'identificativo della tabella)
* CDE_FACISTAT
(Facolta' Istat. </del> Non gestito sui CDS esterni di Esse3, che invece gestisce il Codice ISTAT del CDS. Corrisponde al codice facolta esterna della tabella T19  Questa colonna contiene dati non attendibili)
* CDE_FLGFREQ
(Freq. Obbligatoria (S/N) <del> Non gestito sui CDS esterni di Esse3.)
* CDE_VOTO_CDL
(Base Voto.  Utilizzato come base votazione del corso esterno)
* CDE_NUMANNI
(Numero anni di Corso.)
{BR}
**CDL** (righe n. 499){BR}
_Descriscione Tabella: _Tabella dei corsi di studi. Migrare sulla P06_CDS, P06_CDSORD, P06_FAC_CDS{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CDL_CODFAC
(Codice Facolta'.  Da valutare il concetto di Interfacoltà relativo per ora a 2 corsi)
* CDL_CDLISTAT
(Codice Istat del corso.)
* CDL_DESCRE
(Descrizione corso Estesa )
* CDL_FLGFREQ
(Frequenza obbligatoria (S/N))
* CDL_VOTO_CDL
(Voto Diploma 110,70,50 Etc.)
* CDL_ANNO3_ORE
(Ore per anno)
* CDL_ANNO3_CICLO
(Ciclo di appartenenza dell' anno)
* CDL_ANNO4_ANNU
(Annualita')
* CDL_ANNO4_ORE
(Ore per anno)
* CDL_ANNO4_CICLO
(Ciclo di appartenenza dell' anno)
* CDL_ANNO5_ANNU
(Annualita')
* CDL_ANNO5_ORE
(Ore per anno)
* CDL_ANNO5_CICLO
(Ciclo di appartenenza dell' anno)
* CDL_ANNO6_ANNU
(Annualita')
* CDL_ANNO6_ORE
(Ore per anno)
* CDL_ANNO6_CICLO
(Ciclo di appartenenza dell' anno)
* CDL_FREQ_AUTO
(Frequenza automatica sempre N)
* CDL_FLG_CREDITI
(Corso gestito con i crediti)
* CDL_CLASSE
(CLASSE MIUR)
* CDL_ANNU_CRED
(Gestione in Annualità (A) oppure Crediti (C))
* CDL_ADISTANZA
(Tipologia della didattica)
* CDL_ALMA
(Codice alma laurea)
* CDL_SEDE
(Sede del corso per ALMA)
* CDL_NRCHIUSO
(Corso di studi a numero chiuso(S/N))
* CDL_DESCRDIPL
(Descrizione Titolo ottenuto)
* CDL_ANNO1_ANNU
(Annualita' del primo anno)
* CDL_ANNO1_ORE
(Ore per anno)
* CDL_ANNO1_CICLO
(Ciclo di appartenenza dell' anno)
* CDL_ANNO2_ANNU
(Annualita')
* CDL_ANNO2_ORE
(Ore per anno)
* CDL_ANNO2_CICLO
(Ciclo di appartenenza dell' anno)
* CDL_ANNO3_ANNU
(Annualita')
* CDL_SPEC_OBBL
(Specializzazione Obblig. (S/N)(non utilizzato)  Come tipolo di accesso)
* CDL_ESA_STATO
(Esame Di Stato (S/N)(flag abilitante professione)  Questo corso prevede l'esame di stato)
* CDL_NUMANNI
(Nr. Anni Di Corso Legale)
* CDL_NUMANNU
(Nr. Annualita' (ante riforma) / crediti (post-riforma) Totali)
* CDL_NUMORE
(Nr. Ore Totali)
* CDL_AACANNU
(Anno Acc. Validita' Dello Statuto:(anno attivazione+anno ordinamento))
* CDL_MEDIA_LAU
(Modalita' calcolo media di laurea)
* CDL_ANNO_INT
(Anno integrativo obbligatorio (S/N)  Relativo all'accesso per l'immatricolazione)
* CDL_RID
(Questo campo contiene l'identificativo della tabella)
* CDL_CODCDL
(Codice Corso Di Studi)
* CDL_DESCR
(Descrizione Ridotta </del> Usare quella estesa)
* CDL_TIPO2
(Tipo Di Corso Di Studi L = Corso di laurea D = Corso di diploma F = Scuola Diretta a Fini Speciali U = Diploma Universitario S = Scuola di Specializzazione I = Relazioni Internazionali  Vedi tabella TCL)
* CDL_FLGTIR
(Flag Tirocinio. N=No tirocinio, D=Tirocinio POST-laurea, P=Tirocinio PRE-laurea.)
* CDL_TIPO_IND
(Tipo Indirizzo Cdl(ignorare) U = Umanistico, D = Didattico, A = Applicativo)
* CDL_EN_DES
(Descrizione in lingua inglese)
* CDL_CODEST
(E' il dodice dell' Esame Di Stato relativo presente nella EST  Verificare la coerenza del valore)
* CDL_FREQ_BATCH
(Definizione della frequenza BATCH)
{BR}
**CDM** (righe n. 20){BR}
_Descriscione Tabella: _Commissioni per i dottorati{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CDM_CODCDL
(codice corso dottorato)
* CDM_ANNOACC
(anno accademico)
* CDM_SSCOMM
(codice sottocommisisone  Al momento non è stato utilizzato)
* CDM_1COMM
(Nome primo commissario campo libero)
* CDM_UNIV1COMM
(codice università primo commissario)
* CDM_2COMM
(secondo commissario campo libero)
* CDM_UNIV1ESP
(codice università primo esperto)
* CDM_2ESP
(secondo esperto campo libero)
* CDM_UNIV2ESP
(codice università secondo esperto)
* CDM_NOTE
(note)
* CDM_LOCREC
(località dell'esame)
* CDM_DATAESAME
(data dell'esame)
* CDM_PROROGA
(Flag di proroga)
* CDM_DTUPDATE
(ultimo aggiornamento)
* CDM_RID
(identificativo tabella)
* CDM_PRESIDENTE
(nome cognome presidente campo libero)
* CDM_UNIVPRESID
(codice università del presidente)
* CDM_UNIV2COMM
(codice università secondo commissario)
* CDM_1ESP
(primo esperto campo libero)
* CDM_INDREC
(indirizzo dell'esame)
* CDM_CAPREC
(CAP dell'esame)
{BR}
**CDS** (righe n. 0){BR}
_Descriscione Tabella: _Contiene dati aggiuntivi relativi ai corsi (CDL). {BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CDS_RID
(non rilevante)
* CDS_CODCDL
(Codice del corso)
* CDS_ANNOACC
(Anno di corso)
* CDS_STATUS
(Descrizione dello status)
* CDS_INFO
(Descrizione dello informative)
* CDS_OBIETTIVI
(Descrizione degli obiettivi)
* CDS_EN_STATUS
(Descrizione in inglese)
* CDS_EN_INFO
(Descrizione in inglese)
* CDS_EN_OBJVS
(Descrizione in inglese)
* CDS_INDIR
(Codice indirizzo)
* CDS_SITOWEB
(Sito web)
* CDS_DTUPDATE
(non rilevante)
* CDS_EN_DES
(Descrizione in inglese)
{BR}
**CLA** (righe n. 24){BR}
_Descriscione Tabella: _Tabella delle commissioni di laurea{BR}
_Aree di interesse: _
J18 - Conseguimento Titolo
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CLA_CODCDL
(codice corso)
* CLA_ANNOACC
(anno accademico)
* CLA_01NOME
(nome)
* CLA_02TITOLO
(titolo)
* CLA_02NOME
(nome)
* CLA_03TITOLO
(titolo)
* CLA_03NOME
(nome)
* CLA_04TITOLO
(titolo)
* CLA_04NOME
(nome)
* CLA_05TITOLO
(titolo)
* CLA_06TITOLO
(titolo)
* CLA_07TITOLO
(titolo)
* CLA_07NOME
(nome)
* CLA_08TITOLO
(titolo)
* CLA_08NOME
(nome)
* CLA_09TITOLO
(titolo)
* CLA_09NOME
(nome)
* CLA_10TITOLO
(titolo)
* CLA_10NOME
(nome)
* CLA_11TITOLO
(titolo)
* CLA_11NOME
(nome)
* CLA_DTUPDATE
(ultimo aggiornamento)
* CLA_RID
(identificativo tabella)
* CLA_SESSIONE
(codice sessione)
* CLA_01TITOLO
(titolo)
* CLA_05NOME
(nome)
* CLA_06NOME
(nome)
{BR}
**CLT** (righe n. 153){BR}
_Descriscione Tabella: _Classe del corso di studi. Mappare con P07_CLA_MURST{BR}
_Aree di interesse: _
J09 - Classi e Settori
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CLT_RID
(Questo campo contiene l'identificativo della tabella)
* CLT_TIPOCDL
(Tipo Corso.)
* CLT_CLASSE
(Codice Classe.)
* CLT_DESCR
(Descrizione ridotta. Usare quella estesa.)
* CLT_DESCRE
(Descrizione estesa.)
* CLT_OBIETTIVI
(descrizione ministeriale. (ignorare))
* CLT_ROMANO
(Code ministriale)
* CLT_DTUPDATE
(data aggiornamento.)
* CLT_DESCR_EN
(Descrizione della classe in inglese)
{BR}
**CMR** (righe n. 457){BR}
_Descriscione Tabella: _Dati MIUR dei CORSI DI STUDI per l'anagrafe nazionale studenti{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CMR_RID
* CMR_CODCDL
(Questo campo contiene l'identificativo della tabella)
(Codice Corso.)
* CMR_INDIR
(Codice Indirizzo (Indirizzo/orientamento/lingua))
* CMR_ANNOACC
(Anno accademico)
* CMR_COD_MIUR
(Codice MIUR)
* CMR_DTUPDATE
(Data aggiornamento )
* CMR_SEDE
(Sede del corso.)
* CMR_OFFF
(Codice OFFF)
* CMR_CODICIONE
(Codicione MIUR)
{BR}
**CNC** (righe n. 680){BR}
_Descriscione Tabella: _Anagrafica concorsi con numero chiuso{BR}
_Aree di interesse: _
J04 - Test di Ingresso e Ammissione
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CNC_RID
(Questo campo contiene l'identificativo della tabella)
* CNC_CODCDL
(Codice Corso)
* CNC_ANNOACC
(Anno Accademico)
* CNC_ANNO
(anno di corso)
* CNC_DTESAME
(data esame)
* CNC_DTINIZISCR
(Data Inizio Iscrizioni)
* CNC_DTFINEISCR
(Data Fine Iscrizioni)
* CNC_DTINIZIMM
(Data Inizio Immatricolazioni)
* CNC_DTFINEIMM
(Data Fine Imm.)
* CNC_DTDECRRT
(data del decreto del rettore che istituisce il concorso)
* CNC_NRDECRRT
(numero decreto del rettore)
* CNC_TESTO
(testo libero  (sembra sempre vuoto))
* CNC_DOCENTE3
(codice docente)
* CNC_DOCENTE4
(codice docente)
* CNC_DOCENTE5
(codice docente)
* CNC_ESAME0
(titolo esame)
* CNC_ESAME1
(titolo esame)
* CNC_ESAME2
(titolo esame)
* CNC_ESAME3
(titolo esame)
* CNC_ESAME6
(titolo esame)
* CNC_ESAME7
(titolo esame)
* CNC_ESAME8
(titolo esame)
* CNC_ESAME9
(titolo esame)
* CNC_PROGRISCR
(Ultimo Progressivo Iscrizione (prematricola))
* CNC_NRO_POSTI
(numero posti messi a concorso)
* CNC_DOCENTE1
(codice docente)
* CNC_DOCENTE2
(codice docente)
* CNC_ESAME4
(titolo esame)
* CNC_ESAME5
(titolo esame)
{BR}
**DBO** (righe n. 9456){BR}
_Descriscione Tabella: _Dai aggiuntivi della AAC{BR}
_Aree di interesse: _
J05 - Gestione Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* DBO_RID
(Non rilevante)
* DBO_MATR
(Matricola)
* DBO_ANNOACC
(Anno accademico di riferimento)
* DBO_FLG_CONC01
(Indica se ha richiesto una borsa di studio)
* DBO_FLG_CONC02
(Richiesta delle 150 ore )
* DBO_FLG_CONC03
(non utilizzato)
* DBO_FLG_CONC04
(non utilizzato)
* DBO_FLG_CONC05
(non utilizzato)
* DBO_DTUPDATE
(Non rilevante)
* DBO_CODCDL
(Codice del corso)
{BR}
**DCO** (righe n. 5){BR}
_Descriscione Tabella: _??{BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* DCO_RID
(Identificativo tabella)
* DCO_TIPO
(tipo)
* DCO_DESCR
(Descrizione)
{BR}
**DIP** (righe n. 0){BR}
_Descriscione Tabella: _Tabella Dipartimenti. Migrare sulla P06_DIP.{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* DIP_RID
(Questo campo contiene l'identificativo della tabella)
* DIP_CODDIP
(Codice Dipartimento.)
* DIP_DESCR
(Descrizione ridotta)
* DIP_DESCRE
(Descrizione Estesa)
* DIP_DTUPDATE
(Data aggiornamento)
{BR}
**EAN** (righe n. 229){BR}
_Descriscione Tabella: _Tabella per la gestione dell'anagrafe nazionale  Vengono registrate tutte le elaborazioni{BR}
_Aree di interesse: _
J20 - Anagrafe nazionale studenti
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* EAN_RID
(Questo campo contiene l'identificativo della tabella)
* EAN_ANNOACC
(anno accademico)
* EAN_TIPO
(numero spedizione)
* EAN_INVIO
(tipo di invio )
* EAN_SK_INVIO
(scheda di invio  )
* EAN_NR_REC
(numero record inviati)
* EAN_STATO
(stato elaborazione)
* EAN_DTUPDATE
(ultimo aggiornamento)
* EAN_TP_SPED
(tipo spedizione)
* EAN_NR_INVIO
(numero di invio)
* EAN_DT_INVIO
(data di invio)
{BR}
**ESA** (righe n. 4879){BR}
_Descriscione Tabella: _Tabella degli esami Negativi.   Va migrata nella P11_REG_SCE.{BR}
_Aree di interesse: _
J15 - Libretto Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ESA_RID
(Questo campo contiene l'identificativo della tabella)
* ESA_MATR
(matricola)
* ESA_CODINS
(Codice Insegnamento)
* ESA_DTSOST
(Data Sostenimento Esame)
* ESA_AACSOSTESA
(Anno Acc. Sostenimento Esame)
* ESA_VOTO
(Voto Esame  nn = Numero da 1 a 17  RE=Respinto  RT=Ritirato NE=Negativo)
* ESA_FLGCONVESA
(Flg Esame Convalidato (S/ ) <del> Vale quello della PDS. </del>-)
* ESA_INTEGRATIVO
(Esame integrativo (I/P/..) <del> Non considerare</del>)
* ESA_DOCENTE
(Docente esame. <del> Sempre vuoto </del> Non gestito.)
* ESA_SESSIONE
(Sessione Sostenimento Esame  FK verso T08.T08_Nx)
* ESA_CDL
(Codice corso.   Come per la PDS, questo corso è legato all'insegnamento e non all'iscrizione dello studente.)
* ESA_UNIV
(Universita' Sost. Esame.  ATTENZIONE registrano anche casi di esami di altre università (<> 12))
{BR}
**USD** (righe n. 191){BR}
_Descriscione Tabella: _Tabella Utenti. Da migrare sulla P18_USER. Si tratta degli utenti della segreteria e non degli studenti (a parte quelli che fanno servizi in segreteria).{BR}
_Aree di interesse: _
J01 - Anagrafiche Persone
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* USD_RID
(Questo campo contiene l'identificativo della tabella.)
* USD_CAT
(Codice Categoria Utenti)
* USD_USERID
(Codice utente)
* USD_PASSWORD
(Password)
* USD_PASSWORD_1
(Password precedente 1<del> Non gestito in esse3)
* USD_PASSWORD_2
(Password precedente 2 </del> Non gestito in esse3)
* USD_PASSWORD_3
(Password precedente 3 <del> Non gestito in esse3)
* USD_PASSWORD_4
(Password precedente 4 </del> Non gestito in esse3)
* USD_PASSWORD_5
(Password precedente 5 <del> Non gestito in esse3)
* USD_DTPASSWORD
(Data modifica password)
* USD_FLAGSESSIONE
(Indicatore Sessione)
* USD_CLIENT
(Stazione Client Lavoro)
* USD_DATAINIZIO
(Data Ora Inizio Sessione)
* USD_DATAFINE
(Data Ora Fine Sessione)
* USD_CODAREADB
(Sid banca dati)
* USD_GESTORETAB
(Gestore tabelle)
* USD_SEDE
(Sede utente)
* USD_STNUM
(Stampante default)
* USD_SEGR
(Codici di segreteria. Da definire.)
* USD_TIPOS
(Non Usato. Sempre Vuoto.)
{BR}
**CCZ** (righe n. 75){BR}
_Descriscione Tabella: _Tabella delle classi di abilitazione SISS{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CCZ_RID
(non rilevante)
* CCZ_CODABL
(Codice abilitazione)
* CCZ_DESCABL
(Descrizione abilitazione)
* CCZ_ABILITAZIONE
(Descrizone abilitazione)
* CCZ_FLGATT
(Abilitazione Attiva)
* CCZ_DTUPDATE
(non rilevante)
{BR}
**CCL** (righe n. 79){BR}
_Descriscione Tabella: _Tabella di associazione fra il corso e la classe di abilitazione, usata solo per i corsi esterni, se sono presenti codici di corso interni non devono essere considerati{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CCL_CODABL
(Codice dell'abilitazione)
* CCL_CODCDE
(Codice del corso)
* CCL_NOTE
(Note descrittive)
* CCL_DTUPDATE
(non rilevante)
* CCL_RID
(non rilevante)
{BR}
**INS** (righe n. 34559){BR}
_Descriscione Tabella: _Tabella delle attività didattiche (Insegnamenti). Da migrare sulla P09_AD_GEN, P09_CDS_AD_GEN, P09_AD_CDS, P09_AD_CDSORD.  Le attività didattiche NON presenti nella PDF (piano di facoltà) verranno comunque migrate nella P09_AD_GEN  Tutti gli integrati (INS_TIPOINS=I) dovrebbero avere i moduli (INS_TIPOINS=M)nella tabella MDL. Possono esistere dei casi in cui l'esame è definito integrato, ma non avere i moduli-  Gli insegnamenti integrati NON verranno gestiti come gruppi di esami. {BR}
_Aree di interesse: _
J12 - Offerta Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* INS_RID
(Questo campo contiene l'identificativo della tabella)
* INS_CODCDL
(Corso che offre la logistica dell'insegnamento. )
* INS_CODINS
(Chiave Insegnamento Per convenzione (valido per il 90% dei casi) i primi tre caratteri indicano il codice del corso di laurea.  Ogni corso hai i suoi insegnamenti anche se uguali a quelli di altri corsi. )
* INS_DESCR
(Descrizione completa)
* INS_DESCRRID
(Descrizione Ridotta (NON MIGRARE) Usare quella completa.)
* INS_COMPOSTO
(Insegnamento composto (S/N)   L'informazione è gestita con i gruppi e quindi non solo ins_tipoins=I identifica l'insegnamento composto, padre del raggruppamento.)
* INS_TIPOCOMP
(non utilizzato)
* INS_TIPOESAME
(Tipo Esame. Usare sempre O orale)
* INS_ANNU
(Annualita' (se ci sono moduli è la somma delle annualità sui moduli))
* INS_ORE
(Durata del corso in ore)
* INS_FLGESAME
(Flag Insegnam.Annullato)
* INS_SEMESTRE
(Semestre Di Insegnam.(verificare se si vogliono configurare o no).)
* INS_INS_ITER
(Iterazione Insegnamento (non utilizzato))
* INS_COD_ITER
(Codice dell'eseme del piano di studio del corso a cui l'esame in questione fa riferimento..  Tipo esame di INGLESE che fa riferimento all'esame di LINGUA STRANIERA.)
* INS_AREA
(Area Disciplinare (è valorizzata solo per il post riforma, quindi non la migriamo perchè basta l'info del settore, mentre per l'ante rifomra non è mai valorizzata))
* INS_SETTORE
(è valorizzato sempre, se la ad ha un solo settore lo trovi solo qui se ne ha più di non hanno utilizzato la tabella SIN, ma hanno definito moduli differenti (un integrato effettivo))
* INS_TIPOINS
(Tipo Insegnamento. L = Monodisciplinare I = Integrato (è il padre)  M = Modulo (sono i figli)  W= Workshop B= Laboratorio  P = Prova di idoneità   Vengono gestiti i gruppi: gli I sono i padri, gli M sono i figli )
* INS_CREDITO
(Credito Didattico (se ci sono moduli è la somma dei crediti sui moduli))
* INS_DURATA
(Durata dell'esame  0 - annali 0,2 - bimestrali 0,4 - quadrimestrali 0,5 - semestrali 1 - annuli 1,5 - bisemestrale)
* INS_FLGFREQ
(Flag Freq. Obbl.)
* INS_NOMEDIA
(Flag Escludere da calcolo Media esami.)
* INS_PROP_ITER
(Propedeuticita' Iterazioni)
* INS_PROP_CDL
(Flag propedeuticita' CDL (X/..)(non utilizzato))
* INS_DESCR_EN
(Descrizione dell'insegnamento in inglese)
* INS_ANNO
(Anno Attribuzione generico (anno di corso), ovviamente sulla PDF e PDS può variare)
* INS_TIPOVOTO
(Tipo del voto  null qualsiasi valore "mettere numerico" 30 solo numerico AP approvato GD giudizio ID idoneo PO positivo)
{BR}
**AAF** (righe n. 16252){BR}
_Descriscione Tabella: _Tabella delle attività formative, un dettaglio di quello che uno studente ha fatto relativamente a un insegnamento  Le attività aggiuntive possono essere inserite liberamente oppure tramite inserimento guidato dalla tabella SEM{BR}
_Aree di interesse: _
J15 - Libretto Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* AAF_RID
(identificativo tabella)
* AAF_MATR
(matricola)
* AAF_CODINS
(codice insegnamento)
* AAF_PROGR
(progressivo)
* AAF_ANNOACC
(anno accademico)
* AAF_DTUPDATE
(ultimo aggiornamento)
* AAF_FLGSEM
(flag provenienza dalla tabella SEM)
* AAF_DESCRIZIONE
(descrizione dell'attività svolta)
* AAF_CREDITO
(credito)
{BR}
**CDR** (righe n. 0){BR}
_Descriscione Tabella: _Consigli per i dottorati  Per il momento non è utilizzata Verificare l'effettivo utilizzo in sede di migrazione effettiva{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CDR_RID
(identificativo tabella)
* CDR_CODCDL
(codice corso di dottorato)
* CDR_CICLO
(ciclo)
* CDR_COGNOME
(cognome docente)
{BR}
* CDR_UNIV
(università del docente)
* CDR_FLGVICE
(Flag di Vice carica)
* CDR_DTUPDATE
(ultimo aggiornamento)
* CDR_PROG
(progressivo interno)
* CDR_SETTORE
(settore di afferenza del docente  fk verso SEC)
* CDR_QUALIFICA
(codice codifica  A Associato O Ordinario R Ricercatore)
**DPS** (righe n. 313){BR}
_Descriscione Tabella: _Tabella per il recupero dei crediti ( debiti formativi da immatricolazione )  Contiene anche alcuni crediti formativi dopo l'immatricolazione alla specialistica.{BR}
_Aree di interesse: _
J15 - Libretto Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* DPS_FLG_DC
(flag )
* DPS_DATA
(data di nascita del debito/credito)
* DPS_ASSOLTO
(flag assolto oppure no)
* DPS_RID
(Questo campo contiene l'identificativo della tabella)
* DPS_MATR
(matricola)
* DPS_PROG
(progressivo)
* DPS_SETTORE
(codice settore)
* DPS_DEBITO
(numero debiti formativi)
* DPS_CREDITO
(numero crediti formativi)
* DPS_CODINS
(codice insegnamento)
* DPS_DESCR
(descrizione del debito)
* DPS_ANNOACC
(anno accademico di riferimento)
* DPS_DTUPDATE
(ultimo aggiornamento)
{BR}
**DST** (righe n. 159){BR}
_Descriscione Tabella: _Tabella di altri titoli conseguiti dalla matricola  Utilizzato per studenti che si immatricolano come lureati ed in questa tabella finiscono i titoli aggiuntivi{BR}
_Aree di interesse: _
J01 - Anagrafiche Persone
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* DST_RID
(Questo campo contiene l'identificativo della tabella)
* DST_MATR
(matricola)
* DST_TIPOCDE
(tipo corso esterno FK verso la TCL)
* DST_CODCDE
(Corso esterno esterno che ha rilasciato il titolo)
* DST_VOTO
(voto)
* DST_LODE
(lode)
* DST_DATA
(data conseguimento)
* DST_DTUPDATE
(ultimo aggiornamento)
* DST_ANNOACC
(anno accademico)
* DST_CODCDL
(codice corso di iscrizione)
* DST_DESCR
(descrizione del titolo)
* DST_UNIV
(Università che ha rilasciato il titolo)
{BR}
**ESC** (righe n. 51109){BR}
_Descriscione Tabella: _Tabella associativa tra l'esame sostenuto e l'esame convalidato  Associa due record della PDS: l'originale e la convalida.{BR}
_Aree di interesse: _
J15 - Libretto Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ESC_RID
(identificativo tabella)
* ESC_CDL
(corso)
* ESC_MATR
(matricola)
* ESC_CODINS
(codice insegnamento origine)
* ESC_CODASS
(codice insegnamento convalidato)
* ESC_DESCRIZIONE
(titolo della convalida)
* ESC_FLGESC
(tipo di opzione (tipo di convalida))
* ESC_DTUPDATE
(ultimo aggiornamento)
{BR}
**SFO** (righe n. 5){BR}
_Descriscione Tabella: _Tabella anagrafica delle sedi formative dove lo studente effettuerà parte della didattica  Per lo studente è all'interno della STD (FK){BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* SFO_RID
(identificativo tabella)
* SFO_CODICE
(codice)
* SFO_DESCRIZIONE
(descrizione)
* SFO_DTUPDATE
(ultimo aggiornamento)
{BR}
**TIR** (righe n. 429){BR}
_Descriscione Tabella: _Tabella dei tirocini per matricola{BR}
_Aree di interesse: _
J15 - Libretto Studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TIR_RID
(identificativo tabella)
* TIR_MATR
(matricola )
* TIR_CODINS
(codice insegnamento)
* TIR_DESCR2
(descrizione)
* TIR_DTUPDATE
(ultimo aggiornamento)
* TIR_DESCR1
(descrizione)
{BR}
**TTS** (righe n. 215){BR}
_Descriscione Tabella: _Testi dei certificati  Descrizione del certificato (padre della TST){BR}
_Aree di interesse: _
J00 - Anagrafiche di Servizio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TTS_RID
(Questo campo contiene l'identificativo della tabella)
* TTS_TIPOT
(?)
* TTS_CODICE
(codice)
* TTS_DESCR
(descrizione)
* TTS_LUNRIG
(dimensioni di stampa: lunghezza riga)
* TTS_INTRIG
(?)
* TTS_FLGINS
(Flag Testo con Testi Interni (S/N) )
* TTS_TIPOC
(?)
* TTS_HEADER
(intestazione)
* TTS_FOOTER
(piè di pagina)
* TTS_ENDREP
(fine report)
* TTS_TIPOS
(Tipo Segreteria A = Concorsi di Ammissione C = Corsi di studio E = Esami di Stato P = Pre-Immatricolazione)
* TTS_LUNPAG
(dimensioni di stampa: lunghezza pagina)
{BR}
**TUT** (righe n. 165){BR}
_Descriscione Tabella: _Tabella dei Tutori per medicina  Corrispondono ai medici di base che si prestano per fare effettuare tirocinio in medicina per l'abilitazione all'esame di stato{BR}
_Aree di interesse: _
J01 - Anagrafiche Persone
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TUT_RID
(identificativo)
* TUT_CODTUTOR
(codice)
* TUT_NOME
(Nome)
* TUT_COGN
(cognome)
* TUT_CAPREC
(CAP residenza)
* TUT_LOCREC
(località di residenza)
* TUT_NUMTEL
(numero di telefono)
* TUT_NUMFAX
(numero di fax)
* TUT_NUMCEL
(numero di cellulare)
* TUT_RESP
(respondabile (in forma descrittiva) del tutor)
* TUT_DTUPDATE
(data di ultimo aggiornamento)
* TUT_QUAL
(titolo da anteporre al nome)
* TUT_INDREC
(indirizzo residenza)
* TUT_E_MAIL
(e-mail)
* TUT_SEDE
(sede del tirocinio)
{BR}
**ACL** (righe n. 3111){BR}
_Descriscione Tabella: _Tabella degli Ambiti per classe.  Mappare con P07_AMB_MURST.   Tabella degli ambiti.  Mappare con P07_AMBITI tramite la descrizione e in alcuni casi in modo puntuale {BR}
_Aree di interesse: _
J09 - Classi e Settori
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ACL_RID
(Questo campo contiene l'identificativo della tabella)
* ACL_CLASSE
(Codice Classe)
* ACL_AMBITO
(Codice Ambito.)
* ACL_TIPOAF
(Tipo TAF)
* ACL_COD_MIUR
(Codice Miur Per ANS)
* ACL_TIPOCDL
(Tipo Corso.  Vedi TLC)
* ACL_DTUPDATE
(Data aggiornamento)
* ACL_DESCR_AMB
(Descrizione Ambito)
* ACL_DESCR_EN
(Descrizione Ambito in inglese)
{BR}
**T21** (righe n. 313){BR}
_Descriscione Tabella: _Tabella per la riduzione delle tasse.  Per nucleo familiare viene indicato un coefficiente di calcolo per le tasse{BR}
_Aree di interesse: _
J07 - Configurazione Tasse
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* T21_ANNOACC
(Anno accademico)
* T21_NUCLEOFAM
(Num. camponenti il nucleo familiare.)
* T21_TIPOFASCIA
(Tipo Fascia. Mai valorizzato. Non usare.)
* T21_DCPM
(Scala Equivalenza DCPM)
* T21_RID
(Questo campo contiene l'identificativo della tabella)
* T21_DTUPDATE
(Data Aggiornamento)
* T21_REDDITO
(Reddito Massimo. Sempre 0. Non usare.)
{BR}
**MED** (righe n. 22313){BR}
_Descriscione Tabella: _Tabella delle medie per le riduzioni delle tasse.  Per i corsi ante-riforma è tutto basato sul numero di esami  Per i corsi post-riforma è tutto basato sul numero di crediti{BR}
_Aree di interesse: _
J07 - Configurazione Tasse
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* MED_RID
(Questo campo contiene l'identificativo della tabella)
* MED_CODICE
(Codice Statistica   CM - Crediti Medi SC - Sommatoria dei crediti MM - Valore massino delle medie MN - Valore minimo delle medie NM - Numero media esami superati SN -  VM - Voto Medio NS - Numero studenti SM - Sommatoria media SS -  SV -  VX -  VN -  )
* MED_TIPOS
(Codice del tipo corso di studio  Vedi TCL)
* MED_CODFAC
(Chiave Facolta')
* MED_CODCDL
(Tipologia del Corso di Studio.)
* MED_CODINS
(Codice dell'attività didattica.)
* MED_DOCENTE
(Codice del corso)
* MED_ANNOACC
(Anno Accademico di riferimento per il calcolo di questi dati.  Anno di iscrizione dello studente)
* MED_ANNO
(Anno accademico di immatricolazione)
* MED_NUMERO
(Valore del dato definito nel MED_CODICE)
* MED_DTUPDATE
(non significativo)
{BR}
**TAS** (righe n. 753724){BR}
_Descriscione Tabella: _Tabella delle tasse addebitate agli studenti  E' stato aggiunto un campo TAS_TIPORIM che identifica la motivazione del rimborso{BR}
_Aree di interesse: _
J08 - Tassazione studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* TAS_RID
(Questo campo contiene l'identificativo della tabella)
* TAS_CDL
(Corso di studio di appartenenza della matricola relativamente all'addebito in oggetto.)
* TAS_MATR
(Matricola.)
* TAS_ANNOACC
(Anno accademico da cui sottrarre 1.)
* TAS_COD
(Codice Tassa (decodifica nella tabella T10).)
* TAS_FLGRATA
(Codice Rata.)
* TAS_IMPDOV
(Importo dovuto (in lire ed in euro).)
* TAS_IMPPAG
(Importo effettivamente pagato (in lire ed in euro).)
* TAS_IMPDAP
(Importo da pagare (in lire ed in euro).)
* TAS_IMPRIM
(Importo da rimborsare (in lire ed in euro).)
* TAS_IMPDAR
(Importo Da Rimborsare. E' sempre 0 tranne un caso. NON CONSIDERARE.)
* TAS_DTPAG
(Data di pagamento.)
* TAS_ENTE
(Ente Pagamento.)
{BR}
**AAM** (righe n. 179019){BR}
_Descriscione Tabella: _Tabella dove vengono inserito il coefficente per matricola{BR}
_Aree di interesse: _
J08 - Tassazione studente
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* AAM_ANNO_RIF
(Anno di immatricolazione dello studente in questione)
* AAM_COEFFMERT
(Coefficiente di Merito )
* AAM_RID
(Questo campo contiene l'identificativo della tabella)
* AAM_MATR
(Matricola)
* AAM_ANNOACC
(Anno Accademico)
* AAM_TIPOV
(Tipologia dei dati registrati)
* AAM_NR_ESA_STD
(Somma dei voti degli esami superati entro il 10/8)
* AAM_NR_ESA_RIF
(Somma dei crediti/ annualità degli esami superati entro il 10/8)
* AAM_MEDIA_ESA_STD
(Parametro di merito)
* AAM_CDL
(Corso Di Laurea)
* AAM_DATA_VAL
(Data Valutazione Merito)
* AAM_FASCIAMERT
(Fascia di Merito)
* AAM_MEDIA_ESA_RIF
(Media dei voti degli esami superati entro il 10/8.)
{BR}
**LAU** (righe n. 28411){BR}
_Descriscione Tabella: _Tabella delle Lauree - domande e lauree.   Da migrare sulla P12_DOM_CT insieme alla TES.  TES e LAU vengono caricati assieme, contemporaneamente.  Esiste una nuova colonna: LAU_CFUTIR che contiene i CFU maturati nel tirocinio post-laurea (dove presente). Questo nuovo campo viene generalmente usato per gli esami di stato che prevedono il tirocinio: i cfu vengono certificati per gli studenti che dovrenno sostenere l'esame di stato presso altri atenei.{BR}
_Aree di interesse: _
J18 - Conseguimento Titolo
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* LAU_MATR
(Matricola.)
* LAU_DTDOMLAU
(Data Domanda Di Laurea)
* LAU_ANNOACCLAU
(Anno Accademico Di Laurea)
* LAU_MEDIAES
(Media Esami per la Laurea (è la media degli esami espressa in 30))
* LAU_DTCONSEGLAU
(Data Conseguimento Laurea)
* LAU_VOTOLAU
(Voto Laurea)
* LAU_LODELAU
(Lode laurea)
* LAU_NPAGLAU
(Numero Pagina Registro Lau)
* LAU_NUMDIPL
(N. Del Diploma (è il numero di pergamena))
* LAU_DTCOMPDIPL
(Data Compilazione Diploma (migrare in data invio tipografia))
* LAU_DTINIZTIR
(Data inizio tirocinio)
* LAU_DTFINETIR
(data fine tirocinio)
* LAU_DURATATIR
(Durata Del Tirocinio A = Anni M = Mesi O = Ore  Unità di misura di LAU_PERIODOTIR)
* LAU_PERIODITIR
(durata del tirocinio)
* LAU_GIUDIZIOTIR
(giudizio del tirocinio)
* LAU_DESCRTIR
(Descrizione tirocinio.)
* LAU_DTSTAMPA2
(data stampa del secondo certificato)
* LAU_TIPODOM
(Tipo domanda </del> Non considerare <del> Sempre null e solo un caso con 1.)
* LAU_SSCOMM
( Sotto settore commissione </del> Non considerare<del> sempre vuoto. )
* LAU_QUES
(questionario alma-laurea)
* LAU_RID
(Questo campo contiene l'identificativo della tabella)
* LAU_SIGLA
(Sigla segreteria)
* LAU_SESSIONELAU
(Sessione Conseguimento Lau.)
* LAU_MEDIAEQ
(Media Esami Quadriennali .)
* LAU_NREGLAU
(N. Registro Delle Lauree (da ignorare è sempre 0))
* LAU_NUMTESILAU
(Numero Della Tesi (è il numero progressivo -progressivo testi).)
* LAU_FLGESITOLAU
(Flg Esito Positivo (S/N) (i casi con N sono solo quelli di studenti non ancora laureati))
* LAU_DTRITDIPL
(Data Ritiro Diploma)
* LAU_FLGDISPDIPL
(Flg Diploma Disponibile (S/N) (da migrare, dove c'è la data di ritiro mettere R)).)
* LAU_ANNOESAS
(Anno Esame di Stato (ignorare il dato, verranno migrati i dati delle tabelle degli esami di stato e non questi))
* LAU_SESSESAS
(Sessione Esame di Stato (ignorare il dato, verranno migrati i dati delle tabelle degli esami di stato e non questi))
* LAU_DNVTLAU
(base del voto di laurea)
* LAU_NDOMLAU
(N. Totale Domande Di Lau. (da ignorare)  Esiste un solo record per matricola, pertanto se uno studente presenta più di una domanda viene utilizzato lo stesso record.)
* LAU_CDL
(Codice corso di laurea  Se non dovesse coincidere con il corso presente nella AAC, fa fede quello della AAC.)
{BR}
**CAE** (righe n. 153){BR}
_Descriscione Tabella: _regole di ammissione agli esami di stato  associazioni corsi di laurea - esami di abilitazione{BR}
_Aree di interesse: _
J19 - Post Laurea
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* CAE_RID
(identificativo tabella)
* CAE_CODEST
(codice esame di stato)
* CAE_SEZIONE
(sezione)
* CAE_SETTORE
(settore)
* CAE_CODCDL
(codice corso di laurea)
* CAE_ANNO_INIZ
(anno inizio validità)
* CAE_SESS_INIZ
(sessione inizio validità)
* CAE_DTUPDATE
(ultimo aggiornamento)
* CAE_ANNO_FINE
(anno fine validità)
* CAE_SESS_FINE
(sessione fine validità)
* CAE_TIPOCDL
(tipo corso di laurea)
* CAE_CLASSE
(codice classe di laurea. nei casi in cui ci sia un "/s" nel codice classe, qui non viene specificato. Ad esempio la classe 23/s è codificata come 23.)
{BR}
**ANC** (righe n. 34597){BR}
_Descriscione Tabella: _Graduatoria Iscrizioni per corsi a numero chiuso.  I dati fino al 2003/2004 i dati sono solo in questa tabella. Dal 2004/2005 i dati sono anche in un altro schema (che contiene anche le preiscrizioni non pagate){BR}
_Aree di interesse: _
J04 - Test di Ingresso e Ammissione
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* ANC_RID
(Questo campo contiene l'identificativo della tabella)
* ANC_CODCDL
(Codice CorsoCorso della domanda)
* ANC_ANNOACC
(Anno Accademico)
* ANC_ANNO
(anno di corso)
* ANC_PROGRISCR
(Progressivo Iscrizione (è una sorta di pre-matricola))
* ANC_DATAISCR
(Data Iscrizione)
* ANC_COD_FISCALE
(Codice Fiscale)
* ANC_COGNOME
(Cognome)
* ANC_NOME
(Nome)
* ANC_SESSO
(Sesso)
* ANC_DTNASC
(data di nascita)
* ANC_LUOGONAS
(Luogo di Nascita)
* ANC_NAZNAS
(Nazione di Nascita)
* ANC_INDREC
(Indirizzo recapito)
* ANC_CAPREC
(CAP recapito)
* ANC_COMUNEREC
(Comune recapito)
* ANC_PROVREC
(Provincia recapito)
* ANC_INDRES
(Indirizzo residenza)
* ANC_CAPRES
(CAP Residenza)
* ANC_COMUNERES
(Comune Residenza)
* ANC_PROVRES
(Provincia Residenza)
* ANC_TELRES
(Telefono residenza)
* ANC_CODAMB
(codice ambasciata)
* ANC_DTCOLLOQUIO
(data colloquio per extracomunitari per accertamento conoscenza lingua italiana)
* ANC_VOTOTIT
(Voto Titolo Studio)
* ANC_CODTIT
(Codice Titolo Studio)
* ANC_TASSA_PAGATA
(Flag tassa pagata (S/N))
* ANC_VOTOMEDIATO
(Voto mediato)
* ANC_POSGRADUATORIA
(Posizione Graduatoria)
* ANC_IMMATRICOLATO
(Flag Immatricolato)
* ANC_VOTOESAME0
(non usato)
* ANC_VOTOESAME1
(non usato)
* ANC_VOTOESAME2
(non usato)
* ANC_VOTOESAME3
(non usato)
* ANC_VOTOESAME4
(non usato)
* ANC_VOTOESAME5
(non usato)
* ANC_VOTOESAME6
(non usato)
* ANC_VOTOESAME7
(non usato)
* ANC_TESTO
(note)
* ANC_MEDIATEST
(non usato)
* ANC_ANNOTIT
(anno del titolo)
* ANC_VOTODEN
(base del titolo)
* ANC_CITTITA
(italiano o straniero)
* ANC_DENVESAME0
(non usato)
* ANC_DENVESAME1
(non usato)
* ANC_DENVESAME2
(non usato)
* ANC_DENVESAME3
(non usato)
* ANC_DENVESAME4
(non usato)
* ANC_DENVESAME7
(non usato)
* ANC_DENVESAME8
(non usato)
* ANC_DENVESAME9
(non usato)
* ANC_TIPODIPL
(tipologia del titolo: regionale oppure universitario)
* ANC_VOTOMEDIO
(voto medio)
* ANC_CDL_SCELTA2
(seconda scelta di corso)
* ANC_CDL_SCELTA3
(terza scelta di corso)
* ANC_TIPOLAU
(tipo corso della laurea)
* ANC_DATALAU
(data di laurea)
* ANC_VOTOLAU
(voto laurea)
* ANC_DNVTLAU
(base del voto di laurea)
* ANC_LODELAU
(lode)
* ANC_SEDEFORM2_3
(sede formativa legato al secondo corso scelto)
* ANC_SEDEFORM3_1
(sede formativa legato al terzo corso scelto)
* ANC_SEDEFORM3_2
(sede formativa legato al terzo corso scelto)
* ANC_SEDEFORM3_3
(sede formativa legato al terzo corso scelto)
* ANC_RINUNCIA
(rinuncia)
* ANC_FLGDIPLULT
(flag diplomando)
* ANC_POSIDONEI
(poiszione all'interno della graduatoria degli idonei)
* ANC_CDL_CONV
(corso nel quale viene richiesto allo studente di esprimere la scelta di immatricolarsi)
* ANC_DENVESAME5
(non usato)
* ANC_DENVESAME6
(non usato)
* ANC_SEDEFORM
(Codice sede formativa della didattica legata al primo corso scelto Utilizzato per i corsi sanitari  FK in SFO)
* ANC_SEDEFORM2
(Codice sede formativa della didattica legata al primo corso scelto  Utilizzato per i corsi sanitari  FK in SFO)
* ANC_SEDEFORM3
(Codice sede formativa della didattica legata al primo corso scelto  Utilizzato per i corsi sanitari  FK in SFO)
* ANC_PRENOTAZIONE
(prenotazione del posto da parte di studenti vincitori del concorso che però sono iscritti da altre parti)
* ANC_SEDEFORM2_1
(sede formativa legato al secondo corso scelto)
* ANC_SEDEFORM2_2
(sede formativa legato al secondo corso scelto)
* ANC_TELREC
(Telefono recapito)
* ANC_CITTAD
(cittadinanza)
* ANC_VOTOTEST
(Voto Test di ammissione)
* ANC_VOTOESAME8
(non usato)
* ANC_VOTOESAME9
(non usato)
* ANC_STRAITA
(cittadini stranieri che rientra per legge a fare i concorsi italiani)
{BR}
**UNV** (righe n. 1){BR}
_Descriscione Tabella: _Sono i dati relativi all'università dell'Aquila{BR}
_Aree di interesse: _
J02 - Struttura Didattica
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* UNV_DESCRTIPO
(descrizione da anteporre al nome dell'ateneo)
* UNV_CODISTAT
(Codice ISTAT Universita')
* UNV_TIPOMATR
(Tipo immatricolazione M=Manuale A=Automatica Modalita' possibili di Immatricolazione: M=Manuale P= Pre-immatricolazione U=Generale per Universita' C=Per Corso di Studi)
* UNV_MATRCORSI
(Modalita' Immatricolazione Corsi di Laurea.)
* UNV_MATRSCDIR
(Modalita' Immatricolazione Scuole Dirette a Fini Speciali)
* UNV_MATRDIPLU
(Modalita' Immatricolazione Diplomi Universitari)
* UNV_MATRSCDIP
(Modalita' Immatricolazione Scuole per Diplomi)
* UNV_MATRSSPEC
(Modalita' Immatricolazione Scuole Specializzazione)
* UNV_MATRDOTTR
(Modalita' Immatricolazione Dottorati)
* UNV_MATRRELIN
(Modalita' Immatricolazione Relazioni Internazionali)
* UNV_MATRSTATO
(Modalita' Immatricolazione Esami di Stato)
* UNV_TIPOARC
(Modalita' numerazione Archivio M=Manuale A=Automatica)
* UNV_CODE
(schema di oracle)
* UNV_PSWD
(password di oracle)
* UNV_BATCH_SERVER
(SID del Server per Programmi Batch)
* UNV_FONT_TYPE
(Tipo di Font )
* UNV_FONT_SIZE
(dimensione del font per le stampe)
* UNV_SEDE
(Sede universitaria)
* UNV_SEDE_UC
(Sede universitaria in Maiuscolo)
* UNV_INDIR
(Indirizzo)
* UNV_CAP
(Codice Avviamento Postale)
* UNV_NR_PREF
(Numero preferenze)
* UNV_DTCLIENT
(Data ultimo aggiornamento client )
* UNV_DTUPDATE
(data ultimo aggiornamento)
* UNV_COD_MIUR
(codice MIUR)
* UNV_UNVTIPO
(descrizione (STATALE))
* UNV_UNVTYPE
(tipo in inglese)
* UNV_SITOWEB
(indirizzo web)
* UNV_SITEWEB
(indirizzo in inglese (che poi è lo stesso))
* UNV_COD
(Codice Universita')
* UNV_DESCR
(Descrizione)
* UNV_RID
(Questo campo contiene l'identificativo della tabella)
* UNV_TIPO
(Tipo Universita' U = Universita' degli Studi I = Istituto Universitario P = Politecnico A = Accademia)
* UNV_DESCRE
(descrizione estesa)
{BR}
**P2S** (righe n. 214984){BR}
_Descriscione Tabella: _Tabella contenente l'ultimo piano di studi (e libretto) Ante-riforma dello studente che abbia esercitato l'opzione 509. Migrare sulla P11_AD_SCE, P11_SEG_SCE come piani e libretti storici, legati all'ultima matricola Ante riforma.  Se NON sono stati eseguiti ulteriori passaggi di corso, ed esiste lo schema di convalida, sarà possibile migrare le convalide.  Verificare che tutti gli esami presenti in P2S siano anche in PDS.  Le colonne sono identiche a quelle della tabella PDS, pentanto si rimanda a tale tabella per la spiegazione dei campi{BR}
_Aree di interesse: _
J15 - Libretto Studente
J13 - Piani di Studio
{BR}
_Tabelle di Esse3 interessate : _{BR}
_Lista campi: _{BR}
* P2S_COMPOSTO
(Insegnamento composto (S/N))
* P2S_MODULO
(Modulo (S/N))
* P2S_CODINT
(Codice insegnamento integrato (padre). Presente solo se si tratta di moduli che vanno migrati come Unità didattiche.)
* P2S_CREDITO
(Credito didattico.)
* P2S_ORE
(Ore di insegnamento.)
* P2S_TOTCREDITI
(Crediti convalidati)
* P2S_NOMEDIA
(Insegn. Non In calcolo Media esami)
* P2S_UNIVFRQ
(Universita Di Frequenza)
* P2S_AACFRQ
(Anno Accademico Frequenza)
* P2S_NUMFRQ
(Numero Di Frequenze)
* P2S_TIPOFRQ
(Flg Tipo Frequenza S=Con Statino A=Assegnaz. Automatica N=Non Richiesta (Convalida))
* P2S_UNIVESA
(Universita Sost. Esame)
* P2S_AACSOSTESA
(Anno Accademico Sostenimento Esame)
* P2S_DTSOSTESA
(Data Sost Esame)
* P2S_SESSIONEESA
(Sessione Sost. Esame)
* P2S_VOTOESA
(Voto Esame.)
* P2S_LODEESA
(Lode)
* P2S_FLGCONVESA
(Flg Esame Convalidato (S/ ))
* P2S_CODCATTEDRA
(Codice Docente Esame.</del> NON GESTITO.)
* P2S_SUPINT
(Flg Esame Integrato superato (../S))
* P2S_SEMESTRE
(semestre)
* P2S_TIPOESAME
(tipo esame )
* P2S_FLGFREQ
(flag frequenza)
* P2S_SEDEAF
(sede attività formativa)
* P2S_CRDOPZ
(Crediti opzionali aggiuntivi.)
* P2S_TIPOAF
(Tipo Attività Formativa.)
* P2S_AMBITO
(Codice ambito.)
* P2S_TIPOCORSO
(tipo corso)
* P2S_AAVALID
(anno validità)
* P2S_AMBOLD
(vecchi ambiti interni)
* P2S_RID
(Questo campo contiene l'identificativo della tabella)
* P2S_CDL
(Codice Corso)
* P2S_MATR
(Matricola)
* P2S_CODINS
(Codice Insegnamento)
* P2S_FLGINPIANO
(Flag In Piano (S/N). In realtà usato per identificare i sovrannumerari. Non considerare.  Le AD dei precedenti libretti verranno caricate sul libretto senza il legame al piano di studi, per non contaminare l'offerta didattica.)
* P2S_ANNO
(Anno di corso dell'esame.)
* P2S_TIPOINS
(Tipo Insegnamento.)
* P2S_ANNU
(Annualita Insegnamento)
* P2S_DURATA
(Durata Solare Insegnamento in annualità. valori 0,5 1)
{BR}
