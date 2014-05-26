
## Help on line
L'help on line delle librerie comuni (e di eventuali altre risorse collegate) di Apex-net si può trovare in:

[Help Apex-net Internal Tools - LIB](http://doc.apex-net.it/ait/lib/)

## Come fare per generare un help di questo tipo
* Si possono sfruttare le funzionalità native di alcuni compilatori come c# o di appositi add-in al proprio IDE per generare durante il build del proprio assembly (ad es. la dll di un progetto di classi) anche un **file di commenti in formato XML** (i commenti sono presi direttamente dai commenti al codice di classi, metodi, ecc. 

     csharp
    /// <summary>
    /// Restituisce un oggetto "report document", dato il path completo di un report di CR, 
    /// applicando le info di connection per ogni tabella e sottoreport incluso.
    /// Può connettersi anche ad un server RAS (Unmanaged o Managed)
    /// </summary>
    /// <param name="reportPath">Percorso del report</param>
    /// <returns></returns>
    
    public ReportDocument PrepareReport(string reportPath) 
    { 


* Possiamo utilizzare poi uno strumento come **Sandcastle**, realizzato da Microsoft. Questo tool è usato per creare documentazione tipo MSDN-style da NET assemblies e il loro file di commenti XML associati.
* La versione attuale di Sandcastle (October 2007 CTP) è un tool a riga di comando, senza una propria GUI di front-end. Nella **community** si possono però trovare innumerevoli scrpts e tools interattivi per automatizzare il processo di documentazione tecnica.  
* Riferimenti
    * [Sandcastle wiki: Scripts and Tools](http://www.sandcastledocs.com/Wiki%20Pages/Scripts%20and%20Automation%20from%20Community.aspx)
    * [Sandcastle Help File Builder](http://www.codeplex.com/SHFB)
