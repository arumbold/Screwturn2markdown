
`{{ FormatMessage(Testo, Par1, Par2, Par3, Par4, Par5) `}}

Questa funzione permentte di creare concatenazioni di stringhe senza dover aggiungere come costanti i vari token della stringa.

Per fare un esempio, se dovessimo creare la seguente stringa:

`{{ La Fattura num. 18 del 26/12/1999 è stata eliminata `}}

con il metodo tradizionale, dovremmo fare cosi:

`{{

Dim const1 string
Dim const2 string
Dim const3 string


Dim NumFattura as integer
Dim DataFattura as string


const1 = "La Fattura num."
const2 = "del"
const3 = "è stata eliminata"
NumFattura = 18
DataFattura = "26/12/1999"


a = MessageBox(const1 + " " + cStr(NumFattura) + " " + const2 + " " + DataFattura + " " + const2) `}}

con la funzione **FormatMessage** invece, l'implementazione è molto più semplice, ovvero:

`{{
Dim const1 string


Dim NumFattura as integer
Dim DataFattura as string


const1 = "La Fattura num.|1 del |2 è stata eliminata"


NumFattura = 18
DataFattura = "26/12/1999"


a = MessageBox(FormatMessage(const1, cStr(NumFattura), DataFattura) `}}

In pratica per ogni occorrenza di **|1, |2,... |5** presente nella stringa **Testo**, la funzione esegue una sostituzione del token con i relativi **Par1, Par2,... Par5**
