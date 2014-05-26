diverso su Oracle (ADD_MONTHS($date, $months)) rispetto a Sql Server (DATEADD ( MONTH , $months, $date )).

In particolare su oracle se si passa una data ad ADD_MONTHS che corrisponde all'ultimo giorno del mese, restituisce sempre
l'ultimo giorno del mese richiesto, indipendentemente dal numero reale di giorni nei vari mesi. Per capirci se passiamo il 28 febbraio alla funzione e aggiungiamo 1 mese, in oracle otteniamo il 31 marzo, in sql server il 28 marzo; il comportamento non è propriamento un 'errore', ma più un 'punto di vista' diverso, per cui non è né modificabile né configurabile.

Per coloro che avessero la necessità in oracle di ottenere un risultato simile a sql server, è necessario crearsi una
funzione apposita. Riporto qui sotto un esempio (new_add_months) di funzione che restituisce sempre lo stesso giorno di partenza nel mese di arrivo (a meno che il giorno di partenza non sia superiore al numero di giorni del mese di arrivo):

    
    CREATE OR REPLACE FUNCTION new_add_months (date_in IN DATE, months_shift IN
    NUMBER)
       RETURN DATE
    IS
       /* Return value of function */
       return_value DATE;
    
       /* The day in the month */
       day_of_month VARCHAR2(2);
    
       /* The month and year for the return value */
       month_year VARCHAR2(6);
    
       /* The calculated end of month date */
       end_of_month DATE;
    BEGIN
       return_value := ADD_MONTHS (date_in, months_shift);
    
       /* Is original date the last day of its month? */
       IF date_in = LAST_DAY (date_in)
       THEN
          /* Pull out the day number of the original date */
          day_of_month := TO_CHAR (date_in, 'DD');
    
          /* Grab the month and year of the new date */
          month_year := TO_CHAR (return_value, 'MMYYYY');
    
          /* Combine these components into an actual date */
          BEGIN
             end_of_month := TO_DATE (month_year || day_of_month, 'MMYYYYDD');
             /*
             || Return the earliest of (a) the normal result of ADD_MONTHS
             || and (b) the same day in the new month as in the original month.
             */
             return_value := LEAST (return_value, end_of_month);
          EXCEPTION
             WHEN OTHERS THEN NULL;
          END;
       END IF;
    
       /* Return the shifted date */
       RETURN return_value;
    END new_add_months;
    /
    
    


**Esempio di differenze tra ADD_MONTHS e NEW_ADD_MONTHS:**

select ADD_MONTHS('31-JAN-1995', 1) from dual # > 28-FEB-1995
select NEW_ADD_MONTHS('31-JAN-1995', 1) from dual > 28-FEB-1995

select ADD_MONTHS ('28-FEB-1994', 2) from dual # > 30-APR-1994
select NEW_ADD_MONTHS ('28-FEB-1994', 2) from dual > 28-APR-1995
