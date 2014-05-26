capitare che dopo l'installazione di WSE 3.0, Visual Studio 2005 non lo "veda" come AddIn.

Questo perchè di default la cartella di installaizione è quella "inglese" cioè "%documents and settings%\Application Data...",
mentre con tutta probabilità il file dell'AddIn: WSESettingsVS3.Addin è finito in "%Documents and Settings%\All Users\Dati applicazioni\Microsoft\MSEnvShared\Addins".

Per cui dovete aggiungere in "Tools - Options - Add-in/Macros" di VS 2005 il percorso giusto.

Vedi link:

[Forum Geek WSE 3.0](http://geekswithblogs.net/pavelka/archive/2005/11/22/60917.aspx)
