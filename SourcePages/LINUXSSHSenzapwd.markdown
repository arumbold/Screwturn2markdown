Per farlo seguite le seguenti istruzioni:

Sotto la home dell'utente che si vuole abilitare esiste una dir che si chiama ./.ssh.  

Tale dir viene creata a seguito del comando :

`{{
ssh-keygen -t XXXXXX
`}}

dove al posto di XXXXXX deve essere specificata la tipologia di crittografica che si vuole utilizzare. Viene richiesto anche un "passphrase" che non deve essere specificato. Chiaramente nella maggior parte dei sistemi tale directory esiste già, e altri sistemi già lavorano con la chiave pubblica conosciuta del sistema di partenza.
Quindi cancellare tale dir e ricreare la chiave potrebbe causare squilibri negli script che già funzionano, quindi **ATTENZIONE**.

All'interno di tale directory sono presenti vari file, questi quelli IMPORTANTI che ci servono:

`{{known_hosts
id_rsa.pub
authorized_keys
`}}
    
* Nel primo sono specificati tutti gli host che la prima volta si collegano alla macchina (avete presente il messaggio che appare nel putty ad esempio la prima volta che vi collegate ad un nuovo host??).
* Il secondo non è altro che la chiave pubblica generata (in questo caso del tipo rsa).
* Nel terzo sono specificate le associazioni chiave pubblica/host abilitate all'ssh sulla macchina (senza pwd).

Nel caso di suse8 è necessario accodare il contenutno del file id_rsa.pub della macchina sorgente al file authorized_keys della macchina destinazione, ad esempio

`{{
scp /HOMEUTENTE/.ssh/id_rsa.pub HOSTDEST:/tmp
ssh HOSTDEST
cat /tmp/id_rsa.pub >> /HOMEUTENTE/.ssh/authorized_keys
`}}

Nel caso di suse9 un comando ci facilita la vita:

`{{
ssh-copy-id -i ./.ssh/id_rsa.pub utente@macchinadestinazione
`}}

Per verificare il corretto funzionamento, provate a fare un ssh da macchina sorgente a destinazione, non deve chiedere pwd.
