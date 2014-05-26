
## Scenario 

* Verificare la compatibilità dei software di sviluppo di Apex-net con il sistema operativo windows 7 (x86)
* Le versioni dei software sono generalmente disponibili su DVD/CD, file servers Apex-net; in caso contrario verranno indicati gli appositi links
* Le versioni dei seguenti software sono da intendersi compatibili, salvo esplicita indicazione **(*)**, anche con le versioni di windows vista sp2 e xp sp3

## Strumenti Sviluppo 
* Visual Studio 2005 Professional (ok)
    * sp/update: sp1 / update sp1 per vista **(*)** - stesso update anche per windows 7 **(*)**
* Visual Studio 2008 Team system Developer (ok)
    * sp/update: sp1 / [Hot fix KB960075- VS Dev Environment crash after undocking windows or changing layouts](http://code.msdn.microsoft.com/KB960075)
* Visual Studio 2010 Ultimate (ok)
* Sqlserver 2005 Developer (ok)
    * sp/update: sp3
* Sqlserver 2008 Developer (ok)
    * sp/update: sp1 / [Hot fix 975055](http://support.microsoft.com/kb/975055/en-us)
    * **N.B.: occorre creare un nuovo setup** [Create cumulative setup: sql2008 + sp + cumulative update](http://blogs.msdn.com/petersad/archive/2009/04/16/create-a-merged-slipstream-drop-containing-sql-server-2008-server-pack-1-and-a-cumulative-update-cu-based-on-server-pack-1.aspx); su file server/service packs esiste già un esempio adattabile per architetture x86, questa cosa vale esclusivamente per windows 7 **(*)**
Nota: Per effettuare l'installazione copiare la cartella presente su \\sandiego\software\SERVICE_PACK_PATCH\SQL_Server_2008 in una cartella in locale chiamata c:\temp_install
* INDE 6.9 (ok)
* INDE 9.0 (ok)
* Visual Source Safe 2005 (ok)
* VisualSVN-2.0.x/TortoiseSVN-1.6.9 (ok)
    * ATTENZIONE__: bisogna seguire i seguenti passi nel caso di upgrade da versioni 1.7.x:
*** Disinstallare le vecchie versioni di Tortoise e VisuaSVN
*** eseguire un reboot
*** installare le nuove versioni Tortoise e VisualSVN
*** eseguire un reboot
* Crystal Report 2008 (ok)
    * sp/update: sp2
* Devexpress 2010.1 (ok)
* Oracle 11.x e client tools (ok)
    * Client Oracle 11.1.0.7/ Oracle Developer Tools - ODT with ODAC 11.1.0.7.20 
    * Client Oracle 11.2.0.1 / Oracle Developer Tools - ODT with ODAC 11.2.0.1.2 (support for Visual studio 2010)
    * Toad 10.1
    * Oracle Sql Developer - 2.1.1
* Erwin 4.1 (ok)

## Connettività 
* Cisco Client 5.x (ok)

## Varie 
* Office 2007 (ok)
    * sp/update: sp2
* Virtual Box 3.x (ok) [http://www.virtualbox.org/](http://www.virtualbox.org/)


## Riferimenti 
* [windows 7](http://www.microsoft.com/windows/windows-7/)
