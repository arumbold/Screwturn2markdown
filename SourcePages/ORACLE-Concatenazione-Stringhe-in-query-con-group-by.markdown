Non esiste però nessuna funzione nativa documentata che esegua la concatenazione di stringhe.

Il problema si può arginare in diversi modi.

Prendiamo come esempio una vista che mette in relazione un progetto con i suoi finanziatori:

    SELECT id_progetto, denominazione_ab FROM v_xm_pj01_finanziatori_prog
    order by id_progetto asc


    ID_PROGETTO            DENOMINAZIONE_AB                                                                                                                                                                  
    ----------------------  
    1                      ZORAT ALESSANDRO                                                                                  
    1                      BOSCHI SIGISMONDO - nome esteso                                                                                 
    2                      GATTO LEO SRL                                                                                             
    2                      ZORAT ALESSANDRO                                                                                                    
    3                      GATTO LEO SRL                                                                              
    3                      BOSCHI SIGISMONDO - nome esteso                                          
    4                      ZORAT ALESSANDRO                                                                                                                                     
    5                      GATTO LEO SRL  
 

#### Prima possibilità

Usare una funzione esterna che concateni i valori stringa: questo è l'approccio più naturale ma può essere oneroso in quanto va eseguita una select per ogni record della tabella che si sta raggruppando.

#### Seconda possibilità

Sfruttare la funzione SYS_CONNECT_BY_PATH.
Questa funzione può essere utilizzata solo in query gerarchiche (CONNECT BY) prende in input una colonna ed un carattere e restituisce il path completa di ogni elemento della colonna data a partire dalla root utilizzando il carattere passato in input come separatore.

    SELECT id_progetto ,
      ltrim(SYS_CONNECT_BY_PATH (denominazione_ab, ','),',') finanziatore
    FROM
      (SELECT ID_PROGETTO,
        DENOMINAZIONE_AB,
        RANK() OVER (partition BY id_progetto order by rownum) num
      FROM v_xm_pj01_finanziatori_prog
      )
    WHERE connect_by_isleaf  =1
      START WITH num         =1
      CONNECT BY PRIOR num+1 = num
    AND prior id_progetto    =id_progetto


Il risultato ottenuto sarà:

    ID_PROGETTO            FINANZIATORE                                                           
    1                      ZORAT ALESSANDRO,BOSCHI SIGISMONDO - nome esteso                                                                                                                              
    2                      GATTO LEO SRL,ZORAT ALESSANDRO
    3                      GATTO LEO SRL,BOSCHI SIGISMONDO - nome esteso                                                                                                               
    4                      ZORAT ALESSANDRO                           
    5                      GATTO LEO SRL 


Per ulteriori informazioni e approfondimenti si rimanda al post del blog [oracleitalia](http://oracleitalia.wordpress.com/): [Concatenare i valori di piu record](http://oracleitalia.wordpress.com/2009/12/03/concatenare-i-valori-di-piu-record/).
