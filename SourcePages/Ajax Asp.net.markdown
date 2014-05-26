##  Scenario 
* **L'aggiornamento dei dati lato client senza effetturare il refresh del'intera pagina è da sempre un sogno per molti sviluppatori web**
* Per trasformare questo sogno in realtà occorre  che il browser operi una connessione tacita ad un url remoto, che passi alcuni dati client, svolga operazioni sul server ed infine restituisca un valore al client. Una volta che il browser ha accolto i valori di ritorno, aqggiorna la pagina utilizzando il modello a oggetti Dynamic Html.
* Questo approccio pur non convincendo i "puristi", permette alla pagina di essere eseguita più velocemente e trasmette un senso di continuità all'utente poichè sembra che tutti funzioni localmente.

##  Tecnologie, Strumenti, Overview 
* Premesso che l'acronimo Ajax sta per **Asynchronous Javascript and XML** e quindi è più che altro un "approccio" (utilizzato ad esempio in Google Maps o Gmail), non dipendente dalle architteture server, vediamo come si declina, ad oggi, in architettura .NET:
    * Si puo' uilizzare la **Api grezza di asp.net**: "Script callback" (vedi msdn)
    * **Ajax.net** (conosciuto precedentemente come Atlas): è un framework autoconsistente (non occorre un "broker" sul browser, come nel caso precedente) che tenta di semplificare lo sviluppo client e server e introduce una serie di controlli in grado di operare sia sul client che sul server.
    * Application Platform Roadshow (Overview Microsoft): **AJAX.NET Rimini 08/03/2007**; Slides ed esempi del corso si possono scaricare dal blog del docente: [Pietro Brambati Blog - Application Platform Roadshow](http://blogs.msdn.com/pietrobr/archive/2007/03/05/application-platform-roadshow.aspx)


##  Riferimenti 
* [Panoramica sullo stile di programmazione Ajax](http://en.wikipedia.org/wiki/Ajax_%28programming%29)
* [The Official Microsoft ASP.NET AJAX Site](http://ajax.asp.net)
* [Collezione di esempi e componenti riutilizzabili basati su ASP.NET AJAX](http://ajax.asp.net/ajaxtoolkit)
* [Sdk Virtual Earth](http://dev.live.com/virtualearth/sdk)
* [DayPilot - Open-Source Outlook-Like Calendar/Scheduling Control for ASP.NET](http://www.daypilot.org)
* [UpdatePanel Control Overview](http://www.asp.net/ajax/documentation/live/overview/UpdatePanelOverview.aspx)

* [File esempi Ajax](../Upload/Ajax%20Asp.net%2fajax.rar)
