
# **Il punto di partenza: cosa serve alle università per la loro gestione interna?**
Le esigenze fondamentali di una Università in termini di gestione interna si possono riassumere in 3 punti:
1) gestione del personale 
2) gestione della contabilità
3) gestione della didattica

Attualmente questi tre compiti sono svolti da applicativi diversi e non correlati fra loro: solitamente  “suite” come gli Enterprise Resource Planning (ERP), Human Resources (HR), Customer Relationship Managemnet (CRM) per personale e contabilità e sistemi invece sviluppati ad hoc per didattica e studenti. Cosa comporta questo? 

Da una parte ci sono i sistemi best-of-breed, che assolvono a una precisa esigenza funzionale non coperta dai sistemi ERP. Questi sistemi hanno un'alta specificità applicativa, ma non si rapportano a un modello applicativo di riferimento che faciliti il “dialogo” tra applicazione diverse o che ne condivida i dati. Inoltre, i sistemi best-of-breed utilizzano tecnologie e architetture informatiche più disparate, introducendo  il problema della crescita di tecnologie e architetture eterogenee all'interno dell'Organizzazione.
Il risultato che si ottiene così facendo è un sistema informativo a “silo” dove ogni applicazione ha i propri dati e funzioni separati dagli applicativi già presenti nell'Organizzazione.
 
Dall'altra parte ci sono i sistemi ERP, che risolvono in parte i problemi dei sistemi best-of-breed, ma hanno una specificità tecnologica e applicativa intrinseca nel sistema stesso, che evidenzia una scarsa propensione all'integrazione con altri sistemi (apertura) e all'adattarsi alle esigenze di mutazione o crescita dell'Organizzazione.

<span style="text-decoration:underline">Entrambe le soluzioni contrastano con l'esigenza delle Organizzazioni di avere sistemi informativi flessibili e versatili per poter ottimizzare i propri processi o automatizzarne dei nuovi, anche oltre ai confini della propria struttura per dialogare con sistemi esterni.
</span>


# **Soluzione: un sistema integrato per il "governo dell'ateneo", U-GOV**
La soluzione proposta è quella di un sistema modulare e integrato, basato su architetture aperte orientate ai servizi (SOA) utilizzando gli standards industriali (J2EE, .NET, We Services, XML): questo è il punto di partenza di U-GOV.

## **Modello Applicativo**
*Caratteristiche di U-GOV:
**Sistema gestionale modulare ed integrato per l'Ateneo
**Adozione di anagrafiche centralizzate per soggetti e strutture
**Possibilità di configurare processi e regole di business
**Integrazione con le funzioni di pianificazione e controllo

> ![U-GOV - Overview](../Upload/U-GOV/U-GOV - 1. Overview.jpg)


## **Architettura e scelte tecnologiche**

... vediamo qualche slide ...

> ![](../Upload/U-GOV/U-GOV Architettura 3 livelli.jpg)
> ![](../Upload/U-GOV/U-GOV Architettura generale.jpg)


### <span style="text-decoration:underline">In Dettaglio: pattern MVC per lo sviluppo dell'interfaccia grafica</span>

Il pattern è basato sulla separazione dei compiti fra i componenti software che interpretano tre ruoli principali:
*il model fornisce i metodi per accedere ai dati utili all'applicazione;
*il view visualizza i dati contenuti nel model e si occupa dell'interazione con utenti e agenti;
*il controller riceve i comandi dell'utente (in genere attraverso il view) e li attua modificando lo stato degli altri due componenti

Questo schema, fra l'altro, implica anche la tradizionale separazione fra la logica applicativa (in questo contesto spesso chiamata "logica di business"), a carico del controller e del model, e l'interfaccia utente a carico del view.

