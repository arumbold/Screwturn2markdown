
    
    #!/bin/sh
    
    #===================================================================
    # Apex-net srl 
    #                                                                   
    # Name     : Export.sh                                              
    # Author   : Stefano Teodorani, 29/05/2003 17.17                    
    # Synopsis : Export utente database Oracle in pipe
    # Source   : http://www.apex-net.it                                 
    #===================================================================
    
    
    . /home/oracle/.profile
    
    
    export ORACLE_SID=REPO
    export mailto=nomeutente@apex-net.it
    
    
    DAY=`date +%w`
    DIR=/mnt/bck/DATABASE/EXPORT/REPO/$DAY
    
    
    fifo=/tmp/temp_fifo.dmp
    file=$DIR/oltp_expfull.dmp.gz
    log=$DIR/oltp_expfull.log
    
    
    mkfifo $fifo
    
    
    gzip <$fifo >$file &
    exp system/lore01@REPO full=y file=$fifo log=$log buffer=300000 compress=N statistics=none
    
    
    if ( test $? = 0 ) then
      mail -s "$ORACLE_SID Salvataggio OK" $mailto < $log
    else
      mail -s "$ORACLE_SID Salvataggio KO - ERRORE !!!" $mailto < $log
    fi
    
    rm $fifo


Il file esportato in questo modo viene compresso durante l'export e necessita di poco spazio sul filesystem
