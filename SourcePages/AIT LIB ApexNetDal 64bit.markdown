
## Utilizzo ApexNetDAL in macchina a 64 bit
Per utilizzare la ApexNetDal rilasciato alla versione 02.00.0.1 è necessario utilizzare OracleDataAccess.dll in quanto la dll ha dei riferimenti alla dll di oracle. Nelle installazioni con server a 32 bit è necessario utilizzare OracleDataAccess.dll alla versione 2.102.2.20, nei server a 64 bit la prima versione OracleDataAccess.dll è 2.102.3.2.
Quindi nelle installazioni a 64 bit è necessario sostituire la dll se essa è posizionata nella bin.

## Senari che si possono avere nella macchina 64 bit
1. Client oracle installato. In questo caso le policies di oracle redirigono tutte le versioni precedenti alla versione 2.102.3.2.

2. Client oracle non installato.In questo caso è necessario inserire nel machine.config il seguente codice:

     xml
    <runtime>
    		<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
    			<dependentAssembly>
    				<assemblyIdentity name="Oracle.DataAccess" publicKeyToken="89b483f429c47342" />
    				<bindingRedirect oldVersion="2.102.2.20" newVersion="2.102.3.2" />
    			</dependentAssembly>
    		</assemblyBinding>
    </runtime>

