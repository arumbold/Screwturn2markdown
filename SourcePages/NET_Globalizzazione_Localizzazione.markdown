
##  Scenario: globalizzazione e localizzazione 
* Quando si sviluppano applicazioni internazionali, è necessario concentrare l'attenzione su una gamma di aspetti durante l'intero processo di progettazione e sviluppo dell'applicazione. I tre aspetti chiave sono la **globalizzazione**, la **possibilità di localizzazione** e la **localizzazione**. Vediamoli in dettaglio.
* La globalizzazione è il primo passaggio del processo. Un'applicazione globalizzata supporta le interfacce utente e i dati internazionali localizzati per tutti gli utenti. Le applicazioni realmente internazionali devono utilizzare la lingua e le impostazioni cultura di sistema (che in un'applicazione web significa quelle del browser dell'utente). 
* Un passaggio intermedio precedente alla localizzazione è l'esecuzione di test per verificare la possibilità di localizzazione. In questo passaggio viene verificato che le **risorse dell'applicazione che richiedono la traduzione siano state separate dal resto del codice dell'applicazione**. Se si esegue correttamente il test della possibilità di localizzazione prima di procedere alla fase di localizzazione, non è necessario modificare il codice sorgente dell'applicazione durante la localizzazione. 
* La localizzazione è l'ultimo passaggio nel processo di sviluppo di un'applicazione internazionale. In questo passaggio l'applicazione viene personalizzata per le impostazioni cultura o i paesi specifici da supportare. Questo passaggio è costituito principalmente dalla traduzione dell'interfaccia utente nelle lingue di destinazione.
* Nel processo di localizzazione esistono sempre due aspetti (che possono essere trattati in modo disgiunto, ma che sarebbe bene gestire coerentemente): 
    * la **Culture** che include il sistema di scrittura, i calendari in uso e le convenzioni di formattazione della data e dell'ora, le convenzioni dei numeri e della valuta e le regole di ordinamento.
    * la **UICulture** che determina quali risorse vengono caricate per la pagina e quindi vedere una label tradotta in un modo o in un altro.

##  Piattaforma .NET  
* La piattaforma .NET e l'IDE Visual Studio forniscono un supporto per la globalizzazione di applicazioni sia Windows Form che ASP.NET. In entrambi i casi esiste la possibilità di gestire dei file di risorse su cui basare la localizzazione, vedi riferimenti MSDN.
* La localizzazione dell'applicativo può essere impostata a vari livelli. Per esempio, in modo dochiarativo, sul web.config di un'applicazione asp.net (in questo esempio viene utilizzato il nuovo valore auto che imposta la lingua corrente basandosi sull'eventuale valore impostato sul browser o in caso contrario Italiano)
    
    <globalization culture=”auto:it-IT” uiCulture=”auto:it”>


##  Esempio  
* In allegato alla pagina c'è un esempio di applicazione windows form globalizzata che gestisce 3 localizzazioni (en, it, tr); occorre framework .NET 2.0

[attachment:EsempioGlobal.rar](attachment:EsempioGlobal.rar)

##  Riferimenti 
* [MSDN: Encoding e Localization](http://msdn.microsoft.com/en-us/library/h6270d0z.aspx)
* [MSDN: Globalizzazione e localizzazione ASP.NET](http://msdn.microsoft.com/it-it/library/c6zyy3s9.aspx)
* [MSDN: Procedura dettagliata: localizzazione di Windows Form](http://msdn.microsoft.com/it-it/library/y99d1cd3.aspx)
* [Devexpress: How to localize .NET Windows Forms components](http://www.devexpress.com/Support/Center/KB/p/A421.aspx)
* [www.west-wind.com: Creating a Data Driven ASP.NET Localization Resource Provider and Editor](http://www.west-wind.com/presentations/wwDbResourceProvider)
* [MSDN (english): Globalization and Localization](http://msdn.microsoft.com/en-us/library/ms978628.aspx)
* [MSDN (english): Best Practices for Developing World-Ready Applications](http://msdn.microsoft.com/en-us/library/aa719630.aspx)
* [Aspitalia: Globalizzazione e localizzazione per applicazioni Web - ASP.NET 2.0](http://www.aspitalia.com/articoli/asp.net2/Localizzazione-Globalizzazione-p-1.aspx)

###  Tools 
* [Zeta Resource EditorZeta](http://69.10.233.10/KB/aspnet/ZetaResourceEditor.aspx)
* [RESX Synchronizer 1.3, utility da linea di comando](http://www.screwturn.eu/ResxSync.ashx)
* [RESX-file Web-Editor](http://blog.lavablast.com/post/2008/02/RESX-file-Web-Editor.aspx)
