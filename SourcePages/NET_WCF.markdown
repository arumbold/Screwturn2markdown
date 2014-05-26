##  Scenario 
![ WCF Components](../Upload/WCF_Components.jpg)
* Nel corso degli anni sono state sviluppate molte tecnologie con lo scopo di realizzare applicazioni distribuite, in grado di comunicare via rete attraverso lo scambio di messaggi. Grazie a queste tecnologie, un'applicazione (definita **Client**) può scambiare messaggi o ricevere dati e risorse da un apposito **servizio**, raggiungibile dalla rete grazie ad un apposito protocollo di comunicazione (tcp, http, ...).
* Nel mondo Microsoft sono state sviluppate diverse tecnologie: Micorsoft Messaging Queue, Web Services, .NET Remoting. Queste tecnologie hanno un **limite: un'applicazione può comunicare con i servizi solo se entrambi utilizzano la stessa tecnologia**. Windows Communication Foundation (**WCF**) si propone come un **modello unificato** di programmazione per **tutte le applicazioni distribuite**, che raggruppa tutte le funzionalità di trasmissione dei dati, permettendone la facilità di realizzazione lato client e lato server.

##  Overview, Strumenti 
* In WCF lo scambio di messaggi tra applicazione client e servizio avviene tramite i cosiddetti **Endpoints**.
* L**'ABC** di WCF: ogni Endpoint è suddiviso in tre parti fondamentali.
    * **Address** (Dove): l'indirizzo a cui si trova il servizio, ad esempio un URI 
    * **Binding** (Come): è la vera punta di diamante del WCF, infatti si preoccupa di trasformare e trasmettere le nostre informazioni nel protocollo da noi prescelto: http, https, tcp, ecc. In questo modo possiamo sviluppare il nostro servizio senza preoccuparci del modo in cui comunicherà; il Binding inoltre ha il compito di salvaguardare la sicurezza del messaggio, dichiarando dei Behavior per la trasformazione delle nostre informazioni in formato sicuro
    * **Contract** (Cosa): nel Contract vengono definiti i metodi e le proprietà che fanno parte del nostro servizio; per descriverne la struttura è necessario dichiarare una interfaccia che, come un vero contratto, dovrà indicare quali informazioni e quali operazioni saranno rese accessibili ai client che interrogheranno il servizio utilizzando degli attributi, nello specifico:
*** OperationContract (Metodi del servizio utilizzabili dai client)
*** DataContract (Strutture dati come classi, enum e struct)
*** DataMember (Proprietà pubbliche del servizio)
![WCF Endpoints](../Upload/WCF_Endpoints.jpg)
* Si rimandano gli argomenti più articolati come le **Callback** (situazioni in cui è il servizio a dover inviare messaggi al client, come ad esempio in applicazioni di chat o messagistica istantanea) e la **Sicurezza** ai Riferimenti più sotto. 
* Si può utilizzare come IDE sia Visual Studio .NET 2005 sia **Visual Studio .NET 2008**. Per il 2005 è necessario installare sul sistema operativo il Windows SDK, il 2008 invece è già pronto per lo sviluppo con WCF.

##  Specifiche 
* WCF supporta le specifiche  WS-* (definite da Microsoft, IBM, SUN e altre grandi compagnie)

##  Sicurezza 
* WCF si occupa delle seguenti 4 "feauteres" riguardanti la sicurezza:
    * **Confidentiality**
    * **Integrity**
    * **Authentication**
    * **Authorization**
* WCF ha la capacità di applicare la sicurezza a livello sia del trasporto (i.e. protocol level) sia del messaggio (i.e. data).

![WCF Transport/Message](../Upload/WCF_SecTransportMessage.jpg)

##  Esempi 
* Esempio di porzione di web.config dove è presente la configurazione del servizio WCF ospitato da applicazione WEB ASP.NET
     XML
       <system.serviceModel>
            <behaviors>
                <serviceBehaviors>
                    <behavior name="myOracleServiceBehavior">
                        <!-- To avoid disclosing metadata information, set the value below to false and remove the metadata endpoint above before deployment -->
                        <serviceMetadata httpGetEnabled="true" />
                        <!-- To receive exception details in faults for debugging purposes, set the value below to true.  Set to false before deployment to avoid disclosing exception information -->
                        <serviceDebug includeExceptionDetailInFaults="false" />
                    </behavior>
                </serviceBehaviors>
            </behaviors>
            <services>
                <service behaviorConfiguration="myOracleServiceBehavior" name="myOracleService">
                    <!-- Service Endpoints -->
                    <endpoint address="" binding="wsHttpBinding" contract="ImyOracleService">
                      <!-- 
                      Upon deployment, the following identity element should be removed or replaced to reflect the 
                      identity under which the deployed service runs.  If removed, WCF will infer an appropriate identity 
                      automatically.
                      -->
                      <identity>
                            <dns value="localhost" />
                        </identity>
                    </endpoint>
                    <endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange" />
                </service>
            </services>
        </system.serviceModel>

