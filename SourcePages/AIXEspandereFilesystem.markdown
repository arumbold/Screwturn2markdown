Per prima cosa si deve verificare la disponibilita' di spazio.
Per farlo utilizzare il seguente comando:

`{{lsvg rootvg`}}

esempio di output:

`{{
VOLUME GROUP:   rootvg                   VG IDENTIFIER:  005c431d00004c00000000ff26803576
VG STATE:       active                   PP SIZE:        64 megabyte(s)
VG PERMISSION:  read/write               TOTAL PPs:      1084 (69376 megabytes)
MAX LVs:        256                      '''FREE PPs:       170 (10880 megabytes)'''
LVs:            18                       '''USED PPs:       914 (58496 megabytes)'''
OPEN LVs:       16                       QUORUM:         2
TOTAL PVs:      2                        VG DESCRIPTORS: 3
STALE PVs:      0                        STALE PPs:      0
ACTIVE PVs:     2                        AUTO ON:        yes
MAX PPs per PV: 1016                     MAX PVs:        32
LTG size:       128 kilobyte(s)          AUTO SYNC:      no
HOT SPARE:      no                       BB POLICY:      relocatable
`}}

Nell'esempio sopra riportato i dati che ci interessano è il **FREE PPs** ovvero le partizioni fisiche disponibili.
Quindi in questo caso possiamo disporre di 1 Gb (10880 megabytes) di spazio da utilizzare.

A questo punto eseguiamo il comando per l'estensione della partizione.
Supponiamo di dover espandere il filesystem / (root) perchè è arrivato al 100% si occupazione.

In questo caso, dopo essersi loggati come utenti root, digitiamo il seguente comando:

`{{smit fs`}}

Comparirà una interfaccia a caratteri. A questo punto seguire le seguenti voci di menu:

* Add / Change / Show / Delete File Systems
* Journaled File System
* Change / Show Characteristics of a Journaled File System

A questo punto aumentare il valore di 

`{{Number of units`}}

Attenzione il valore e' espresso in blocchi (1 blocco = 512 bytes)
Dopo aver cambiato il valore confermare premendo invio.
In seguito per uscire dall'interfaccio premere in sequenza ESC+0

A questo punto se si ridigita il comando **lsvg rootvg** viene riproposta la pagina iniziale in cui si notera' che il numero delle Partizioni fisiche si sara' ridotto.
