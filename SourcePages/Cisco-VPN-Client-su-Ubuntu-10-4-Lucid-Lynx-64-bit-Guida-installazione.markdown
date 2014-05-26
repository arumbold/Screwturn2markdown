
## Installazione

Il Client Cisco VPN necessita di una patch per la compilazione con il kerner Ubuntu 9.04+.

Se si tenta di installarlo si ottiene il seguente errore:

     bash
    
    [....]
    Error 2
    make[1]: Leaving directory `/usr/src/linux-headers-2.6.31-1-generic'
    make: *** [default] Error 2
    Failed to make module "cisco_ipsec.ko".
    


Ecco i passi da seguire per una corretta installazione:

1) Download del client Cisco VPN 

     bash
    wget http://projects.tuxx-home.at/ciscovpn/clients/linux/4.8.02/vpnclient-linux-x86_64-4.8.02.0030-k9.tar.gz


2) Unpack

     bash
    tar zxf vpnclient-linux-x86_64-4.8.02.0030-k9.tar.gz


3) Download vpnclient-linux-4.8.02-64bit.patch

     bash 
    wget http://projects.tuxx-home.at/ciscovpn/patches/vpnclient-linux-4.8.02-64bit.patch


4) Download vpnclient-linux-4.8.02-64bit.ge.2.6.31.patch

     bash
    wget http://painfullscratch.nl/code/vpn/vpnclient-linux-4.8.02-64bit.ge.2.6.31.patch


5) Posizionarsi sulla directory del client

     bash
    cd vpnclient


6) Applicare la patch

     bash
    patch < ../vpnclient-linux-4.8.02-64bit.patch


7) Applicare la patch con (ge) 2.6.31 o superiore

     bash
    patch < ../vpnclient-linux-4.8.02-64bit.ge.2.6.31.patch


8) A questo punto è necessario modificare i file netdevice.h che si trovano nelle directory /usr/src/linux-headers-{kerner_number}/include/linux/netdevice.h

     bash
    sudo sed -i 's/const\ struct\ net_device_ops\ \*netdev_ops;/struct\ net_device_ops\ \*netdev_ops;/' `find /usr/src -name netdevice.h`


(sostituisce "const struct net_device_ops *netdev_ops;" con "struct net_device_ops *netdev_ops;" come descritto in questo [link](http://forum.tuxx-home.at/viewtopic.php?f=15&t=790) )

9) Finalmente si può installare il client

     bash
    sudo ./vpn_install


## Riferimenti
Questa guida è una sintesi delle guide trovate a questi indirizzi:

<http://www.lamnk.com/blog/vpn/how-to-install-cisco-vpn-client-on-ubuntu-jaunty-jackalope-and-karmic-koala-64-bit/>

[http://www.painfullscratch.nl/code/vpn/](http://www.painfullscratch.nl/code/vpn/)

La patch invece è fornita da:

[tuxx-home.at support forum](http://forum.tuxx-home.at/viewtopic.php?f=15&t=790&sid=0f466816287ec0ec3941772532ab725e)





