

# TODO

L'elenco delle cose che dovrei aggiungere in questa guida prima di pubblicarla.

1. L'implementazione attuale richiede un'istanza dedicata di `WRP3` per ogni application installato (anche se questo limita la capacita' di servire piu' di un applicazione di `WRP2`)
2. Le proprieta' `TranslateTextFieldPrefix` e `TranslateFormulaFieldPrefix` in `app.config`

# Globalizzazione e Localizzazione dei Report

A partire da `WRP 3.0.0.0` e' possibile avere report tradotti in piu' lingue, attraverso i file `resx`, se questi report vengono creati come spiegato.

# Obiettivo

Questa guida spiega come modificare un report precedentemente creato in modo che si possa applicare la traduzione automatica. Le stesse metodologie si possono applicare anche sui report nuovi.

# Note Importanti

La versione di `Crystal Reports` usato in questa guida e' `12.0.0.683`, quindi potrebbe essere necessario salvare i vostri report vecchi con questa versione prima di fare delle modifiche.

# Procedimento

1. Analizzeremo prima i vari componenti che prendiamo in considerazione
2. Crearemo i file `resx` utilizzando la Windows Application `ApexNetReportResources` (trovato in `SVN` nel percorso `https://tangeri.apex-net.it/svn/ApexNetProjects/AIT/Sviluppo/LIB/trunk/`)
3. Installeremo e configureremo un'istanza di `WRP3`
4. Installeremo i file `resx` in `WRP3`

# Componenti

`{{
'''NOTA BENE:''' Per qualsiasi componente aggiunto nel report, se questo non si vuole che sia tradotto,
allora su questo elemento non occorre applicare nessun tipo di modifica!
`}}

I seguenti componenti sono stati presi in considerazione:

## Text Object

`{{
'''NOTA BENE:''' Qualsiasi {{Text Object` che si vuole tradurre e che contiene elementi diversi dal puro testo
(ad es. `Formula Field`, `Database Field`, ecc.) dovra' essere sostituito con un `Formula Field` [come spiegato](#formula_field)!
}}}}

Per rendere un `Text Object` traducibile basta cambiare l'`Object Name` dell'oggetto:

1. Click destro sull'object in questione (direttamente nella modalita' `Design` od altrimenti dal `Report Explorer`)
2. Selezionare `Format Text` dal menu
3. Andare sulla scheda `Common`
4. Dare un nome che abbia come sintassi `<esc><TranslateTextFieldPrefix><UnNomeUnico></esc>`, dove `TranslateTextFieldPrefix` ha il valore di default `TT_`

Esempio:

![](../Upload/GLOB_LOC_Crystal_Report/001.PNG)
![](../Upload/GLOB_LOC_Crystal_Report/002.PNG)

## Formula Field


Per quanto riguarda il contenuto dei `Formula Field` non occorrono delle modifiche particolari. E' sufficiente che il codice sia valido e quindi non contenga errori di sintassi, formattazione e/o dati.

Per rendere un `Formula Field` traducibile basta cambiare il suo nome:

1. Click destro sul `Formula Field` in questione in `Field Explorer`
2. Selezionare `Rename` dal menu
3. Dare un nome che abbia come sintassi `<esc><TranslateFormulaFieldPrefix><UnNomeUnico></esc>`, dove `TranslateFormulaFieldPrefix` ha il valore di default `TF_`

Esempio:

![](../Upload/GLOB_LOC_Crystal_Report/003.PNG)
![](../Upload/GLOB_LOC_Crystal_Report/004.PNG)

`{{
Anche se dal punto di applicativo non vi sono problemi, e' consigliato racchiudere le stringhe
fra doppie apici (ad es.: "{{foo"`) e concatenare vari elementi con il simbolo `&` (ad es.: `"foo" & "bar"`,
`<esc>{foo}</esc> & "bar"`). Questo e' importante, perche' chi fara' la traduzione puo' non avere
una buona conoscenza di programmazione e quindi risulta importante avere una sintassi coerente.

In alternativo si possono utilizzare l'apice singola per le stringhe ed il carattere `+` per la concatenazione.
}}}}

## Subreport

## Cross-Tab

# ApexNetReportResources

# Installazione & Configurazione

<!-- End of file -->
