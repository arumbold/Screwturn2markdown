
##  Javascript Tutorials 
**Links:**
* [Introduzione Js - prof. ing. A. Omicini Univ. Bologna Cesena](http://lia.deis.unibo.it/corsi/2003-2004/LABTEC-LA-CE/slides/4-Introduzione%20a%20JavaScript.pdf )
* [4 passi in Js - Univ. Pisa Dip. Informatica](http://www.di.unipi.it/~ambriola/ib/4PassiInJavaScript-v1.05.pdf )
* [Js tutorial On-line](http://www.w3schools.com/js/default.asp )

##  Javascript e ASP.NET 
**Domanda: **
* E' possibile che, malgrado le grandi potenzialita' offerte da ASP.Net, ci si debba ancora preoccupare di utilizzare codice Javascript all'interno delle pagine generate da ASP.Net e se ha ancora senso usare Javascript al posto di altre tecniche piu' evolute?
* La risposta e' SI, per i dettagli vedere il link di UGIDOTNET.
* ASP.NET 2.0 introduce tecniche di programmazione AJAX (Asynchronous Javascript and XML) attraverso varie tecniche (callbacks, ecc...)

**Restrizioni: **
* Se stiamo sviluppando un sito pubblico occorre fare attenzione all'utilizzo del javascript, poichè non si comporta allo stesso identico modo su tutti i browser; occorre sviluppare osservando regole di "Adaptative rendering", per fortuna tutti i "server control" nativi di ASP.NET, html e javascript vengono sempre mandati al client browser a seconda delle specifiche capacità del browser stesso; ovviamente le pop-up sono vietatissime, se sono funzionali al vostro applicativo
* via libera alla fantasia se siete in ambito intranet!!!!

**Links:**
* [Inserire codice Javascript all'interno di pagine ASP.NET](http://www.ugidotnet.org/articles/articles_read.aspx?ID=24 UGIDOTNET)
* [Implementing a Dialog Box in ASP.NET Based Web Application](http://www.dotnetjunkies.com/Article/A72FCFD7-3874-408A-8FCE-541BEC74C704.dcik Dotnetjunkies )

##  Child Windows 
**Suggerimenti**
* Implementare in javascript un buon colloquio parent-child tra window non è molto dissimile che farlo in altre tecnologie ed in altri linguaggi (ad esempio: la window chiamante NON deve manipolare oggetti sulla window chiamata e viceversa, ecc...)

* Oltre ai links qui sotto allego alla pagina un progetto in C#-VS2003 dove sono riportati tutta una serie di modalità di colloquio tra web forms, partendo dai casi più semplici a quelli più complessi: senza js, con js, con n parametri in ingresso e m di output, con l'utilizzo di eventi javascript su bottoni, su griglie, ecc...; per poter essere mandato in esecuzione occorrono risorse in uso dal reparto sviluppo di Apex-net

**Links:**
* [C-sharpcorner - Modal Popup Dialog Window](http://www.c-sharpcorner.com/Code/2003/Sept/ModalPopupInASP.NET.asp )
* [CodeProject - Those Crazy Popups](http://www.codeproject.com/aspnet/ThoseCrazyPopups.asp )