* Esempio di un "app.config", autogenerato dall'IDE per un client WCF che si collega ad un webservice remoto esposto tramite AXIS (tecnologia Java) ed internamente implementato in Powerbuilder:
     XML
    <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
        <system.serviceModel>
            <bindings>
                <basicHttpBinding>
                    <binding name="n_gs_00_010_segnalazioni_s" closeTimeout="00:01:00"
                        openTimeout="00:01:00" receiveTimeout="00:10:00" sendTimeout="00:01:00"
                        allowCookies="false" bypassProxyOnLocal="false" hostNameComparisonMode="StrongWildcard"
                        maxBufferSize="65536" maxBufferPoolSize="524288" maxReceivedMessageSize="65536"
                        messageEncoding="Text" textEncoding="utf-8" transferMode="Buffered"
                        useDefaultWebProxy="true">
                        <readerQuotas maxDepth="32" maxStringContentLength="8192" maxArrayLength="16384"
                            maxBytesPerRead="4096" maxNameTableCharCount="16384" />
                        <security mode="None">
                            <transport clientCredentialType="None" proxyCredentialType="None"
                                realm="" />
                            <message clientCredentialType="UserName" algorithmSuite="Default" />
                        </security>
                    </binding>
                </basicHttpBinding>
            </bindings>
            <client>
                <endpoint address="http://patroclo:8080/ws/services/n_gs_00_010_segnalazioni_s"
                    binding="basicHttpBinding" bindingConfiguration="n_gs_00_010_segnalazioni_s"
                    contract="ServiceReferenceWsGs.n_gs_00_010_segnalazioni_s"
                    name="n_gs_00_010_segnalazioni_s" />
            </client>
        </system.serviceModel>
    </configuration>


##  Note e soluzioni ad alcuni problemi 

* When you're hosting WCF services within IIS 5 or 6 you can only use bindings that use the HTTP protocol, we can't use like the TCP or NamedPipes bindings etc.

* IIS 7 has WAS (Windows Process Activation Service) and that will allow to use other bindings.

* Hosting WCF - .svc Files in IIS7 (HTTP Error 404.3 - Not Found) => <http://thesherpaproject.com/2007/01/11/hosting-wcf-svc-files-in-iis7/>

* Se avete IIS 6 e non riuscite ad aprire il file .svc, provate le soluzioni proposte in questo articolo:
  <http://msdn.microsoft.com/en-us/library/ms752252.aspx>

    cd "C:\Windows\Microsoft.NET\Framework\v3.0\Windows Communication Foundation"
    ServiceModelReg.exe -i
    Microsoft(R) Windows Communication Foundation Installation Utility
    [Microsoft (R) Windows (R) Communication Foundation, Version 3.0.4506.4037]
    Copyright (c) Microsoft Corporation.  All rights reserved.
    
    Installing: Machine.config Section Groups and Handlers
    Installing: System.Web Build Provider
    Installing: System.Web Compilation Assemblies
    Installing: HTTP Handlers
    Installing: HTTP Modules
    Installing: ListenerAdapter node for protocol net.tcp
    Installing: Protocol node for protocol net.tcp
    Installing: TransportConfiguration node for protocol net.tcp
    Installing: ListenerAdapter node for protocol net.pipe
    Installing: Protocol node for protocol net.pipe
    Installing: TransportConfiguration node for protocol net.pipe
    Installing: ListenerAdapter node for protocol net.msmq
    Installing: Protocol node for protocol net.msmq
    Installing: TransportConfiguration node for protocol net.msmq
    Installing: ListenerAdapter node for protocol msmq.formatname
    Installing: Protocol node for protocol msmq.formatname
    Installing: TransportConfiguration node for protocol msmq.formatname
    Installing: HTTP Modules (WAS)
    Installing: HTTP Handlers (WAS)


###  WCF Test Client (WcfTestClient.exe) 

Windows Communication Foundation (WCF) Test Client (WcfTestClient.exe) is a GUI tool that enables users to input test parameters, submit that input to the service, and view the response that the service sends back. It provides a seamless service testing experience when combined with WCF Service Host.

Esempi di utilizzo:

* Visual Studio 2008 Command Prompt => `WcfTestClient.exe <one mex or wsdl url>`
* `"C:\Program Files\Microsoft Visual Studio 9.0\Common7\IDE\WcfTestClient.exe" http://localhost/up/trunk/up_web_sln/up_ws/Services/__ImportService.svc/mex__`
* `"C:\Program Files\Microsoft Visual Studio 9.0\Common7\IDE\WcfTestClient.exe" http://localhost/up/trunk/up_web_sln/up_ws/Services/__ImportService.svc__`
* `"C:\Program Files\Microsoft Visual Studio 9.0\Common7\IDE\WcfTestClient.exe" http://localhost/up/trunk/up_web_sln/up_ws/Services/__ImportService.svc?wsdl__`

###  Configuration Editor Tool (SvcConfigEditor.exe) 

The Windows Communication Foundation (WCF) Service Configuration Editor (SvcConfigEditor.exe) allows administrators and developers to create and modify configuration settings for WCF services using a graphical user interface. With this tool, you can manage settings for WCF bindings, behaviors, services, and diagnostics without having to directly edit XML configuration files.

Esempi di utilizzo:

* Visual Studio 2008 Command Prompt => `SvcConfigEditor.exe`
* `"C:\Program Files\Microsoft SDKs\Windows\v6.0A\bin\SvcConfigEditor.exe"` => File > Open ... Selezionare app.config oppure web.config del progetto.

##  Riferimenti 
* [MSDN - WCF](http://msdn.microsoft.com/en-us/library/ms735119.aspx)
* [WCF Binding Comparison](http://www.pluralsight.com/community/blogs/aaron/archive/2007/03/22/46560.aspx)
* [Codeproject WCF : 10 security related FAQ](http://www.codeproject.com/KB/WCF/WCFFAQPart3.aspx)
