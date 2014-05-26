Quando viene fatto un upload di file superiori a 4 mega parte l'upload e poi rimane in standby senza far nulla.

## Cause 
Il problema e' dovuto ad un comportamento predefinito del framework .NET, infatti le applicazioni .NET limitano, per ragioni di sicurezza, la dimensione dei files che e' possibile ricevere in upload. Di dafault questo limite e' posto a 4 mega.

## Soluzione 
Come descritto nell'articolo, riportato qui sotto nei riferimenti, si puo' impostare un limite superiore definendolo nel file Web.config (o, in alternativa, nel Machine.config) la seguente sessione 

    <httpRuntime maxRequestLength="" />

a un nuovo valore. 
Ad esempio se si vuole impostare fino a 65 mega si configurera' nel seguente modo 

    <httpRuntime maxRequestLength="65536"/>

Il valore massimo che può raggiungere, nel Framework 2.0, è 2GB ossia 
    <httpRuntime maxRequestLength="2097151"/>

**Proprieta del httpRuntime**

Element configures ASP.NET HTTP runtime settings.
Attribute name Description 
**maxRequestLength** Attribute indicates the maximum file upload size supported by ASP.NET. 
This limit can be used to prevent denial of service attacks caused by users posting large files to the server. 
The size specified is in kilobytes. The default is "4096" (4 MB).
Max value is "1048576" (1 GB) for .NET Framework 1.o and 1.1 and "2097151" (2 GB) for .NET Framework 2.0.
PowUpload ignores this parameter if ignoreHttpRuntimeMaxRequestLength set to "true" and supports up to 4 GB requests (limited by IIS) but most browsers don't sends greater than 2 GB files. 

**executionTimeout** Attribute indicates the maximum number of seconds that a request is allowed to 
execute before being automatically shut down by ASP.NET. 
The executionTimeout value should always be longer than the amount of time that the upload process can take. (esempio executionTimeout="3600")
    <httpRuntime maxRequestLength="2097151" executionTimeout="3600"/>


## Altre configurazioni per IIS7 
By default in IIS 7 enabled requestFiltering that have MaxAllowedContentLength property. It specifies, in bytes, the maximum length of content in a request. The default is 30000000 (approximately 30 megabytes.) To change this value you must include following code in your Web.config file if you want to apply this setting only to you application. If you want to change this setting for all of the computer and not just this ASP.NET application, you must modify the Machine.config file. By default, the element is set to the following parameters in the Machine.config file: The Machine.config file is located in the \System Root\Microsoft.NET\Framework\Version Number\CONFIG directory.
    <configuration>
       <system.webServer>
          <security>
             <requestFiltering>
                <requestLimits maxAllowedContentLength="100000000"/>  
             </requestFiltering>
          </security>
       </system.webServer>
    </configuration>

If you have error that requestFiltering cannot be overriden you must edit mashine.config file and change string 
    <section name="requestFiltering" overrideModeDefault="Deny" /> 
    to <section name="requestFiltering" overrideModeDefault="Allow" />


## Riferimenti 

<http://support.microsoft.com/default.aspx?scid=kb;EN-US;295626>
<http://www.element-it.com/OnlineHelp/Webconfig.html>
