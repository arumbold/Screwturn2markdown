
##  Scenario 
* Lo scopo di queste note è puntualizzare alcune novità introdotte con le versioni 2009.2 e 2009.3 dei componenti forniti dalle varie suites DevExpress

##  Asp-net **performance improvements** in de 2009.2 
* Grazie alla riprogettazione di un nuovo **custom HttpHandler** è possibile comprimere varie risorse connesse ai controlli di devexpress WEB; la compressione puo' ridurre l'html output rispetto alla versione precedente di 5,7 volte, migliorando cosi' le performance globali del sito
* E' possibile parametrizzare queste funzionalità attraverso il web.config, vedi il seguente frammento
     xml
    <appSettings>
    <add key="DXEnableCallbackCompression" value="true"/>
    <add key="DXEnableResourceCompression" value="true"/>
    <add key="DXEnableResourceMerging" value="true"/>
    <add key="DXEnableHtmlCompression" value="true"/>
    </appSettings>
 
* In dettaglio:
    * DXEnableCallbackCompression - **Comprime AJAX callbacks** (true by default)
    * DXEnableResourceCompression - **Comprime scripts e CSS files** (true by default)
    * DXEnableResourceMerging - Combina tutti gli scripts in un **unico file** (da differenti assemblies) e fa il **merge** di tutti i CSS-files in unico file. Riduce 'server requests'. (false by default)
    * DXEnableHtmlCompression - **Comprime HTML** output al browser client includendo AJAX callbacks (false by default); per comprimere pagine singole, utilizzare il metodo DevExpress.Web.ASPxClasses.ASPxWebControl.MakeResponseCompressed(). 
    * Vedi anche: [Asp-net performance improvements in devexpress 2009 volume 2](http://community.devexpress.com/blogs/aspnet/archive/2009/07/20/asp-net-performance-improvements-in-devexpress-2009-volume-2.aspx)

##  Asp-net **performance improvements** in de 2009.3 
* Viene abilitata la posssibilità di utilizzare la tecnica **CSS Image Sprites**; tutte le immagini sono memorizzate in un'unica grande immagine e vengono mantenuti i riferimenti tramite tecniche posizionali; questo incrementa le perfomance poichè si evitano tante richieste ai web server per recuperare tutte le immagini; vedi [CSS Image Sprites](http://www.devexpress.com/Products/NET/DXperience/WhatsNew2009v3/index.xml?page=25)

##  Asp-net New **ASP.NET Splitter Control** in de 2009.3 
* Permette di costruire interfacce utente web con pannelli ridimensionabili dall'utente
* [Demo Online Splitter](http://demos.devexpress.com/ASPxperienceDemos/Splitter/ControlsResizing.aspx)

##  Riferimenti 
* [What's New 2009.2](http://www.devexpress.com/Products/NET/DXperience/WhatsNew2009v2/)
* [Breaking Changes 2009.2](http://www.devexpress.com/Support/WhatsNew/DXperience/files/9.2.4.bc.xml)
* [What's New 2009.3](http://www.devexpress.com/Products/NET/DXperience/WhatsNew2009v3/)
