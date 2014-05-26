
##  Scenario 
La **compressione HTTP ** fornisce la volta di trasmissione più veloce tra i browser abilitati a gestire la  compressione e un web server (ci occuperemo qui di IIS). 

È possibile comprimere i file soli statici e/o le applicazioni dinamiche. Se la larghezza di banda di rete è limitata, considerare almeno la compressione HTTP di file statici a meno che l'utilizzo di processore sia già elevato. 

##  Come fare 
In IIS 6 esistono una serie di passi che occorre fare per abilitare la compressione di determinati file statici (documenti word, css, ecc...) e contenuti dinamici di vario genere (server pages, http handler, script ajax, ecc..).

Nel caso di tecnologie .NET occorre includere attivare la compressione HTTP includendo per le pagine dinamiche le seguenti estensioni: aspx, axd, ashx, ecc...
Per fare questo occorre editare il file **MetaBase.xml** (possibilmente utilizzando le utilities di sistema), vedi riferimenti ed esempio seguente. 
E' ovviamente possibile implementare una compressione http ad hoc in un'applicazione ASP.NET particolare.

Esempio di procedura per attivare la compressione HTTP in IIS 6:
* PER ABILITARE LA COMPRESSIONE sia su IIS5 che su IIS6 occorre:
    * IIS Manager 
    * Aprire l'elenco dei siti 
    * tasto destro/proprietà su Web site 
    * tab Service 
    * a questo punto abilitare e specificare la dir temporanea (importante).
* PER AGGIUNGERE files specifici alla compressione: 
    * cscript.exe adsutil.vbs set  W3Svc/Filters/Compression/GZIP/HcFileExtensions "htm" "html" "txt" "ppt" "xls" "xml" "xslt" "doc" "xsl" "js" "css" 
    * cscript.exe adsutil.vbs set W3Svc/Filters/Compression/DEFLATE/HcFileExtensions "htm" "html" "txt" "ppt" "xls" "xml" "xslt" "doc" "xsl" "js" "css" 
    * cscript.exe adsutil.vbs set  W3Svc/Filters/Compression/GZIP/HcScriptFileExtensions "asp" "dll" "exe" "aspx" "ashx" "axd"
    * cscript.exe adsutil.vbs set  W3Svc/Filters/Compression/DEFLATE/HcScriptFileExtensions "asp" "dll" "exe" "aspx" "ashx" "axd"
    * IISreset.exe /restart 
* E' possibile anche abilitare la compressione selettiva solo per un sito, così:
    * cscript.exe adsutil.vbs set w3svc/1/root/Home/StyleSheets/DoStaticCompression true
*** dove w3svc/1/root/Home/StyleSheets equivale ad un sito in questo formato http://www.contoso.com/Home/StyleSheets

##  Riferimenti 
* [MSDN: HOW TO Enable ASPX Compression in IIS 5](http://support.microsoft.com/kb/322603/en-us )
* [TechNet: Enabling HTTP Compression in IIS 6](http://technet2.microsoft.com/windowsserver/en/library/ae342c42-fbc4-4ab7-b9ac-20a89f0fa4ad1033.mspx?mfr=true )
* [ASP.NET Blog: How To HTTP Compression in IIS 6.0](http://weblogs.asp.net/ssadasivuni/archive/2003/12/10/42448.aspx )
* [MSDN: 10 Tips for Writing High-Performance Web Applications](http://msdn.microsoft.com/msdnmag/issues/05/01/ASPNETPerformance )
* [Codeproject: HTTP compression in .NET Framework 2.0](http://www.codeproject.com/aspnet/CompressibleHTTP20.asp )
* [Pipeboost: Test http compression on-line](http://www.pipeboost.com/default.asp )
