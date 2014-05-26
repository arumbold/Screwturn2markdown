
La conseguenza di questa anomalia e' che :

* Vengono girate le date anziche dd/mm/yyyy viene rappresentato mm/dd/yyyy.
* Vengono messi i punti invece della virgola e viceversa e, conseguentemente, registrati male i valori interi sul db. Per esempio se scrivo 8,00 viene registrato 800.

Per risolvere il problema Matteo ha trovato questa soluzione:

1. Creare un file asci con estensione .reg e incollarci il codice riportato in seguito
2. Mettere il file sul server incriminato e cliccarci sopra.

`{{
Windows Registry Editor Version 5.00


[HKEY_USERS\.DEFAULT\Control Panel\International]
"iCountry"="39"
"iCurrDigits"="0"
"iCurrency"="2"
"iDate"="1"
"iDigits"="2"
"iLZero"="1"
"iMeasure"="0"
"iNegCurr"="9"
"iTime"="1"
"iTLZero"="1"
"Locale"="00000410"
"s1159"=""
"s2359"=""
"sCountry"="Italy"
"sCurrency"="€"
"sDate"="/"
"sDecimal"=","
"sLanguage"="ITA"
"sList"=";"
"sLongDate"="dddd d MMMM yyyy"
"sShortDate"="dd/MM/yyyy"
"sThousand"="."
"sTime"="."
"sTimeFormat"="HH.mm.ss"
"iTimePrefix"="0"
"sMonDecimalSep"=""
"sMonThousandSep"="."
"iNegNumber"="1"
"sNativeDigits"="0123456789"
"NumShape"="1"
"iCalendarType"="1"
"iFirstDayOfWeek"="0"
"iFirstWeekOfYear"="2"
"sGrouping"="3;0"
"sMonGrouping"="3;0"
"sPositiveSign"=""
"sNegativeSign"="-"


`}}


