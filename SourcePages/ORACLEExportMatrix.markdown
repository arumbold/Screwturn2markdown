

    
      Subject:  Compatibility Matrix for Export & Import Between Different Oracle
      Versions 
      Doc ID:  Note:132904.1 
    
      ......
    
      1) Always use a version of the EXPORT utility that is equal to the
         lowest version of either the source or the target database.
      ......
      2) With some patchsets the data dictionary export views are also changed.
         As a result it will not be possible to run this patched Export utility
         against an unpatched database. Therefore the same basic rule also applies
      
         to the patchset release: Export the data with the Export utility of the 
         lowest database version involved.
      ......
      3) Always use a version of the IMPORT utility that is equal to the
         version of the target database.
      
      ......
      
      Matrix 2: Which EXPORT utility to use when importing into an Oracle8 
                or a higher database release
                (always use IMPORT utility of the target database):
    
      +-----------+--------------------------------------------------------------+
      |  EXPORT   |                         IMPORT into:                         |
      |   from    +--------+--------+--------+--------+--------+--------+--------+
      |    \/     |  8.1.5 |  8.1.6 |  8.1.7 |  9.0.1 |  9.2.0 | 10.1.0 | 10.2.0 |
      +-----------+--------+--------+--------+--------+--------+--------+--------+
      |  5.x 1) 2)| EXP5x  | EXP5x  | EXP5x  | EXP5x  | EXP5x  | EXP5x  | EXP5x  |
      |  6.x    2)| EXP6x  | EXP6x  | EXP6x  | EXP6x  | EXP6x  | EXP6x  | EXP6x  |
      |  7.x    3)| EXP7x  | EXP7x  | EXP7x  | EXP7x  | EXP7x  | EXP7x  | EXP7x  |
      +-----------+--------+--------+--------+--------+--------+--------+--------+
      |  8.0.3    | EXP803 | EXP803 | EXP803 | EXP803 | EXP803 | EXP803 | EXP803 |
      |  8.0.4    | EXP804 | EXP804 | EXP804 | EXP804 | EXP804 | EXP804 | EXP804 |
      |  8.0.5    | EXP805 | EXP805 | EXP805 | EXP805 | EXP805 | EXP805 | EXP805 |
      |  8.0.6    | EXP806 | EXP806 | EXP806 | EXP806 | EXP806 | EXP806 | EXP806 |
      +-----------+--------+--------+--------+--------+--------+--------+--------+
      |  8.1.5    | EXP815 | EXP815 | EXP815 | EXP815 | EXP815 | EXP815 | EXP815 |
      |  8.1.6    | EXP815 | EXP816 | EXP816 | EXP816 | EXP816 | EXP816 | EXP816 |
      |  8.1.7    | EXP815 | EXP816 | EXP817 | EXP817 | EXP817 | EXP817 | EXP817 |
      +-----------+--------+--------+--------+--------+--------+--------+--------+
      |  9.0.1    |   N/S  | EXP816 | EXP817 | EXP901 | EXP901 | EXP901 | EXP901 |
      |  9.2.0    |   N/S  |   N/S  | EXP817 | EXP901 | EXP920 | EXP920 | EXP920 |
      +-----------+--------+--------+--------+--------+--------+--------+--------+
      | 10.1.0  4)|  Not Supported  | EXP817 | EXP901 | EXP920 |    4)  |    4)  |
      | 10.2.0  4)|  Not Supported  | EXP817 | EXP901 | EXP920 |    4)  |    4)  |
      +-----------+--------+--------+--------+--------+--------+--------+--------+
    
      
      Remarks:
      1) IMPORT can read export dump files created by EXPORT release 5.1.22 and 
         higher (up to same version).
      2) An Oracle5 or Oracle6 export dump and an Oracle8 or Oracle8i or Oracle9i
         IMPORT: see the Oracle Utilities Manual, Chapter 2 "Import" for special 
         considerations to keep in mind.
      3) An Oracle7 export dump and an Oracle8 or Oracle8i or Oracle9i IMPORT: 
         check constraints on the DATE columns become invalid when TO_DATE 
         function has not been used in the constraint (this was not required 
         in earlier Oracle versions).
      4) To have a better performance when exporting from and importing into
         Oracle10g databases: use the new Export Data Pump (expdp) and Import 
         DataPump (impdp) utilties.
    
  



