##  Scenario 
* Visual Studio 2008 porta con sé alcune novità per gli sviluppatori, non solo nell' IDE ma anche e soprattutto per i linguaggi .NET. 
* **LINQ** (Language INtegrated Query) è il risultato di questa evoluzione offrendo un framework con cui scrivere codice che accede a diverse sorgenti dati con una sintassi simile a quella usata con l'SQL. Le estensioni al linguaggio consentono di usare un nuovo modello di programmazione sia che si stia accedendo a collezioni di oggetti, a nodi XML o a dati relazionali. LINQ offre un modello di programmazione che si integra fortemente nei linguaggi .NET in modo "strongly typed" e senza rinunciare all'IntelliSense.
![LINQ](../Upload/cc299390_linq(it-it%2cMSDN_10).jpg)

##  Tecnologie, Strumenti, Overview 
* Esistono già un certo numero di implementazioni e provider per lavorare con LINQ.
    * **LINQ to SQL**: è una delle implementazioni di LINQ che sono state rilasciate con Visual Studio 2008. LINQ to SQL è il modo più semplice per poter lavorare con SQL Server usando un nuovo modello di programmazione in C# 3.0 e Visual Basic 9. E' a tutti gli effeti un **O/RM** (object relational mapper). In questo modo nel nostro linguaggio .NET preferito scriviamo del codice che si avvicina ad una sintassi SQL rendendo di fatto meno complicato far "parlare" le nostre applicazioni fatte di classi, clicli e quant'altro con SQL Server, un DBMS relazionale in cui "vediamo" solo tabelle
    * **LINQ to Object** permette di effettuare query di ricerca su collezioni di oggetti in memoria
    * **Linq to XML** permette di lavorare sui file xml
    * **LINQ to Entities** è un'altra implementazione di LINQ fatta per parlare con l' ADO.NET Entity Framework (EF), sia l'EF che LINQ to Entities sono attualmente in Beta. L'EF è un framework che consentirà agli sviluppatori di lavorare con un maggior livello di astrazione; cioè uno sviluppatore si concentrerà solo sul modello concettuale proprio del modello Entità-Relazione, in maniera indipendente dallo storage sottostante sia esso SQL Server o un altro database.
    * **LINQ for Flickr** è un provider per [Flickr](http://www.flickr.com) per ospitato su Codeplex, vedi rif.

##  Vantaggi 
* Riduce i tempi di sviluppo
* Ottimo per creare velocemente le chiamate alle stored procedure

##  Svantaggi 
* Possibili problemi di performace dovuti a query di interrogazioni generate in automatico.

##  Riferimenti 
* [MSDN - LINQ: .NET Language-Integrated Query](http://msdn.microsoft.com/en-us/library/bb308959.aspx)
* [Scott Guthrie Blog: LINQ to SQL](http://weblogs.asp.net/scottgu/archive/2007/07/16/linq-to-sql-part-5-binding-ui-using-the-asp-linqdatasource-control.aspx)
* [LINQ for Flickr](http://www.codeplex.com/LINQFlickr/Release/ProjectReleases.aspx?ReleaseId=10825)
* [Percorso Formativo](http://msdn.microsoft.com/it-it/vbasic/cc299390.aspx )
* [Panoramica di Linq](http://programminghacks.net/2008/03/07/linq-panoramica-delle-funzionalita/)
* [Esempio sviluppo con linq](http://weblogs.asp.net/scottgu/archive/2007/05/19/using-linq-to-sql-part-1.aspx )
* [Introduzione a linq](http://aspnet.html.it/articoli/leggi/2527/introduzione-a-linq/)


##  Download 
* [<span style="text-decoration:underline">Scarica</span> i **lucidi** in PowerPoint](../Upload/NET_LINQ\Lucidi.rar)
* [<span style="text-decoration:underline">Scarica</span> il **progetto** di esempio](../Upload/NET_LINQ\Esempio Progetto Linq.rar)