Vedi: [Wikipedia - MVC](http://it.wikipedia.org/wiki/Model-View-Controller); [Design Pattern](http://it.wikipedia.org/wiki/Design_pattern)

### <span style="text-decoration:underline">Tecnologie Utilizzate nel progetto U-GOV</span>
*Database: Oracle 10
*Persistenza: Kodo JDO (Vedi: [KODO JDO](http://solarmetric.com/Software/Documentation/3.4.1/docs/manual.html))
*Application Server: OC4J
*Presentation: JFS - Facelet (Vedi: [JSF](http://www.ibm.com/developerworks/library/j-jsf3/))

### Il Framework di supporto allo sviluppo
> ![](../Upload/U-GOV/U-GOV Frk e modello dei componenti.jpg)

### Collegamento con i pattern
> ![](../Upload/U-GOV/U-GOV Frk e patterns J2EE.jpg)

### Architettura orientata ai servizi
> ![](../Upload/U-GOV/U-GOV Orientamento ai servizi.jpg)


*Per chi volesse approfondire l'argomento: [Guida J2EE](http://java.html.it/guide/leggi/136/guida-j2ee/); [MVC e J2EE](../Upload/U-GOV/MVC e J2EE.pdf)
# **Entriamo in dettaglio**
## Modulo Contabilità

La contabilità di U-GOV si propone di essere altamente flessibile e configurabile. 
Principali caratteristiche:
### Gestione dei tre metodi contabili: COFI-COGE-COAN

*Contabilità Finanziaria (COFI): orientata al controllo autorizzativo e formale dei flussi finanziari nominali o certi
*Contabilità Economica o Contabilità Generale/Aziendale (COGE): orientata alla dimostrazione del risultato economico della gestione
*Contabilità Analitica (COAN): orientata all'analisi delle ragioni e delle responsabilità dei flussi amministrativi al fine del Controllo di Gestione

Per ognuna di queste contabilità sono forniti i rispettivi "motori" che implementano le logiche specifiche. E' possibile usare queste tre metodologie contabili sia separatamente che in parallelo.

> ![](../Upload/U-GOV/U-GOV Contabilita visione metodi contabili.jpg)

### Separazione fra evento gestionale e registrazione contabile

Dallo stesso evento gestionale (documento), rilevato in quanto tale e non in relazione ai suoi effetti amministrativi, possono scaturire diverse registrazioni contabili nei diversi metodi (motori di registrazione). 
Le relazioni tra i diversi eventi costituiscono il ciclo attivo e passivo e altri cicli produttivi o di supporto (cicli gestionali), nel cui insieme possono formare i processi operativi.

> ![](../Upload/U-GOV/U-GOV Contabilita Cicli Motori 1.jpg)
> ![](../Upload/U-GOV/U-GOV Contabilita Cicli Motori 2.jpg)

### Alta configurabilità dei cicli e della UI
*Completa libertà di scelta di creazione dei Documenti appartenenti ai cicli (Fattura passiva, DDT, RDA, Contratto eccetera)
*Completa libertà di scelta tra attributi previsti (da attivare o meno per un DG) o attributi non previsti a design time
*Completà libertà di disegno del WF sulla base delle relazioni (di tipo pred succ) tra DG. Alcune relazioni sono controllate, per cui preesistono e possono essere scelte di volta in volta
*Completa libertà, per ogni DG, di disegnare la sua Macchina a Stati Finiti (autorizzazioni, chiamate ai motori di registrazioni, eccetera)
*Configurabilità nella User Interface e nella reportistica
*Configurabilità della chiamata verso metodi di un motore: ogni metodo è descritto in parte dal sistema in parte da un INTERPRETE REGOLE che si basa su attributi dinamici o statici

	Esempio: 
	Una registrazione COGE può essere chiamata a partire da un Tipo DG a scelta 
	La stessa registraizione può muovere voci del PDC COGE derivanti da scelte statiche (associazioni natura/conto e simili) ma anche dinamiche (Tipo DG, attributi non noti a priori dello stesso DG)

## Cicli e Documenti Gestionali
### Modello concettuale cicli gestionali

> ![](../Upload/U-GOV/DG/U-GOV Modello concettuale cicli gestionali.jpg)

#### Cicli e documenti gestionali
Il ciclo gestionale è la rappresentazione applicativa di un processo amministrativo, decisionale o di supporto, che si svolge come sequenza complessa di attività eseguite per raggiungere un particolare obiettivo o risultato significativo per l'organizzazione. I documenti gestionali sono le astrazioni applicative delle informazioni trattate all'interno dei cicli gestionali; il loro scopo è quello di registrare le informazioni e le coordinate utili a descrivere un evento gestionale ed ad attivarne le registrazioni necessarie. Ogni documento gestionale ha associata una macchine che regola l'evoluzione di ogni singolo documento e le interazioni con altri documenti gestionali ed i motori di registrazione. Ogni documento gestionale è caratterizzato da un tipo e può essere associato ad altri documenti a lui direttamente correlati nel contesto di un ciclo gestionale e denominati predecessori.

#### Motori di registrazione
I motori di registrazione hanno il compito di elaborare le informazioni strutturate provenienti dai cicli gestionali, attraverso i documenti gestionali prodotti, di generare movimentazioni e registrazioni secondo la logica dei diversi mondi funzionali (contabilità finanziaria, analitica, magazzino, carriera personale,..) e di aggiornare le anagrafiche.
Negli ambiti funzionali di pertinenza dei vari motori, il documento gestionale può essere esteso con decorazioni specifiche di ogni contesto; questo con l'obiettivo di disaccoppiare la natura gestionale di un documento dalle informazioni di un particolare ambito (ad. Esempio la contabilità finanziaria).

#### Anagrafiche e giornali
Le anagrafiche ed i giornali costituiscono il patrimonio informativo di base del sistema. A questo livello non vi sono elementi attivi o di processo, ma solo una serie di archivi che contengono le informazioni inerenti il dominio applicativo. Più precisamente, le anagrafiche contengono informazioni per lo più statiche o a bassa frequenza di variazione; i giornali sono invece informazioni fortemente dinamiche derivanti dall'interpretazione dei processi dell'organizzazione.

### Dg modello logico architetturale

> ![](../Upload/U-GOV/DG/U-GOV - Dg modello logico architetturale.jpg)

