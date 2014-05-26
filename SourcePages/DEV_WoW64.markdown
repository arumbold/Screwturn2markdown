
##  Scenario 
* E' possibile, per vari motivi, di essere costretti a far girare applicazioni a 32 bit su server a 64 bit (sistemi windows) 

##  WOW  
* Windows On Windows 64-bit (chiamato anche un windows dentro windows a 64 bit) è un sottosistema (subsystem) del sistema operativo Microsoft capace di far funzionare le applicazioni native a 32 bit ed è incluso in tutte le versioni di Windows a 64 bit
* **IIS 6.0** permette di far correre 32-bit Web applications su 64-bit Windows usando il layer di compatibilità **WOW64** a livello di server (occorre però ricordare che IIS 6 non permette di far correre processi di lavoro a 32-bit e a 64-bit contemporaneamente sullo stesso server)
* Esempio di configurazione di IIS 6 per gestire work process .net a 32 o 64 bit 
    
    ### a 32 bit
    cscript %SystemDrive%\inetpub\AdminScripts\adsutil.vbs set w3svc/AppPools/Enable32bitAppOnWin64 1
    iisreset
    %windir%\Microsoft.NET\Framework\v2.0.50727\aspnet_regiis -i
    ### a 64 bit
    cscript %SystemDrive%\inetpub\AdminScripts\adsutil.vbs set w3svc/AppPools/Enable32bitAppOnWin64 0
    iisreset
    %windir%\Microsoft.NET\Framework64\v2.0.50727\aspnet_regiis -i
 
* **IIS 7.0** (presente su windows server 2008 oltre che su windows vista) **permette di far correre worker process a 32 e 64 bit simultaneamente ** sullo stesso server, poichè il layer di compatibilità WOW64 è configurabile a livello di singolo application pool (basta andare in impostazioni avanzate e spuntare il corrispondente flag) [II7 Config. Example](../Upload/ExampleWebServer_Win2008_64bit.JPG)

##  Caso: Crystal Report  
* Crystal Reports 2008 (sp0 - 12.0) supporta Windows Server 2003 64 bit attraverso la compatibilità WOW
* Crystal Reports 2008 Basic (10.5, è la versione embedded per Visual Studio 2008) supporta l'esecuzione di applicazioni su computer a 64 bit. E' necessario installare il corrispondente runtime a 64 bit Crystal Reports per l'ambiente a 64 bit

##  Riferimenti 
* [Compatibilità WOW64 per applicazioni Web in IIS 6.0 a 32 bit](http://support.microsoft.com/?id=895976)
* [Crystal Reports Basic per Visual Studio - Configurazione dello sviluppo di applicazioni a 64 bit](http://msdn.microsoft.com/it-it/library/ms225583.aspx)
* [Tips Tricks WOW64](http://alsolorzano.com/blogs/tips__tricks/archive/2008/02/04/64-bit-windows-or-32-bit-windows.aspx)
